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
    public class PlaticaFacade
    {
        public static MySqlDataReader BuscarPorNombre(String nombre)
        {
            return PlaticaRealizadaDao.BuscarPorNombre(nombre);
        }

        public static Boolean GuardarPlatica(Platica platica)
        {
            return PlaticaRealizadaDao.GuardarPlatica(platica);
        }

        public static Boolean ModificarPlatica(Platica platica)
        {
            return PlaticaRealizadaDao.ModificarPlatica(platica);
        }
    }
}
