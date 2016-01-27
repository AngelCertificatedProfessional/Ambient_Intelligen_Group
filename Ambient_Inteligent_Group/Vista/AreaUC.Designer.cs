using Ambient_Inteligent_Group.Controlador;
using Ambient_Inteligent_Group.Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Ambient_Inteligent_Group.Vista
{
    partial class AreaUC : InterfaceComunicador
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private AreaControl areaControl;
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
            this.tablaArea = new System.Windows.Forms.DataGridView();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.descripcionLbl = new System.Windows.Forms.Label();
            this.nombreAreaTB = new System.Windows.Forms.TextBox();
            this.nombreAreaLbl = new System.Windows.Forms.Label();
            this.manteAreaLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaArea)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.eliminarBtn);
            this.panel1.Controls.Add(this.modificarBtn);
            this.panel1.Controls.Add(this.tablaArea);
            this.panel1.Controls.Add(this.buscarBtn);
            this.panel1.Controls.Add(this.agregarBtn);
            this.panel1.Controls.Add(this.descripcionLbl);
            this.panel1.Controls.Add(this.nombreAreaTB);
            this.panel1.Controls.Add(this.nombreAreaLbl);
            this.panel1.Controls.Add(this.manteAreaLbl);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 651);
            this.panel1.TabIndex = 1;
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
            // tablaArea
            // 
            this.tablaArea.AllowUserToAddRows = false;
            this.tablaArea.AllowUserToDeleteRows = false;
            this.tablaArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaArea.Location = new System.Drawing.Point(29, 277);
            this.tablaArea.Name = "tablaArea";
            this.tablaArea.ReadOnly = true;
            this.tablaArea.Size = new System.Drawing.Size(1087, 260);
            this.tablaArea.TabIndex = 6;
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
            // nombreAreaTB
            // 
            this.nombreAreaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreAreaTB.Location = new System.Drawing.Point(115, 177);
            this.nombreAreaTB.Name = "nombreAreaTB";
            this.nombreAreaTB.Size = new System.Drawing.Size(318, 29);
            this.nombreAreaTB.TabIndex = 2;
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
            // manteAreaLbl
            // 
            this.manteAreaLbl.AutoSize = true;
            this.manteAreaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manteAreaLbl.Location = new System.Drawing.Point(22, 60);
            this.manteAreaLbl.Name = "manteAreaLbl";
            this.manteAreaLbl.Size = new System.Drawing.Size(303, 37);
            this.manteAreaLbl.TabIndex = 0;
            this.manteAreaLbl.Text = "Mantenimiento Area";
            // 
            // AreaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AreaUC";
            this.Size = new System.Drawing.Size(1164, 654);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaArea)).EndInit();
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
            if (mensaje == "Cerrar")
            {
                this.Enabled = true;
            }
            else
            {
                MessageBox.Show(mensaje, "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            areaControl.BuscarTodos("Area");
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
                List<Area> areaLis = new List<Area>();
                for (int i = 0; i < info.Count; i++)
                {
                    areaLis.Add((Area)info[i]);
                }
                tablaArea.DataSource = areaLis;
                tablaArea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                VisibilidadOpciones(true);
            }
            else
            {
                MessageBox.Show("No se encontraron councidencias", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void setInfo(List<Object> info)
        {
            AgregarModificarAreaForm agreMod = new AgregarModificarAreaForm(this);
            agreMod.Visible = true;
            this.Enabled = false;
            agreMod.ObtenerInfo(info);
        }

        public void setLista(List<Object> info, int i)
        {

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.DataGridView tablaArea;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Label descripcionLbl;
        private System.Windows.Forms.TextBox nombreAreaTB;
        private System.Windows.Forms.Label nombreAreaLbl;
        private System.Windows.Forms.Label manteAreaLbl;
    }
}
