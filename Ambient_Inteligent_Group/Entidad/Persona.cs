using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Entidad
{
    public class Persona
    {
        public int IdPersona {set; get;}
        public String NombreCompleto { set; get; }
        public String ApellidoPaterno { set; get; }
        public String ApellidoMaterno { set; get; }
        private int IdEscolaridad;
        public Char Sexo { set; get; }

        public int GetIdEscolaridad() {
            return IdEscolaridad;
        }

        public void SetIdEscolaridad(int IdEscolaridad) {
            this.IdEscolaridad = IdEscolaridad;
        }

    }
}
