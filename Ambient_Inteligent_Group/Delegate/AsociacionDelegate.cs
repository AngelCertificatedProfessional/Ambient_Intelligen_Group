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
    public class AsociacionDelegate
    {
        public static MySqlDataReader BuscarDescripcion(String tabla)
        {
            return AsociacionFacade.BuscarDescripcion(tabla);
        }

        public static bool ModificarAsociacion(Asociacion asociacion)
        {
            return AsociacionFacade.ModificarAsociacion(asociacion);
        }

        public static Boolean GuardarAsociacion(Asociacion asociacion)
        {
            return AsociacionFacade.GuardarAsociacion(asociacion);
        }
    }
}
