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
    public partial class Tipo_SocioUC : UserControl
    {
        public Tipo_SocioUC()
        {
            InitializeComponent();
           tipo_SocioControl = new Tipo_SocioControl(this, typeof(Tipo_Socio));
        }
        private void VisibilidadOpciones(Boolean visibilidad)
        {
            modificarBtn.Enabled = visibilidad;
            eliminarBtn.Enabled = visibilidad;
        }
        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (tipoSocioTB.Text == "")
            {
                tipo_SocioControl.BuscarTodos("Tipo_Socio");
            }
            else
            {
                tipo_SocioControl.BuscarDescripcion(tipoSocioTB.Text, "Tipo_Socio");
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (tablaTipo_Socio.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar el tipo de socio Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(tablaTipo_Socio.CurrentRow.Cells[0].Value);
                    tipo_SocioControl.Eliminar("Tipo_Socio", id, "idTipo_Socio");
                }
            }
            else
            {
                MessageBox.Show("debe de seleccionar una fila");
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            AgregarModificarTipoSocioForm agreMod =
                new AgregarModificarTipoSocioForm(this);
            agreMod.Visible = true;
            this.Enabled = false;
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (tablaTipo_Socio.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaTipo_Socio.CurrentRow.Cells[0].Value);
                tipo_SocioControl.ObtenerPorId("Tipo_Socio", id, "idTipo_Socio");
            } 
        }
    }
}
