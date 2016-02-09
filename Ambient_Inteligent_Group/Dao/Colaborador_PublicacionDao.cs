using Ambient_Inteligent_Group.Conexion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Dao
{
    public class Colaborador_PublicacionDao
    {
        public static Boolean GuardarColaborador_Publicacion(int idPublicacion, int idPersona)
        {
            Boolean retorno = true;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                MySqlCommand comandoUni = new MySqlCommand(string.Format(
                    "Insert into Colaborador_Publicacion (Publicacion_idPublicacion,Persona_idPersona) values (" + idPublicacion
                    + "," + idPersona + ")"), ConexionBD.EnviarConexion());
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
            finally
            {
                ConexionBD.CerrarConexion();
            }
            return retorno;
        }
    }
}
