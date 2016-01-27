using Ambient_Inteligent_Group.Conexion;
using Ambient_Inteligent_Group.Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Dao
{
    public class AsociacionDao
    {
        public static Boolean GuardarAsociacion(Asociacion asociacion)
        {
            Boolean retorno = true;
            String cadena = "insert into Asociacion (descripcion,link,imagen) values (@descripcion,@link,@imagen)";
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                
                MySqlCommand comando = new MySqlCommand(cadena,ConexionBD.EnviarConexion());

                comando.Parameters.Add("@descripcion",MySqlDbType.VarChar,255);
                comando.Parameters.Add("@link", MySqlDbType.VarChar, 45);
                comando.Parameters.Add("@imagen", MySqlDbType.LongBlob);

                comando.Parameters["@descripcion"].Value = asociacion.Descripcion;
                comando.Parameters["@link"].Value = asociacion.Link;
                comando.Parameters["@imagen"].Value = asociacion.GetImagen();                

                /*string.Format(
                    "Insert into Asociacion (descripcion,link,imagen) values ('" + asociacion.Descripcion,asociacion.Link,asociacion.GetImagen() + "')"),
                    ConexionBD.EnviarConexion());*/
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
                "SELECT * FROM Asociacion where descripcion LIKE '%" + nombre + "%'"), ConexionBD.EnviarConexion());
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

        public static Boolean ModificarAsociacion(Asociacion asociacion)
        {
            Boolean retorno = true;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                String cadena = "Update Asociacion set descripcion=@descripcion,link=@link,imagen=@imagen where idAsociacion=@idAsociacion";
                MySqlCommand comando = new MySqlCommand(cadena, ConexionBD.EnviarConexion());

                comando.Parameters.Add("@idAsociacion", MySqlDbType.Int32);
                comando.Parameters.Add("@descripcion", MySqlDbType.VarChar, 255);
                comando.Parameters.Add("@link", MySqlDbType.VarChar, 45);
                comando.Parameters.Add("@imagen", MySqlDbType.LongBlob);

                comando.Parameters["@idAsociacion"].Value = asociacion.IdAsociacion;
                comando.Parameters["@descripcion"].Value = asociacion.Descripcion;
                comando.Parameters["@link"].Value = asociacion.Link;
                comando.Parameters["@imagen"].Value = asociacion.GetImagen(); 


                //MySqlCommand comando = new MySqlCommand(string.Format("Update Asociacion set descripcion='{0}',link='{1},imagen={2} where idAsociacion={2}",
                //asociacion.Descripcion, asociacion.Link, asociacion.GetImagen(),asociacion.IdAsociacion), ConexionBD.EnviarConexion());
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
