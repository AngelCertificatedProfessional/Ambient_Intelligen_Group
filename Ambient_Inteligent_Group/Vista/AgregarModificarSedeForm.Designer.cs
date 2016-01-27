using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Ambient_Inteligent_Group.Vista
{
    partial class AgregarModificarSedeForm : InterfaceComunicador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private SedeControl controlSede;
        private int idSede;

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
            this.edificioLbl = new System.Windows.Forms.Label();
            this.salonLbl = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.edificioTxt = new System.Windows.Forms.TextBox();
            this.salonTxt = new System.Windows.Forms.TextBox();
            this.advertenciaNombreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agregarModLbl
            // 
            this.agregarModLbl.AutoSize = true;
            this.agregarModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarModLbl.Location = new System.Drawing.Point(12, 27);
            this.agregarModLbl.Name = "agregarModLbl";
            this.agregarModLbl.Size = new System.Drawing.Size(214, 37);
            this.agregarModLbl.TabIndex = 0;
            this.agregarModLbl.Text = "Agregar Sede";
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
            this.nombreLbl.TabIndex = 2;
            this.nombreLbl.Text = "Nombre: *";
            // 
            // edificioLbl
            // 
            this.edificioLbl.AutoSize = true;
            this.edificioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edificioLbl.Location = new System.Drawing.Point(22, 202);
            this.edificioLbl.Name = "edificioLbl";
            this.edificioLbl.Size = new System.Drawing.Size(76, 24);
            this.edificioLbl.TabIndex = 3;
            this.edificioLbl.Text = "Edificio:";
            // 
            // salonLbl
            // 
            this.salonLbl.AutoSize = true;
            this.salonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salonLbl.Location = new System.Drawing.Point(22, 270);
            this.salonLbl.Name = "salonLbl";
            this.salonLbl.Size = new System.Drawing.Size(63, 24);
            this.salonLbl.TabIndex = 4;
            this.salonLbl.Text = "Salon:";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.Location = new System.Drawing.Point(587, 364);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(112, 43);
            this.cancelarBtn.TabIndex = 5;
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
            this.guardarBtn.TabIndex = 6;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // nombreTxt
            // 
            this.nombreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTxt.Location = new System.Drawing.Point(124, 134);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(252, 29);
            this.nombreTxt.TabIndex = 7;
            this.nombreTxt.Enter += new System.EventHandler(this.nombreTxt_Enter);
            this.nombreTxt.Leave += new System.EventHandler(this.nombreTxt_Leave);
            // 
            // edificioTxt
            // 
            this.edificioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edificioTxt.Location = new System.Drawing.Point(124, 199);
            this.edificioTxt.Name = "edificioTxt";
            this.edificioTxt.Size = new System.Drawing.Size(252, 29);
            this.edificioTxt.TabIndex = 8;
            // 
            // salonTxt
            // 
            this.salonTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salonTxt.Location = new System.Drawing.Point(124, 265);
            this.salonTxt.Name = "salonTxt";
            this.salonTxt.Size = new System.Drawing.Size(252, 29);
            this.salonTxt.TabIndex = 9;
            // 
            // advertenciaNombreLbl
            // 
            this.advertenciaNombreLbl.AutoSize = true;
            this.advertenciaNombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaNombreLbl.ForeColor = System.Drawing.Color.Maroon;
            this.advertenciaNombreLbl.Location = new System.Drawing.Point(124, 170);
            this.advertenciaNombreLbl.Name = "advertenciaNombreLbl";
            this.advertenciaNombreLbl.Size = new System.Drawing.Size(110, 15);
            this.advertenciaNombreLbl.TabIndex = 10;
            this.advertenciaNombreLbl.Text = "Campo Obligatorio";
            this.advertenciaNombreLbl.Visible = false;
            // 
            // AgregarModificarSedeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(846, 419);
            this.Controls.Add(this.advertenciaNombreLbl);
            this.Controls.Add(this.salonTxt);
            this.Controls.Add(this.edificioTxt);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.salonLbl);
            this.Controls.Add(this.edificioLbl);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.instruccionesLbl);
            this.Controls.Add(this.agregarModLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AgregarModificarSedeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarModificarSedeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /**
         * Metodo para mostrar un mensaje al usuario, por ejemplo, un mensaje de
         * exito o de error.
         * 
         * @param mensaje Mensaje que se mostrara al usuario.
         */
        public void setMensaje(String mensaje)
        {
            MessageBox.Show(mensaje,"Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        }

        public void setInfo(List<Object> info)
        {

        }

        public void setLista(List<Object> info, int i)
        {

        }
        #endregion

        private System.Windows.Forms.Label agregarModLbl;
        private System.Windows.Forms.Label instruccionesLbl;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label edificioLbl;
        private System.Windows.Forms.Label salonLbl;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox edificioTxt;
        private System.Windows.Forms.TextBox salonTxt;
        private Label advertenciaNombreLbl;
    }
}