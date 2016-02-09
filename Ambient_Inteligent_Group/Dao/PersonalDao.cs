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
    public class PersonalDao
    {
        public static int GuardarPersona(Persona persona)
        {
            MySqlCommand comando;
            String cadenaPersona = "Insert into Persona (nombreCompleto,apellidoPaterno,apellidoMaterno,Escolaridad_id,Sexo) values (@nombreCompleto" +
                ",@apellidoPaterno,@apellidoMaterno,@Escolaridad_id,@Sexo)";
            String cadenaPersonaSinEsc = "Insert into Persona (nombreCompleto,apellidoPaterno,apellidoMaterno,Sexo) values (@nombreCompleto" +
                ",@apellidoPaterno,@apellidoMaterno,@Sexo)";
            int id=0;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                if (persona.GetIdEscolaridad() != 0)
                {
                    comando = new MySqlCommand(cadenaPersona, ConexionBD.EnviarConexion());
                }
                else {
                    comando = new MySqlCommand(cadenaPersonaSinEsc, ConexionBD.EnviarConexion());
                }
               
                
                comando.Parameters.Add("@nombreCompleto", MySqlDbType.VarChar,200);
                comando.Parameters.Add("@apellidoPaterno", MySqlDbType.VarChar, 45);
                comando.Parameters.Add("@apellidoMaterno", MySqlDbType.VarChar,45);

                if (persona.GetIdEscolaridad()!=0) {
                    comando.Parameters.Add("@Escolaridad_id", MySqlDbType.Int32);
                }
                
                comando.Parameters.Add("@Sexo", MySqlDbType.Enum);


                comando.Parameters["@nombreCompleto"].Value = persona.NombreCompleto;
                comando.Parameters["@apellidoPaterno"].Value = persona.ApellidoPaterno;
                comando.Parameters["@apellidoMaterno"].Value = persona.ApellidoMaterno;
                if (persona.GetIdEscolaridad() !=0)
                {
                    comando.Parameters["@Escolaridad_id"].Value = persona.GetIdEscolaridad();
                }
                
                comando.Parameters["@Sexo"].Value = persona.Sexo;
                comando.ExecuteNonQuery();

                id = (int)(Convert.ToInt64(comando.LastInsertedId));
                ConexionBD.Commit();
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

        public static MySqlDataReader BuscarNombre(String nombre)
        {
            MySqlDataReader lector;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT * FROM Persona where nombreCompleto LIKE '%" + nombre +
                "%' or apellidoPaterno LIKE '%"+ nombre+ "%' or apellidoMaterno LIKE '%"+nombre+"%'"), ConexionBD.EnviarConexion());
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

        public static int ModificarPersona(Persona persona)
        {
            MySqlCommand comando;
            String cadenaPersona = "Update Persona set nombreCompleto = @nombreCompleto, apellidoPaterno = @apellidoPaterno, apellidoMaterno = @apellidoMaterno,"+
                " Escolaridad_id = @Escolaridad_id, Sexo = @Sexo where idPersona = @idPersona";

            int id = 0;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                comando = new MySqlCommand(cadenaPersona, ConexionBD.EnviarConexion());

                comando.Parameters.Add("@idPersona", MySqlDbType.Int32);
                comando.Parameters.Add("@nombreCompleto", MySqlDbType.VarChar, 200);
                comando.Parameters.Add("@apellidoPaterno", MySqlDbType.VarChar, 45);
                comando.Parameters.Add("@apellidoMaterno", MySqlDbType.VarChar, 45);
                comando.Parameters.Add("@Escolaridad_id", MySqlDbType.Int32);
                comando.Parameters.Add("@Sexo", MySqlDbType.Enum);

                comando.Parameters["@idPersona"].Value = persona.IdPersona;
                comando.Parameters["@nombreCompleto"].Value = persona.NombreCompleto;
                comando.Parameters["@apellidoPaterno"].Value = persona.ApellidoPaterno;
                comando.Parameters["@apellidoMaterno"].Value = persona.ApellidoMaterno;
                if (persona.GetIdEscolaridad() != 0)
                {
                    comando.Parameters["@Escolaridad_id"].Value = persona.GetIdEscolaridad();
                }
                else {
                    comando.Parameters["@Escolaridad_id"].Value = null;
                }

                comando.Parameters["@Sexo"].Value = persona.Sexo;
                comando.ExecuteNonQuery();

                id = persona.IdPersona;
                ConexionBD.Commit();
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
