using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {

        partial void Parametros_Inserting(Parametro entity)
        {
            Parametros_Changing(entity);
        }

        private void Parametros_Changing(Parametro entity)
        {
            entity.RegId = entity.Familia.Trim().ToUpper() + "-" + entity.Clave.Trim().ToUpper();
        }

        partial void Parametros_Updating(Parametro entity)
        {
            Parametros_Changing(entity);
        }

        partial void Monedas_Inserting(Moneda entity)
        {
            Monedas_Changing(entity);
        }

        private void Monedas_Changing(Moneda entity)
        {
            entity.RegId = entity.Simbolo;
        }

        partial void Monedas_Updating(Moneda entity)
        {
            Monedas_Changing(entity);
        }
    }
}
