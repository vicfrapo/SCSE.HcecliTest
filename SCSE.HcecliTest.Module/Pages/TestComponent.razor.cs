using Microsoft.AspNetCore.Components;
using SCSE.DynamicForms.Module.Domain;
using SCSE.Framework.Application.Core;
using SCSE.Framework.Common.Components.Blz;
using SCSE.Framework.Searches.Model;

namespace SCSE.HcecliTest.Module;

public partial class TestComponent
{
    #region Injects
    /// Cliente Http
    [Inject] HttpClient _httpclient { get; set; }
    #endregion

    #region Properties
    ///Contexto
    public WebDynamicContext ContextTemplate { get; set; }
    ///Query test
    Query SearchQuery { get; set; } = new Query() { QueryText = "SELECT ciacod, cianom FROM sicia", ValueMember = "ciacod", DisplayMember = "cianom" };
    ///Query test
    Query SearchQuery2 { get; set; } = new Query() { QueryText = "select ctedetpar, ctedetdes from hictedet where ctedetcod = 'SINO'", ValueMember = "ctedetpar", DisplayMember = "ctedetdes" };
    #endregion

    #region Members
    ///Componente numerico
    NumericComponent numericComponent;
    ///Componente Texto
    TextComponent textComponent;
    ///Componente lista de valores
    ValueListComponent selectionListComponent;
    ///Componente lista de cajas de chequeo
    ValueListComponent checkBoxListComponent;
    ///Componente cajas de chequeo
    ValueListComponent checkBoxComponent;
    ///Componente radio botones
    ValueListComponent radioButtonComponent;
    ///Componente buscador
    SearchComponent searchComponent;
    ///Componente fecha
    DateTimeComponent dateTimeComponent;
    ///Componente sitch
    SwitchComponent switchComponent;
    #endregion

    #region Members to bindigs
    ///Valor binding componente numerico
    public string numericComponentValue { get; set; }
    ///Valor binding componente texto
    public string textComponentValue { get; set; }
    ///Valor binding componente lista seleccion
    GenericItem selectionListComponentValue = new GenericItem();
    ///Valor binding componente lista checks
    IEnumerable<GenericItem> checkBoxListComponentValue = new List<GenericItem>();
    ///Valor binding componente  checks
    IEnumerable<GenericItem> checkBoxComponentValue = new List<GenericItem>();
    ///Valor binding componente  radio botones
    GenericItem radioButtonComponentValue = new GenericItem();
    ///Valor binding componente  datetime
    DateTime? DateTimeValue;
    ///Valor binding componente switch
    public string switchComponentValue { get; set; }
    #endregion

    #region Constructor
    ///Constructor de clase al iniciailizar
    protected override void OnInitialized()
    {
        BuildContext();
    }
    #endregion

    #region Methods
    ///Crear contexto
    public void BuildContext()
    {
        Dictionary<string, object> inputArguments = new Dictionary<string, object>();
        inputArguments.Add("eda", 24);
        inputArguments.Add("sex", "F");
        inputArguments.Add("pes", 150);
        inputArguments.Add("tal", 50);
        inputArguments.Add("cpa", "MATE");
        inputArguments.Add("tat", "HO");

        ContextTemplate = new WebDynamicContext()
        {
            Editors = new DynamicForms.Module.Domain.EditorCollection(),
            InputArguments = inputArguments,
            ServicesURL = appContext.ServicesURL
        };
    }
    ///Asignar valores
    public void SetValue()
    {
        numericComponent?.SetValue(120);
        textComponent?.SetValue("vfranco");
        selectionListComponent?.SetValue("04");
        checkBoxListComponent?.SetValue("04");
        checkBoxComponent?.SetValue("S");
        radioButtonComponent?.SetValue("N");
        searchComponent?.SetValue("04");
        dateTimeComponent?.SetValue(DateTime.Now);
        switchComponent?.SetValue("S");
    }
    ///Validar
    public void Validate()
    {
        numericComponent?.Validate();
        textComponent?.Validate();
        selectionListComponent?.Validate();
        checkBoxListComponent?.Validate();
        checkBoxComponent?.Validate();
        radioButtonComponent?.Validate();
        searchComponent?.Validate();
        dateTimeComponent?.Validate();
        switchComponent?.Validate();
    }
    ///Deshabilitar
    public void Disable()
    {
        numericComponent.IsEditable = false;
        textComponent.IsEditable = false;
        selectionListComponent.IsEditable = false;
        checkBoxListComponent.IsEditable = false;
        checkBoxComponent.IsEditable = false;
        radioButtonComponent.IsEditable = false;
        searchComponent.IsEditable = false;
        dateTimeComponent.IsEditable = false;
        switchComponent.IsEditable = false;
    }
    #endregion
}
