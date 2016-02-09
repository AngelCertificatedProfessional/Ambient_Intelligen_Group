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
    public class SocioDao
    {
        public static Boolean GuardarSocio(Socio socio)
        {
            Boolean retorno = true;
            String cadena = "insert into Socio (Persona_id,Area_id,Persona_idDirector,Tesis,Tipo_Socio_id,Estado,imagen) values"+ 
                "(@Persona_id,@Area_id,@Persona_idDirector,@Tesis,@Tipo_Socio_id,@Estado,@imagen)";
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();

                MySqlCommand comando = new MySqlCommand(cadena, ConexionBD.EnviarConexion());

                comando.Parameters.Add("@Persona_id", MySqlDbType.Int32);
                comando.Parameters.Add("@Area_id", MySqlDbType.Int32);
                comando.Parameters.Add("@Persona_idDirector", MySqlDbType.Int32);
                comando.Parameters.Add("@Tesis", MySqlDbType.VarChar,200);
                comando.Parameters.Add("@Tipo_Socio_id", MySqlDbType.Int32);
                comando.Parameters.Add("@Estado", MySqlDbType.VarChar, 45);
                comando.Parameters.Add("@imagen", MySqlDbType.LongBlob);

                comando.Parameters["@Persona_id"].Value = socio.GetPersona_Id();
                if (socio.GetArea_Id() == 0)
                {
                    comando.Parameters["@Area_id"].Value = null;
                }
                else {
                    comando.Parameters["@Area_id"].Value = socio.GetArea_Id();
                }
                if (socio.GetPersona_IdDirector() == 0) {
                    comando.Parameters["@Persona_idDirector"].Value = null;
                } else {
                    comando.Parameters["@Persona_idDirector"].Value = socio.GetPersona_IdDirector();
                }
                comando.Parameters["@Tesis"].Value = socio.GetTesis();
                comando.Parameters["@Tipo_Socio_id"].Value = socio.GetTipoSocio_Id();
                comando.Parameters["@Estado"].Value = socio.GetEstado();
                comando.Parameters["@imagen"].Value = socio.GetImagen();
                
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

        public static Boolean ModificarSocio(Socio socio)
        {
            Boolean retorno = true;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                String cadena = "Update Socio set Persona_id=@Persona_id,Area_id=@Area_id,Persona_idDirector = @Persona_idDirector,Tesis = @Tesis,"+
                    "@Tipo_Socio_id=@Tipo_Socio_id,Estado=@Estado,imagen=@imagen where idSocio=@idSocio";
                MySqlCommand comando = new MySqlCommand(cadena, ConexionBD.EnviarConexion());

                comando.Parameters.Add("@idSocio", MySqlDbType.Int32);
                comando.Parameters.Add("@Persona_id", MySqlDbType.Int32);
                comando.Parameters.Add("@Area_id", MySqlDbType.Int32);
                comando.Parameters.Add("@Persona_idDirector", MySqlDbType.Int32);
                comando.Parameters.Add("@Tesis", MySqlDbType.VarChar, 200);
                comando.Parameters.Add("@Tipo_Socio_id", MySqlDbType.Int32);
                comando.Parameters.Add("@Estado", MySqlDbType.VarChar, 45);
                comando.Parameters.Add("@imagen", MySqlDbType.LongBlob);

                comando.Parameters["@idSocio"].Value = socio.IdSocio;
                comando.Parameters["@Persona_id"].Value = socio.GetPersona_Id();
                if (socio.GetArea_Id() == 0)
                {
                    comando.Parameters["@Area_id"].Value = null;
                }
                else {
                    comando.Parameters["@Area_id"].Value = socio.GetArea_Id();
                }
                if (socio.GetPersona_IdDirector() == 0)
                {
                    comando.Parameters["@Persona_idDirector"].Value = null;
                }
                else {
                    comando.Parameters["@Persona_idDirector"].Value = socio.GetPersona_IdDirector();
                }
                comando.Parameters["@Tesis"].Value = socio.GetTesis();
                comando.Parameters["@Tipo_Socio_id"].Value = socio.GetTipoSocio_Id();
                comando.Parameters["@Estado"].Value = socio.GetEstado();
                comando.Parameters["@imagen"].Value = socio.GetImagen();
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
