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
    public class Tipo_SocioControl : BaseControl
    {
        public Tipo_SocioControl(InterfaceComunicador comunicador, Type clazz)
            : base(comunicador, clazz)
        {
            ;
        }

        public void BuscarDescripcion(String nombreTipo_Socio, String nombreTabla)
        {
            com.setTabla(HelpetEntidad.DescomponerObjetos(Tipo_SocioDelegate.BuscarDescripcion(nombreTipo_Socio), nombreTabla));
            BaseDelegate.CerrarConexion();
        }

        public void ModificarTipo_Socio(Tipo_Socio tipo_Socio)
        {
            Boolean resultado;
            resultado = Tipo_SocioDelegate.ModificarTipo_Socio(tipo_Socio);
            if (resultado == true)
            {
                com.setMensaje("La modificacion fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro la modificacion");
            }
        }

        public void GuardarTipo_Socio(Tipo_Socio tipo_Socio)
        {
            Boolean resultado;
            resultado = Tipo_SocioDelegate.GuardarTipo_Socio(tipo_Socio);
            if (resultado == true)
            {
                com.setMensaje("El registro fue exitoso");
            } else
            {
                com.setMensaje("No se logro el registro");
            }

        }
    }
}
