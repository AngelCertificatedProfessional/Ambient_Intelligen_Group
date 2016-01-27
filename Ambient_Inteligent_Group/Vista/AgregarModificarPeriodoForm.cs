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
    public partial class AgregarModificarPeriodoForm : Form
    {
        private InterfaceComunicador comunicador;
        public AgregarModificarPeriodoForm(InterfaceComunicador comunicador)
        {
            InitializeComponent();
            this.comunicador = comunicador;
            periodoControl = new PeriodoControl(this, typeof(Area));
            guardarBtn.Text = "Guardar";
            agregarModLbl.Text = "Agregar Periodo";
            periodoControl.BuscarTodos("Periodo");
        }
        public void ObtenerInfo(List<Object> listaPeriodo)
        {
            idPeriodo = (int)listaPeriodo[0];
            periodoTxt.Text = (String)listaPeriodo[1];
            guardarBtn.Text = "Modificar";
            agregarModLbl.Text = "Modificar Area";
        }
        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (Validacion() == false)
            {
                if (guardarBtn.Text == "Guardar")
                {
                    List<Object> listaPeriodo = new List<Object>();
                    listaPeriodo.Add(periodoTxt.Text);
                    periodoControl.GuardarPeriodo(HelpetEntidad.ContruccionPeriodo(listaPeriodo, "Guardar"));
                }
                else
                {
                    List<Object> listaPeriodo = new List<Object>();
                    listaPeriodo.Add(idPeriodo);
                    listaPeriodo.Add(periodoTxt.Text);
                    periodoControl.ModificarPeriodo(HelpetEntidad.ContruccionPeriodo(listaPeriodo, "Modificar"));
                }
            }
        }

        private void periodoTxt_Enter(object sender, EventArgs e)
        {
            advertenciaPeriodoLbl.Visible = false;
        }

        private void periodoTxt_Leave(object sender, EventArgs e)
        {
            if (periodoTxt.Text == "")
            {
                advertenciaPeriodoLbl.Visible = true;
                advertenciaPeriodoLbl.Text = "Campo Obligatorio";
            }
            else
            {
                for (int x = 0; x < periodoLis.Count; x++)
                {
                    if (periodoLis[x].Anio == periodoTxt.Text)
                    {
                        if (periodoLis[x].IdPeriodo == idPeriodo)
                        {
                            return;
                        }
                        else
                        {
                            advertenciaPeriodoLbl.Text = "El periodo ya existe";
                            advertenciaPeriodoLbl.Visible = true;
                            return;
                        }
                    }
                }
            }
        }

        private Boolean Validacion()
        {
            if (periodoTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir el nombre del periodo", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                for (int x = 0; x < periodoLis.Count; x++)
                {
                    if (periodoLis[x].Anio == periodoTxt.Text)
                    {
                        if (periodoLis[x].IdPeriodo != idPeriodo)
                        {
                            MessageBox.Show("El periodo ya existe", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void AgregarModificarPeriodoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            comunicador.setMensaje("Cerrar");
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            comunicador.setMensaje("Cerrar");
        }

    }
}
