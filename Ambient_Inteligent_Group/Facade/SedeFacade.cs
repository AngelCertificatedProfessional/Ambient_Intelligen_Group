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
    public class SedeFacade
    {
        public static MySqlDataReader BuscarPorNombre(String nombre)
        {
            return SedeDao.BuscarPorNombre(nombre);
        }

        public static Boolean GuardarSede(Sede sede)
        {
            return SedeDao.GuardarSede(sede);
        }

        public static Boolean ModificarSede(Sede sede)
        {
            return SedeDao.ModificarSede(sede);
        }

    }
}
