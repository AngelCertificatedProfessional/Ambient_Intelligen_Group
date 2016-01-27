using Ambient_Inteligent_Group.Dao;
using Ambient_Inteligent_Group.Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Facade
{
    public class Tipo_SocioFacade
    {
        public static MySqlDataReader BuscarDescripcion(String nombre)
        {
            return Tipo_SocioDao.BuscarDescripcion(nombre);
        }

        public static Boolean GuardarTipo_Socio(Tipo_Socio tipo_Socio)
        {
            return Tipo_SocioDao.GuardarTipo_Socio(tipo_Socio);
        }

        public static Boolean ModificarTipo_Socio(Tipo_Socio tipo_Socio)
        {
            return Tipo_SocioDao.ModificarTipo_Socio(tipo_Socio);
        }
    }
}
