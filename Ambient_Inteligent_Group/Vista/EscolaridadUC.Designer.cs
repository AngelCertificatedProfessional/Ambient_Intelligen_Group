using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Ambient_Inteligent_Group.Vista
{
    partial class EscolaridadUC : InterfaceComunicador
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private EscolaridadControl escolaridadControl;
        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.universidadPanel = new System.Windows.Forms.Panel();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.tablaEscolaridad = new System.Windows.Forms.DataGridView();
            this.escolaridadTB = new System.Windows.Forms.TextBox();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.universidadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEscolaridad)).BeginInit();
            this.SuspendLayout();
            // 
            // universidadPanel
            // 
            this.universidadPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.universidadPanel.Controls.Add(this.modificarBtn);
            this.universidadPanel.Controls.Add(this.eliminarBtn);
            this.universidadPanel.Controls.Add(this.buscarBtn);
            this.universidadPanel.Controls.Add(this.agregarBtn);
            this.universidadPanel.Controls.Add(this.tablaEscolaridad);
            this.universidadPanel.Controls.Add(this.escolaridadTB);
            this.universidadPanel.Controls.Add(this.nombreLbl);
            this.universidadPanel.Controls.Add(this.label2);
            this.universidadPanel.Controls.Add(this.label1);
            this.universidadPanel.Location = new System.Drawing.Point(2, 2);
            this.universidadPanel.Name = "universidadPanel";
            this.universidadPanel.Size = new System.Drawing.Size(1161, 651);
            this.universidadPanel.TabIndex = 1;
            // 
            // modificarBtn
            // 
            this.modificarBtn.Enabled = false;
            this.modificarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarBtn.Location = new System.Drawing.Point(841, 556);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(107, 39);
            this.modificarBtn.TabIndex = 8;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Enabled = false;
            this.eliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBtn.Location = new System.Drawing.Point(1009, 556);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(107, 39);
            this.eliminarBtn.TabIndex = 7;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // buscarBtn
            // 
            this.buscarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarBtn.Location = new System.Drawing.Point(326, 221);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(107, 39);
            this.buscarBtn.TabIndex = 6;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // agregarBtn
            // 
            this.agregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBtn.Location = new System.Drawing.Point(29, 221);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(107, 39);
            this.agregarBtn.TabIndex = 5;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // tablaEscolaridad
            // 
            this.tablaEscolaridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEscolaridad.Location = new System.Drawing.Point(29, 277);
            this.tablaEscolaridad.Name = "tablaEscolaridad";
            this.tablaEscolaridad.Size = new System.Drawing.Size(1087, 260);
            this.tablaEscolaridad.TabIndex = 4;
            // 
            // escolaridadTB
            // 
            this.escolaridadTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolaridadTB.Location = new System.Drawing.Point(115, 177);
            this.escolaridadTB.Name = "escolaridadTB";
            this.escolaridadTB.Size = new System.Drawing.Size(318, 29);
            this.escolaridadTB.TabIndex = 3;
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLbl.Location = new System.Drawing.Point(25, 180);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(84, 24);
            this.nombreLbl.TabIndex = 2;
            this.nombreLbl.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione el boton \"Agregar\" para habilitar la seccion de registro, \nsi desea re" +
    "alizar una busqueda seleccione el boton \"Buscar\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento Escolaridad";
            // 
            // EscolaridadUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.universidadPanel);
            this.Name = "EscolaridadUC";
            this.Size = new System.Drawing.Size(1164, 654);
            this.universidadPanel.ResumeLayout(false);
            this.universidadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEscolaridad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel universidadPanel;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.DataGridView tablaEscolaridad;
        private System.Windows.Forms.TextBox escolaridadTB;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        /**
         * Metodo para mostrar un mensaje al usuario, por ejemplo, un mensaje de
         * exito o de error.
         * 
         * @param mensaje Mensaje que se mostrara al usuario.
         */
        public void setMensaje(String mensaje)
        {
            if (mensaje == "Cerrar")
            {
                this.Enabled = true;
            }
            else
            {
                MessageBox.Show(mensaje, "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            escolaridadControl.BuscarTodos("Escolaridad");
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
                List<Escolaridad> escoLis = new List<Escolaridad>();
                for (int i = 0; i < info.Count; i++)
                {
                    escoLis.Add((Escolaridad)info[i]);
                }
                tablaEscolaridad.DataSource = escoLis;
                tablaEscolaridad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                VisibilidadOpciones(true);
            }
            else
            {
                MessageBox.Show("No se encontraron councidencias", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void setInfo(List<Object> info)
        {
            AgregarModificarEscolaridadForm agreMod = new AgregarModificarEscolaridadForm(this);
            agreMod.Visible = true;
            this.Enabled = false;
            agreMod.ObtenerInfo(info);
        }

        public void setLista(List<Object> info, int i)
        {

        }


    }
}
