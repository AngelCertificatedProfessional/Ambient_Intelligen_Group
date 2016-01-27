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
    public class AreaFacade
    {
        public static MySqlDataReader BuscarDescripcion(String nombre)
        {
            return AreaDao.BuscarDescripcion(nombre);
        }

        public static Boolean GuardarArea(Area area)
        {
            return AreaDao.GuardarArea(area);
        }

        public static Boolean ModificarArea(Area area)
        {
            return AreaDao.ModificarArea(area);
        }
    }
}
