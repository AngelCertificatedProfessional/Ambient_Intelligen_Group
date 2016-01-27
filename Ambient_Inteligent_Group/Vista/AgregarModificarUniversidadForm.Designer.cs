using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Ambient_Inteligent_Group.Vista
{
    partial class AgregarModificarUniversidadForm : InterfaceComunicador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private UniversidadControl controlUniversidad;
        private int idUniversidad;
        List<Universidad> uniLis;
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
            this.agregarModLbl = new System.Windows.Forms.Label();
            this.instruccionesLbl = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.abreviacionLbl = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.abreviacionTxt = new System.Windows.Forms.TextBox();
            this.advertenciaNombreLbl = new System.Windows.Forms.Label();
            this.advertenciaAbreLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // agregarModLbl
            // 
            this.agregarModLbl.AutoSize = true;
            this.agregarModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarModLbl.Location = new System.Drawing.Point(12, 27);
            this.agregarModLbl.Name = "agregarModLbl";
            this.agregarModLbl.Size = new System.Drawing.Size(309, 37);
            this.agregarModLbl.TabIndex = 0;
            this.agregarModLbl.Text = "Agregar Universidad";
            // 
            // instruccionesLbl
            // 
            this.instruccionesLbl.AutoSize = true;
            this.instruccionesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruccionesLbl.Location = new System.Drawing.Point(19, 82);
            this.instruccionesLbl.Name = "instruccionesLbl";
            this.instruccionesLbl.Size = new System.Drawing.Size(165, 15);
            this.instruccionesLbl.TabIndex = 1;
            this.instruccionesLbl.Text = "Llene los campos solicitados";
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.Location = new System.Drawing.Point(22, 137);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(96, 24);
            this.nombreLbl.TabIndex = 11;
            this.nombreLbl.Text = "Nombre: *";
            // 
            // abreviacionLbl
            // 
            this.abreviacionLbl.AutoSize = true;
            this.abreviacionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abreviacionLbl.Location = new System.Drawing.Point(22, 202);
            this.abreviacionLbl.Name = "abreviacionLbl";
            this.abreviacionLbl.Size = new System.Drawing.Size(122, 24);
            this.abreviacionLbl.TabIndex = 12;
            this.abreviacionLbl.Text = "Abreviacion*:";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.Location = new System.Drawing.Point(587, 364);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(112, 43);
            this.cancelarBtn.TabIndex = 13;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBtn.Location = new System.Drawing.Point(722, 364);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(112, 43);
            this.guardarBtn.TabIndex = 14;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // nombreTxt
            // 
            this.nombreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTxt.Location = new System.Drawing.Point(143, 134);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(252, 29);
            this.nombreTxt.TabIndex = 15;
            this.nombreTxt.Enter += new System.EventHandler(this.nombreTxt_Enter);
            this.nombreTxt.Leave += new System.EventHandler(this.nombreTxt_Leave);
            // 
            // abreviacionTxt
            // 
            this.abreviacionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abreviacionTxt.Location = new System.Drawing.Point(143, 199);
            this.abreviacionTxt.Name = "abreviacionTxt";
            this.abreviacionTxt.Size = new System.Drawing.Size(252, 29);
            this.abreviacionTxt.TabIndex = 16;
            this.abreviacionTxt.Enter += new System.EventHandler(this.abreviacionTxt_Enter);
            this.abreviacionTxt.Leave += new System.EventHandler(this.abreviacionTxt_Leave);
            // 
            // advertenciaNombreLbl
            // 
            this.advertenciaNombreLbl.AutoSize = true;
            this.advertenciaNombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaNombreLbl.ForeColor = System.Drawing.Color.Maroon;
            this.advertenciaNombreLbl.Location = new System.Drawing.Point(140, 166);
            this.advertenciaNombreLbl.Name = "advertenciaNombreLbl";
            this.advertenciaNombreLbl.Size = new System.Drawing.Size(110, 15);
            this.advertenciaNombreLbl.TabIndex = 17;
            this.advertenciaNombreLbl.Text = "Campo Obligatorio";
            this.advertenciaNombreLbl.Visible = false;
            // 
            // advertenciaAbreLbl
            // 
            this.advertenciaAbreLbl.AutoSize = true;
            this.advertenciaAbreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaAbreLbl.ForeColor = System.Drawing.Color.Maroon;
            this.advertenciaAbreLbl.Location = new System.Drawing.Point(140, 231);
            this.advertenciaAbreLbl.Name = "advertenciaAbreLbl";
            this.advertenciaAbreLbl.Size = new System.Drawing.Size(110, 15);
            this.advertenciaAbreLbl.TabIndex = 18;
            this.advertenciaAbreLbl.Text = "Campo Obligatorio";
            this.advertenciaAbreLbl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.advertenciaAbreLbl);
            this.panel1.Controls.Add(this.advertenciaNombreLbl);
            this.panel1.Controls.Add(this.abreviacionTxt);
            this.panel1.Controls.Add(this.nombreTxt);
            this.panel1.Controls.Add(this.guardarBtn);
            this.panel1.Controls.Add(this.cancelarBtn);
            this.panel1.Controls.Add(this.abreviacionLbl);
            this.panel1.Controls.Add(this.nombreLbl);
            this.panel1.Controls.Add(this.instruccionesLbl);
            this.panel1.Controls.Add(this.agregarModLbl);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 417);
            this.panel1.TabIndex = 0;
            // 
            // AgregarModificarUniversidadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 419);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AgregarModificarUniversidadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarModificarUniversidad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarModificarUniversidadForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

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
            }

        }

        public void setInfo(List<Object> info)
        {

        }

        public void setLista(List<Object> info, int i)
        {

        }



        #endregion

        private Label agregarModLbl;
        private Label instruccionesLbl;
        private Label nombreLbl;
        private Label abreviacionLbl;
        private Button cancelarBtn;
        private Button guardarBtn;
        private TextBox nombreTxt;
        private TextBox abreviacionTxt;
        private Label advertenciaNombreLbl;
        private Label advertenciaAbreLbl;
        private Panel panel1;

    }
}