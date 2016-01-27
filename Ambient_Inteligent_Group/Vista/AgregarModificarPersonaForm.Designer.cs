using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Ambient_Inteligent_Group.Vista
{
    partial class AgregarModificarPersonaForm :InterfaceComunicador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int idPersona;
        List<Universidad> uniLis;
        private PersonaControl personaControl;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mujerRb = new System.Windows.Forms.RadioButton();
            this.hombreRb = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.escolaridadCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.advertenciaApellidoPLbl = new System.Windows.Forms.Label();
            this.apellidoMaternoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.advertenciaNombreLbl = new System.Windows.Forms.Label();
            this.apellidoPaternoTxt = new System.Windows.Forms.TextBox();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.abreviacionLbl = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.instruccionesLbl = new System.Windows.Forms.Label();
            this.agregarModLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.tablaListaUniDt = new System.Windows.Forms.DataGridView();
            this.tablaCataUniDt = new System.Windows.Forms.DataGridView();
            this.universidadTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaListaUniDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCataUniDt)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 542);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage1.Controls.Add(this.mujerRb);
            this.tabPage1.Controls.Add(this.hombreRb);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.escolaridadCb);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.advertenciaApellidoPLbl);
            this.tabPage1.Controls.Add(this.apellidoMaternoTxt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.advertenciaNombreLbl);
            this.tabPage1.Controls.Add(this.apellidoPaternoTxt);
            this.tabPage1.Controls.Add(this.nombreTxt);
            this.tabPage1.Controls.Add(this.abreviacionLbl);
            this.tabPage1.Controls.Add(this.nombreLbl);
            this.tabPage1.Controls.Add(this.instruccionesLbl);
            this.tabPage1.Controls.Add(this.agregarModLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // mujerRb
            // 
            this.mujerRb.AutoSize = true;
            this.mujerRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mujerRb.Location = new System.Drawing.Point(322, 380);
            this.mujerRb.Name = "mujerRb";
            this.mujerRb.Size = new System.Drawing.Size(66, 24);
            this.mujerRb.TabIndex = 44;
            this.mujerRb.TabStop = true;
            this.mujerRb.Text = "Mujer";
            this.mujerRb.UseVisualStyleBackColor = true;
            // 
            // hombreRb
            // 
            this.hombreRb.AutoSize = true;
            this.hombreRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hombreRb.Location = new System.Drawing.Point(192, 380);
            this.hombreRb.Name = "hombreRb";
            this.hombreRb.Size = new System.Drawing.Size(84, 24);
            this.hombreRb.TabIndex = 43;
            this.hombreRb.TabStop = true;
            this.hombreRb.Text = "Hombre";
            this.hombreRb.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Sexo: *";
            // 
            // escolaridadCb
            // 
            this.escolaridadCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolaridadCb.FormattingEnabled = true;
            this.escolaridadCb.Location = new System.Drawing.Point(192, 312);
            this.escolaridadCb.Name = "escolaridadCb";
            this.escolaridadCb.Size = new System.Drawing.Size(349, 26);
            this.escolaridadCb.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Escolaridad: ";
            // 
            // advertenciaApellidoPLbl
            // 
            this.advertenciaApellidoPLbl.AutoSize = true;
            this.advertenciaApellidoPLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaApellidoPLbl.ForeColor = System.Drawing.Color.Maroon;
            this.advertenciaApellidoPLbl.Location = new System.Drawing.Point(192, 219);
            this.advertenciaApellidoPLbl.Name = "advertenciaApellidoPLbl";
            this.advertenciaApellidoPLbl.Size = new System.Drawing.Size(110, 15);
            this.advertenciaApellidoPLbl.TabIndex = 37;
            this.advertenciaApellidoPLbl.Text = "Campo Obligatorio";
            this.advertenciaApellidoPLbl.Visible = false;
            // 
            // apellidoMaternoTxt
            // 
            this.apellidoMaternoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoMaternoTxt.Location = new System.Drawing.Point(192, 250);
            this.apellidoMaternoTxt.Name = "apellidoMaternoTxt";
            this.apellidoMaternoTxt.Size = new System.Drawing.Size(349, 29);
            this.apellidoMaternoTxt.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Apellido Materno:";
            // 
            // advertenciaNombreLbl
            // 
            this.advertenciaNombreLbl.AutoSize = true;
            this.advertenciaNombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaNombreLbl.ForeColor = System.Drawing.Color.Maroon;
            this.advertenciaNombreLbl.Location = new System.Drawing.Point(189, 152);
            this.advertenciaNombreLbl.Name = "advertenciaNombreLbl";
            this.advertenciaNombreLbl.Size = new System.Drawing.Size(110, 15);
            this.advertenciaNombreLbl.TabIndex = 34;
            this.advertenciaNombreLbl.Text = "Campo Obligatorio";
            this.advertenciaNombreLbl.Visible = false;
            // 
            // apellidoPaternoTxt
            // 
            this.apellidoPaternoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoPaternoTxt.Location = new System.Drawing.Point(192, 187);
            this.apellidoPaternoTxt.Name = "apellidoPaternoTxt";
            this.apellidoPaternoTxt.Size = new System.Drawing.Size(349, 29);
            this.apellidoPaternoTxt.TabIndex = 33;
            this.apellidoPaternoTxt.Enter += new System.EventHandler(this.apellidoPaternoTxt_Enter);
            this.apellidoPaternoTxt.Leave += new System.EventHandler(this.apellidoPaternoTxt_Leave);
            // 
            // nombreTxt
            // 
            this.nombreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTxt.Location = new System.Drawing.Point(192, 120);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(349, 29);
            this.nombreTxt.TabIndex = 32;
            this.nombreTxt.Enter += new System.EventHandler(this.nombreTxt_Enter);
            this.nombreTxt.Leave += new System.EventHandler(this.nombreTxt_Leave);
            // 
            // abreviacionLbl
            // 
            this.abreviacionLbl.AutoSize = true;
            this.abreviacionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abreviacionLbl.Location = new System.Drawing.Point(25, 190);
            this.abreviacionLbl.Name = "abreviacionLbl";
            this.abreviacionLbl.Size = new System.Drawing.Size(161, 24);
            this.abreviacionLbl.TabIndex = 31;
            this.abreviacionLbl.Text = "Apellido Paterno*:";
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.Location = new System.Drawing.Point(25, 125);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(96, 24);
            this.nombreLbl.TabIndex = 30;
            this.nombreLbl.Text = "Nombre: *";
            // 
            // instruccionesLbl
            // 
            this.instruccionesLbl.AutoSize = true;
            this.instruccionesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruccionesLbl.Location = new System.Drawing.Point(22, 70);
            this.instruccionesLbl.Name = "instruccionesLbl";
            this.instruccionesLbl.Size = new System.Drawing.Size(165, 15);
            this.instruccionesLbl.TabIndex = 29;
            this.instruccionesLbl.Text = "Llene los campos solicitados";
            // 
            // agregarModLbl
            // 
            this.agregarModLbl.AutoSize = true;
            this.agregarModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarModLbl.Location = new System.Drawing.Point(15, 15);
            this.agregarModLbl.Name = "agregarModLbl";
            this.agregarModLbl.Size = new System.Drawing.Size(260, 37);
            this.agregarModLbl.TabIndex = 28;
            this.agregarModLbl.Text = "Agregar Persona";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.eliminarBtn);
            this.tabPage2.Controls.Add(this.agregarBtn);
            this.tabPage2.Controls.Add(this.tablaListaUniDt);
            this.tabPage2.Controls.Add(this.tablaCataUniDt);
            this.tabPage2.Controls.Add(this.universidadTxt);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.buscarBtn);
            this.tabPage2.Controls.Add(this.guardarBtn);
            this.tabPage2.Controls.Add(this.cancelarBtn);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Universidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(490, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "Lista de Universidades asistidas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Catalogo Universidad";
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(382, 343);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 53);
            this.eliminarBtn.TabIndex = 41;
            this.eliminarBtn.Text = "<";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(382, 219);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(75, 53);
            this.agregarBtn.TabIndex = 40;
            this.agregarBtn.Text = ">";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // tablaListaUniDt
            // 
            this.tablaListaUniDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaListaUniDt.Location = new System.Drawing.Point(470, 179);
            this.tablaListaUniDt.Name = "tablaListaUniDt";
            this.tablaListaUniDt.Size = new System.Drawing.Size(360, 264);
            this.tablaListaUniDt.TabIndex = 39;
            // 
            // tablaCataUniDt
            // 
            this.tablaCataUniDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCataUniDt.Location = new System.Drawing.Point(13, 179);
            this.tablaCataUniDt.Name = "tablaCataUniDt";
            this.tablaCataUniDt.Size = new System.Drawing.Size(357, 264);
            this.tablaCataUniDt.TabIndex = 38;
            // 
            // universidadTxt
            // 
            this.universidadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.universidadTxt.Location = new System.Drawing.Point(138, 100);
            this.universidadTxt.Name = "universidadTxt";
            this.universidadTxt.Size = new System.Drawing.Size(275, 29);
            this.universidadTxt.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Seleccione las universidades de la persona";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Nombre:";
            // 
            // buscarBtn
            // 
            this.buscarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarBtn.Location = new System.Drawing.Point(509, 100);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(170, 29);
            this.buscarBtn.TabIndex = 34;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBtn.Location = new System.Drawing.Point(722, 454);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(112, 43);
            this.guardarBtn.TabIndex = 24;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.Location = new System.Drawing.Point(587, 454);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(112, 43);
            this.cancelarBtn.TabIndex = 23;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Universidades de la persona";
            // 
            // AgregarModificarPersonaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(850, 534);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AgregarModificarPersonaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarModificarPersonaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarModificarPersonaForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaListaUniDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCataUniDt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /**
         * Metodo para mostrar un mensaje al usuario, por ejemplo, un mensaje de
         * exito o de error.
         * 
         * @param mensaje Mensaje que se mostrara al usuario.
         */
        public void setMensaje(String mensaje)
        {
            MessageBox.Show(mensaje, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            comunicador.setMensaje("Cerrar");
        }

        /***
         * Metodo para mostrar la informacion obtenida en una tabla de la interfaz
         * grafica.
         * 
         * @param info Informacion que se asignara a la tabla
         */
        public void setTabla(List<Object> info)
        {
            if (info.Count > 0)
            {
                uniLis = new List<Universidad>();
                for (int i = 0; i < info.Count; i++)
                {
                    uniLis.Add((Universidad)info[i]);
                }
                tablaCataUniDt.DataSource = uniLis;
                tablaCataUniDt.AutoResizeColumns();
                VisibilidadOpciones(true);
            }
            else
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void setInfo(List<Object> info)
        {

        }

        public void setLista(List<Object> info, int i)
        {
            switch (i)
            {
                case 1:
                    List<Escolaridad> escoLis = new List<Escolaridad>();
                    for (int k = 0; k < info.Count; k++)
                    {
                        escoLis.Add((Escolaridad)info[k]);
                    }
                    escolaridadCb.DataSource = escoLis;
                    escolaridadCb.DisplayMember = "Descripcion";
                    escolaridadCb.ValueMember = "IdEscolaridad";
                    escolaridadCb.DropDownStyle = ComboBoxStyle.DropDownList;
                    break;
            }
        }

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label advertenciaNombreLbl;
        private TextBox apellidoPaternoTxt;
        private TextBox nombreTxt;
        private Label abreviacionLbl;
        private Label nombreLbl;
        private Label instruccionesLbl;
        private Label agregarModLbl;
        private TabPage tabPage2;
        private Button buscarBtn;
        private Button guardarBtn;
        private Button cancelarBtn;
        private Label label1;
        private Label advertenciaApellidoPLbl;
        private TextBox apellidoMaternoTxt;
        private Label label2;
        private RadioButton mujerRb;
        private RadioButton hombreRb;
        private Label label5;
        private ComboBox escolaridadCb;
        private Label label4;
        private Label label9;
        private Label label8;
        private Button eliminarBtn;
        private Button agregarBtn;
        private DataGridView tablaListaUniDt;
        private DataGridView tablaCataUniDt;
        private TextBox universidadTxt;
        private Label label7;
        private Label label6;
    
    
    
    
    }
}