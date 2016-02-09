using Ambient_Inteligent_Group.Entidad;
using Ambient_Inteligent_Group.Facade;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Delegate
{
    public class PersonaDelegate
    {
        public static MySqlDataReader BuscarNombre(String nombre)
        {
            return PersonaFacade.BuscarNombre(nombre);
        }

        public static MySqlDataReader BuscarUniversidad(String nombre)
        {
            return UniversidadFacade.BuscarPorNombre(nombre);
        }

        public static Boolean GuardarPersona(Persona persona, List<int> uniLis)
        {
            return PersonaFacade.GuardarPersona(persona, uniLis);
        }

        public static Boolean ModificarPersona(Persona persona, List<int> uniLis)
        {
            return PersonaFacade.ModificarPersona(persona, uniLis);
        }
    }
}
