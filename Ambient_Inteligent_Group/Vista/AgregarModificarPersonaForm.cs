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
        public void ObtenerInfo(List<Object> listaPlatica)
        {
            /*
            idPlatica = (int)listaPlatica[0];
            fechaDt.Value = (DateTime)listaPlatica[1];
            nombrePlaticaTxt.Text = (String)listaPlatica[2];
            sedeCb.SelectedValue = (int)listaPlatica[3];
            nombreEventoTxt.Text = (String)listaPlatica[4];
            abreviacionEventoTxt.Text = (String)listaPlatica[5];

            guardarBtn.Text = "Modificar";
            agregarModLbl.Text = "Modificar Platica";*/
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
            List<Universidad> uniLisTemporal = new List<Universidad>();
            try {
                if (tablaListaUniDt.CurrentRow.Cells[0].Value != null) {
                    tablaListaUniDt.Rows.RemoveAt(tablaListaUniDt.SelectedRows[0].Index);
                }
            }
            catch (Exception exc) {
                Console.WriteLine(exc);
            }
            
            
        }


    }
}
