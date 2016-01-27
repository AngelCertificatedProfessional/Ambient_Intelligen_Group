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
        public static Boolean GuardarPersona(Persona persona,List<Universidad> universidadLis)
        {
            Boolean retorno = true;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                MySqlCommand comando = new MySqlCommand(string.Format(
                    "Insert into Persona (nombreCompleto,apellidoPaterno,apellidoMaterno,Escolaridad_id,Sexo) values ('" + persona.NombreCompleto
                    +"','"+persona.ApellidoPaterno+"','"+persona.ApellidoMaterno+"',"+persona.GetIdEscolaridad()+",'"+persona.Sexo+"')",
                    ConexionBD.EnviarConexion()));
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

        public static Boolean ModificarPersona(Persona persona,List<Universidad> universidadLis)
        {
            Boolean retorno = true;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                MySqlCommand comando = new MySqlCommand(string.Format("Update Persona set NombreCompleto='{0}', apellidoPaterno='{1}', apellidoMaterno='{2}', "+
                    "Escolaridad_id={3},Sexo='{4}' where idPersona={5}",persona.NombreCompleto,persona.ApellidoPaterno,persona.ApellidoMaterno,persona.GetIdEscolaridad(),persona.Sexo,
                    persona.IdPersona), ConexionBD.EnviarConexion());
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
