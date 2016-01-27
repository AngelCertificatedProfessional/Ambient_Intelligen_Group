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
    public class Tipo_SocioDelegate
    {
        public static MySqlDataReader BuscarDescripcion(String tabla)
        {
            return Tipo_SocioFacade.BuscarDescripcion(tabla);
        }

        public static bool ModificarTipo_Socio(Tipo_Socio tipo_Socio)
        {
            return Tipo_SocioFacade.ModificarTipo_Socio(tipo_Socio);
        }

        public static Boolean GuardarTipo_Socio(Tipo_Socio tipo_Socio)
        {
            return Tipo_SocioFacade.GuardarTipo_Socio(tipo_Socio);
        }
    }
}
