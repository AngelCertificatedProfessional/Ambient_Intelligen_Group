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
    public partial class AgregarModificarPublicacionForm : Form
    {
        private InterfaceComunicador comunicador;

        public AgregarModificarPublicacionForm(InterfaceComunicador comunicador)
        {
            InitializeComponent();
            this.comunicador = comunicador;
            publicacionControl = new PublicacionControl(this, typeof(Publicacion));
            guardarBtn.Text = "Guardar";
            agregarModLbl.Text = "Agregar Publicacion";
            tipoCb.Items.Add("Conferencia");
            tipoCb.Items.Add("Articulo");
            tipoCb.DropDownStyle = ComboBoxStyle.DropDownList;
            tipoCb.SelectedIndex = 0;
            tablaListaPerDt.AutoResizeColumns();
            

        }

        public void ObtenerInfo(List<Object> listaPublicacion)
        {
            idPublicacion = (int)listaPublicacion[0];
            nombreTxt.Text = (String)listaPublicacion[1];
            if ((int)listaPublicacion[2] == 1)
            {
                tipoCb.SelectedValue = 0;
            }
            else {
                tipoCb.SelectedIndex = 1;
            }
            anioTxt.Text = (String)listaPublicacion[3];
            linkTxt.Text  = (String)listaPublicacion[4];
            paginaTxt.Text = (String)listaPublicacion[5];

            guardarBtn.Text = "Modificar";
            agregarModLbl.Text = "Modificar Publicacion";
            tablaDetector++;
            publicacionControl.ObtenerPorIdLis("Colaborador_Publicacion", idPublicacion, "Publicacion_idPublicacion");
            tablaDetector++;
            publicacionControl.BuscarTodos("Persona");
            tablaDetector = 0;

        }


        private void CrearTabla()
        {
            tablaListaPerDt.ColumnCount = 2;
            tablaListaPerDt.Columns[0].Name = "IdUni";
            tablaListaPerDt.Columns[1].Name = "Universidad";
            tablaListaPerDt.AutoResizeColumns();
        }

        private void VisibilidadOpciones(Boolean visibilidad)
        {
            agregarBtn.Enabled = visibilidad;
            eliminarBtn.Enabled = visibilidad;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            comunicador.setMensaje("Cerrar");
            this.Close();
        }

        private void AgregarModificarPublicacionForm_FormClosing(object sender, FormClosingEventArgs e)
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
            }
        }

        private void anioTxt_Enter(object sender, EventArgs e)
        {
            advertenciaAnioLbl.Visible = false;
        }

        private void anioTxt_Leave(object sender, EventArgs e)
        {
            if (anioTxt.Text == "")
            {
                advertenciaAnioLbl.Visible = true;
            }
        }

        private void linkTxt_Enter(object sender, EventArgs e)
        {
            advertenciaLinkLbl.Visible = false;
        }

        private void linkTxt_Leave(object sender, EventArgs e)
        {
            if (linkTxt.Text == "")
            {
                advertenciaLinkLbl.Visible = true;
            }
        }

        private void paginaTxt_Enter(object sender, EventArgs e)
        {
            advertenciaPaginaLbl.Visible = false;
        }

        private void paginaTxt_Leave(object sender, EventArgs e)
        {
            if (paginaTxt.Text == "")
            {
                advertenciaPaginaLbl.Visible = true;
            }
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (personaTxt.Text == "")
            {
                publicacionControl.BuscarTodos("Persona");
            }
            else {
                publicacionControl.BuscarPersona(personaTxt.Text, "Persona");
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            Boolean bandera = false;
            int id = Convert.ToInt32(tablaCataPerDt.CurrentRow.Cells[0].Value);
            for (int i = 0; i < tablaListaPerDt.RowCount - 1; i++)
            {
                if (Convert.ToInt32(tablaListaPerDt.Rows[i].Cells[0].Value) == id)
                {
                    return;
                }
            }

            if (tablaListaPerDt.RowCount == 0)
            {
                CrearTabla();
            }
            if (bandera == false)
            {
                for (int i = 0; i < perLis.Count(); i++)
                {
                    if (perLis[i].IdPersona == id)
                    {
                        String[] row = new String[] { perLis[i].IdPersona + "", perLis[i].NombreCompleto +" " + perLis[i].ApellidoPaterno };
                        tablaListaPerDt.Rows.Add(row);
                    }
                }
            }
            tablaListaPerDt.AutoResizeColumns();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablaListaPerDt.CurrentRow.Cells[0].Value != null)
                {
                    tablaListaPerDt.Rows.RemoveAt(tablaListaPerDt.SelectedRows[0].Index);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (Validacion() == false)
            {
                List<int> listaPersona = new List<int>();
                if (guardarBtn.Text == "Guardar")
                {
                    List<Object> listaPublicacion = new List<Object>();
                    listaPublicacion.Add(nombreTxt.Text);
                    if (tipoCb.Text == "Conferencia")
                    {
                        listaPublicacion.Add(1);
                    }
                    else {
                        listaPublicacion.Add(2);
                    }
                    listaPublicacion.Add(anioTxt.Text);
                    listaPublicacion.Add(linkTxt.Text);
                    listaPublicacion.Add(paginaTxt.Text);

                    if (tablaListaPerDt.RowCount > 1)
                    {
                        for (int i = 0; i < tablaListaPerDt.RowCount - 1; i++)
                        {
                            listaPersona.Add(Convert.ToInt32(tablaListaPerDt.Rows[i].Cells[0].Value));
                        }
                    }
                    publicacionControl.GuardarPublicacion(HelpetEntidad.ContruccionPublicacion(listaPublicacion, "Guardar"), listaPersona);
                }
                else
                {
                    List<Object> listaPublicacion = new List<Object>();
                    listaPublicacion.Add(idPublicacion);
                    listaPublicacion.Add(nombreTxt.Text);
                    if (tipoCb.Text == "Conferencia")
                    {
                        listaPublicacion.Add(1);
                    }
                    else {
                        listaPublicacion.Add(2);
                    }
                    listaPublicacion.Add(anioTxt.Text);
                    listaPublicacion.Add(linkTxt.Text);
                    listaPublicacion.Add(paginaTxt.Text);

                    if (tablaListaPerDt.RowCount > 1)
                    {
                        for (int i = 0; i < tablaListaPerDt.RowCount - 1; i++)
                        {
                            listaPersona.Add(Convert.ToInt32(tablaListaPerDt.Rows[i].Cells[0].Value));
                        }
                    }
                    publicacionControl.ModificarPublicacion(HelpetEntidad.ContruccionPublicacion(listaPublicacion, "Modificar"), listaPersona);
                }
            }
        }

        private Boolean Validacion()
        {
            if (nombreTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir el nombre de la publicacion", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (linkTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir el link de la publicacion", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (anioTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir el año de la publicacion", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (linkTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir la pagina de la publicacion", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}
