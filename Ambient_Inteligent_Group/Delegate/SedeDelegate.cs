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
    public class SedeDelegate
    {
        public static MySqlDataReader BuscarPorNombre(String tabla)
        {
            return SedeFacade.BuscarPorNombre(tabla);
        }

        public static bool ModificarSede(Sede sede)
        {
            return SedeFacade.ModificarSede(sede);
        }

        public static Boolean GuardarSede(Sede sede)
        {
            return SedeFacade.GuardarSede(sede);
        }
    }
}
