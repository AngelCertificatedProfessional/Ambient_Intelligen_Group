using Ambient_Inteligent_Group.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Dao
{
    public class Socio_UniversidadDao
    {
        public static Boolean GuardarSocio_Universidad(int idUni, int idPersona)
        {
            Boolean retorno = true;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                MySqlCommand comandoUni = new MySqlCommand(string.Format(
                    "Insert into Socio_Universidad (Persona_id,Universidad_id) values (" + idPersona
                    + "," + idUni + ")"), ConexionBD.EnviarConexion());
                comandoUni.ExecuteNonQuery();
                ConexionBD.Commit();
                retorno = true;
            }
            catch (Exception e)
            {
                System.Console.Write(e);
                ConexionBD.Rollback();
                retorno = false;
            }
            finally {
                ConexionBD.CerrarConexion();
            }
            return retorno;
        }
    }
}
