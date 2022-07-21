using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SCSE.HcecliTest.Module;
using MudBlazor.Services;
using MudBlazor;
using SCSE.DynamicForms.Module.Shared;
using SCSE.Framework.Common.Components.Blz;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<MessageUIService>();
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopRight;

    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = false;
    config.SnackbarConfiguration.VisibleStateDuration = 1000;
    config.SnackbarConfiguration.HideTransitionDuration = 500;
    config.SnackbarConfiguration.ShowTransitionDuration = 500;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
});

//builder.Services.AddHttpClient<HttpClientWithToken>(cliente => cliente.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)).AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
//builder.Services.AddHttpClient<HttpClientWithOutToken>(cliente => cliente.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
//builder.Services.AddScoped<IHttpClientRepository, HttpClientRepository>();

/// <summary>
/// Contexto de la aplicación
/// </summary>
var LocalConfigurations = builder.Configuration.Get<ApplicationContextConfiguration>();
builder.Services.AddSingleton(LocalConfigurations.ApplicationContext);

/// <summary>
/// Core de plantillas dinamicas
/// </summary>
builder.Services.AddScoped<IDynamicTemplateCore, DynamicTemplateCore>();


await builder.Build().RunAsync();
