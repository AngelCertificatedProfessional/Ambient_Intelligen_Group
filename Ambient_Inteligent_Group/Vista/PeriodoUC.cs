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
    public partial class PeriodoUC : UserControl
    {
        public PeriodoUC()
        {
            InitializeComponent();
            periodoControl = new PeriodoControl(this, typeof(Periodo));
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if(periodoTB.Text == ""){
                periodoControl.BuscarTodos("Periodo");
            }else{
                periodoControl.BuscarPeriodo(periodoTB.Text,"Periodo");
            }
            
        }

        private void VisibilidadOpciones(Boolean visibilidad)
        {
            modificarBtn.Enabled = visibilidad;
            eliminarBtn.Enabled = visibilidad;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (tablaPeriodo.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar el periodo Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(tablaPeriodo.CurrentRow.Cells[0].Value);
                    periodoControl.Eliminar("Periodo", id, "idPeriodo");
                }
            }
            else
            {
                MessageBox.Show("debe de seleccionar una fila");
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            AgregarModificarPeriodoForm agreMod =
                new AgregarModificarPeriodoForm(this);
            agreMod.Visible = true;
            this.Enabled = false;
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (tablaPeriodo.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaPeriodo.CurrentRow.Cells[0].Value);
                System.Console.Write(id);
                periodoControl.ObtenerPorId("Periodo", id, "idPeriodo");
            } 
        }

    }
}
