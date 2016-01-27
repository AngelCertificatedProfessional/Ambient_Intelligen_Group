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
    public partial class AreaUC : UserControl
    {
        public AreaUC()
        {
            InitializeComponent();
            areaControl = new AreaControl(this, typeof(Area));
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (nombreAreaTB.Text == "")
            {
                areaControl.BuscarTodos("Area");
            }
            else {
                areaControl.BuscarDescripcion(nombreAreaTB.Text,"Area");
            }
        }

        private void VisibilidadOpciones(Boolean visibilidad)
        {
            modificarBtn.Enabled = visibilidad;
            eliminarBtn.Enabled = visibilidad;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (tablaArea.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar el area Actual?", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(tablaArea.CurrentRow.Cells[0].Value);
                    areaControl.Eliminar("Area", id, "idArea");
                }
            }
            else
            {
                MessageBox.Show("debe de seleccionar una fila");
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            AgregarModificarAreaForm agreMod =
                new AgregarModificarAreaForm(this);
            agreMod.Visible = true;
            this.Enabled = false;
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (tablaArea.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaArea.CurrentRow.Cells[0].Value);
                System.Console.Write(id);
                areaControl.ObtenerPorId("Area", id, "idArea");
            }
        }

    }
}
