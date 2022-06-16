using Newtonsoft.Json;
using SCSE.DynamicForms.Module.Domain;
using SCSE.Framework.Common.HttpClientHelpers;
using SCSE.Framework.Searches.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCSE.HcecliTest.ViewModels;

public class IndexViewModel
{
    #region Properties
    /// <summary>
    /// Contexto de la plantilla utilizado para enviar a los componentes
    /// </summary>
    public WebDynamicContext ContextTemplate { get; set; }
    /// <summary>
    /// Cliente http
    /// </summary>
    public HttpClient HttpClient { get; set; }
    /// <summary>
    /// Repositorio http
    /// </summary>
    HttpClientRepository _HttpClientRepository { get; set; }
    #endregion

    /// <summary>
    /// Ontener listado de plantillasd dinamicas
    /// </summary>
    /// <returns></returns>
    public async Task<List<DynamicFormItem>> GetTemplates()
    {
        _HttpClientRepository = new HttpClientRepository(HttpClient);
        var requestTemplateLayout = await _HttpClientRepository.Get<List<DynamicFormItem>>($"https://localhost:7004/DynamicFormsModule/DynamicForms/api/v1/GetDynamicTemplates");
        return requestTemplateLayout.Response;
    }


    public async Task<List<MedicalRegisterItemSave>> Save(List<MedicalRegisterItem> medicalRegisterItems)
    {
        HttpClientRepository httpClientRepository = new HttpClientRepository(HttpClient);
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, $"https://localhost:7004/DynamicFormsModule/DynamicForms/api/v1/SaveClinicalRegisterAsync");
        request.Content = new StringContent(JsonConvert.SerializeObject(medicalRegisterItems), Encoding.UTF8, "application/json");

        //var response = await httpClientRepository.Send<int>(request);
        var ww = await httpClientRepository.Send<List<MedicalRegisterItemSave>>(request);

        return ww.Response;
    }

    public async Task<List<MedicalRegisterItem>> Load()
    {
        HttpClientRepository _HttpClientRepository = new HttpClientRepository(HttpClient);
        var requestTemplateLayout = await _HttpClientRepository.Get<List<MedicalRegisterItem>>($"https://localhost:7004/DynamicFormsModule/DynamicForms/api/v1/GetClinicalRegisterAsync/12345/199");
        return requestTemplateLayout.Response;
    }
}
