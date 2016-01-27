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
    public class ProgramaEducativoDelegate
    {
        public static MySqlDataReader BuscarDescripcion(String tabla)
        {
            return ProgramaEducativoFacade.BuscarDescripcion(tabla);
        }

        public static bool ModificarPrograma(ProgramaEducativo programa)
        {
            return ProgramaEducativoFacade.ModificarPrograma(programa);
        }

        public static Boolean GuardarPrograma(ProgramaEducativo programa)
        {
            return ProgramaEducativoFacade.GuardarPrograma(programa);
        }
    }
}
