using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Ambient_Inteligent_Group.Vista
{
    partial class AgregarModificarAreaForm : InterfaceComunicador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private AreaControl areaControl;
        private int idArea;
        private List<Area> areaLis;
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
            this.advertenciaNombreLbl = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.instruccionesLbl = new System.Windows.Forms.Label();
            this.agregarModLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // advertenciaNombreLbl
            // 
            this.advertenciaNombreLbl.AutoSize = true;
            this.advertenciaNombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaNombreLbl.ForeColor = System.Drawing.Color.Maroon;
            this.advertenciaNombreLbl.Location = new System.Drawing.Point(124, 162);
            this.advertenciaNombreLbl.Name = "advertenciaNombreLbl";
            this.advertenciaNombreLbl.Size = new System.Drawing.Size(110, 15);
            this.advertenciaNombreLbl.TabIndex = 17;
            this.advertenciaNombreLbl.Text = "Campo Obligatorio";
            this.advertenciaNombreLbl.Visible = false;
            // 
            // nombreTxt
            // 
            this.nombreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTxt.Location = new System.Drawing.Point(124, 126);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(252, 29);
            this.nombreTxt.TabIndex = 16;
            this.nombreTxt.Enter += new System.EventHandler(this.nombreTxt_Enter);
            this.nombreTxt.Leave += new System.EventHandler(this.nombreTxt_Leave);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBtn.Location = new System.Drawing.Point(722, 356);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(112, 43);
            this.guardarBtn.TabIndex = 15;
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
            this.cancelarBtn.TabIndex = 14;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.Location = new System.Drawing.Point(22, 129);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(96, 24);
            this.nombreLbl.TabIndex = 13;
            this.nombreLbl.Text = "Nombre: *";
            // 
            // instruccionesLbl
            // 
            this.instruccionesLbl.AutoSize = true;
            this.instruccionesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruccionesLbl.Location = new System.Drawing.Point(19, 74);
            this.instruccionesLbl.Name = "instruccionesLbl";
            this.instruccionesLbl.Size = new System.Drawing.Size(165, 15);
            this.instruccionesLbl.TabIndex = 12;
            this.instruccionesLbl.Text = "Llene los campos solicitados";
            // 
            // agregarModLbl
            // 
            this.agregarModLbl.AutoSize = true;
            this.agregarModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarModLbl.Location = new System.Drawing.Point(12, 19);
            this.agregarModLbl.Name = "agregarModLbl";
            this.agregarModLbl.Size = new System.Drawing.Size(209, 37);
            this.agregarModLbl.TabIndex = 11;
            this.agregarModLbl.Text = "Agregar Area";
            // 
            // AgregarModificarAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(846, 419);
            this.Controls.Add(this.advertenciaNombreLbl);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.instruccionesLbl);
            this.Controls.Add(this.agregarModLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AgregarModificarAreaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarModificarArea";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarModificarAreaForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

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
                areaLis = new List<Area>();
                for (int i = 0; i < info.Count; i++)
                {
                    areaLis.Add((Area)info[i]);
                }
            }
        }

        public void setInfo(List<Object> info)
        {

        }

        public void setLista(List<Object> info, int i)
        {

        }

        private System.Windows.Forms.Label advertenciaNombreLbl;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label instruccionesLbl;
        private System.Windows.Forms.Label agregarModLbl;
    }
}