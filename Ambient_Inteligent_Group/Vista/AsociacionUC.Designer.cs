using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Ambient_Inteligent_Group.Vista
{
    partial class AsociacionUC : InterfaceComunicador
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private AsociacionControl asociacionControl;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.tablaAsociacion = new System.Windows.Forms.DataGridView();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.nombreAsociacionTxt = new System.Windows.Forms.TextBox();
            this.nombreAreaLbl = new System.Windows.Forms.Label();
            this.manteAsociacionLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAsociacion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.eliminarBtn);
            this.panel1.Controls.Add(this.modificarBtn);
            this.panel1.Controls.Add(this.tablaAsociacion);
            this.panel1.Controls.Add(this.buscarBtn);
            this.panel1.Controls.Add(this.agregarBtn);
            this.panel1.Controls.Add(this.descripcionLbl);
            this.panel1.Controls.Add(this.nombreAsociacionTxt);
            this.panel1.Controls.Add(this.nombreAreaLbl);
            this.panel1.Controls.Add(this.manteAsociacionLbl);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 651);
            this.panel1.TabIndex = 2;
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Enabled = false;
            this.eliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBtn.Location = new System.Drawing.Point(1009, 556);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(107, 39);
            this.eliminarBtn.TabIndex = 8;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.Enabled = false;
            this.modificarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarBtn.Location = new System.Drawing.Point(841, 556);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(107, 39);
            this.modificarBtn.TabIndex = 7;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // tablaAsociacion
            // 
            this.tablaAsociacion.AllowUserToAddRows = false;
            this.tablaAsociacion.AllowUserToDeleteRows = false;
            this.tablaAsociacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAsociacion.Location = new System.Drawing.Point(29, 277);
            this.tablaAsociacion.Name = "tablaAsociacion";
            this.tablaAsociacion.ReadOnly = true;
            this.tablaAsociacion.Size = new System.Drawing.Size(1087, 260);
            this.tablaAsociacion.TabIndex = 6;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarBtn.Location = new System.Drawing.Point(326, 221);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(107, 39);
            this.buscarBtn.TabIndex = 5;
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
            this.agregarBtn.TabIndex = 4;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // descripcionLbl
            // 
            this.descripcionLbl.AutoSize = true;
            this.descripcionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLbl.Location = new System.Drawing.Point(26, 124);
            this.descripcionLbl.Name = "descripcionLbl";
            this.descripcionLbl.Size = new System.Drawing.Size(407, 32);
            this.descripcionLbl.TabIndex = 3;
            this.descripcionLbl.Text = "Seleccione el boton \"Agregar\" para habilitar la seccion de registro, \nsi desea re" +
    "alizar una busqueda seleccione el boton \"Buscar\"";
            // 
            // nombreAsociacionTxt
            // 
            this.nombreAsociacionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreAsociacionTxt.Location = new System.Drawing.Point(115, 177);
            this.nombreAsociacionTxt.Name = "nombreAsociacionTxt";
            this.nombreAsociacionTxt.Size = new System.Drawing.Size(318, 29);
            this.nombreAsociacionTxt.TabIndex = 2;
            // 
            // nombreAreaLbl
            // 
            this.nombreAreaLbl.AutoSize = true;
            this.nombreAreaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreAreaLbl.Location = new System.Drawing.Point(25, 180);
            this.nombreAreaLbl.Name = "nombreAreaLbl";
            this.nombreAreaLbl.Size = new System.Drawing.Size(84, 24);
            this.nombreAreaLbl.TabIndex = 1;
            this.nombreAreaLbl.Text = "Nombre:";
            // 
            // manteAsociacionLbl
            // 
            this.manteAsociacionLbl.AutoSize = true;
            this.manteAsociacionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manteAsociacionLbl.Location = new System.Drawing.Point(22, 60);
            this.manteAsociacionLbl.Name = "manteAsociacionLbl";
            this.manteAsociacionLbl.Size = new System.Drawing.Size(391, 37);
            this.manteAsociacionLbl.TabIndex = 0;
            this.manteAsociacionLbl.Text = "Mantenimiento Asociacion";
            // 
            // AsociacionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AsociacionUC";
            this.Size = new System.Drawing.Size(1164, 654);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAsociacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.DataGridView tablaAsociacion;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Label descripcionLbl;
        private System.Windows.Forms.TextBox nombreAsociacionTxt;
        private System.Windows.Forms.Label nombreAreaLbl;
        private System.Windows.Forms.Label manteAsociacionLbl;

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
            asociacionControl.BuscarTodos("Asociacion");
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
                List<Asociacion> asociacionLis = new List<Asociacion>();
                for (int i = 0; i < info.Count; i++)
                {
                    asociacionLis.Add((Asociacion)info[i]);
                }
                tablaAsociacion.DataSource = asociacionLis;
                tablaAsociacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                VisibilidadOpciones(true);
            }
            else
            {
                MessageBox.Show("No se encontraron councidencias", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void setInfo(List<Object> info)
        {
            AgregarModificarAsociacionForm agreMod = new AgregarModificarAsociacionForm(this);
            agreMod.Visible = true;
            this.Enabled = false;
            agreMod.ObtenerInfo(info);
        }

        public void setLista(List<Object> info, int i)
        {

        }

    }
}
