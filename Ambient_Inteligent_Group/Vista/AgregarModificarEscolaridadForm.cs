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
    public partial class AgregarModificarEscolaridadForm : Form
    {
        InterfaceComunicador comunicador;
        public AgregarModificarEscolaridadForm(InterfaceComunicador comunicador)
        {
            InitializeComponent();
            this.comunicador = comunicador;
            escolaridadControl = new EscolaridadControl(this, typeof(Escolaridad));
            guardarBtn.Text = "Guardar";
            agregarModLbl.Text = "Agregar Escolaridad";
            escolaridadControl.BuscarTodos("Escolaridad");
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            comunicador.setMensaje("Cerrar");
        }

        private void AgregarModificarEscolaridadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            comunicador.setMensaje("Cerrar");
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (Validacion() == false)
            {
                if (guardarBtn.Text == "Guardar")
                {
                    List<Object> listaEscolaridad = new List<Object>();
                    listaEscolaridad.Add(escolaridaTxt.Text);
                    escolaridadControl.GuardarEscolaridad(HelpetEntidad.ContruccionEscolaridad(listaEscolaridad, "Guardar"));
                }
                else
                {
                    List<Object> listaEscolaridad = new List<Object>();
                    listaEscolaridad.Add(idEscolaridad);
                    listaEscolaridad.Add(escolaridaTxt.Text);
                    escolaridadControl.ModificarEscolaridad(HelpetEntidad.ContruccionEscolaridad(listaEscolaridad, "Modificar"));
                }
            }
        }

        private Boolean Validacion()
        {
            if (escolaridaTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir el nombre de la escolaridad", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                for (int x = 0; x < escLis.Count; x++)
                {
                    if (escLis[x].Descripcion == escolaridaTxt.Text)
                    {
                        if (escLis[x].IdEscolaridad != idEscolaridad)
                        {
                            MessageBox.Show("La escolaridad ya existe", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public void ObtenerInfo(List<Object> listaEscolaridad)
        {
            idEscolaridad = (int)listaEscolaridad[0];
            escolaridaTxt.Text = (String)listaEscolaridad[1];
            guardarBtn.Text = "Modificar";
            agregarModLbl.Text = "Modificar Escolaridad";
        }


        private void escolaridadTxt_Enter(object sender, EventArgs e)
        {
            advertenciaEscolaridadLbl.Visible = false;
        }

        private void escolaridadTxt_Leave(object sender, EventArgs e)
        {
            if (escolaridaTxt.Text == "")
            {
                advertenciaEscolaridadLbl.Visible = true;
                advertenciaEscolaridadLbl.Text = "Campo Obligatorio";
            }
            else
            {
                for (int x = 0; x < escLis.Count; x++)
                {
                    if (escLis[x].Descripcion == escolaridaTxt.Text)
                    {
                        if (escLis[x].IdEscolaridad == idEscolaridad)
                        {
                            return;
                        }
                        else
                        {
                            advertenciaEscolaridadLbl.Text = "La escolaridad ya existe";
                            advertenciaEscolaridadLbl.Visible = true;
                            return;
                        }
                    }
                }
            }
        }

    }
}
