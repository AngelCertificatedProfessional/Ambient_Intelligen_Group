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
    public class BaseFacade
    {
        public static MySqlDataReader BuscarTodos(String tabla)
        {
            return BaseDao.BuscarTodos(tabla);
        }

        public static MySqlDataReader ObtenerPorId(String tabla,int id,String idColumnaS)
        {
            return BaseDao.ObtenerPorId(tabla,id,idColumnaS);
        }

        public static MySqlDataAdapter ObtenerPorIdConImagen(String tabla, int id, String idColumnaS)
        {
            return BaseDao.ObtenerPorIdConImagen(tabla, id, idColumnaS);
        }

        public static void CerrarConexion() {
            BaseDao.CerrarConexion();
        }

        public static bool Eliminar(string nombreTabla, int id, String idColumnaS)
        {
            return BaseDao.Eliminar(nombreTabla,id,idColumnaS);
        }
    }
}
