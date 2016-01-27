using Ambient_Inteligent_Group.Entidad;
using Ambient_Inteligent_Group.Facade;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Delegate
{
    public class PeriodoDelegate
    {
        public static MySqlDataReader BuscarPeriodo(String tabla)
        {
            return PeriodoFacade.BuscarPeriodo(tabla);
        }

        public static bool ModificarPeriodo(Periodo periodo)
        {
            return PeriodoFacade.ModificarPeriodo(periodo);
        }

        public static Boolean GuardarPeriodo(Periodo periodo)
        {
            return PeriodoFacade.GuardarPeriodo(periodo);
        }
    }
}
