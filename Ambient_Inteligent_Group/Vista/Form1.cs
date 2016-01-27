
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambient_Inteligent_Group
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializadorUC();
        }

        private void sedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibilidadPaneles(false);
            sedeUC.Visible = true;
        }

        private void universidadMI_Click(object sender, EventArgs e)
        {
            VisibilidadPaneles(false);
            universidadUC.Visible = true;
        }

        private void VisibilidadPaneles(Boolean visibilidad) {
            sedeUC.Visible = visibilidad;
            universidadUC.Visible = visibilidad;
            areaUC.Visible = visibilidad;
            periodoUC.Visible = visibilidad;
            tipo_SocioUC.Visible = visibilidad;
            escolaridadUC.Visible = visibilidad;
            programaEduUC.Visible = visibilidad;
            asociacionUC.Visible = visibilidad;
            platicaUC.Visible = visibilidad;
            personaUC.Visible = visibilidad;
        }

        private void areaMI_Click(object sender, EventArgs e)
        {
            VisibilidadPaneles(false);
            areaUC.Visible = true;
        }

        private void periodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibilidadPaneles(false);
            periodoUC.Visible = true;
        }

        private void socioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibilidadPaneles(false);
            tipo_SocioUC.Visible = true;
        }

        private void escolaridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibilidadPaneles(false);
            escolaridadUC.Visible = true;
        }

        private void programaEducativoMI_Click(object sender, EventArgs e)
        {
            VisibilidadPaneles(false);
            programaEduUC.Visible = true;
        }

        private void asociacionMI_Click(object sender, EventArgs e)
        {
            VisibilidadPaneles(false);
            asociacionUC.Visible = true;
        }

        private void platicasInvitadasMI_Click(object sender, EventArgs e)
        {
            VisibilidadPaneles(false);
            platicaUC.Visible = true;
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibilidadPaneles(false);
            personaUC.Visible = true;
        }

    }
}
