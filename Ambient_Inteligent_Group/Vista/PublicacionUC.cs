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
    public partial class PublicacionUC : UserControl
    {
        public PublicacionUC()
        {
            InitializeComponent();
            publicacionControl = new PublicacionControl(this, typeof(Publicacion));
        }

        private void VisibilidadOpciones(Boolean visibilidad)
        {
            modificarBtn.Enabled = visibilidad;
            eliminarBtn.Enabled = visibilidad;
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (nombreTxt.Text == "")
            {
                publicacionControl.BuscarTodos("Publicacion");
            }
            else
            {
                publicacionControl.BuscarNombre(nombreTxt.Text, "Publicacion");
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            AgregarModificarPublicacionForm agreMod =
               new AgregarModificarPublicacionForm(this);
            agreMod.Visible = true;
            this.Enabled = false;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (tablaPublicacion.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar la publicacion?", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(tablaPublicacion.CurrentRow.Cells[0].Value);
                    publicacionControl.Eliminar("Colaborador_Publicacion", id, "Publicacion_idPublicacion");
                    contMen++;
                    publicacionControl.Eliminar("Publicacion", id, "idPublicacion");
                    contMen--;
                }
            }
            else
            {
                MessageBox.Show("debe de seleccionar una fila");
            }
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (tablaPublicacion.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaPublicacion.CurrentRow.Cells[0].Value);
                publicacionControl.ObtenerPorId("Publicacion", id, "idPublicacion");
            }
        }
    }
}
