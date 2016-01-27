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
    public class BaseControl
    {
        //Comunicador con la interfaz grafica
        protected InterfaceComunicador com;
        protected Type clazz;

        public BaseControl(InterfaceComunicador com,Type clazz) {
            this.com = com;
            this.clazz = clazz;
        }

        public void BuscarTodos(String nombreTabla) {
            com.setTabla(HelpetEntidad.DescomponerObjetos(BaseDelegate.BuscarTodos(nombreTabla),nombreTabla));
            BaseDelegate.CerrarConexion();
        }

        public void Eliminar(String nombreTabla, int id, String idColumnaS) {
            Boolean resultado;
            resultado = BaseDelegate.Eliminar(nombreTabla,id,idColumnaS);
            if (resultado == true)
            {
                com.setMensaje("La eliminacion fue exitosa");
            }
            else {
                com.setMensaje("No se logro la eliminacion");
            }
        }

        public void ObtenerPorId(String tabla, int id, String idColumnaS)
        {
            com.setInfo(HelpetEntidad.DescomponerObjeto(BaseDelegate.ObtenerPorId(tabla,id,idColumnaS), tabla));
            BaseDelegate.CerrarConexion();
        }

        public void ObtenerPorIdConImagen(String tabla, int id, String idColumnaS)
        {
            com.setInfo(HelpetEntidad.DescomponerObjeto(BaseDelegate.ObtenerPorIdConImagen(tabla, id, idColumnaS), tabla));
            BaseDelegate.CerrarConexion();
        }


    }
}
