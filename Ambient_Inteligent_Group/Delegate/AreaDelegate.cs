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
    public class AreaDelegate
    {
        public static MySqlDataReader BuscarDescripcion(String tabla)
        {
            return AreaFacade.BuscarDescripcion(tabla);
        }

        public static bool ModificarArea(Area area)
        {
            return AreaFacade.ModificarArea(area);
        }

        public static Boolean GuardarArea(Area area)
        {
            return AreaFacade.GuardarArea(area);
        }

    }
}
