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
    public class EscolaridadFacade
    {
        public static MySqlDataReader BuscarDescripcion(String nombre)
        {
            return EscolaridadDao.BuscarDescripcion(nombre);
        }

        public static Boolean GuardarEscolaridad(Escolaridad escolaridad)
        {
            return EscolaridadDao.GuardarEscolaridad(escolaridad);
        }

        public static Boolean ModificarEscolaridad(Escolaridad escolaridad)
        {
            return EscolaridadDao.ModificarEscolaridad(escolaridad);
        }
    }
}
