using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Ambient_Inteligent_Group.Vista
{
    partial class AgregarModificarTipoSocioForm : InterfaceComunicador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Tipo_SocioControl tipoSocioControl;
        private int idTipo_Socio;
        private List<Tipo_Socio> tipo_SocioLis;
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
            this.advertenciaTipoLbl = new System.Windows.Forms.Label();
            this.tipo_SocioTxt = new System.Windows.Forms.TextBox();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.tipo_SocioLbl = new System.Windows.Forms.Label();
            this.instruccionesLbl = new System.Windows.Forms.Label();
            this.agregarModLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // advertenciaTipoLbl
            // 
            this.advertenciaTipoLbl.AutoSize = true;
            this.advertenciaTipoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaTipoLbl.ForeColor = System.Drawing.Color.Maroon;
            this.advertenciaTipoLbl.Location = new System.Drawing.Point(141, 165);
            this.advertenciaTipoLbl.Name = "advertenciaTipoLbl";
            this.advertenciaTipoLbl.Size = new System.Drawing.Size(110, 15);
            this.advertenciaTipoLbl.TabIndex = 24;
            this.advertenciaTipoLbl.Text = "Campo Obligatorio";
            this.advertenciaTipoLbl.Visible = false;
            // 
            // tipo_SocioTxt
            // 
            this.tipo_SocioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_SocioTxt.Location = new System.Drawing.Point(144, 122);
            this.tipo_SocioTxt.Name = "tipo_SocioTxt";
            this.tipo_SocioTxt.Size = new System.Drawing.Size(252, 29);
            this.tipo_SocioTxt.TabIndex = 23;
            this.tipo_SocioTxt.Enter += new System.EventHandler(this.tipo_SocioTxt_Enter);
            this.tipo_SocioTxt.Leave += new System.EventHandler(this.tipo_SocioTxt_Leave);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBtn.Location = new System.Drawing.Point(720, 354);
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
            this.cancelarBtn.Location = new System.Drawing.Point(585, 354);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(112, 43);
            this.cancelarBtn.TabIndex = 21;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // tipo_SocioLbl
            // 
            this.tipo_SocioLbl.AutoSize = true;
            this.tipo_SocioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_SocioLbl.Location = new System.Drawing.Point(20, 127);
            this.tipo_SocioLbl.Name = "tipo_SocioLbl";
            this.tipo_SocioLbl.Size = new System.Drawing.Size(118, 24);
            this.tipo_SocioLbl.TabIndex = 20;
            this.tipo_SocioLbl.Text = "Tipo Socio: *";
            // 
            // instruccionesLbl
            // 
            this.instruccionesLbl.AutoSize = true;
            this.instruccionesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruccionesLbl.Location = new System.Drawing.Point(17, 72);
            this.instruccionesLbl.Name = "instruccionesLbl";
            this.instruccionesLbl.Size = new System.Drawing.Size(165, 15);
            this.instruccionesLbl.TabIndex = 19;
            this.instruccionesLbl.Text = "Llene los campos solicitados";
            // 
            // agregarModLbl
            // 
            this.agregarModLbl.AutoSize = true;
            this.agregarModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarModLbl.Location = new System.Drawing.Point(10, 17);
            this.agregarModLbl.Name = "agregarModLbl";
            this.agregarModLbl.Size = new System.Drawing.Size(221, 37);
            this.agregarModLbl.TabIndex = 18;
            this.agregarModLbl.Text = "Agregar Socio";
            // 
            // AgregarModificarTipoSocioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(842, 415);
            this.Controls.Add(this.advertenciaTipoLbl);
            this.Controls.Add(this.tipo_SocioTxt);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.tipo_SocioLbl);
            this.Controls.Add(this.instruccionesLbl);
            this.Controls.Add(this.agregarModLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AgregarModificarTipoSocioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarModificarTipoSocioForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarModificarTipoSocioForm_FormClosing);
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
                tipo_SocioLis = new List<Tipo_Socio>();
                for (int i = 0; i < info.Count; i++)
                {
                    tipo_SocioLis.Add((Tipo_Socio)info[i]);
                }
            }
        }

        public void setInfo(List<Object> info)
        {

        }

        public void setLista(List<Object> info, int i)
        {

        }

        private System.Windows.Forms.Label advertenciaTipoLbl;
        private System.Windows.Forms.TextBox tipo_SocioTxt;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label tipo_SocioLbl;
        private System.Windows.Forms.Label instruccionesLbl;
        private System.Windows.Forms.Label agregarModLbl;
    }
}