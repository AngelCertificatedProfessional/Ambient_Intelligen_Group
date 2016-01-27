using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Entidad
{
    public class Universidad
    {
        public int IdUniversidad { set; get; }
        public String NombreUniversidad { set; get; }
        private String abreviacion;

        public Universidad(){
        
        }


        public void SetAbreviacion(String abreviacion) {
            this.abreviacion = abreviacion;
        }

        public String GetAbreviacion() {
            return abreviacion;
        }

    }
}
