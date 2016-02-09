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
    public class PublicacionDao
    {
        public static int GuardarPublicacion(Publicacion publicacion)
        {
            int id = 0;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                MySqlCommand comando = new MySqlCommand(string.Format(
                    "Insert into Publicacion (descripcion,tipo_Publicacion_id,anio,link,pagina) values ('" + 
                    publicacion.Descripcion + "'," + publicacion.GetTipo_Publicacion() + ",'" + publicacion.Anio+ "','"+publicacion.Link+"','"+publicacion.GetPagina()+"')"),
                    ConexionBD.EnviarConexion());
                comando.ExecuteNonQuery();
                ConexionBD.Commit();
                id = (int)(Convert.ToInt64(comando.LastInsertedId));
            }
            catch (Exception e)
            {
                System.Console.Write(e);
                ConexionBD.Rollback();
                id = 0;
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
            return id;
        }

        public static MySqlDataReader BuscarPorPublicacion(String nombre)
        {
            MySqlDataReader lector;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT * FROM Publicacion where Descripcion LIKE '%" + nombre + "%'"), ConexionBD.EnviarConexion());
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

        public static int ModificarPublicacion(Publicacion publicacion)
        {
            int id = 0;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                MySqlCommand comando = new MySqlCommand(string.Format("Update Publicacion set descripcion='{0}', tipo_Publicacion_id={1}, anio='{2}',link='{3}'," +
                    "pagina='{4}' where IdPublicacion={5}", publicacion.Descripcion, publicacion.GetTipo_Publicacion(), publicacion.Anio, publicacion.Link, 
                    publicacion.GetPagina(),publicacion.IdPublicacion), ConexionBD.EnviarConexion());
                comando.ExecuteNonQuery();
                ConexionBD.Commit();
                id = publicacion.IdPublicacion;
            }
            catch (Exception e)
            {
                System.Console.Write(e);
                ConexionBD.Rollback();
                id = 0;
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
            return id;
        }

    }
}
