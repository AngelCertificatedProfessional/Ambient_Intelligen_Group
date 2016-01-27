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
    public class AsociacionFacade
    {
        public static MySqlDataReader BuscarDescripcion(String nombre)
        {
            return AsociacionDao.BuscarDescripcion(nombre);
        }

        public static Boolean GuardarAsociacion(Asociacion asociacion)
        {
            return AsociacionDao.GuardarAsociacion(asociacion);
        }

        public static Boolean ModificarAsociacion(Asociacion asociacion)
        {
            return AsociacionDao.ModificarAsociacion(asociacion);
        }
    }
}
