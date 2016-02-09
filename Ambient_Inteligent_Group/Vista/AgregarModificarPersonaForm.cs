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
    public partial class AgregarModificarPersonaForm : Form
    {
        InterfaceComunicador comunicador;
        public AgregarModificarPersonaForm(InterfaceComunicador comunicador)
        {
            InitializeComponent();
            this.comunicador = comunicador;
            personaControl = new PersonaControl(this, typeof(Persona));
            guardarBtn.Text = "Guardar";
            agregarModLbl.Text = "Agregar Persona";
            personaControl.BuscarEscolaridad("Escolaridad", 1); 

            tablaListaUniDt.AutoResizeColumns();
            
        }

        public void ObtenerInfo(List<Object> listaPersona)
        {
            
            idPersona = (int)listaPersona[0];
            nombreTxt.Text = (String) listaPersona[1];
            apellidoPaternoTxt.Text = (String)listaPersona[2];
            apellidoMaternoTxt.Text = (String)listaPersona[3];
            if (listaPersona[4] != null)
            {
                escolaridadCb.SelectedValue = (int)listaPersona[4];
            }
            else {
                escolaridadCb.SelectedValue = 0;
            }

            if ((char)listaPersona[5]=='H') {
                hombreRb.Checked = true;
            }
            else{
                mujerRb.Checked = true;
            }

            guardarBtn.Text = "Modificar";
            agregarModLbl.Text = "Modificar Persona";
            tablaDetector++;
            personaControl.ObtenerPorIdLis("Socio_Universidad", idPersona, "Persona_id");
            tablaDetector++;
            personaControl.BuscarTodos("Universidad");
            tablaDetector = 0;

        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            Boolean bandera = false;
            int id = Convert.ToInt32(tablaCataUniDt.CurrentRow.Cells[0].Value);
            for (int i = 0; i < tablaListaUniDt.RowCount-1; i++)
            {
                if (Convert.ToInt32(tablaListaUniDt.Rows[i].Cells[0].Value) == id)
                {
                    return;
                }
            }

            if (tablaListaUniDt.RowCount == 0) {
                CrearTabla();
            }
            if (bandera == false) {
                for (int i = 0; i < uniLis.Count(); i++)
                {
                    if (uniLis[i].IdUniversidad == id)
                    {
                        String[] row = new String[] { uniLis[i].IdUniversidad + "", uniLis[i].NombreUniversidad };
                        tablaListaUniDt.Rows.Add(row);
                    }
                }
            }
            tablaListaUniDt.AutoResizeColumns();
        }

        private void CrearTabla() {
            tablaListaUniDt.ColumnCount = 2;
            tablaListaUniDt.Columns[0].Name = "IdUni";
            tablaListaUniDt.Columns[1].Name = "Universidad";
            tablaListaUniDt.AutoResizeColumns();
        }


        private void nombreTxt_Enter(object sender, EventArgs e)
        {
            advertenciaNombreLbl.Visible = false;
        }

        private void nombreTxt_Leave(object sender, EventArgs e)
        {
            if (nombreTxt.Text == "") {
                advertenciaNombreLbl.Visible = true;
            }
            
        }


        private void apellidoPaternoTxt_Enter(object sender, EventArgs e)
        {
            advertenciaApellidoPLbl.Visible = false;
        }

        private void apellidoPaternoTxt_Leave(object sender, EventArgs e)
        {
            if (apellidoPaternoTxt.Text == "")
            {
                advertenciaApellidoPLbl.Visible = true;
            }
        }

        private void AgregarModificarPersonaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            comunicador.setMensaje("Cerrar");
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            comunicador.setMensaje("Cerrar");
            this.Close();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (universidadTxt.Text == "")
            {
                personaControl.BuscarTodos("Universidad");
            }
            else {
                personaControl.BuscarUniversidad(universidadTxt.Text,"Universidad");
            }
        }

        private void VisibilidadOpciones(Boolean visibilidad){
            agregarBtn.Enabled = visibilidad;
            eliminarBtn.Enabled = visibilidad;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            try {
                if (tablaListaUniDt.CurrentRow.Cells[0].Value != null) {
                    tablaListaUniDt.Rows.RemoveAt(tablaListaUniDt.SelectedRows[0].Index);
                }
            }
            catch (Exception exc) {
                Console.WriteLine(exc);
            }
            
            
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (Validacion() == false)
            {
                List<int> listaUniversidad = new List<int>();
                if (guardarBtn.Text == "Guardar")
                {
                    List<Object> listaPersona = new List<Object>();
                    listaPersona.Add(nombreTxt.Text);
                    listaPersona.Add(apellidoPaternoTxt.Text);
                    listaPersona.Add(apellidoMaternoTxt.Text);
                    listaPersona.Add(escolaridadCb.SelectedValue);
                    if (hombreRb.Checked == true)
                    {
                        listaPersona.Add('H');
                    }
                    else {
                        listaPersona.Add('M');
                    }

                    if (tablaListaUniDt.RowCount>1) {
                        for (int i=0;i<tablaListaUniDt.RowCount-1;i++) {
                            listaUniversidad.Add(Convert.ToInt32(tablaListaUniDt.Rows[i].Cells[0].Value));
                        }
                    }
                    personaControl.GuardarPersona(HelpetEntidad.ContruccionPersona(listaPersona, "Guardar"),listaUniversidad);
                }
                else
                {
                    List<Object> listaPersona = new List<Object>();
                    listaPersona.Add(idPersona);
                    listaPersona.Add(nombreTxt.Text);
                    listaPersona.Add(apellidoPaternoTxt.Text);
                    listaPersona.Add(apellidoMaternoTxt.Text);
                    listaPersona.Add(escolaridadCb.SelectedValue);
                    if (hombreRb.Checked == true)
                    {
                        listaPersona.Add('H');
                    }
                    else {
                        listaPersona.Add('M');
                    }
                    if (tablaListaUniDt.RowCount > 0)
                    {
                        for (int i = 0; i < tablaListaUniDt.RowCount - 1; i++)
                        {
                            listaUniversidad.Add(Convert.ToInt32(tablaListaUniDt.Rows[i].Cells[0].Value));
                        }
                    }
                    personaControl.ModificarPersona(HelpetEntidad.ContruccionPersona(listaPersona, "Modificar"), listaUniversidad);
                }
            }
        }

        private Boolean Validacion()
        {
            if (nombreTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir el nombre de la persona", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            } else if (apellidoPaternoTxt.Text == "")
            {
                MessageBox.Show("Se debe escribir el Apellido Paterno de la persona", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (hombreRb.Checked == false && mujerRb.Checked == false)
            {
                MessageBox.Show("Se debe seleccionar un sexo de la persona", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}
