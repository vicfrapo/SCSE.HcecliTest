namespace SCSE.HcecliTest.Module.Pages;

using Microsoft.AspNetCore.Components;
using MudBlazor;
using SCSE.DynamicForms.Components;
using SCSE.DynamicForms.Module.Domain;
using SCSE.Framework.DynamicCore.Application;
using SCSE.Framework.Searches.Model;
using SCSE.HcecliTest.Domain;
using SCSE.HcecliTest.ViewModels;
using System.Linq;

public partial class Index
{

    WebDynamicContext Context;

    /// <summary>
    /// Cliente http
    /// </summary>
    [Inject] HttpClient _httpClient { get; set; }

    List<GenericItem> TemplatesMenuList { get; set; }

    List<DynamicTemplateItem> Templates { get; set; } = new();

    DynamicTemplateItem SelectedTemplate { get; set; }

    int activeIndex = 0;

    public IndexViewModel ViewModel { get; set; }

    protected override async Task OnInitializedAsync()
    {
        ViewModel = new IndexViewModel();
        ViewModel.HttpClient = _httpClient;
        Context = BuildContextTemplate();
        ViewModel.ContextTemplate = Context;
        TemplatesMenuList = await ViewModel.GetTemplates();
    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (_updateIndex == true)
        {
            if ((Templates.Count - 1) >= 0)
                IndexTab = Templates.Count - 1;

            StateHasChanged();
            _updateIndex = false;
        }
    }

    /// <summary>
    /// Componente
    /// </summary>
    public DynamicFormRenderComponent SelectedTemplateComponent { get; set; }
    public DynamicFormRenderComponent ComponentB { get; set; }
    public DynamicFormRenderComponent ComponentC { get; set; }

    MudDynamicTabs tabs;

    /// Construir el contexto
    private WebDynamicContext BuildContextTemplate()
    {

        Dictionary<string, object> tmpArgs = new Dictionary<string, object>();
        tmpArgs.Add("ead", "01");//Esctructura administrativa
        tmpArgs.Add("fna", new DateTime(1999, 09, 15));//Fecha nacimiento
        tmpArgs.Add("ofc", "CIRU");//Especialidad //
        tmpArgs.Add("eda", 24);//Edad
        tmpArgs.Add("sex", "F");//Genero
        tmpArgs.Add("pes", 150);
        tmpArgs.Add("tal", 50);
        tmpArgs.Add("cpa", "MATE");
        tmpArgs.Add("tat", "HO");
        tmpArgs.Add("epi", "001");
        tmpArgs.Add("pro", "chppla");
        tmpArgs.Add("usu", "admon");
        appContext.InputArguments = tmpArgs;

        return new WebDynamicContext()
        {
            Editors = new DynamicForms.Module.Domain.EditorCollection(),
            InputArguments = appContext.InputArguments,
            ServicesURL = appContext.ServicesURL
        };
    }

    public void Test()
    {
        SelectedTemplate = null;

        //SelectedTemplate = new DynamicTemplateItem()
        //{
        //    Code = "chp055",
        //    Description = "cccccc",
        //    IsVisible = true
        //}; ;
    }


    public void Test2()
    {
        SelectedTemplate = null;
        StateHasChanged();

        SelectedTemplate = new DynamicTemplateItem()
        {
            Code = "chp055",
            Description = "cccccc",
            IsVisible = true
        };
    }

    public void OnClickMenu(GenericItem item)
    {
        if (!Templates.Any(x => x.Code.Equals(item.Code)))
        {
            DynamicTemplateItem newDynamicTemplateItem = new DynamicTemplateItem()
            {
                Code = item.Code,
                Description = item.Value,
                IsVisible = true,                
            };

            SelectedTemplate = newDynamicTemplateItem;
            Templates.Add(newDynamicTemplateItem);
        }

        _updateIndex = true;
    }

    public void Validate()
    {
        if (Templates.Any())
        {
            Templates.ForEach(template =>
            {
                if (template.Template != null)
                    template.Template.Validate();
            });
        }
    }



    public void SavePartial()
    {
        if (Templates.Any())
        {
            Templates.ForEach(template =>
            {
                if (template.Template != null)
                    (template.Template as DynamicFormRenderComponent).SavePartial();
            });
        }
    }

    private void CloseTabCallback(MudTabPanel panel)
    {
        var template = Templates.FirstOrDefault(x => x.Code.Equals(panel.ID));
        if (template != null)
            Templates.Remove(template);

        _updateIndex = true;
    }

    public int GetEditorIndex(DynamicTemplateItem item) => Templates.FindIndex(x => x.Code.Equals(item.Code));

    public int contador { get; set; } = 0;


    int indexTab;
    private int IndexTab 
    {
        get { return indexTab; }
        set 
        { 
            indexTab = value;
            SetTabVisible(value);
        } 
    }

    void SetTabVisible(int index)
    {
        if(Templates.Any())
        {
            var currentPanel = tabs.ActivePanel;
            if (currentPanel != null)
            {
                Templates.ForEach(template =>
                {
                    template.IsVisible = (template.Code.Equals(currentPanel.ID));
                });

                StateHasChanged();
            }
        }
    }


    private bool _updateIndex = false;
    private void AddTabCallback()
    {
        Templates.Add(new DynamicTemplateItem()
        {
            Code = "01",
            Description = "Vfff"
        });

        _updateIndex = true;
    }

    public void OnChangedTab(int tab)
    {

    }

    /// <summary>
    /// Evento generado por un editor/Componente
    /// </summary>
    /// <param name="eventArgs"></param>
    public void OnRaiseEditorEvent(ContextEventArgs eventArgs)
    {

    }

    public void GetData()
    {
        List<Dictionary<string,object>> Values = new();
        Dictionary<string, object> value;

        if (Templates.Any())
        {
            Templates.ForEach(template => {
                value = new Dictionary<string, object>();
                value.Add(template.Code, template.Template.GetValue());
                Values.Add(value);
            });
        }

        var sss = Values;
        var oo = sss;
    }

    public void SetValue()
    {
        if (Templates.Any())
        {
            Templates.ForEach(template => {
                Dictionary<string, object> valores = new Dictionary<string, object>();
                valores.Add("chptamcol005", "Ahi vamos dandole");
                valores.Add("chptamcol003", "S");
                template.Template.SetValue(valores);
            });
        }
    }
}
