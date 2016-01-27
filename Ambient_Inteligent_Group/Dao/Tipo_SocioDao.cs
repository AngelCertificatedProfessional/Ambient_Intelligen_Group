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
    public class Tipo_SocioDao
    {
        public static Boolean GuardarTipo_Socio(Tipo_Socio tipo_Socio)
        {
            Boolean retorno = true;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                MySqlCommand comando = new MySqlCommand(string.Format(
                    "Insert into Tipo_Socio (Descripcion) values ('" + tipo_Socio.Descripcion + "')"),
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

        public static MySqlDataReader BuscarDescripcion(String nombre)
        {
            MySqlDataReader lector;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT * FROM Tipo_Socio where Descripcion LIKE '%" + nombre + "%'"), ConexionBD.EnviarConexion());
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

        public static Boolean ModificarTipo_Socio(Tipo_Socio tipo_Socio)
        {
            Boolean retorno = true;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                MySqlCommand comando = new MySqlCommand(string.Format("Update Tipo_Socio set Descripcion='{0}' where idTipo_Socio={1}",
                tipo_Socio.Descripcion, tipo_Socio.IdTipo_Socio), ConexionBD.EnviarConexion());
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
