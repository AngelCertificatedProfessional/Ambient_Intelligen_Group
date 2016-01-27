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
    public class UniversidadDelegate
    {
        public static MySqlDataReader BuscarPorNombre(String tabla)
        {
            return UniversidadFacade.BuscarPorNombre(tabla);
        }
        public static bool ModificarUniversidad(Universidad universidad)
        {
            return UniversidadFacade.ModificarUniversidad(universidad);
        }

        public static Boolean GuardarUniversidad(Universidad universidad)
        {
            return UniversidadFacade.GuardarUniversidad(universidad);
        }
    }
}
