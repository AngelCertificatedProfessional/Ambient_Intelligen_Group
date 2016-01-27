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
    public class EscolaridadDelegate
    {
        public static MySqlDataReader BuscarDescripcion(String tabla)
        {
            return EscolaridadFacade.BuscarDescripcion(tabla);
        }

        public static bool ModificarEscolaridad(Escolaridad escolaridad)
        {
            return EscolaridadFacade.ModificarEscolaridad(escolaridad);
        }

        public static Boolean GuardarEscolaridad(Escolaridad escolaridad)
        {
            return EscolaridadFacade.GuardarEscolaridad(escolaridad);
        }
    }
}
