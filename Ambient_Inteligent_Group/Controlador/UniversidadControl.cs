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
    public class UniversidadControl : BaseControl
    {
        public UniversidadControl(InterfaceComunicador comunicador, Type clazz)
            : base(comunicador, clazz)
        {
            ;
        }

        public void BuscarPorNombre(String nombreUniversidad, String nombreTabla)
        {
            com.setTabla(HelpetEntidad.DescomponerObjetos(UniversidadDelegate.BuscarPorNombre(nombreUniversidad), nombreTabla));
            BaseDelegate.CerrarConexion();
        }

        public void ModificarUniversidad(Universidad universidad)
        {
            Boolean resultado;
            resultado = UniversidadDelegate.ModificarUniversidad(universidad);
            if (resultado == true)
            {
                com.setMensaje("La modificacion fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro la modificacion");
            }
        }

        public void GuardarUniversidad(Universidad universidad)
        {
            Boolean resultado;
            resultado = UniversidadDelegate.GuardarUniversidad(universidad);
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
