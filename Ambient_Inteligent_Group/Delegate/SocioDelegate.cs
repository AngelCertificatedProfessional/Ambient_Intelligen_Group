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
    public class SocioDelegate
    {
        public static MySqlDataReader BuscarDescripcion(String tabla)
        {
            return SocioFacade.BuscarDescripcion(tabla);
        }

        public static bool ModificarSocio(Socio socio)
        {
            return SocioFacade.ModificarSocio(socio);
        }

        public static Boolean GuardarSocio(Socio socio)
        {
            return SocioFacade.GuardarSocio(socio);
        }
    }
}
