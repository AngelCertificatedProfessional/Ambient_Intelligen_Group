using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Entidad
{
    public class Platica
    {
        public int IdPlatica {get; set;}
        public DateTime Fecha { set; get; }
        public String Nombre_Platica { set; get; }
        private int Id_Sede { set; get; }
        public String Nombre_Evento { set; get; }
        public String Abreviacion_Evento { set; get; }

        public void SetId_Sede(int Id_Sede)
        {
            this.Id_Sede = Id_Sede;
        }

        public int GetId_Sede()
        {
            return Id_Sede = Id_Sede;
        }

    }
}
