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
    public partial class AgregarModificarProgramaEducativoForm : Form
    {
        private InterfaceComunicador comunicador;
        public AgregarModificarProgramaEducativoForm(InterfaceComunicador comunicador)
        {
            InitializeComponent();
            this.comunicador = comunicador;
            programaEduControl = new ProgramaEducativoControl(this, typeof(ProgramaEducativo));
            guardarBtn.Text = "Guardar";
            agregarModLbl.Text = "Agregar Programa Educativo";
            programaEduControl.BuscarTodos("Programa_Educativo");
        }
        public void ObtenerInfo(List<Object> listaArea)
        {
            idProgramaEducativo = (int)listaArea[0];
            programaEduTxt.Text = (String)listaArea[1];
            guardarBtn.Text = "Modificar";
            agregarModLbl.Text = "Modificar Programa Educativo";
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            comunicador.setMensaje("Cerrar");
            this.Close();
        }

        private void AgregarModificarProgramaEducativoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            comunicador.setMensaje("Cerrar");
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (Validacion() == false)
            {
                if (guardarBtn.Text == "Guardar")
                {
                    List<Object> listaPrograma = new List<Object>();
                    listaPrograma.Add(programaEduTxt.Text);
                    programaEduControl.GuardarPrograma(HelpetEntidad.ContruccionProgramaEducativo(listaPrograma, "Guardar"));
                }
                else
                {
                    List<Object> listaPrograma = new List<Object>();
                    listaPrograma.Add(idProgramaEducativo);
                    listaPrograma.Add(programaEduTxt.Text);
                    programaEduControl.ModificarPrograma(HelpetEntidad.ContruccionProgramaEducativo(listaPrograma, "Modificar"));
                }
            }
        }

        private Boolean Validacion()
        {
            if (programaEduTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir el nombre del programa educativo", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                for (int x = 0; x < programaEduLis.Count; x++)
                {
                    if (programaEduLis[x].Descripcion == programaEduTxt.Text)
                    {
                        if (programaEduLis[x].IdPrograma_Educativo != idProgramaEducativo)
                        {
                            MessageBox.Show("El programa ya existe", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void programaEduTxt_Enter(object sender, EventArgs e)
        {
            advertenciaProgramaLbl.Visible = false;
        }

        private void programaEduTxt_Leave(object sender, EventArgs e)
        {
            if (programaEduTxt.Text == "")
            {
                advertenciaProgramaLbl.Visible = true;
                advertenciaProgramaLbl.Text = "Campo Obligatorio";
            }
            else
            {
                for (int x = 0; x < programaEduLis.Count; x++)
                {
                    if (programaEduLis[x].Descripcion == programaEduTxt.Text)
                    {
                        if (programaEduLis[x].IdPrograma_Educativo == idProgramaEducativo)
                        {
                            return;
                        }
                        else
                        {
                            advertenciaProgramaLbl.Text = "El programa ya existe";
                            advertenciaProgramaLbl.Visible = true;
                            return;
                        }
                    }
                }
            }
        }


    }
}
