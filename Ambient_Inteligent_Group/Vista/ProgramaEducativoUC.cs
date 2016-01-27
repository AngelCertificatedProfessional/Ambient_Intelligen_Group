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
    public partial class ProgramaEducativoUC : UserControl
    {
        public ProgramaEducativoUC()
        {
            InitializeComponent();
            programaEducativoControl = new ProgramaEducativoControl(this,typeof(ProgramaEducativo));
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (nombreProgramaTxt.Text == "")
            {
                programaEducativoControl.BuscarTodos("Programa_Educativo");
            }
            else
            {
                programaEducativoControl.BuscarDescripcion(nombreProgramaTxt.Text, "Programa_Educativo");
            }
        }

        private void VisibilidadOpciones(Boolean visibilidad)
        {
            modificarBtn.Enabled = visibilidad;
            eliminarBtn.Enabled = visibilidad;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (tablaProgramaEdu.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Esta Seguro que desea eliminarel programa educativo Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(tablaProgramaEdu.CurrentRow.Cells[0].Value);
                    programaEducativoControl.Eliminar("Programa_Educativo", id, "idPrograma_Educativo");
                }
            }
            else
            {
                MessageBox.Show("debe de seleccionar una fila");
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            AgregarModificarProgramaEducativoForm agreMod =
                new AgregarModificarProgramaEducativoForm(this);
            agreMod.Visible = true;
            this.Enabled = false;
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (tablaProgramaEdu.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaProgramaEdu.CurrentRow.Cells[0].Value);
                programaEducativoControl.ObtenerPorId("Programa_Educativo", id, "idPrograma_Educativo");
            } 
        }
    }
}
