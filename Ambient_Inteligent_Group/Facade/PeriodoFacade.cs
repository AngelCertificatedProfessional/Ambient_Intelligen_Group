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
    public class PeriodoFacade
    {
        public static MySqlDataReader BuscarPeriodo(String periodo)
        {
            return PeriodoDao.BuscarPeriodo(periodo);
        }

        public static Boolean GuardarPeriodo(Periodo periodo)
        {
            return PeriodoDao.GuardarPeriodo(periodo);
        }

        public static Boolean ModificarPeriodo(Periodo periodo)
        {
            return PeriodoDao.ModificarPeriodo(periodo);
        }
    }
}
