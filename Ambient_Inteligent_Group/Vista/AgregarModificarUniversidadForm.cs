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
    public partial class AgregarModificarUniversidadForm : Form
    {

        private InterfaceComunicador comunicador;

        public AgregarModificarUniversidadForm(InterfaceComunicador comunicador)
        {
            InitializeComponent();
            this.comunicador = comunicador;
            controlUniversidad = new UniversidadControl(this, typeof(Universidad));
            guardarBtn.Text = "Guardar";
            agregarModLbl.Text = "Agregar Universidad";
            controlUniversidad.BuscarTodos("Universidad");
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            comunicador.setMensaje("Cerrar");
        }

        private void AgregarModificarUniversidadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            comunicador.setMensaje("Cerrar");
        }

        private void nombreTxt_Enter(object sender, EventArgs e)
        {
            advertenciaNombreLbl.Visible = false;
            
        }

        private void nombreTxt_Leave(object sender, EventArgs e)
        {
            if (nombreTxt.Text == "")
            {
                advertenciaNombreLbl.Visible = true;
                advertenciaNombreLbl.Text = "Campo Obligatorio";
            }
            else {
                for (int x = 0; x < uniLis.Count; x++) { 
                    if(uniLis[x].NombreUniversidad==nombreTxt.Text){
                        if (uniLis[x].IdUniversidad == idUniversidad)
                        {
                            return;
                        }
                        else {
                            advertenciaNombreLbl.Text = "El nombre ya existe";
                            advertenciaNombreLbl.Visible = true;
                            return;
                        }
                    }
                }
            }
        }

        private void abreviacionTxt_Enter(object sender, EventArgs e)
        {
            advertenciaAbreLbl.Visible = false;   
        }

        private void abreviacionTxt_Leave(object sender, EventArgs e)
        {
            if (abreviacionTxt.Text == "")
            {
                advertenciaAbreLbl.Visible = true;
                advertenciaNombreLbl.Text = "Campo Obligatorio";
            }
            else
            {
                for (int x = 0; x < uniLis.Count; x++)
                {
                    if (uniLis[x].GetAbreviacion() == abreviacionTxt.Text)
                    {
                        if (uniLis[x].IdUniversidad == idUniversidad)
                        {
                            return;
                        }
                        else
                        {
                            advertenciaAbreLbl.Text = "La abreviacion ya existe";
                            advertenciaAbreLbl.Visible = true;
                            return;
                        }
                    }
                }
            }
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (Validacion() == false) {
                if (guardarBtn.Text == "Guardar")
                {
                    List<Object> listaUniversidad = new List<Object>();
                    listaUniversidad.Add(nombreTxt.Text);
                    listaUniversidad.Add(abreviacionTxt.Text);
                    controlUniversidad.GuardarUniversidad(HelpetEntidad.ContruccionUniversidad(listaUniversidad, "Guardar"));
                }
                else
                {
                    List<Object> listaUniversidad = new List<Object>();
                    listaUniversidad.Add(idUniversidad);
                    listaUniversidad.Add(nombreTxt.Text);
                    listaUniversidad.Add(abreviacionTxt.Text);
                    controlUniversidad.ModificarUniversidad(HelpetEntidad.ContruccionUniversidad(listaUniversidad, "Modificar"));
                }
            }
            
        }

        private Boolean Validacion()
        {
            if (nombreTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir el nombre de la Univeridad", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (abreviacionTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir la abreviacion de la Universidad", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else {
                for (int x = 0; x < uniLis.Count; x++)
                {
                    if (uniLis[x].GetAbreviacion() == abreviacionTxt.Text)
                    {
                        if (uniLis[x].IdUniversidad != idUniversidad)
                        {
                            MessageBox.Show("La abreviatura ya existe", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                    else if (uniLis[x].NombreUniversidad == nombreTxt.Text)
                    {
                        if (uniLis[x].IdUniversidad != idUniversidad)
                        {
                            MessageBox.Show("El nombre de la universidad ya existe", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public void ObtenerInfo(List<Object> listaUniversidad)
        {
            idUniversidad = (int)listaUniversidad[0];
            nombreTxt.Text = (String)listaUniversidad[1];
            abreviacionTxt.Text = (String)listaUniversidad[2];
            guardarBtn.Text = "Modificar";
            agregarModLbl.Text = "Modificar Universidad";
        }
    }
}
