using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ambient_Inteligent_Group.Entidad;
using Ambient_Inteligent_Group.Controlador;

namespace Ambient_Inteligent_Group.Vista
{
    public partial class SedeUC : UserControl
    {
        public SedeUC()
        {
            sedeControl = new SedeControl(this,typeof(Sede));
            InitializeComponent();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (nombreSedeTB.Text == "")
            {
                sedeControl.BuscarTodos("Sede");
            }
            else {
                sedeControl.BuscarPorNombre(nombreSedeTB.Text,"Sede");
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            AgregarModificarSedeForm agreMod = new AgregarModificarSedeForm(this);
            agreMod.Visible = true;
            this.Enabled = false;
        }

        private void VisibilidadOpciones(Boolean visibilidad) {
            modificarBtn.Enabled = visibilidad;
            eliminarBtn.Enabled = visibilidad;
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (tablaSede.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaSede.CurrentRow.Cells[0].Value);
                System.Console.Write(id);
                sedeControl.ObtenerPorId("Sede", id,"idSede");
            } 
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (tablaSede.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar la sede Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                    int id = Convert.ToInt32(tablaSede.CurrentRow.Cells[0].Value);
                    sedeControl.Eliminar("Sede",id,"idSede");
                } 
            }
            else { 
                MessageBox.Show("debe de seleccionar una fila");
            }
                
        }

    }
}
