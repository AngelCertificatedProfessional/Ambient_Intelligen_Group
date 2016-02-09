using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Entidad
{
    public class Escolaridad
    {

        public Escolaridad(int idEscolaridad,String descripcion) {
            this.IdEscolaridad = idEscolaridad;
            this.Descripcion = descripcion;
        }

        public Escolaridad() {

        }

        public int IdEscolaridad { set; get; }
        public String Descripcion { set; get; }
    }
}
