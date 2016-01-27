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
    public class AreaControl : BaseControl
    {
        public AreaControl(InterfaceComunicador comunicador, Type clazz)
            : base(comunicador, clazz)
        {
            ;
        }

        public void BuscarDescripcion(String nombreArea, String nombreTabla)
        {
            com.setTabla(HelpetEntidad.DescomponerObjetos(AreaDelegate.BuscarDescripcion(nombreArea), nombreTabla));
            BaseDelegate.CerrarConexion();
        }

        public void ModificarArea(Area area)
        {
            Boolean resultado;
            resultado = AreaDelegate.ModificarArea(area);
            if (resultado == true)
            {
                com.setMensaje("La modificacion fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro la modificacion");
            }
        }

        public void GuardarArea(Area area)
        {
            Boolean resultado;
            resultado = AreaDelegate.GuardarArea(area);
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
