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
    public class AsociacionControl : BaseControl

    {
        public AsociacionControl(InterfaceComunicador comunicador, Type clazz)
            : base(comunicador, clazz)
        {
            ;
        }

        public void BuscarDescripcion(String nombreAsociacion, String nombreTabla)
        {
            com.setTabla(HelpetEntidad.DescomponerObjetos(AsociacionDelegate.BuscarDescripcion(nombreAsociacion), nombreTabla));
            BaseDelegate.CerrarConexion();
        }

        public void ModificarAsociacion(Asociacion asociacion)
        {
            Boolean resultado;
            resultado = AsociacionDelegate.ModificarAsociacion(asociacion);
            if (resultado == true)
            {
                com.setMensaje("La modificacion fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro la modificacion");
            }
        }

        public void GuardarAsociacion(Asociacion asociacion)
        {
            Boolean resultado;
            resultado = AsociacionDelegate.GuardarAsociacion(asociacion);
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
