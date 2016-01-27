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
    public class PlaticaDelegate
    {
        public static MySqlDataReader BuscarPorNombre(String tabla)
        {
            return PlaticaFacade.BuscarPorNombre(tabla);
        }

        public static bool ModificarPlatica(Platica platica)
        {
            return PlaticaFacade.ModificarPlatica(platica);
        }

        public static Boolean GuardarPlatica(Platica platica)
        {
            return PlaticaFacade.GuardarPlatica(platica);
        }
    }
}
