using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Parametro
    {

        partial void Familia_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if(Familia != null)
                Familia = Familia.Trim().ToUpper();
        }

        partial void Clave_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if(Clave != null)
                Clave = Clave.Trim().ToUpper();
        }
    }
}
