using SCSE.DynamicForms.Module.Domain;
using SCSE.Framework.Application.Core;

namespace SCSE.HcecliTest.ORM
{
    public class ApplicationContext
    {
        /// <summary>
        /// Código del cliente
        /// </summary>
        public string? ClientCode { get; set; }
        /// <summary>
        /// Proveedor
        /// </summary>
        public string? Provider { get; set; }
        /// <summary>
        /// Conexión bd
        /// </summary>
        public string? ConnectionString { get; set; }
        /// <summary>
        /// Servicios
        /// </summary>
        public Dictionary<string, ComponentsServicesURL>? ServicesURL { get; set; }
        /// <summary>
        /// Argumentos
        /// </summary>
        public Dictionary<string, object>? InputArguments { get; set; }
        /// <summary>
        /// Editores/Componentes
        /// </summary>
        public Dictionary<string, IComponentBaseConfiguration>? Editors { get; set; }
        /// <summary>
        /// Token
        /// </summary>
        public string? Token { get; set; }
    }
}
