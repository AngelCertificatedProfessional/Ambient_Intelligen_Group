using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Ambient_Inteligent_Group.Vista
{
    partial class AgregarModificarPlaticaForm :InterfaceComunicador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<Platica> plaLis;
        private int idPlatica;
        private PlaticaControl platicaControl;
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
            this.guardarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.instruccionesLbl = new System.Windows.Forms.Label();
            this.agregarModLbl = new System.Windows.Forms.Label();
            this.advertenciaNombreLbl = new System.Windows.Forms.Label();
            this.nombrePlaticaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaDt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.sedeCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nombreEventoTxt = new System.Windows.Forms.TextBox();
            this.abreviacionEventoTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guardarBtn
            // 
            this.guardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBtn.Location = new System.Drawing.Point(726, 438);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(112, 43);
            this.guardarBtn.TabIndex = 29;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.Location = new System.Drawing.Point(588, 438);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(112, 43);
            this.cancelarBtn.TabIndex = 28;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.Location = new System.Drawing.Point(24, 131);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(185, 24);
            this.nombreLbl.TabIndex = 27;
            this.nombreLbl.Text = "Fecha de la platica: *";
            // 
            // instruccionesLbl
            // 
            this.instruccionesLbl.AutoSize = true;
            this.instruccionesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruccionesLbl.Location = new System.Drawing.Point(21, 76);
            this.instruccionesLbl.Name = "instruccionesLbl";
            this.instruccionesLbl.Size = new System.Drawing.Size(165, 15);
            this.instruccionesLbl.TabIndex = 26;
            this.instruccionesLbl.Text = "Llene los campos solicitados";
            // 
            // agregarModLbl
            // 
            this.agregarModLbl.AutoSize = true;
            this.agregarModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarModLbl.Location = new System.Drawing.Point(14, 21);
            this.agregarModLbl.Name = "agregarModLbl";
            this.agregarModLbl.Size = new System.Drawing.Size(237, 37);
            this.agregarModLbl.TabIndex = 25;
            this.agregarModLbl.Text = "Agregar Platica";
            // 
            // advertenciaNombreLbl
            // 
            this.advertenciaNombreLbl.AutoSize = true;
            this.advertenciaNombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertenciaNombreLbl.ForeColor = System.Drawing.Color.Maroon;
            this.advertenciaNombreLbl.Location = new System.Drawing.Point(228, 231);
            this.advertenciaNombreLbl.Name = "advertenciaNombreLbl";
            this.advertenciaNombreLbl.Size = new System.Drawing.Size(110, 15);
            this.advertenciaNombreLbl.TabIndex = 34;
            this.advertenciaNombreLbl.Text = "Campo Obligatorio";
            this.advertenciaNombreLbl.Visible = false;
            // 
            // nombrePlaticaTxt
            // 
            this.nombrePlaticaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePlaticaTxt.Location = new System.Drawing.Point(231, 199);
            this.nombrePlaticaTxt.Name = "nombrePlaticaTxt";
            this.nombrePlaticaTxt.Size = new System.Drawing.Size(391, 29);
            this.nombrePlaticaTxt.TabIndex = 33;
            this.nombrePlaticaTxt.Enter += new System.EventHandler(this.nombrePlaticaTxt_Enter);
            this.nombrePlaticaTxt.Leave += new System.EventHandler(this.nombrePlaticaTxt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre de la Platica: *";
            // 
            // fechaDt
            // 
            this.fechaDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDt.Location = new System.Drawing.Point(231, 131);
            this.fechaDt.Name = "fechaDt";
            this.fechaDt.Size = new System.Drawing.Size(391, 26);
            this.fechaDt.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Sede de la platica: *";
            // 
            // sedeCb
            // 
            this.sedeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sedeCb.FormattingEnabled = true;
            this.sedeCb.Location = new System.Drawing.Point(231, 266);
            this.sedeCb.Name = "sedeCb";
            this.sedeCb.Size = new System.Drawing.Size(391, 26);
            this.sedeCb.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nombre del evento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Abreviacion del evento: ";
            // 
            // nombreEventoTxt
            // 
            this.nombreEventoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEventoTxt.Location = new System.Drawing.Point(231, 325);
            this.nombreEventoTxt.Name = "nombreEventoTxt";
            this.nombreEventoTxt.Size = new System.Drawing.Size(391, 29);
            this.nombreEventoTxt.TabIndex = 42;
            // 
            // abreviacionEventoTxt
            // 
            this.abreviacionEventoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abreviacionEventoTxt.Location = new System.Drawing.Point(231, 389);
            this.abreviacionEventoTxt.Name = "abreviacionEventoTxt";
            this.abreviacionEventoTxt.Size = new System.Drawing.Size(391, 29);
            this.abreviacionEventoTxt.TabIndex = 43;
            // 
            // AgregarModificarPlaticaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(850, 493);
            this.Controls.Add(this.abreviacionEventoTxt);
            this.Controls.Add(this.nombreEventoTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sedeCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaDt);
            this.Controls.Add(this.advertenciaNombreLbl);
            this.Controls.Add(this.nombrePlaticaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.instruccionesLbl);
            this.Controls.Add(this.agregarModLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AgregarModificarPlaticaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarModificarPlaticaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarModificarPlaticaForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label instruccionesLbl;
        private System.Windows.Forms.Label agregarModLbl;
        private System.Windows.Forms.Label advertenciaNombreLbl;
        private System.Windows.Forms.TextBox nombrePlaticaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaDt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sedeCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombreEventoTxt;
        private System.Windows.Forms.TextBox abreviacionEventoTxt;

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
                plaLis = new List<Platica>();
                for (int i = 0; i < info.Count; i++)
                {
                    plaLis.Add((Platica)info[i]);
                }
            }

        }

        public void setInfo(List<Object> info)
        {

        }

        public void setLista(List<Object> info, int i)
        {
            switch (i) { 
                case 1:
                    List<Sede> sedeLis = new List<Sede>();
                    for (int k = 0; k < info.Count; k++)
                    {
                        sedeLis.Add((Sede)info[k]);
                    }
                    sedeCb.DataSource = sedeLis;
                    sedeCb.DisplayMember = "Nombre";
                    sedeCb.ValueMember = "IdSede";
                    sedeCb.DropDownStyle = ComboBoxStyle.DropDownList;
                break;
            }
        }



    }
}