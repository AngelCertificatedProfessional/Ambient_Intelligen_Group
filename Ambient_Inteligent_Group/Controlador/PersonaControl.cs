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
    public class PersonaControl : BaseControl
    {
        public PersonaControl(InterfaceComunicador comunicador, Type clazz)
            : base(comunicador, clazz)
        {
            ;
        }

        public void BuscarNombre(String nombrePersona, String nombreTabla)
        {
            com.setTabla(HelpetEntidad.DescomponerObjetos(PersonaDelegate.BuscarNombre(nombrePersona), nombreTabla));
            BaseDelegate.CerrarConexion();
        }

        public void BuscarUniversidad(String nombrePersona, String nombreTabla)
        {
            com.setTabla(HelpetEntidad.DescomponerObjetos(PersonaDelegate.BuscarUniversidad(nombrePersona), nombreTabla));
            BaseDelegate.CerrarConexion();
        }

        public void ModificarPersona(Persona persona,List<Universidad> uniLis)
        {
            Boolean resultado;
            resultado = PersonaDelegate.ModificarPersona(persona,uniLis);
            if (resultado == true)
            {
                com.setMensaje("La modificacion fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro la modificacion");
            }
        }

        public void GuardarPersona(Persona persona,List<Universidad> uniLis)
        {
            Boolean resultado;
            resultado = PersonaDelegate.GuardarPersona(persona,uniLis);
            if (resultado == true)
            {
                com.setMensaje("El registro fue exitoso");
            }
            else
            {
                com.setMensaje("No se logro el registro");
            }

        }

        public void BuscarEscolaridad(string nombreTabla, int ubicacion)
        {
            com.setLista(HelpetEntidad.DescomponerObjetos(BaseDelegate.BuscarTodos(nombreTabla), nombreTabla), ubicacion);
            BaseDelegate.CerrarConexion();
        }
    }
}
