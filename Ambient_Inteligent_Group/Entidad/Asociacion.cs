using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Entidad
{
    public class Asociacion
    {
        public int IdAsociacion { set; get; }
        public String Descripcion { set; get; }
        public String Link { set; get; }
        private byte[] imagen;

        public void SetImangen(byte[] imagen) { 
            this.imagen = imagen;
        }

        public byte[] GetImagen() {
            return this.imagen;
        }

    }
}
