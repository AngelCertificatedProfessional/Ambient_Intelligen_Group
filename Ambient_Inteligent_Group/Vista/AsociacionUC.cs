using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;

namespace Ambient_Inteligent_Group.Vista
{
    public partial class AsociacionUC : UserControl
    {
        public AsociacionUC()
        {
            InitializeComponent();
            asociacionControl = new AsociacionControl(this, typeof(Asociacion));
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (nombreAsociacionTxt.Text == "")
            {
                asociacionControl.BuscarTodos("Asociacion");
            }
            else
            {
                asociacionControl.BuscarDescripcion(nombreAsociacionTxt.Text, "Asociacion");
            }
        }

        private void VisibilidadOpciones(Boolean visibilidad)
        {
            modificarBtn.Enabled = visibilidad;
            eliminarBtn.Enabled = visibilidad;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (tablaAsociacion.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar la asociacion Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(tablaAsociacion.CurrentRow.Cells[0].Value);
                    asociacionControl.Eliminar("Asociacion", id, "idAsociacion");
                }
            }
            else
            {
                MessageBox.Show("debe de seleccionar una fila");
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            AgregarModificarAsociacionForm agreMod =
               new AgregarModificarAsociacionForm(this);
            agreMod.Visible = true;
            this.Enabled = false;
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (tablaAsociacion.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaAsociacion.CurrentRow.Cells[0].Value);
                System.Console.Write(id);
                asociacionControl.ObtenerPorIdConImagen("Asociacion", id, "idAsociacion");
            } 
        }
    }
}
