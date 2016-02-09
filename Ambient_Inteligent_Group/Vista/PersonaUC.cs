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
    public partial class PersonaUC : UserControl
    {
        public PersonaUC()
        {
            InitializeComponent();
            personaControl = new PersonaControl(this, typeof(Persona));
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (personaTxt.Text == "")
            {
                personaControl.BuscarTodos("Persona");
            }
            else
            {
                personaControl.BuscarNombre(personaTxt.Text, "Persona");
            }
        }

        private void VisibilidadOpciones(Boolean visibilidad)
        {
            modificarBtn.Enabled = visibilidad;
            eliminarBtn.Enabled = visibilidad;
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            AgregarModificarPersonaForm agreMod =
               new AgregarModificarPersonaForm(this);
            agreMod.Visible = true;
            this.Enabled = false;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (tablaPersona.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar la persona?", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(tablaPersona.CurrentRow.Cells[0].Value);
                    personaControl.Eliminar("Socio_Universidad", id, "Persona_id");
                    contMen++;
                    personaControl.Eliminar("Persona", id, "idpersona");
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
            if (tablaPersona.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(tablaPersona.CurrentRow.Cells[0].Value);
                personaControl.ObtenerPorId("Persona", id, "idPersona");
            }
        }
    }
}
