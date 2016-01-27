using Ambient_Inteligent_Group.Dao;
using Ambient_Inteligent_Group.Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Facade
{
    public class ProgramaEducativoFacade
    {
        public static MySqlDataReader BuscarDescripcion(String nombre)
        {
            return ProgramaEducativoDao.BuscarDescripcion(nombre);
        }

        public static Boolean GuardarPrograma(ProgramaEducativo programa)
        {
            return ProgramaEducativoDao.GuardarPrograma(programa);
        }

        public static Boolean ModificarPrograma(ProgramaEducativo programa)
        {
            return ProgramaEducativoDao.ModificarPrograma(programa);
        }
    }
}
