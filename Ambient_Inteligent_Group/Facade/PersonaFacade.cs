using Ambient_Inteligent_Group.Dao;
using Ambient_Inteligent_Group.Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Facade
{
    public class PersonaFacade
    {
        public static MySqlDataReader BuscarNombre(String nombre)
        {
            return PersonalDao.BuscarNombre(nombre);
        }

        public static Boolean GuardarPersona(Persona persona,List<Universidad> uniLis)
        {
            return PersonalDao.GuardarPersona(persona,uniLis);
        }

        public static Boolean ModificarPersona(Persona persona, List<Universidad> uniLis)
        {
            return PersonalDao.ModificarPersona(persona,uniLis);
        }
    }
}
