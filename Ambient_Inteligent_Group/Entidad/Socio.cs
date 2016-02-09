using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambient_Inteligent_Group.Entidad
{
    public class Socio
    {
        public int IdSocio { set; get; }
        private int persona_id;
        private int area_id;
        private int persona_idDirector;
        private String tesis;
        private int tipo_Socio_id;
        private String estado;
        private byte[] imagen;

        public void SetPersona_Id(int persona_id) {
            this.persona_id = persona_id;
        }

        public int GetPersona_Id() {
            return persona_id;
        }

        public void SetArea_Id(int area_id) {
            this.area_id = area_id;
        }

        public int GetArea_Id() {
            return area_id;
        }

        public void SetPersona_IdDirector(int persona_idDirector) {
            this.persona_idDirector = persona_idDirector;
        }

        public int GetPersona_IdDirector() {
            return persona_idDirector;
        }

        public void SetTesis(String tesis) {
            this.tesis = tesis;
        }

        public String GetTesis() {
            return tesis;
        }

        public void SetTipoSocio_Id(int tipo_Socio_id)
        {
            this.tipo_Socio_id = tipo_Socio_id;
        }

        public int GetTipoSocio_Id() {
            return tipo_Socio_id;
        }

        public void SetEstado(String estado) {
            this.estado = estado;
        }

        public String GetEstado() {
            return estado;
        }

        public void SetImangen(byte[] imagen)
        {
            this.imagen = imagen;
        }

        public byte[] GetImagen()
        {
            return this.imagen;
        }
    }
}
