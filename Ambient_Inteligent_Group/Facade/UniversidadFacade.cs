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
    public class UniversidadFacade
    {
        public static MySqlDataReader BuscarPorNombre(String nombre)
        {
            return UniversidadDao.BuscarPorNombre(nombre);
        }

        public static Boolean GuardarUniversidad(Universidad universidad)
        {
            return UniversidadDao.GuardarUniversidad(universidad);
        }

        public static Boolean ModificarUniversidad(Universidad universidad)
        {
            return UniversidadDao.ModificarUniversidad(universidad);
        }

    }
}
