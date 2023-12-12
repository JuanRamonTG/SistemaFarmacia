namespace SistemaFarmacia
{
    partial class GestionEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.txtBuscarEmpleados = new System.Windows.Forms.TextBox();
            this.lblBuscarPacientes = new System.Windows.Forms.Label();
            this.grbEdicionPaciente = new System.Windows.Forms.GroupBox();
            this.btnEliminarEmpleados = new System.Windows.Forms.Button();
            this.btnModificarEmpleados = new System.Windows.Forms.Button();
            this.btnNuevoEmpleados = new System.Windows.Forms.Button();
            this.grbNavegacionPaciente = new System.Windows.Forms.GroupBox();
            this.btnSiguientePacientes = new System.Windows.Forms.Button();
            this.lblRegistroPaciente = new System.Windows.Forms.Label();
            this.btnUltimoPaciente = new System.Windows.Forms.Button();
            this.btnAnteriorPaciente = new System.Windows.Forms.Button();
            this.btnPrimeroPaciente = new System.Windows.Forms.Button();
            this.grbDatosGestionPacientes = new System.Windows.Forms.GroupBox();
            this.db_clinicaDataSet = new SistemaFarmacia.db_clinicaDataSet();
            this.gestionPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionPacientesTableAdapter = new SistemaFarmacia.db_clinicaDataSetTableAdapters.GestionPacientesTableAdapter();
            this.tableAdapterManager = new SistemaFarmacia.db_clinicaDataSetTableAdapters.TableAdapterManager();
            this.gestionEmpleadosTableAdapter = new SistemaFarmacia.db_clinicaDataSetTableAdapters.GestionEmpleadosTableAdapter();
            this.gestionEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdGestionEmpleados = new System.Windows.Forms.DataGridView();
            this.idEmpleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFechaEmpleado = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEmpleado = new System.Windows.Forms.Label();
            this.lblAlumnoEmpleado = new System.Windows.Forms.Label();
            this.lblPeriodoEmpleado = new System.Windows.Forms.Label();
            this.cboAlumnoEmpleado = new System.Windows.Forms.ComboBox();
            this.cboPeriodoEmpleado = new System.Windows.Forms.ComboBox();
            this.grbEdicionPaciente.SuspendLayout();
            this.grbNavegacionPaciente.SuspendLayout();
            this.grbDatosGestionPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGestionEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarEmpleados
            // 
            this.txtBuscarEmpleados.Location = new System.Drawing.Point(436, 31);
            this.txtBuscarEmpleados.Name = "txtBuscarEmpleados";
            this.txtBuscarEmpleados.ReadOnly = true;
            this.txtBuscarEmpleados.Size = new System.Drawing.Size(373, 20);
            this.txtBuscarEmpleados.TabIndex = 36;
            // 
            // lblBuscarPacientes
            // 
            this.lblBuscarPacientes.AutoSize = true;
            this.lblBuscarPacientes.Location = new System.Drawing.Point(374, 34);
            this.lblBuscarPacientes.Name = "lblBuscarPacientes";
            this.lblBuscarPacientes.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarPacientes.TabIndex = 35;
            this.lblBuscarPacientes.Text = "Buscar:";
            // 
            // grbEdicionPaciente
            // 
            this.grbEdicionPaciente.Controls.Add(this.btnEliminarEmpleados);
            this.grbEdicionPaciente.Controls.Add(this.btnModificarEmpleados);
            this.grbEdicionPaciente.Controls.Add(this.btnNuevoEmpleados);
            this.grbEdicionPaciente.Location = new System.Drawing.Point(618, 319);
            this.grbEdicionPaciente.Name = "grbEdicionPaciente";
            this.grbEdicionPaciente.Size = new System.Drawing.Size(282, 79);
            this.grbEdicionPaciente.TabIndex = 33;
            this.grbEdicionPaciente.TabStop = false;
            this.grbEdicionPaciente.Text = "Edicion";
            // 
            // btnEliminarEmpleados
            // 
            this.btnEliminarEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleados.ForeColor = System.Drawing.Color.LightCoral;
            this.btnEliminarEmpleados.Location = new System.Drawing.Point(192, 33);
            this.btnEliminarEmpleados.Name = "btnEliminarEmpleados";
            this.btnEliminarEmpleados.Size = new System.Drawing.Size(70, 27);
            this.btnEliminarEmpleados.TabIndex = 9;
            this.btnEliminarEmpleados.Text = "Eliminar";
            this.btnEliminarEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnModificarEmpleados
            // 
            this.btnModificarEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEmpleados.Location = new System.Drawing.Point(95, 33);
            this.btnModificarEmpleados.Name = "btnModificarEmpleados";
            this.btnModificarEmpleados.Size = new System.Drawing.Size(80, 27);
            this.btnModificarEmpleados.TabIndex = 8;
            this.btnModificarEmpleados.Text = "Modificar";
            this.btnModificarEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnNuevoEmpleados
            // 
            this.btnNuevoEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEmpleados.Location = new System.Drawing.Point(6, 33);
            this.btnNuevoEmpleados.Name = "btnNuevoEmpleados";
            this.btnNuevoEmpleados.Size = new System.Drawing.Size(73, 27);
            this.btnNuevoEmpleados.TabIndex = 7;
            this.btnNuevoEmpleados.Text = "Nuevo";
            this.btnNuevoEmpleados.UseVisualStyleBackColor = true;
            // 
            // grbNavegacionPaciente
            // 
            this.grbNavegacionPaciente.Controls.Add(this.btnSiguientePacientes);
            this.grbNavegacionPaciente.Controls.Add(this.lblRegistroPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnUltimoPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnAnteriorPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnPrimeroPaciente);
            this.grbNavegacionPaciente.Location = new System.Drawing.Point(372, 319);
            this.grbNavegacionPaciente.Name = "grbNavegacionPaciente";
            this.grbNavegacionPaciente.Size = new System.Drawing.Size(225, 79);
            this.grbNavegacionPaciente.TabIndex = 32;
            this.grbNavegacionPaciente.TabStop = false;
            this.grbNavegacionPaciente.Text = "Navegacion";
            // 
            // btnSiguientePacientes
            // 
            this.btnSiguientePacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguientePacientes.Location = new System.Drawing.Point(141, 33);
            this.btnSiguientePacientes.Name = "btnSiguientePacientes";
            this.btnSiguientePacientes.Size = new System.Drawing.Size(25, 27);
            this.btnSiguientePacientes.TabIndex = 21;
            this.btnSiguientePacientes.Text = ">";
            this.btnSiguientePacientes.UseVisualStyleBackColor = true;
            // 
            // lblRegistroPaciente
            // 
            this.lblRegistroPaciente.AutoSize = true;
            this.lblRegistroPaciente.Location = new System.Drawing.Point(99, 41);
            this.lblRegistroPaciente.Name = "lblRegistroPaciente";
            this.lblRegistroPaciente.Size = new System.Drawing.Size(36, 13);
            this.lblRegistroPaciente.TabIndex = 18;
            this.lblRegistroPaciente.Text = "x de n";
            // 
            // btnUltimoPaciente
            // 
            this.btnUltimoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoPaciente.Location = new System.Drawing.Point(172, 33);
            this.btnUltimoPaciente.Name = "btnUltimoPaciente";
            this.btnUltimoPaciente.Size = new System.Drawing.Size(37, 27);
            this.btnUltimoPaciente.TabIndex = 3;
            this.btnUltimoPaciente.Text = ">|";
            this.btnUltimoPaciente.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorPaciente
            // 
            this.btnAnteriorPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorPaciente.Location = new System.Drawing.Point(64, 33);
            this.btnAnteriorPaciente.Name = "btnAnteriorPaciente";
            this.btnAnteriorPaciente.Size = new System.Drawing.Size(29, 27);
            this.btnAnteriorPaciente.TabIndex = 1;
            this.btnAnteriorPaciente.Text = "<";
            this.btnAnteriorPaciente.UseVisualStyleBackColor = true;
            // 
            // btnPrimeroPaciente
            // 
            this.btnPrimeroPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroPaciente.Location = new System.Drawing.Point(24, 33);
            this.btnPrimeroPaciente.Name = "btnPrimeroPaciente";
            this.btnPrimeroPaciente.Size = new System.Drawing.Size(34, 27);
            this.btnPrimeroPaciente.TabIndex = 0;
            this.btnPrimeroPaciente.Text = "|<";
            this.btnPrimeroPaciente.UseVisualStyleBackColor = true;
            // 
            // grbDatosGestionPacientes
            // 
            this.grbDatosGestionPacientes.Controls.Add(this.dtFechaEmpleado);
            this.grbDatosGestionPacientes.Controls.Add(this.lblFechaEmpleado);
            this.grbDatosGestionPacientes.Controls.Add(this.lblAlumnoEmpleado);
            this.grbDatosGestionPacientes.Controls.Add(this.lblPeriodoEmpleado);
            this.grbDatosGestionPacientes.Controls.Add(this.cboAlumnoEmpleado);
            this.grbDatosGestionPacientes.Controls.Add(this.cboPeriodoEmpleado);
            this.grbDatosGestionPacientes.Location = new System.Drawing.Point(12, 80);
            this.grbDatosGestionPacientes.Name = "grbDatosGestionPacientes";
            this.grbDatosGestionPacientes.Size = new System.Drawing.Size(330, 206);
            this.grbDatosGestionPacientes.TabIndex = 31;
            this.grbDatosGestionPacientes.TabStop = false;
            this.grbDatosGestionPacientes.Text = "Datos";
            // 
            // db_clinicaDataSet
            // 
            this.db_clinicaDataSet.DataSetName = "db_clinicaDataSet";
            this.db_clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionPacientesBindingSource
            // 
            this.gestionPacientesBindingSource.DataMember = "GestionPacientes";
            this.gestionPacientesBindingSource.DataSource = this.db_clinicaDataSet;
            // 
            // gestionPacientesTableAdapter
            // 
            this.gestionPacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GestionEmpleadosTableAdapter = this.gestionEmpleadosTableAdapter;
            this.tableAdapterManager.GestionPacientesTableAdapter = this.gestionPacientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = SistemaFarmacia.db_clinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gestionEmpleadosTableAdapter
            // 
            this.gestionEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // gestionEmpleadosBindingSource
            // 
            this.gestionEmpleadosBindingSource.DataMember = "GestionEmpleados";
            this.gestionEmpleadosBindingSource.DataSource = this.db_clinicaDataSet;
            // 
            // grdGestionEmpleados
            // 
            this.grdGestionEmpleados.AutoGenerateColumns = false;
            this.grdGestionEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGestionEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleados,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdGestionEmpleados.DataSource = this.gestionEmpleadosBindingSource;
            this.grdGestionEmpleados.Location = new System.Drawing.Point(366, 80);
            this.grdGestionEmpleados.Name = "grdGestionEmpleados";
            this.grdGestionEmpleados.Size = new System.Drawing.Size(544, 220);
            this.grdGestionEmpleados.TabIndex = 37;
            // 
            // idEmpleados
            // 
            this.idEmpleados.DataPropertyName = "idEmpleados";
            this.idEmpleados.HeaderText = "ID";
            this.idEmpleados.Name = "idEmpleados";
            this.idEmpleados.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            // 
            // dtFechaEmpleado
            // 
            this.dtFechaEmpleado.Enabled = false;
            this.dtFechaEmpleado.Location = new System.Drawing.Point(80, 153);
            this.dtFechaEmpleado.Name = "dtFechaEmpleado";
            this.dtFechaEmpleado.Size = new System.Drawing.Size(223, 20);
            this.dtFechaEmpleado.TabIndex = 11;
            // 
            // lblFechaEmpleado
            // 
            this.lblFechaEmpleado.AutoSize = true;
            this.lblFechaEmpleado.Location = new System.Drawing.Point(28, 153);
            this.lblFechaEmpleado.Name = "lblFechaEmpleado";
            this.lblFechaEmpleado.Size = new System.Drawing.Size(40, 13);
            this.lblFechaEmpleado.TabIndex = 10;
            this.lblFechaEmpleado.Text = "Fecha:";
            // 
            // lblAlumnoEmpleado
            // 
            this.lblAlumnoEmpleado.AutoSize = true;
            this.lblAlumnoEmpleado.Location = new System.Drawing.Point(28, 93);
            this.lblAlumnoEmpleado.Name = "lblAlumnoEmpleado";
            this.lblAlumnoEmpleado.Size = new System.Drawing.Size(57, 13);
            this.lblAlumnoEmpleado.TabIndex = 9;
            this.lblAlumnoEmpleado.Text = "Empleado:";
            // 
            // lblPeriodoEmpleado
            // 
            this.lblPeriodoEmpleado.AutoSize = true;
            this.lblPeriodoEmpleado.Location = new System.Drawing.Point(28, 37);
            this.lblPeriodoEmpleado.Name = "lblPeriodoEmpleado";
            this.lblPeriodoEmpleado.Size = new System.Drawing.Size(46, 13);
            this.lblPeriodoEmpleado.TabIndex = 8;
            this.lblPeriodoEmpleado.Text = "Periodo:";
            // 
            // cboAlumnoEmpleado
            // 
            this.cboAlumnoEmpleado.DisplayMember = "nombre";
            this.cboAlumnoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlumnoEmpleado.Enabled = false;
            this.cboAlumnoEmpleado.FormattingEnabled = true;
            this.cboAlumnoEmpleado.Location = new System.Drawing.Point(80, 93);
            this.cboAlumnoEmpleado.Name = "cboAlumnoEmpleado";
            this.cboAlumnoEmpleado.Size = new System.Drawing.Size(223, 21);
            this.cboAlumnoEmpleado.TabIndex = 7;
            this.cboAlumnoEmpleado.ValueMember = "idAlumno";
            // 
            // cboPeriodoEmpleado
            // 
            this.cboPeriodoEmpleado.DisplayMember = "periodo";
            this.cboPeriodoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodoEmpleado.Enabled = false;
            this.cboPeriodoEmpleado.FormattingEnabled = true;
            this.cboPeriodoEmpleado.Location = new System.Drawing.Point(80, 34);
            this.cboPeriodoEmpleado.Name = "cboPeriodoEmpleado";
            this.cboPeriodoEmpleado.Size = new System.Drawing.Size(223, 21);
            this.cboPeriodoEmpleado.TabIndex = 6;
            this.cboPeriodoEmpleado.ValueMember = "idPeriodo";
            // 
            // GestionEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 417);
            this.Controls.Add(this.grdGestionEmpleados);
            this.Controls.Add(this.txtBuscarEmpleados);
            this.Controls.Add(this.lblBuscarPacientes);
            this.Controls.Add(this.grbEdicionPaciente);
            this.Controls.Add(this.grbNavegacionPaciente);
            this.Controls.Add(this.grbDatosGestionPacientes);
            this.Name = "GestionEmpleados";
            this.Text = "GestionEmpleados";
            this.Load += new System.EventHandler(this.GestionEmpleados_Load);
            this.grbEdicionPaciente.ResumeLayout(false);
            this.grbNavegacionPaciente.ResumeLayout(false);
            this.grbNavegacionPaciente.PerformLayout();
            this.grbDatosGestionPacientes.ResumeLayout(false);
            this.grbDatosGestionPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGestionEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarEmpleados;
        private System.Windows.Forms.Label lblBuscarPacientes;
        private System.Windows.Forms.GroupBox grbEdicionPaciente;
        private System.Windows.Forms.Button btnEliminarEmpleados;
        private System.Windows.Forms.Button btnModificarEmpleados;
        private System.Windows.Forms.Button btnNuevoEmpleados;
        private System.Windows.Forms.GroupBox grbNavegacionPaciente;
        private System.Windows.Forms.Button btnSiguientePacientes;
        private System.Windows.Forms.Label lblRegistroPaciente;
        private System.Windows.Forms.Button btnUltimoPaciente;
        private System.Windows.Forms.Button btnAnteriorPaciente;
        private System.Windows.Forms.Button btnPrimeroPaciente;
        private System.Windows.Forms.GroupBox grbDatosGestionPacientes;
        private db_clinicaDataSet db_clinicaDataSet;
        private System.Windows.Forms.BindingSource gestionPacientesBindingSource;
        private db_clinicaDataSetTableAdapters.GestionPacientesTableAdapter gestionPacientesTableAdapter;
        private db_clinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private db_clinicaDataSetTableAdapters.GestionEmpleadosTableAdapter gestionEmpleadosTableAdapter;
        private System.Windows.Forms.BindingSource gestionEmpleadosBindingSource;
        private System.Windows.Forms.DataGridView grdGestionEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DateTimePicker dtFechaEmpleado;
        private System.Windows.Forms.Label lblFechaEmpleado;
        private System.Windows.Forms.Label lblAlumnoEmpleado;
        private System.Windows.Forms.Label lblPeriodoEmpleado;
        private System.Windows.Forms.ComboBox cboAlumnoEmpleado;
        private System.Windows.Forms.ComboBox cboPeriodoEmpleado;
    }
}