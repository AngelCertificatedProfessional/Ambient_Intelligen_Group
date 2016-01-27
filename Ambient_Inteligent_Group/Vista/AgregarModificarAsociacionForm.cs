using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambient_Inteligent_Group.Vista
{
    public partial class AgregarModificarAsociacionForm : Form
    {
        InterfaceComunicador comunicador;
        public AgregarModificarAsociacionForm(InterfaceComunicador comunicador)
        {
            InitializeComponent();
            this.comunicador = comunicador;
            asociacionControl = new AsociacionControl(this, typeof(Asociacion));
            guardarBtn.Text = "Guardar";
            agregarModLbl.Text = "Agregar asociacion";
            asociacionControl.BuscarTodos("Asociacion");
            pinturaPb.SizeMode = PictureBoxSizeMode.StretchImage;
            pinturaPb.BorderStyle = BorderStyle.Fixed3D;
        }

        public void ObtenerInfo(List<Object> listaAso)
        {
            idAsociacion = (int) listaAso[0];
            nombreTxt.Text = (String)listaAso[1];
            linkTxt.Text = (String)listaAso[2];
            if (listaAso[3] != null) {
                MemoryStream ms = new MemoryStream((byte[])listaAso[3]);
                pinturaPb.Image = Image.FromStream(ms);
                pinturaPb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            guardarBtn.Text = "Modificar";
            agregarModLbl.Text = "Modificar Asociacion";
        }

        private void AgregarModificarAsociacionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            comunicador.setMensaje("Cerrar");
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            comunicador.setMensaje("Cerrar");
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (Validacion() == false)
            {
                MemoryStream ms = new MemoryStream();
                pinturaPb.Image.Save(ms,pinturaPb.Image.RawFormat);
                if (guardarBtn.Text == "Guardar")
                {
                    List<Object> listaAsociacion = new List<Object>();
                    listaAsociacion.Add(nombreTxt.Text);
                    listaAsociacion.Add(linkTxt.Text);
                    listaAsociacion.Add(ms);
                    asociacionControl.GuardarAsociacion(HelpetEntidad.ContruccionAsociacion(listaAsociacion, "Guardar"));
                }
                else
                {
                    List<Object> listaAsociacion = new List<Object>();
                    listaAsociacion.Add(idAsociacion);
                    listaAsociacion.Add(nombreTxt.Text);
                    listaAsociacion.Add(linkTxt.Text);
                    listaAsociacion.Add(ms);
                    asociacionControl.ModificarAsociacion(HelpetEntidad.ContruccionAsociacion(listaAsociacion, "Modificar"));
                }
            } 
        }

        private Boolean Validacion()
        {
            if (nombreTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir el nombre del area", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                for (int x = 0; x < asoLis.Count; x++)
                {
                    if (asoLis[x].Descripcion == nombreTxt.Text)
                    {
                        if (asoLis[x].IdAsociacion != idAsociacion)
                        {
                            MessageBox.Show("La asociacion ya existe", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void nombreTxt_Enter(object sender, EventArgs e)
        {

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
                for (int x = 0; x < asoLis.Count; x++)
                {
                    if (asoLis[x].Descripcion == nombreTxt.Text)
                    {
                        if (asoLis[x].IdAsociacion == idAsociacion)
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

        private void buscarBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog figura = new OpenFileDialog();
                figura.InitialDirectory = "C:/Picture/";
                figura.Filter = "All Files|*.*|JPEGs|*.jpg|BitMaps|*.bmp";
                figura.FilterIndex = 2;
                if (figura.ShowDialog() == DialogResult.OK)
                {
                    pinturaPb.Image = Image.FromFile(figura.FileName);
                    pinturaPb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pinturaPb.BorderStyle = BorderStyle.Fixed3D;
                }
            }
            catch (Exception exception)
            {
                System.Console.Write(exception);
            }
        }


    }
}
