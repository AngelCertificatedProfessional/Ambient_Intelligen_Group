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
    public partial class UniversidadUC : UserControl
    {
        public UniversidadUC()
        {
            InitializeComponent();
            universidadControl = new UniversidadControl(this,typeof(Universidad));
        }
        private void VisibilidadOpciones(Boolean visibilidad)
        {
            modificarBtn.Enabled = visibilidad;
            eliminarBtn.Enabled = visibilidad;
        }
        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (nombreUniversidadTB.Text == "")
            {
                universidadControl.BuscarTodos("Universidad");
            }
            else
            {
                universidadControl.BuscarPorNombre(nombreUniversidadTB.Text, "Universidad");
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (tablaUniversidad.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar la universidad Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(tablaUniversidad.CurrentRow.Cells[0].Value);
                    universidadControl.Eliminar("Universidad", id, "idUniversidad");
                }
            }
            else
            {
                MessageBox.Show("debe de seleccionar una fila");
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            AgregarModificarUniversidadForm agreMod = 
                new AgregarModificarUniversidadForm(this);
            agreMod.Visible = true;
            this.Enabled = false;
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (tablaUniversidad.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaUniversidad.CurrentRow.Cells[0].Value);
                System.Console.Write(id);
                universidadControl.ObtenerPorId("Universidad", id, "idUniversidad");
            } 
        }
    }
}
