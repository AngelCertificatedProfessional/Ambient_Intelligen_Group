using Ambient_Inteligent_Group.Delegate;
using Ambient_Inteligent_Group.Entidad;
using Ambient_Inteligent_Group.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Controlador
{
    public class SedeControl : BaseControl
    {
        public SedeControl(InterfaceComunicador comunicador, Type clazz)
            : base(comunicador, clazz)
        {
            ;
        }

        public void BuscarPorNombre(String nombreSede, String nombreTabla)
        {
            com.setTabla(HelpetEntidad.DescomponerObjetos(SedeDelegate.BuscarPorNombre(nombreSede), nombreTabla));
            BaseDelegate.CerrarConexion();
        }

        public void ModificarSede(Sede sede)
        {
            Boolean resultado;
            resultado = SedeDelegate.ModificarSede(sede);
            if (resultado == true)
            {
                com.setMensaje("La modificacion fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro la modificacion");
            }
        }

        public void GuardarSede(Sede sede)
        {
            Boolean resultado;
            resultado = SedeDelegate.GuardarSede(sede);
            if (resultado == true)
            {
                com.setMensaje("El registro fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro el registro");
            }

        }
    }
}
