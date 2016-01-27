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
    public partial class AgregarModificarAreaForm : Form
    {
        private InterfaceComunicador comunicador;

        public AgregarModificarAreaForm(InterfaceComunicador comunicador)
        {
            InitializeComponent();
            this.comunicador = comunicador;
            areaControl = new AreaControl(this, typeof(Area));
            guardarBtn.Text = "Guardar";
            agregarModLbl.Text = "Agregar Area";
            areaControl.BuscarTodos("Area");
        }
        public void ObtenerInfo(List<Object> listaArea)
        {
            idArea = (int)listaArea[0];
            nombreTxt.Text = (String)listaArea[1];
            guardarBtn.Text = "Modificar";
            agregarModLbl.Text = "Modificar Area";
        }

        private Boolean Validacion()
        {
            if (nombreTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir el nombre del area", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            } else
            {
                for (int x = 0; x < areaLis.Count; x++)
                {
                    if (areaLis[x].Descripcion == nombreTxt.Text)
                    {
                        if (areaLis[x].IdArea != idArea)
                        {
                            MessageBox.Show("El area ya existe", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void AgregarModificarAreaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            comunicador.setMensaje("Cerrar");
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
            else
            {
                for (int x = 0; x < areaLis.Count; x++)
                {
                    if (areaLis[x].Descripcion == nombreTxt.Text)
                    {
                        if (areaLis[x].IdArea == idArea)
                        {
                            return;
                        }
                        else
                        {
                            advertenciaNombreLbl.Text = "El nombre ya existe";
                            advertenciaNombreLbl.Visible = true;
                            return;
                        }
                    }
                }
            }
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (Validacion() == false)
            {
                if (guardarBtn.Text == "Guardar")
                {
                    List<Object> listaArea = new List<Object>();
                    listaArea.Add(nombreTxt.Text);
                    areaControl.GuardarArea(HelpetEntidad.ContruccionArea(listaArea, "Guardar"));
                }
                else
                {
                    List<Object> listaArea = new List<Object>();
                    listaArea.Add(idArea);
                    listaArea.Add(nombreTxt.Text);
                    areaControl.ModificarArea(HelpetEntidad.ContruccionArea(listaArea, "Modificar"));
                }
            }
        }

    }
}
