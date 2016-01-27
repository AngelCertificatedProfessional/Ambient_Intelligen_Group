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
    public class PlaticaRealizadaDao
    {
        public static Boolean GuardarPlatica(Platica platica)
        {

            Boolean retorno = true;
            String cadena = "insert into Platica (fecha,NombrePlatica,Sede_idSede,EventoNombre,abreviacionNombre) values"  +
                " (@fecha,@NombrePlatica,@Sede_idSede,@EventoNombre,@abreviacionNombre)";
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();

                MySqlCommand comando = new MySqlCommand(cadena, ConexionBD.EnviarConexion());
                comando.Parameters.Add("@fecha", MySqlDbType.DateTime);
                comando.Parameters.Add("@NombrePlatica", MySqlDbType.VarChar, 200);
                comando.Parameters.Add("@Sede_idSede", MySqlDbType.Int32);
                comando.Parameters.Add("@EventoNombre", MySqlDbType.VarChar, 200);
                comando.Parameters.Add("@abreviacionNombre", MySqlDbType.VarChar,45);

                comando.Parameters["@fecha"].Value = platica.Fecha;
                comando.Parameters["@NombrePlatica"].Value = platica.Nombre_Platica;
                comando.Parameters["@Sede_IdSede"].Value = platica.GetId_Sede();
                comando.Parameters["@EventoNombre"].Value = platica.Nombre_Evento;
                comando.Parameters["@abreviacionNombre"].Value = platica.Abreviacion_Evento;

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

        public static MySqlDataReader BuscarPorNombre(String nombre)
        {
            MySqlDataReader lector;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT * FROM Platica where NombrePlatica LIKE '%" + nombre + "%'"), ConexionBD.EnviarConexion());
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

        public static Boolean ModificarPlatica(Platica platica)
        {
            Boolean retorno = true;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                String cadena = "Update Platica set fecha=@fecha, NombrePlatica=@NombrePlatica, Sede_idSede=@Sede_idSede, EventoNombre = @EventoNombre,"
                    + "abreviacionNombre = @abreviacionNombre where idPlatica=@idPlatica";
                MySqlCommand comando = new MySqlCommand(cadena, ConexionBD.EnviarConexion());

                comando.Parameters.Add("@idPlatica", MySqlDbType.Int32);
                comando.Parameters.Add("@fecha", MySqlDbType.DateTime);
                comando.Parameters.Add("@NombrePlatica", MySqlDbType.VarChar, 200);
                comando.Parameters.Add("@Sede_idSede", MySqlDbType.Int32);
                comando.Parameters.Add("@EventoNombre", MySqlDbType.VarChar, 200);
                comando.Parameters.Add("@abreviacionNombre", MySqlDbType.VarChar, 45);

                comando.Parameters["@idPlatica"].Value = platica.IdPlatica;
                comando.Parameters["@fecha"].Value = platica.Fecha;
                comando.Parameters["@NombrePlatica"].Value = platica.Nombre_Platica;
                comando.Parameters["@Sede_IdSede"].Value = platica.GetId_Sede();
                comando.Parameters["@EventoNombre"].Value = platica.Nombre_Evento;
                comando.Parameters["@abreviacionNombre"].Value = platica.Abreviacion_Evento;
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
