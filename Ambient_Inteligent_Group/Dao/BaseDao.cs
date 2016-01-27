using Ambient_Inteligent_Group.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Dao
{
    public class BaseDao
    {

        public static MySqlDataReader BuscarTodos(String tabla){
            MySqlDataReader lector;
            try {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT * FROM " + tabla), ConexionBD.EnviarConexion());
                lector = _comando.ExecuteReader();
            }catch(Exception e){
                System.Console.Write(e);
                lector = null;
                ConexionBD.CerrarConexion();
            }finally{
            }
            return lector; 
        }

        public static bool Eliminar(String nombreTabla, int id, String idColumnaS)
        {
            Boolean validacion;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                
                MySqlCommand comando = new MySqlCommand(string.Format(
                    "Delete From " + nombreTabla + " where " + idColumnaS + "={0}", id), ConexionBD.EnviarConexion());
                comando.ExecuteNonQuery();
                ConexionBD.Commit();
                validacion = true;
            }
            catch (Exception e)
            {
                System.Console.Write(e);
                ConexionBD.Rollback();
                validacion = false;
            }
            finally {
                ConexionBD.CerrarConexion();
            }
            return validacion;
        }

        public static MySqlDataReader ObtenerPorId(String nombreTabla, int id,String idColumnaS)
        {
            MySqlDataReader lectura;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM " + nombreTabla + " where "+idColumnaS+" = {0}", id), ConexionBD.EnviarConexion());
                lectura = _comando.ExecuteReader();
            }
            catch (Exception e) {
                lectura = null;
                System.Console.Write(e);
                ConexionBD.CerrarConexion();
            }
            return lectura;
        }


        public static MySqlDataAdapter ObtenerPorIdConImagen(String nombreTabla, int id, String idColumnaS)
        {
            MySqlDataAdapter lectura;
            String comandoS = "SELECT * FROM " + nombreTabla + " where " + idColumnaS + " = "+ id;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                MySqlCommand comando = new MySqlCommand(comandoS,ConexionBD.EnviarConexion());
                lectura = new MySqlDataAdapter(comando);
            }
            catch (Exception e)
            {
                lectura = null;
                System.Console.Write(e);
                ConexionBD.CerrarConexion();
            }
            return lectura;
        }



        public static void CerrarConexion() {
            ConexionBD.CerrarConexion();
        }

    }
}
