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
    public partial class EscolaridadUC : UserControl
    {
        public EscolaridadUC()
        {
            InitializeComponent();
            escolaridadControl = new EscolaridadControl(this, typeof(Escolaridad));
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (escolaridadTB.Text == "")
            {
                escolaridadControl.BuscarTodos("Escolaridad");
            }
            else
            {
                escolaridadControl.BuscarDescripcion(escolaridadTB.Text, "Escolaridad");
            }
        }

        private void VisibilidadOpciones(Boolean visibilidad)
        {
            modificarBtn.Enabled = visibilidad;
            eliminarBtn.Enabled = visibilidad;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (tablaEscolaridad.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar la escolaridad actual?", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(tablaEscolaridad.CurrentRow.Cells[0].Value);
                    escolaridadControl.Eliminar("Escolaridad", id, "idEscolaridad");
                }
            }
            else
            {
                MessageBox.Show("debe de seleccionar una fila");
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            AgregarModificarEscolaridadForm agreMod =
                new AgregarModificarEscolaridadForm(this);
            agreMod.Visible = true;
            this.Enabled = false;
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (tablaEscolaridad.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaEscolaridad.CurrentRow.Cells[0].Value);
                System.Console.Write(id);
                escolaridadControl.ObtenerPorId("Escolaridad", id, "idEscolaridad");
            } 
        }
    }
}
