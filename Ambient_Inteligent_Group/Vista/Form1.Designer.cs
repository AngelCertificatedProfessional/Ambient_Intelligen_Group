using Ambient_Inteligent_Group.Vista;
namespace Ambient_Inteligent_Group
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        
        

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoMI = new System.Windows.Forms.ToolStripMenuItem();
            this.sedesMI = new System.Windows.Forms.ToolStripMenuItem();
            this.universidadMI = new System.Windows.Forms.ToolStripMenuItem();
            this.areaMI = new System.Windows.Forms.ToolStripMenuItem();
            this.programaEducativoMI = new System.Windows.Forms.ToolStripMenuItem();
            this.periodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolaridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosMI = new System.Windows.Forms.ToolStripMenuItem();
            this.asociacionMI = new System.Windows.Forms.ToolStripMenuItem();
            this.platicasInvitadasMI = new System.Windows.Forms.ToolStripMenuItem();
            this.claseMI = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosMI = new System.Windows.Forms.ToolStripMenuItem();
            this.publicacionMI = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosMI = new System.Windows.Forms.ToolStripMenuItem();
            this.clasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoMI,
            this.procesosMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoMI
            // 
            this.mantenimientoMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sedesMI,
            this.universidadMI,
            this.areaMI,
            this.programaEducativoMI,
            this.periodoToolStripMenuItem,
            this.socioToolStripMenuItem,
            this.escolaridadToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.mantenimientoMI.Name = "mantenimientoMI";
            this.mantenimientoMI.Size = new System.Drawing.Size(148, 20);
            this.mantenimientoMI.Text = "Mantenimientos Basicos";
            // 
            // sedesMI
            // 
            this.sedesMI.Name = "sedesMI";
            this.sedesMI.Size = new System.Drawing.Size(181, 22);
            this.sedesMI.Text = "Sedes";
            this.sedesMI.Click += new System.EventHandler(this.sedesToolStripMenuItem_Click);
            // 
            // universidadMI
            // 
            this.universidadMI.Name = "universidadMI";
            this.universidadMI.Size = new System.Drawing.Size(181, 22);
            this.universidadMI.Text = "Universidad";
            this.universidadMI.Click += new System.EventHandler(this.universidadMI_Click);
            // 
            // areaMI
            // 
            this.areaMI.Name = "areaMI";
            this.areaMI.Size = new System.Drawing.Size(181, 22);
            this.areaMI.Text = "Area";
            this.areaMI.Click += new System.EventHandler(this.areaMI_Click);
            // 
            // programaEducativoMI
            // 
            this.programaEducativoMI.Name = "programaEducativoMI";
            this.programaEducativoMI.Size = new System.Drawing.Size(181, 22);
            this.programaEducativoMI.Text = "Programa Educativo";
            this.programaEducativoMI.Click += new System.EventHandler(this.programaEducativoMI_Click);
            // 
            // periodoToolStripMenuItem
            // 
            this.periodoToolStripMenuItem.Name = "periodoToolStripMenuItem";
            this.periodoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.periodoToolStripMenuItem.Text = "Periodo";
            this.periodoToolStripMenuItem.Click += new System.EventHandler(this.periodoToolStripMenuItem_Click);
            // 
            // socioToolStripMenuItem
            // 
            this.socioToolStripMenuItem.Name = "socioToolStripMenuItem";
            this.socioToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.socioToolStripMenuItem.Text = "Tipo de Socios";
            this.socioToolStripMenuItem.Click += new System.EventHandler(this.socioToolStripMenuItem_Click);
            // 
            // escolaridadToolStripMenuItem
            // 
            this.escolaridadToolStripMenuItem.Name = "escolaridadToolStripMenuItem";
            this.escolaridadToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.escolaridadToolStripMenuItem.Text = "Escolaridad";
            this.escolaridadToolStripMenuItem.Click += new System.EventHandler(this.escolaridadToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // procesosMI
            // 
            this.procesosMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asociacionMI,
            this.platicasInvitadasMI,
            this.claseMI,
            this.proyectosMI,
            this.publicacionMI,
            this.eventosMI,
            this.clasesToolStripMenuItem});
            this.procesosMI.Name = "procesosMI";
            this.procesosMI.Size = new System.Drawing.Size(66, 20);
            this.procesosMI.Text = "Procesos";
            // 
            // asociacionMI
            // 
            this.asociacionMI.Name = "asociacionMI";
            this.asociacionMI.Size = new System.Drawing.Size(164, 22);
            this.asociacionMI.Text = "Asociacion";
            this.asociacionMI.Click += new System.EventHandler(this.asociacionMI_Click);
            // 
            // platicasInvitadasMI
            // 
            this.platicasInvitadasMI.Name = "platicasInvitadasMI";
            this.platicasInvitadasMI.Size = new System.Drawing.Size(164, 22);
            this.platicasInvitadasMI.Text = "Platicas Invitadas";
            this.platicasInvitadasMI.Click += new System.EventHandler(this.platicasInvitadasMI_Click);
            // 
            // claseMI
            // 
            this.claseMI.Name = "claseMI";
            this.claseMI.Size = new System.Drawing.Size(164, 22);
            this.claseMI.Text = "Socios";
            // 
            // proyectosMI
            // 
            this.proyectosMI.Name = "proyectosMI";
            this.proyectosMI.Size = new System.Drawing.Size(164, 22);
            this.proyectosMI.Text = "Proyectos";
            // 
            // publicacionMI
            // 
            this.publicacionMI.Name = "publicacionMI";
            this.publicacionMI.Size = new System.Drawing.Size(164, 22);
            this.publicacionMI.Text = "Publicacion";
            // 
            // eventosMI
            // 
            this.eventosMI.Name = "eventosMI";
            this.eventosMI.Size = new System.Drawing.Size(164, 22);
            this.eventosMI.Text = "Eventos";
            // 
            // clasesToolStripMenuItem
            // 
            this.clasesToolStripMenuItem.Name = "clasesToolStripMenuItem";
            this.clasesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.clasesToolStripMenuItem.Text = "Clases";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1144, 612);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ambient_Inteligent_Group";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private Ambient_Inteligent_Group.Vista.SedeUC sedeUC;
        private Ambient_Inteligent_Group.Vista.UniversidadUC universidadUC;
        private Ambient_Inteligent_Group.Vista.AreaUC areaUC;
        private Ambient_Inteligent_Group.Vista.PeriodoUC periodoUC;
        private Ambient_Inteligent_Group.Vista.Tipo_SocioUC tipo_SocioUC;
        private Ambient_Inteligent_Group.Vista.EscolaridadUC escolaridadUC;
        private Ambient_Inteligent_Group.Vista.ProgramaEducativoUC programaEduUC;
        private Ambient_Inteligent_Group.Vista.AsociacionUC asociacionUC;
        private Ambient_Inteligent_Group.Vista.PlaticaUC platicaUC;
        private Ambient_Inteligent_Group.Vista.PersonaUC personaUC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoMI;
        private System.Windows.Forms.ToolStripMenuItem procesosMI;
        private System.Windows.Forms.ToolStripMenuItem sedesMI;
        private System.Windows.Forms.ToolStripMenuItem universidadMI;
        private System.Windows.Forms.ToolStripMenuItem areaMI;
        private System.Windows.Forms.ToolStripMenuItem programaEducativoMI;
        private System.Windows.Forms.ToolStripMenuItem asociacionMI;
        private System.Windows.Forms.ToolStripMenuItem platicasInvitadasMI;
        private System.Windows.Forms.ToolStripMenuItem claseMI;
        private System.Windows.Forms.ToolStripMenuItem proyectosMI;
        private System.Windows.Forms.ToolStripMenuItem publicacionMI;

        public void InicializadorUC()
        {
            sedeUC = new SedeUC();
            this.sedeUC.Location = new System.Drawing.Point(0, 0);
            this.sedeUC.Name = "sedeUC";
            this.sedeUC.TabIndex = 1;
            this.sedeUC.Visible = false;
            this.sedeUC.Enabled = true;
            this.Controls.Add(sedeUC);

            universidadUC = new UniversidadUC();
            this.universidadUC.Location = new System.Drawing.Point(0, 0);
            this.universidadUC.Name = "universidadUC";
            this.universidadUC.TabIndex = 1;
            this.universidadUC.Visible = false;
            this.universidadUC.Enabled = true;
            this.Controls.Add(universidadUC);

            areaUC = new AreaUC();
            this.areaUC.Location = new System.Drawing.Point(0, 0);
            this.areaUC.Name = "areaUC";
            this.areaUC.TabIndex = 1;
            this.areaUC.Visible = false;
            this.areaUC.Enabled = true;
            this.Controls.Add(areaUC);

            periodoUC = new PeriodoUC();
            this.periodoUC.Location = new System.Drawing.Point(0, 0);
            this.periodoUC.Name = "periodoUC";
            this.periodoUC.TabIndex = 1;
            this.periodoUC.Visible = false;
            this.periodoUC.Enabled = true;
            this.Controls.Add(periodoUC);

            tipo_SocioUC = new Tipo_SocioUC();
            this.tipo_SocioUC.Location = new System.Drawing.Point(0, 0);
            this.tipo_SocioUC.Name = "tipo_SocioUC";
            this.tipo_SocioUC.TabIndex = 1;
            this.tipo_SocioUC.Visible = false;
            this.tipo_SocioUC.Enabled = true;
            this.Controls.Add(tipo_SocioUC);

            escolaridadUC = new EscolaridadUC();
            this.escolaridadUC.Location = new System.Drawing.Point(0, 0);
            this.escolaridadUC.Name = "escolaridadUC";
            this.escolaridadUC.TabIndex = 1;
            this.escolaridadUC.Visible = false;
            this.escolaridadUC.Enabled = true;
            this.Controls.Add(escolaridadUC);

            programaEduUC = new ProgramaEducativoUC();
            this.programaEduUC.Location = new System.Drawing.Point(0, 0);
            this.programaEduUC.Name = "programaEduUC";
            this.programaEduUC.TabIndex = 1;
            this.programaEduUC.Visible = false;
            this.programaEduUC.Enabled = true;
            this.Controls.Add(programaEduUC);

            asociacionUC = new AsociacionUC();
            this.asociacionUC.Location = new System.Drawing.Point(0, 0);
            this.asociacionUC.Name = "asociacionUC";
            this.asociacionUC.TabIndex = 1;
            this.asociacionUC.Visible = false;
            this.asociacionUC.Enabled = true;
            this.Controls.Add(asociacionUC);

            platicaUC = new PlaticaUC();
            this.platicaUC.Location = new System.Drawing.Point(0, 0);
            this.platicaUC.Name = "platicaUC";
            this.platicaUC.TabIndex = 1;
            this.platicaUC.Visible = false;
            this.platicaUC.Enabled = true;
            this.Controls.Add(platicaUC);

            personaUC = new PersonaUC();
            this.personaUC.Location = new System.Drawing.Point(0, 0);
            this.personaUC.Name = "personaUC";
            this.personaUC.TabIndex = 1;
            this.personaUC.Visible = false;
            this.personaUC.Enabled = true;
            this.Controls.Add(personaUC);
        }

        private System.Windows.Forms.ToolStripMenuItem eventosMI;
        private System.Windows.Forms.ToolStripMenuItem periodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolaridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
    
    }
}

