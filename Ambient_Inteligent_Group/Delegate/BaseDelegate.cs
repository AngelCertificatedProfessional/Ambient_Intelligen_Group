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
    public class BaseDelegate
    {
        

        public static MySqlDataReader BuscarTodos(String tabla)
        {
            return BaseFacade.BuscarTodos(tabla);
        }

        public static MySqlDataReader ObtenerPorId(String tabla, int id, String idColumnaS)
        {
            return BaseFacade.ObtenerPorId(tabla, id, idColumnaS);
        }

        public static void CerrarConexion() {
            BaseFacade.CerrarConexion();
        }

        public static MySqlDataAdapter ObtenerPorIdConImagen(String tabla, int id, String idColumnaS)
        {
            return BaseFacade.ObtenerPorIdConImagen(tabla, id, idColumnaS);
        }

        public static bool Eliminar(String nombreTabla, int id, String idColumnaS)
        {
            return BaseFacade.Eliminar(nombreTabla,id,idColumnaS);
        }
    }
}
