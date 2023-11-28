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
            this.GestionEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultadoDeAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentaciónClínicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.db_clinicaDataSet = new SistemaFarmacia.db_clinicaDataSet();
            this.dbclinicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inicio = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnxSistema.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.mnxSistema.Size = new System.Drawing.Size(681, 25);
            this.mnxSistema.TabIndex = 2;
            this.mnxSistema.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem,
            this.inicio});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // aplicacionesToolStripMenuItem
            // 
            this.aplicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionPacientesToolStripMenuItem,
            this.GestionEmpleadosToolStripMenuItem,
            this.ResultadoDeAnalisisToolStripMenuItem,
            this.InventarioToolStripMenuItem,
            this.DocumentaciónClínicaToolStripMenuItem,
            this.toolStripMenuItem1});
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(89, 19);
            this.aplicacionesToolStripMenuItem.Text = "Aplicaciones ";
            // 
            // GestionPacientesToolStripMenuItem
            // 
            this.GestionPacientesToolStripMenuItem.Name = "GestionPacientesToolStripMenuItem";
            this.GestionPacientesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.GestionPacientesToolStripMenuItem.Text = "Gestion Pacientes";
            this.GestionPacientesToolStripMenuItem.Click += new System.EventHandler(this.GestionPacientesToolStripMenuItem_Click);
            // 
            // GestionEmpleadosToolStripMenuItem
            // 
            this.GestionEmpleadosToolStripMenuItem.Name = "GestionEmpleadosToolStripMenuItem";
            this.GestionEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.GestionEmpleadosToolStripMenuItem.Text = "Gestion Empleados";
            this.GestionEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.GestionEmpleadosToolStripMenuItem_Click);
            // 
            // ResultadoDeAnalisisToolStripMenuItem
            // 
            this.ResultadoDeAnalisisToolStripMenuItem.Name = "ResultadoDeAnalisisToolStripMenuItem";
            this.ResultadoDeAnalisisToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.ResultadoDeAnalisisToolStripMenuItem.Text = "Resultado de Analisis";
            this.ResultadoDeAnalisisToolStripMenuItem.Click += new System.EventHandler(this.ResultadoDeAnalisisToolStripMenuItem_Click);
            // 
            // InventarioToolStripMenuItem
            // 
            this.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem";
            this.InventarioToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.InventarioToolStripMenuItem.Text = "Inventario";
            this.InventarioToolStripMenuItem.Click += new System.EventHandler(this.InventarioToolStripMenuItem_Click);
            // 
            // DocumentaciónClínicaToolStripMenuItem
            // 
            this.DocumentaciónClínicaToolStripMenuItem.Name = "DocumentaciónClínicaToolStripMenuItem";
            this.DocumentaciónClínicaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.DocumentaciónClínicaToolStripMenuItem.Text = "Documentación Clínica";
            this.DocumentaciónClínicaToolStripMenuItem.Click += new System.EventHandler(this.DocumentaciónClínicaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
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
            // inicio
            // 
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(180, 22);
            this.inicio.Text = "inicio";
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // Principal
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(681, 513);
            this.Controls.Add(this.mnxSistema);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnxSistema;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
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
        private System.Windows.Forms.ToolStripMenuItem GestionEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResultadoDeAnalisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DocumentaciónClínicaToolStripMenuItem;
        private System.Windows.Forms.BindingSource dbclinicaDataSetBindingSource;
        private db_clinicaDataSet db_clinicaDataSet;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inicio;
    }
}

