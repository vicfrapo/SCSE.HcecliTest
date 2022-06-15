using SCSE.DynamicForms.Components;
using SCSE.DynamicForms.Module.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCSE.HcecliTest.Domain;

public class DynamicTemplateItem
{
    public string Version { get; set; }
    ///Código
    public string Code { get; set; }
    ///Descripción
    public string Description { get; set; }
    ///Indicador de visible
    public bool IsVisible { get; set; }
    ///Formulario
    public DynamicFormRenderComponent Template { get; set; }
}
