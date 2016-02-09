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
    public class PublicacionFacade
    {
        public static MySqlDataReader BuscarPorPublicacion(String nombre)
            {
                return PublicacionDao.BuscarPorPublicacion(nombre);
            }

            public static Boolean GuardarPublicacion(Publicacion publicacion, List<int> perLis)
            {
                bool bandera = true;
                int id = PublicacionDao.GuardarPublicacion(publicacion);
                if (perLis.Count != 0 && id != 0)
                {

                    for (int i = 0; i < perLis.Count; i++)
                    {
                        if (Colaborador_PublicacionDao.GuardarColaborador_Publicacion(id, perLis[i]) == false)
                        {
                            BaseDao.Eliminar("Publicacion", id, "idPublicacion");
                            BaseDao.Eliminar("Colaborador_Publicacion", id, "Publicacion_idPublicacion");
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

        public static Boolean ModificarPublicacion(Publicacion publicacion, List<int> perLis)
        {
            bool bandera = true;
            int id = PublicacionDao.ModificarPublicacion(publicacion);
            if (perLis.Count != 0 && id != 0)
            {
                BaseDao.Eliminar("Colaborador_Publicacion", id, "Publicacion_idPublicacion");
                for (int i = 0; i < perLis.Count; i++)
                {
                    if (Colaborador_PublicacionDao.GuardarColaborador_Publicacion(id, perLis[i]) == false)
                    {
                        BaseDao.Eliminar("Publicacion", id, "idPublicacion");
                        BaseDao.Eliminar("Colaborador_Publicacion", id, "Publicacion_idPublicacion");
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
