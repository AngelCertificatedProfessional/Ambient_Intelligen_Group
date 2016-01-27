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
    public partial class AgregarModificarTipoSocioForm : Form
    {
        private InterfaceComunicador comunicador;
        public AgregarModificarTipoSocioForm(InterfaceComunicador comunicador)
        {
            InitializeComponent();
            this.comunicador = comunicador;
            tipoSocioControl = new Tipo_SocioControl(this, typeof(Tipo_Socio));
            guardarBtn.Text = "Guardar";
            agregarModLbl.Text = "Agregar Tipo Socio";
            tipoSocioControl.BuscarTodos("Tipo_Socio");
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            comunicador.setMensaje("Cerrar");
        }

        public void ObtenerInfo(List<Object> listaSocio)
        {
            idTipo_Socio = (int)listaSocio[0];
            tipo_SocioTxt.Text = (String)listaSocio[1];
            guardarBtn.Text = "Modificar";
            agregarModLbl.Text = "Modificar Tipo Socio";
        }

        private Boolean Validacion()
        {
            if (tipo_SocioTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir el tipo de Socio", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                for (int x = 0; x < tipo_SocioLis.Count; x++)
                {
                    if (tipo_SocioLis[x].Descripcion == tipo_SocioTxt.Text)
                    {
                        if (tipo_SocioLis[x].IdTipo_Socio != idTipo_Socio)
                        {
                            MessageBox.Show("El tipo de socio ya existe", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private void tipo_SocioTxt_Enter(object sender, EventArgs e)
        {
            advertenciaTipoLbl.Visible = false;
        }

        private void tipo_SocioTxt_Leave(object sender, EventArgs e)
        {
            if (tipo_SocioTxt.Text == "")
            {
                advertenciaTipoLbl.Visible = true;
                advertenciaTipoLbl.Text = "Campo Obligatorio";
            }
            else
            {
                for (int x = 0; x < tipo_SocioLis.Count; x++)
                {
                    if (tipo_SocioLis[x].Descripcion == tipo_SocioTxt.Text)
                    {
                        if (tipo_SocioLis[x].IdTipo_Socio == idTipo_Socio)
                        {
                            return;
                        }
                        else
                        {
                            advertenciaTipoLbl.Text = "El tio ya existe";
                            advertenciaTipoLbl.Visible = true;
                            return;
                        }
                    }
                }
            }
        }

        private void AgregarModificarTipoSocioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            comunicador.setMensaje("Cerrar");
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (Validacion() == false)
            {
                if (guardarBtn.Text == "Guardar")
                {
                    List<Object> listatipo_Socio = new List<Object>();
                    listatipo_Socio.Add(tipo_SocioTxt.Text);
                    tipoSocioControl.GuardarTipo_Socio(HelpetEntidad.ContruccionTipo_Socio(listatipo_Socio, "Guardar"));
                }
                else
                {
                    List<Object> listaArea = new List<Object>();
                    listaArea.Add(idTipo_Socio);
                    listaArea.Add(tipo_SocioTxt.Text);
                    tipoSocioControl.ModificarTipo_Socio(HelpetEntidad.ContruccionTipo_Socio(listaArea, "Modificar"));
                }
            }
        }
    }
}
