using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Moneda
    {
        partial void Simbolo_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if (Simbolo != null)
                Simbolo = Simbolo.Trim().ToUpper();
        }
    }
}
