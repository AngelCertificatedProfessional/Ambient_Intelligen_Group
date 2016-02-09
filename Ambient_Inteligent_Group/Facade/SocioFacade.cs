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
    public class SocioFacade
    {
        public static MySqlDataReader BuscarDescripcion(String nombre)
        {
            return SocioDao.BuscarDescripcion(nombre);
        }

        public static Boolean GuardarSocio(Socio socio)
        {
            return SocioDao.GuardarSocio(socio);
        }

        public static Boolean ModificarSocio(Socio socio)
        {
            return SocioDao.ModificarSocio(socio);
        }
    }
}
