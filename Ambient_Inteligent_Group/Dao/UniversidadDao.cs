using Ambient_Inteligent_Group.Conexion;
using Ambient_Inteligent_Group.Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Dao
{
    public class UniversidadDao
    {
        public static MySqlDataReader BuscarPorNombre(String nombre)
        {
            MySqlDataReader lector;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT * FROM Universidad where nombreUniversidad LIKE '%" + nombre + "%'"), ConexionBD.EnviarConexion());
                lector = _comando.ExecuteReader();
            }
            catch (Exception e)
            {
                lector = null;
                System.Console.Write(e);
            }
            finally
            {
            }
            return lector;
        }

        public static Boolean GuardarUniversidad(Universidad universidad)
        {
            Boolean retorno = true;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                MySqlCommand comando = new MySqlCommand(string.Format(
                    "Insert into Universidad (nombreUniversidad,abreviacion) values ('" + universidad.NombreUniversidad + "','" + universidad.GetAbreviacion() + "')"),
                    ConexionBD.EnviarConexion());
                comando.ExecuteNonQuery();
                ConexionBD.Commit();
                retorno = true;
            }
            catch (Exception e)
            {
                System.Console.Write(e);
                ConexionBD.Rollback();
                retorno = false;
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
            return retorno;
        }

        public static Boolean ModificarUniversidad(Universidad universidad)
        {
            Boolean retorno = true;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                MySqlCommand comando = new MySqlCommand(string.Format("Update Universidad set nombreUniversidad='{0}', abreviacion='{1}' where idUniversidad={2}",
                universidad.NombreUniversidad, universidad.GetAbreviacion(), universidad.IdUniversidad), ConexionBD.EnviarConexion());
                comando.ExecuteNonQuery();
                ConexionBD.Commit();
            }
            catch (Exception e)
            {
                System.Console.Write(e);
                ConexionBD.Rollback();
                retorno = false;
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
            return retorno;
        }


    }
}
