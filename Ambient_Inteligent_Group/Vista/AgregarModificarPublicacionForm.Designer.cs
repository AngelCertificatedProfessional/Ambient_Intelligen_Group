using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ambient_Inteligent_Group.Vista
{
    partial class AgregarModificarPublicacionForm : InterfaceComunicador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private PublicacionControl publicacionControl;
        private int tablaDetector = 0;
        private List<Persona> perLis;
        private int idPublicacion;
        private List<Object> listaColaboradorPublicacion;
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
            this.advertenciaPaginaLbl = new System.Windows.Forms.Label();
            this.advertenciaLinkLbl = new System.Windows.Forms.Label();
            this.paginaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.advertenciaAnioLbl = new System.Windows.Forms.Label();
            this.linkTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.advertenciaNombreLbl = new System.Windows.Forms.Label();
            this.anioTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.instruccionesLbl = new System.Windows.Forms.Label();
            this.agregarModLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.tablaListaPerDt = new System.Windows.Forms.DataGridView();
            this.tablaCataPerDt = new System.Windows.Forms.DataGridView();
            this.personaTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaListaPerDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCataPerDt)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 542);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage1.Controls.Add(this.advertenciaPaginaLbl);
            this.tabPage1.Controls.Add(this.advertenciaLinkLbl);
            this.tabPage1.Controls.Add(this.paginaTxt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tipoCb);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.advertenciaAnioLbl);
            this.tabPage1.Controls.Add(this.linkTxt);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.advertenciaNombreLbl);
            this.tabPage1.Controls.Add(this.anioTxt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.nombreTxt);
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
            // advertenciaPaginaLbl
            // 
            this.advertenciaPaginaLbl.AutoSize = true;
            this.advertenciaPaginaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaPaginaLbl.ForeColor = System.Drawing.Color.Maroon;
            this.advertenciaPaginaLbl.Location = new System.Drawing.Point(124, 349);
            this.advertenciaPaginaLbl.Name = "advertenciaPaginaLbl";
            this.advertenciaPaginaLbl.Size = new System.Drawing.Size(110, 15);
            this.advertenciaPaginaLbl.TabIndex = 45;
            this.advertenciaPaginaLbl.Text = "Campo Obligatorio";
            this.advertenciaPaginaLbl.Visible = false;
            // 
            // advertenciaLinkLbl
            // 
            this.advertenciaLinkLbl.AutoSize = true;
            this.advertenciaLinkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaLinkLbl.ForeColor = System.Drawing.Color.Maroon;
            this.advertenciaLinkLbl.Location = new System.Drawing.Point(124, 284);
            this.advertenciaLinkLbl.Name = "advertenciaLinkLbl";
            this.advertenciaLinkLbl.Size = new System.Drawing.Size(110, 15);
            this.advertenciaLinkLbl.TabIndex = 44;
            this.advertenciaLinkLbl.Text = "Campo Obligatorio";
            this.advertenciaLinkLbl.Visible = false;
            // 
            // paginaTxt
            // 
            this.paginaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginaTxt.Location = new System.Drawing.Point(127, 317);
            this.paginaTxt.Name = "paginaTxt";
            this.paginaTxt.Size = new System.Drawing.Size(349, 29);
            this.paginaTxt.TabIndex = 43;
            this.paginaTxt.Enter += new System.EventHandler(this.paginaTxt_Enter);
            this.paginaTxt.Leave += new System.EventHandler(this.paginaTxt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "Pagina*:";
            // 
            // tipoCb
            // 
            this.tipoCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoCb.FormattingEnabled = true;
            this.tipoCb.Location = new System.Drawing.Point(127, 374);
            this.tipoCb.Name = "tipoCb";
            this.tipoCb.Size = new System.Drawing.Size(349, 26);
            this.tipoCb.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tipo*: ";
            // 
            // advertenciaAnioLbl
            // 
            this.advertenciaAnioLbl.AutoSize = true;
            this.advertenciaAnioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaAnioLbl.ForeColor = System.Drawing.Color.Maroon;
            this.advertenciaAnioLbl.Location = new System.Drawing.Point(124, 215);
            this.advertenciaAnioLbl.Name = "advertenciaAnioLbl";
            this.advertenciaAnioLbl.Size = new System.Drawing.Size(110, 15);
            this.advertenciaAnioLbl.TabIndex = 37;
            this.advertenciaAnioLbl.Text = "Campo Obligatorio";
            this.advertenciaAnioLbl.Visible = false;
            // 
            // linkTxt
            // 
            this.linkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTxt.Location = new System.Drawing.Point(127, 252);
            this.linkTxt.Name = "linkTxt";
            this.linkTxt.Size = new System.Drawing.Size(349, 29);
            this.linkTxt.TabIndex = 36;
            this.linkTxt.Enter += new System.EventHandler(this.linkTxt_Enter);
            this.linkTxt.Leave += new System.EventHandler(this.linkTxt_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 24);
            this.label10.TabIndex = 35;
            this.label10.Text = "Link*:";
            // 
            // advertenciaNombreLbl
            // 
            this.advertenciaNombreLbl.AutoSize = true;
            this.advertenciaNombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaNombreLbl.ForeColor = System.Drawing.Color.Maroon;
            this.advertenciaNombreLbl.Location = new System.Drawing.Point(124, 157);
            this.advertenciaNombreLbl.Name = "advertenciaNombreLbl";
            this.advertenciaNombreLbl.Size = new System.Drawing.Size(110, 15);
            this.advertenciaNombreLbl.TabIndex = 34;
            this.advertenciaNombreLbl.Text = "Campo Obligatorio";
            this.advertenciaNombreLbl.Visible = false;
            // 
            // anioTxt
            // 
            this.anioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioTxt.Location = new System.Drawing.Point(127, 183);
            this.anioTxt.Name = "anioTxt";
            this.anioTxt.Size = new System.Drawing.Size(349, 29);
            this.anioTxt.TabIndex = 33;
            this.anioTxt.Enter += new System.EventHandler(this.anioTxt_Enter);
            this.anioTxt.Leave += new System.EventHandler(this.anioTxt_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Año*:";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTxt.Location = new System.Drawing.Point(127, 125);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(349, 29);
            this.nombreTxt.TabIndex = 32;
            this.nombreTxt.Enter += new System.EventHandler(this.nombreTxt_Enter);
            this.nombreTxt.Leave += new System.EventHandler(this.nombreTxt_Leave);
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
            this.agregarModLbl.Size = new System.Drawing.Size(305, 37);
            this.agregarModLbl.TabIndex = 28;
            this.agregarModLbl.Text = "Agregar Publicacion";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.eliminarBtn);
            this.tabPage2.Controls.Add(this.agregarBtn);
            this.tabPage2.Controls.Add(this.tablaListaPerDt);
            this.tabPage2.Controls.Add(this.tablaCataPerDt);
            this.tabPage2.Controls.Add(this.personaTxt);
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
            this.tabPage2.Text = "Persona";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(490, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "Lista de Personas Asociadas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Catalogo Persona";
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
            // tablaListaPerDt
            // 
            this.tablaListaPerDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaListaPerDt.Location = new System.Drawing.Point(470, 179);
            this.tablaListaPerDt.Name = "tablaListaPerDt";
            this.tablaListaPerDt.Size = new System.Drawing.Size(360, 264);
            this.tablaListaPerDt.TabIndex = 39;
            // 
            // tablaCataPerDt
            // 
            this.tablaCataPerDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCataPerDt.Location = new System.Drawing.Point(13, 179);
            this.tablaCataPerDt.Name = "tablaCataPerDt";
            this.tablaCataPerDt.Size = new System.Drawing.Size(357, 264);
            this.tablaCataPerDt.TabIndex = 38;
            // 
            // personaTxt
            // 
            this.personaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personaTxt.Location = new System.Drawing.Point(138, 100);
            this.personaTxt.Name = "personaTxt";
            this.personaTxt.Size = new System.Drawing.Size(275, 29);
            this.personaTxt.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Seleccione las personas asociadas a la publicacion";
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
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
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
            this.label1.Size = new System.Drawing.Size(357, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Personas asociafas a la publicacion";
            // 
            // AgregarModificarPublicacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 538);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "AgregarModificarPublicacionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarModificarPublicacionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarModificarPublicacionForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaListaPerDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCataPerDt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox tipoCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label advertenciaAnioLbl;
        private System.Windows.Forms.TextBox linkTxt;
        private System.Windows.Forms.Label advertenciaNombreLbl;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label instruccionesLbl;
        private System.Windows.Forms.Label agregarModLbl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.DataGridView tablaListaPerDt;
        private System.Windows.Forms.DataGridView tablaCataPerDt;
        private System.Windows.Forms.TextBox personaTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label label1;



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
            switch (tablaDetector)
            {
                case 0:
                    if (info.Count > 0)
                    {
                        perLis = new List<Persona>();
                        for (int i = 0; i < info.Count; i++)
                        {
                            perLis.Add((Persona)info[i]);
                        }
                        tablaCataPerDt.DataSource = perLis;
                        tablaCataPerDt.AutoResizeColumns();
                        VisibilidadOpciones(true);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 1:
                    listaColaboradorPublicacion = info;
                    break;
                case 2:
                    if (listaColaboradorPublicacion.Count > 0)
                    {
                        List<Persona> secPerLis = new List<Persona>();
                        CrearTabla();
                        for (int i = 0; i < info.Count; i++)
                        {
                            secPerLis.Add((Persona)info[i]);
                        }
                        for (int i = 0; i < listaColaboradorPublicacion.Count; i++)
                        {
                            for (int k = 0; k < secPerLis.Count; k++)
                            {
                                if (secPerLis[k].IdPersona == (int)listaColaboradorPublicacion[i])
                                {
                                    String[] row = new String[] { secPerLis[k].IdPersona + "", secPerLis[k].NombreCompleto+" "+secPerLis[k].ApellidoPaterno};
                                    tablaListaPerDt.Rows.Add(row);
                                }
                            }
                        }
                        tablaListaPerDt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; ;
                    }
                    break;
            }
        }

        public void setInfo(List<Object> info)
        {

        }

        public void setLista(List<Object> info, int i)
        {
        }

        private Label advertenciaPaginaLbl;
        private Label advertenciaLinkLbl;
        private TextBox paginaTxt;
        private Label label3;
        private Label label10;
        private TextBox anioTxt;
        private Label label5;
    }
}