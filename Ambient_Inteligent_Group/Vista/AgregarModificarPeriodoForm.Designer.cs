using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Ambient_Inteligent_Group.Vista
{
    partial class AgregarModificarPeriodoForm : InterfaceComunicador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int idPeriodo;
        private List<Periodo> periodoLis = new List<Periodo>();
        private PeriodoControl periodoControl;
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
            this.advertenciaPeriodoLbl = new System.Windows.Forms.Label();
            this.periodoTxt = new System.Windows.Forms.TextBox();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.periodoLbl = new System.Windows.Forms.Label();
            this.instruccionesLbl = new System.Windows.Forms.Label();
            this.agregarModLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // advertenciaPeriodoLbl
            // 
            this.advertenciaPeriodoLbl.AutoSize = true;
            this.advertenciaPeriodoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaPeriodoLbl.ForeColor = System.Drawing.Color.Maroon;
            this.advertenciaPeriodoLbl.Location = new System.Drawing.Point(124, 162);
            this.advertenciaPeriodoLbl.Name = "advertenciaPeriodoLbl";
            this.advertenciaPeriodoLbl.Size = new System.Drawing.Size(110, 15);
            this.advertenciaPeriodoLbl.TabIndex = 24;
            this.advertenciaPeriodoLbl.Text = "Campo Obligatorio";
            this.advertenciaPeriodoLbl.Visible = false;
            // 
            // periodoTxt
            // 
            this.periodoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodoTxt.Location = new System.Drawing.Point(124, 126);
            this.periodoTxt.Name = "periodoTxt";
            this.periodoTxt.Size = new System.Drawing.Size(252, 29);
            this.periodoTxt.TabIndex = 23;
            this.periodoTxt.Enter += new System.EventHandler(this.periodoTxt_Enter);
            this.periodoTxt.Leave += new System.EventHandler(this.periodoTxt_Leave);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBtn.Location = new System.Drawing.Point(722, 356);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(112, 43);
            this.guardarBtn.TabIndex = 22;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.Location = new System.Drawing.Point(587, 356);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(112, 43);
            this.cancelarBtn.TabIndex = 21;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // periodoLbl
            // 
            this.periodoLbl.AutoSize = true;
            this.periodoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodoLbl.Location = new System.Drawing.Point(22, 129);
            this.periodoLbl.Name = "periodoLbl";
            this.periodoLbl.Size = new System.Drawing.Size(93, 24);
            this.periodoLbl.TabIndex = 20;
            this.periodoLbl.Text = "Periodo: *";
            // 
            // instruccionesLbl
            // 
            this.instruccionesLbl.AutoSize = true;
            this.instruccionesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruccionesLbl.Location = new System.Drawing.Point(19, 74);
            this.instruccionesLbl.Name = "instruccionesLbl";
            this.instruccionesLbl.Size = new System.Drawing.Size(165, 15);
            this.instruccionesLbl.TabIndex = 19;
            this.instruccionesLbl.Text = "Llene los campos solicitados";
            // 
            // agregarModLbl
            // 
            this.agregarModLbl.AutoSize = true;
            this.agregarModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarModLbl.Location = new System.Drawing.Point(12, 19);
            this.agregarModLbl.Name = "agregarModLbl";
            this.agregarModLbl.Size = new System.Drawing.Size(251, 37);
            this.agregarModLbl.TabIndex = 18;
            this.agregarModLbl.Text = "Agregar Periodo";
            // 
            // AgregarModificarPeriodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(846, 419);
            this.Controls.Add(this.advertenciaPeriodoLbl);
            this.Controls.Add(this.periodoTxt);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.periodoLbl);
            this.Controls.Add(this.instruccionesLbl);
            this.Controls.Add(this.agregarModLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AgregarModificarPeriodoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarModificarPeriodoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarModificarPeriodoForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label advertenciaPeriodoLbl;
        private System.Windows.Forms.TextBox periodoTxt;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label periodoLbl;
        private System.Windows.Forms.Label instruccionesLbl;
        private System.Windows.Forms.Label agregarModLbl;

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
                periodoLis = new List<Periodo>();
                for (int i = 0; i < info.Count; i++)
                {
                    periodoLis.Add((Periodo)info[i]);
                }
            }
        }

        public void setInfo(List<Object> info)
        {

        }

        public void setLista(List<Object> info, int i)
        {

        }


    }
}