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

        }

    }
}
