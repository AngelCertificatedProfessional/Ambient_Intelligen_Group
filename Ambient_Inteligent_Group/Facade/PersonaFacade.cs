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
    public class PersonaFacade
    {
        public static MySqlDataReader BuscarNombre(String nombre)
        {
            return PersonalDao.BuscarNombre(nombre);
        }

        public static Boolean GuardarPersona(Persona persona,List<int> uniLis)
        {
            bool bandera = true;
            int id = PersonalDao.GuardarPersona(persona);
            if (uniLis.Count != 0 && id != 0)
            {
                for (int i = 0; i < uniLis.Count; i++)
                {
                    if (Socio_UniversidadDao.GuardarSocio_Universidad(uniLis[i], id) == false)
                    {
                        BaseDao.Eliminar("Persona", id, "idPersona");
                        BaseDao.Eliminar("Socio_Universidad", id, "Persona_id");
                        return false;
                    }
                    else {
                        bandera = true;
                    }
                }
            }
            else if(id==0){
                return false;
            }
            return bandera;
        }

        public static Boolean ModificarPersona(Persona persona, List<int> uniLis)
        {
            bool bandera = true;
            int id = PersonalDao.ModificarPersona(persona);
            if (uniLis.Count != 0 && id != 0)
            {
                BaseDao.Eliminar("Socio_Universidad", id, "Persona_id");
                for (int i = 0; i < uniLis.Count; i++)
                {
                    
                    if (Socio_UniversidadDao.GuardarSocio_Universidad(uniLis[i], id) == false)
                    {
                        BaseDao.Eliminar("Persona", id, "idPersona");
                        BaseDao.Eliminar("Socio_Universidad", id, "Persona_id");
                        return false;
                    }
                    else {
                        bandera = true;
                    }
                }
            }
            else if (id == 0)
            {
                return false;
            }
            return bandera;
        }
    }
}
