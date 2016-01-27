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
    public class EscolaridadControl : BaseControl
    {
        public EscolaridadControl(InterfaceComunicador comunicador, Type clazz)
            : base(comunicador, clazz)
        {
            ;
        }

        public void BuscarDescripcion(String nombreEscolaridad, String nombreTabla)
        {
            com.setTabla(HelpetEntidad.DescomponerObjetos(EscolaridadDelegate.BuscarDescripcion(nombreEscolaridad), nombreTabla));
            BaseDelegate.CerrarConexion();
        }

        public void ModificarEscolaridad(Escolaridad escolaridad)
        {
            Boolean resultado;
            resultado = EscolaridadDelegate.ModificarEscolaridad(escolaridad);
            if (resultado == true)
            {
                com.setMensaje("La modificacion fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro la modificacion");
            }
        }

        public void GuardarEscolaridad(Escolaridad escolaridad)
        {
            Boolean resultado;
            resultado = EscolaridadDelegate.GuardarEscolaridad(escolaridad);
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
