using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambient_Inteligent_Group.Vista
{
    public partial class AgregarModificarSedeForm : Form
    {
        private InterfaceComunicador comunicador;
        public AgregarModificarSedeForm(InterfaceComunicador comunicador)
        {
            InitializeComponent();
            this.comunicador = comunicador;
            controlSede = new SedeControl(this, typeof(Sede));
            guardarBtn.Text = "Guardar";
            agregarModLbl.Text = "Agregar Sede";
        }

        public AgregarModificarSedeForm()
        {
            InitializeComponent();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            comunicador.setMensaje("Cerrar");
        }


        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if(Validacion()==false){
                if (guardarBtn.Text == "Guardar")
                {
                    List<Object> listaSede = new List<Object>();
                    listaSede.Add(nombreTxt.Text);
                    listaSede.Add(edificioTxt.Text);
                    listaSede.Add(salonTxt.Text);
                    controlSede.GuardarSede(HelpetEntidad.ContruccionSede(listaSede,"Guardar"));
                }
                else
                {
                    List<Object> listaSede = new List<Object>();
                    listaSede.Add(idSede);
                    listaSede.Add(nombreTxt.Text);
                    listaSede.Add(edificioTxt.Text);
                    listaSede.Add(salonTxt.Text);
                    controlSede.ModificarSede(HelpetEntidad.ContruccionSede(listaSede, "Modificar"));
                }
            }
        }

        private Boolean Validacion() {
            if (nombreTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir el nombre de la Sede", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        private void nombreTxt_Leave(object sender, EventArgs e)
        {
            if (nombreTxt.Text == "")
            {
                advertenciaNombreLbl.Visible = true;
            }
        }

        private void nombreTxt_Enter(object sender, EventArgs e)
        {
            if (nombreTxt.Text == "")
            {
                advertenciaNombreLbl.Visible = false;
            }
        }

        public void ObtenerInfo(List<Object> listaSede){
            idSede = (int) listaSede[0];
            nombreTxt.Text = (String) listaSede[1];
            edificioTxt.Text = (String)listaSede[2];
            salonTxt.Text = (String) listaSede[3];
            guardarBtn.Text = "Modificar";
            agregarModLbl.Text = "Modificar Sede";
        }

        private void AgregarModificarSedeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            comunicador.setMensaje("Cerrar");
        }

    }
}
