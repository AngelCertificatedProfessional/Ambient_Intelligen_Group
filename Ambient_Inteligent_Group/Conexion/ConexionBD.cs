using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Ambient_Inteligent_Group.Conexion
{
    public class ConexionBD
    {
        private const String server="127.0.0.1";
        private const String database = "ambient_inteligent_group";
        private const String usuario = "root";
        private const String contrasena = "1234";
        private static MySqlConnection conexion;
        private static MySqlTransaction transaccion;

        public static MySqlConnection CrearConexion()
        {
            conexion = new MySqlConnection("server="+server+"; database= "+database+"; Uid="+usuario+";pwd="+contrasena+";");
            return conexion;
        }

        public static MySqlConnection ConectarConexion()
        {
            conexion.Open();
            return conexion;
        }

        public static MySqlConnection CerrarConexion() {
            conexion.Close();
            return conexion;
        }

        public static MySqlTransaction Commit()
        {
            transaccion.Commit();
            return transaccion;
        }

        public static MySqlTransaction Rollback()
        {
            transaccion.Rollback();
            return transaccion;
        }

        public static MySqlTransaction BeginTransaction()
        {
            transaccion = conexion.BeginTransaction();
            return transaccion;
        }

        public static MySqlConnection EnviarConexion() {
            return conexion;
        }

    }
}
