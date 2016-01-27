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
    public partial class PlaticaUC : UserControl
    {
        public PlaticaUC()
        {
            InitializeComponent();
            platicaControl = new PlaticaControl(this, typeof(Platica));
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (nombrePlaticaTB.Text == "")
            {
                platicaControl.BuscarTodos("Platica");
            }
            else
            {
                platicaControl.BuscarPorNombre(nombrePlaticaTB.Text, "Platica");
            }
        }

        private void VisibilidadOpciones(Boolean visibilidad)
        {
            modificarBtn.Enabled = visibilidad;
            eliminarBtn.Enabled = visibilidad;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (tablaPlatica.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar la platica?", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(tablaPlatica.CurrentRow.Cells[0].Value);
                    platicaControl.Eliminar("Platica", id, "idplatica");
                }
            }
            else
            {
                MessageBox.Show("debe de seleccionar una fila");
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            AgregarModificarPlaticaForm agreMod =
                 new AgregarModificarPlaticaForm(this);
            agreMod.Visible = true;
            this.Enabled = false;
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (tablaPlatica.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaPlatica.CurrentRow.Cells[0].Value);
                System.Console.Write(id);
                platicaControl.ObtenerPorId("Platica", id, "idPlatica");
            }
        }

    }
}
