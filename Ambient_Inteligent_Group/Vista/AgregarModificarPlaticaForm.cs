using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambient_Inteligent_Group.Vista
{
    public partial class AgregarModificarPlaticaForm : Form
    {
        private InterfaceComunicador comunicador;
        public AgregarModificarPlaticaForm(InterfaceComunicador comunicador)
        {
            InitializeComponent();
            this.comunicador = comunicador;
            platicaControl = new PlaticaControl(this, typeof(Platica));
            guardarBtn.Text = "Guardar";
            agregarModLbl.Text = "Agregar Platica";
            platicaControl.BuscarTodos("Platica");
            platicaControl.BuscarSedes("Sede",1);
            
        }
        public void ObtenerInfo(List<Object> listaPlatica)
        {
            idPlatica = (int)listaPlatica[0];
            fechaDt.Value = (DateTime)listaPlatica[1];
            nombrePlaticaTxt.Text = (String)listaPlatica[2];
            sedeCb.SelectedValue = (int)listaPlatica[3];
            nombreEventoTxt.Text = (String)listaPlatica[4];
            abreviacionEventoTxt.Text = (String)listaPlatica[5];

            guardarBtn.Text = "Modificar";
            agregarModLbl.Text = "Modificar Platica";
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (Validacion() == false)
            {
                if (guardarBtn.Text == "Guardar")
                {
                    List<Object> listaPlatica = new List<Object>();
                    listaPlatica.Add(fechaDt.Value.Date);
                    listaPlatica.Add(nombrePlaticaTxt.Text);
                    listaPlatica.Add(sedeCb.SelectedValue);
                    listaPlatica.Add(nombreEventoTxt.Text);
                    listaPlatica.Add(abreviacionEventoTxt.Text);
                    platicaControl.GuardarPlatica(HelpetEntidad.ContruccionPlatica(listaPlatica, "Guardar"));
                }
                else
                {
                    List<Object> listaPlatica = new List<Object>();
                    listaPlatica.Add(idPlatica);
                    listaPlatica.Add(fechaDt.Value.Date);
                    listaPlatica.Add(nombrePlaticaTxt.Text);
                    listaPlatica.Add(sedeCb.SelectedValue);
                    listaPlatica.Add(nombreEventoTxt.Text);
                    listaPlatica.Add(abreviacionEventoTxt.Text);
                    platicaControl.ModificarPlatica(HelpetEntidad.ContruccionPlatica(listaPlatica, "Modificar"));
                }
            }
        }

        private void AgregarModificarPlaticaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            comunicador.setMensaje("Cerrar");
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            comunicador.setMensaje("Cerrar");
            this.Close();
        }

        private void nombrePlaticaTxt_Enter(object sender, EventArgs e)
        {
            advertenciaNombreLbl.Visible = false;
        }

        private void nombrePlaticaTxt_Leave(object sender, EventArgs e)
        {
            if (nombrePlaticaTxt.Text == "")
            {
                advertenciaNombreLbl.Visible = true;
                advertenciaNombreLbl.Text = "Campo Obligatorio";
            }
        }

        private Boolean Validacion()
        {
            if (nombrePlaticaTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir el nombre de la escolaridad", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

    }
}
