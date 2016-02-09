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
    public class PublicacionControl : BaseControl
    {

        public PublicacionControl(InterfaceComunicador comunicador, Type clazz)
            : base(comunicador, clazz)
        {
            ;
        }

        public void BuscarNombre(String nombrePublicacion, String nombreTabla)
        {
            com.setTabla(HelpetEntidad.DescomponerObjetos(PublicacionDelegate.BuscarPorPublicacion(nombrePublicacion), nombreTabla));
            BaseDelegate.CerrarConexion();
        }

        public void BuscarPersona(String nombrePersona, String nombreTabla)
        {
            com.setTabla(HelpetEntidad.DescomponerObjetos(PublicacionDelegate.BuscarPersona(nombrePersona), nombreTabla));
            BaseDelegate.CerrarConexion();
        }

        public void ModificarPublicacion(Publicacion publicacion, List<int> perLis)
        {
            Boolean resultado;
            resultado = PublicacionDelegate.ModificarPublicacion(publicacion, perLis);
            if (resultado == true)
            {
                com.setMensaje("La modificacion fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro la modificacion");
            }
        }

        public void GuardarPublicacion(Publicacion publicacion, List<int> perLis)
        {
            Boolean resultado;
            resultado = PublicacionDelegate.GuardarPublicacion(publicacion, perLis);
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
