namespace SistemaFarmacia
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnxSistema = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoDeAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentaciónClínicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.db_clinicaDataSet = new SistemaFarmacia.db_clinicaDataSet();
            this.dbclinicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mnxSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbclinicaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mnxSistema
            // 
            this.mnxSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.aplicacionesToolStripMenuItem});
            this.mnxSistema.Location = new System.Drawing.Point(0, 0);
            this.mnxSistema.Name = "mnxSistema";
            this.mnxSistema.Size = new System.Drawing.Size(817, 24);
            this.mnxSistema.TabIndex = 2;
            this.mnxSistema.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // aplicacionesToolStripMenuItem
            // 
            this.aplicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionPacientesToolStripMenuItem,
            this.gestionEmpleadosToolStripMenuItem,
            this.resultadoDeAnalisisToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.documentaciónClínicaToolStripMenuItem});
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.aplicacionesToolStripMenuItem.Text = "Aplicaciones ";
            // 
            // GestionPacientesToolStripMenuItem
            // 
            this.GestionPacientesToolStripMenuItem.Name = "GestionPacientesToolStripMenuItem";
            this.GestionPacientesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.GestionPacientesToolStripMenuItem.Text = "Gestion Pacientes";
            this.GestionPacientesToolStripMenuItem.Click += new System.EventHandler(this.GestionPacientesToolStripMenuItem_Click);
            // 
            // gestionEmpleadosToolStripMenuItem
            // 
            this.gestionEmpleadosToolStripMenuItem.Name = "gestionEmpleadosToolStripMenuItem";
            this.gestionEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.gestionEmpleadosToolStripMenuItem.Text = "Gestion Empleados";
            // 
            // resultadoDeAnalisisToolStripMenuItem
            // 
            this.resultadoDeAnalisisToolStripMenuItem.Name = "resultadoDeAnalisisToolStripMenuItem";
            this.resultadoDeAnalisisToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.resultadoDeAnalisisToolStripMenuItem.Text = "Resultado de Analisis";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // documentaciónClínicaToolStripMenuItem
            // 
            this.documentaciónClínicaToolStripMenuItem.Name = "documentaciónClínicaToolStripMenuItem";
            this.documentaciónClínicaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.documentaciónClínicaToolStripMenuItem.Text = "Documentación Clínica";
            // 
            // db_clinicaDataSet
            // 
            this.db_clinicaDataSet.DataSetName = "db_clinicaDataSet";
            this.db_clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbclinicaDataSetBindingSource
            // 
            this.dbclinicaDataSetBindingSource.DataSource = this.db_clinicaDataSet;
            this.dbclinicaDataSetBindingSource.Position = 0;
            // 
            // Principal
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(817, 376);
            this.Controls.Add(this.mnxSistema);
            this.Font = new System.Drawing.Font("Mocking Bird", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnxSistema;
            this.Name = "Principal";
            this.Text = "SISTEMA CLINICO ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnxSistema.ResumeLayout(false);
            this.mnxSistema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbclinicaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnxSistema;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadoDeAnalisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentaciónClínicaToolStripMenuItem;
        private System.Windows.Forms.BindingSource dbclinicaDataSetBindingSource;
        private db_clinicaDataSet db_clinicaDataSet;
    }
}

