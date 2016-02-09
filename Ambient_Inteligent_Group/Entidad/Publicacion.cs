using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Entidad
{
    public class Publicacion
    {

        public int IdPublicacion { set; get; }
        public String Descripcion { set; get; }
        private int tipo_Publicaion;
        public String Anio { set; get;}
        public String Link { set; get; }
        private String pagina;

        public int GetTipo_Publicacion() {
            return tipo_Publicaion;
        }

        public void SetTipo_Publicacion(int tipo_Publicaion) {
            this.tipo_Publicaion = tipo_Publicaion;
        }

        public String GetPagina()
        {
            return pagina;
        }

        public void SetPagina(String pagina) {
            this.pagina = pagina;
        }

    }
}
