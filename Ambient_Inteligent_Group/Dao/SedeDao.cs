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
    public class SedeDao
    {

        public static Boolean GuardarSede(Sede sede)
        {
            Boolean retorno = true;
            try
            {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                MySqlCommand comando = new MySqlCommand(string.Format(
                    "Insert into Sede (Nombre,Edificio,Salon) values ('"+sede.Nombre+"','"+sede.Edificio+"','"+sede.Salon+"')"),
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

        public static MySqlDataReader BuscarPorNombre(String nombre)
        {
            MySqlDataReader lector;
            try {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT * FROM Sede where Nombre LIKE '%" + nombre + "%'"), ConexionBD.EnviarConexion());
                lector = _comando.ExecuteReader();
            }catch(Exception e){
                lector = null;
                System.Console.Write(e);
            }finally{
            }
            return lector;
        }

        public static Boolean ModificarSede(Sede sede)
        {
            Boolean retorno= true;
            try {
                ConexionBD.CrearConexion();
                ConexionBD.ConectarConexion();
                ConexionBD.BeginTransaction();
                MySqlCommand comando = new MySqlCommand(string.Format("Update Sede set Nombre='{0}', Edificio='{1}', Salon='{2}' where IdSede={3}",
                sede.Nombre, sede.Edificio, sede.Salon, sede.IdSede), ConexionBD.EnviarConexion());
                comando.ExecuteNonQuery();
                ConexionBD.Commit();
            }catch(Exception e)
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
