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
    public class PlaticaControl : BaseControl
    {

        public PlaticaControl(InterfaceComunicador comunicador, Type clazz)
            : base(comunicador, clazz)
        {
            ;
        }

        public void BuscarPorNombre(String nombrePlatica, String nombreTabla)
        {
            com.setTabla(HelpetEntidad.DescomponerObjetos(PlaticaDelegate.BuscarPorNombre(nombrePlatica), nombreTabla));
            BaseDelegate.CerrarConexion();
        }

        public void ModificarPlatica(Platica platica)
        {
            Boolean resultado;
            resultado = PlaticaDelegate.ModificarPlatica(platica);
            if (resultado == true)
            {
                com.setMensaje("La modificacion fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro la modificacion");
            }
        }

        public void GuardarPlatica(Platica platica)
        {
            Boolean resultado;
            resultado = PlaticaDelegate.GuardarPlatica(platica);
            if (resultado == true)
            {
                com.setMensaje("El registro fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro el registro");
            }

        }


        public void BuscarSedes(string nombreTabla, int ubicacion)
        {
            com.setLista(HelpetEntidad.DescomponerObjetos(BaseDelegate.BuscarTodos(nombreTabla), nombreTabla),ubicacion);
            BaseDelegate.CerrarConexion();
        }
    }
}
