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
            this.txtBuscarPacientes = new System.Windows.Forms.TextBox();
            this.lblBuscarPacientes = new System.Windows.Forms.Label();
            this.cboOpcionBuscarPacientes = new System.Windows.Forms.ComboBox();
            this.grbEdicionPaciente = new System.Windows.Forms.GroupBox();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.grbNavegacionPaciente = new System.Windows.Forms.GroupBox();
            this.btnSiguientePacientes = new System.Windows.Forms.Button();
            this.lblRegistroPaciente = new System.Windows.Forms.Label();
            this.btnUltimoPaciente = new System.Windows.Forms.Button();
            this.btnAnteriorPaciente = new System.Windows.Forms.Button();
            this.btnPrimeroPaciente = new System.Windows.Forms.Button();
            this.lblCodigoPaciente = new System.Windows.Forms.Label();
            this.txtCodigoPaciente = new System.Windows.Forms.TextBox();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccionPaciente = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefonoPaciente = new System.Windows.Forms.TextBox();
            this.grbDatosGestionPacientes = new System.Windows.Forms.GroupBox();
            this.db_clinicaDataSet = new SistemaFarmacia.db_clinicaDataSet();
            this.gestionPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionPacientesTableAdapter = new SistemaFarmacia.db_clinicaDataSetTableAdapters.GestionPacientesTableAdapter();
            this.tableAdapterManager = new SistemaFarmacia.db_clinicaDataSetTableAdapters.TableAdapterManager();
            this.gestionEmpleadosTableAdapter = new SistemaFarmacia.db_clinicaDataSetTableAdapters.GestionEmpleadosTableAdapter();
            this.gestionEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionEmpleadosDataGridView = new System.Windows.Forms.DataGridView();
            this.idEmpleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEdicionPaciente.SuspendLayout();
            this.grbNavegacionPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEmpleadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarPacientes
            // 
            this.txtBuscarPacientes.Location = new System.Drawing.Point(603, 31);
            this.txtBuscarPacientes.Name = "txtBuscarPacientes";
            this.txtBuscarPacientes.ReadOnly = true;
            this.txtBuscarPacientes.Size = new System.Drawing.Size(206, 20);
            this.txtBuscarPacientes.TabIndex = 36;
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
            // cboOpcionBuscarPacientes
            // 
            this.cboOpcionBuscarPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarPacientes.FormattingEnabled = true;
            this.cboOpcionBuscarPacientes.Items.AddRange(new object[] {
            "Codigo",
            "Empleados"});
            this.cboOpcionBuscarPacientes.Location = new System.Drawing.Point(434, 31);
            this.cboOpcionBuscarPacientes.Name = "cboOpcionBuscarPacientes";
            this.cboOpcionBuscarPacientes.Size = new System.Drawing.Size(163, 21);
            this.cboOpcionBuscarPacientes.TabIndex = 34;
            // 
            // grbEdicionPaciente
            // 
            this.grbEdicionPaciente.Controls.Add(this.btnEliminarPaciente);
            this.grbEdicionPaciente.Controls.Add(this.btnModificarPaciente);
            this.grbEdicionPaciente.Controls.Add(this.btnNuevoPaciente);
            this.grbEdicionPaciente.Location = new System.Drawing.Point(618, 319);
            this.grbEdicionPaciente.Name = "grbEdicionPaciente";
            this.grbEdicionPaciente.Size = new System.Drawing.Size(282, 79);
            this.grbEdicionPaciente.TabIndex = 33;
            this.grbEdicionPaciente.TabStop = false;
            this.grbEdicionPaciente.Text = "Edicion";
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPaciente.ForeColor = System.Drawing.Color.LightCoral;
            this.btnEliminarPaciente.Location = new System.Drawing.Point(192, 33);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(70, 27);
            this.btnEliminarPaciente.TabIndex = 9;
            this.btnEliminarPaciente.Text = "Eliminar";
            this.btnEliminarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnModificarPaciente
            // 
            this.btnModificarPaciente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPaciente.Location = new System.Drawing.Point(95, 33);
            this.btnModificarPaciente.Name = "btnModificarPaciente";
            this.btnModificarPaciente.Size = new System.Drawing.Size(80, 27);
            this.btnModificarPaciente.TabIndex = 8;
            this.btnModificarPaciente.Text = "Modificar";
            this.btnModificarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnNuevoPaciente
            // 
            this.btnNuevoPaciente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPaciente.Location = new System.Drawing.Point(6, 33);
            this.btnNuevoPaciente.Name = "btnNuevoPaciente";
            this.btnNuevoPaciente.Size = new System.Drawing.Size(73, 27);
            this.btnNuevoPaciente.TabIndex = 7;
            this.btnNuevoPaciente.Text = "Nuevo";
            this.btnNuevoPaciente.UseVisualStyleBackColor = true;
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
            // lblCodigoPaciente
            // 
            this.lblCodigoPaciente.AutoSize = true;
            this.lblCodigoPaciente.Location = new System.Drawing.Point(73, 93);
            this.lblCodigoPaciente.Name = "lblCodigoPaciente";
            this.lblCodigoPaciente.Size = new System.Drawing.Size(42, 13);
            this.lblCodigoPaciente.TabIndex = 23;
            this.lblCodigoPaciente.Text = "codigo:";
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.Location = new System.Drawing.Point(147, 90);
            this.txtCodigoPaciente.Name = "txtCodigoPaciente";
            this.txtCodigoPaciente.ReadOnly = true;
            this.txtCodigoPaciente.Size = new System.Drawing.Size(90, 20);
            this.txtCodigoPaciente.TabIndex = 24;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(73, 132);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(45, 13);
            this.lblNombrePaciente.TabIndex = 25;
            this.lblNombrePaciente.Text = "nombre:";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(147, 129);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.ReadOnly = true;
            this.txtNombrePaciente.Size = new System.Drawing.Size(174, 20);
            this.txtNombrePaciente.TabIndex = 26;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(73, 170);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(53, 13);
            this.lblDireccion.TabIndex = 27;
            this.lblDireccion.Text = "direccion:";
            // 
            // txtDireccionPaciente
            // 
            this.txtDireccionPaciente.Location = new System.Drawing.Point(147, 167);
            this.txtDireccionPaciente.Name = "txtDireccionPaciente";
            this.txtDireccionPaciente.ReadOnly = true;
            this.txtDireccionPaciente.Size = new System.Drawing.Size(184, 20);
            this.txtDireccionPaciente.TabIndex = 28;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(73, 216);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(48, 13);
            this.lblTelefono.TabIndex = 29;
            this.lblTelefono.Text = "telefono:";
            // 
            // txtTelefonoPaciente
            // 
            this.txtTelefonoPaciente.Location = new System.Drawing.Point(147, 213);
            this.txtTelefonoPaciente.Name = "txtTelefonoPaciente";
            this.txtTelefonoPaciente.ReadOnly = true;
            this.txtTelefonoPaciente.Size = new System.Drawing.Size(123, 20);
            this.txtTelefonoPaciente.TabIndex = 30;
            // 
            // grbDatosGestionPacientes
            // 
            this.grbDatosGestionPacientes.Location = new System.Drawing.Point(30, 53);
            this.grbDatosGestionPacientes.Name = "grbDatosGestionPacientes";
            this.grbDatosGestionPacientes.Size = new System.Drawing.Size(330, 216);
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
            // gestionEmpleadosDataGridView
            // 
            this.gestionEmpleadosDataGridView.AutoGenerateColumns = false;
            this.gestionEmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gestionEmpleadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleados,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono});
            this.gestionEmpleadosDataGridView.DataSource = this.gestionEmpleadosBindingSource;
            this.gestionEmpleadosDataGridView.Location = new System.Drawing.Point(366, 80);
            this.gestionEmpleadosDataGridView.Name = "gestionEmpleadosDataGridView";
            this.gestionEmpleadosDataGridView.Size = new System.Drawing.Size(544, 220);
            this.gestionEmpleadosDataGridView.TabIndex = 37;
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
            // GestionEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 417);
            this.Controls.Add(this.gestionEmpleadosDataGridView);
            this.Controls.Add(this.txtBuscarPacientes);
            this.Controls.Add(this.lblBuscarPacientes);
            this.Controls.Add(this.cboOpcionBuscarPacientes);
            this.Controls.Add(this.grbEdicionPaciente);
            this.Controls.Add(this.grbNavegacionPaciente);
            this.Controls.Add(this.lblCodigoPaciente);
            this.Controls.Add(this.txtCodigoPaciente);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccionPaciente);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefonoPaciente);
            this.Controls.Add(this.grbDatosGestionPacientes);
            this.Name = "GestionEmpleados";
            this.Text = "GestionEmpleados";
            this.Load += new System.EventHandler(this.GestionEmpleados_Load);
            this.grbEdicionPaciente.ResumeLayout(false);
            this.grbNavegacionPaciente.ResumeLayout(false);
            this.grbNavegacionPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEmpleadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarPacientes;
        private System.Windows.Forms.Label lblBuscarPacientes;
        private System.Windows.Forms.ComboBox cboOpcionBuscarPacientes;
        private System.Windows.Forms.GroupBox grbEdicionPaciente;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.Button btnModificarPaciente;
        private System.Windows.Forms.Button btnNuevoPaciente;
        private System.Windows.Forms.GroupBox grbNavegacionPaciente;
        private System.Windows.Forms.Button btnSiguientePacientes;
        private System.Windows.Forms.Label lblRegistroPaciente;
        private System.Windows.Forms.Button btnUltimoPaciente;
        private System.Windows.Forms.Button btnAnteriorPaciente;
        private System.Windows.Forms.Button btnPrimeroPaciente;
        private System.Windows.Forms.Label lblCodigoPaciente;
        private System.Windows.Forms.TextBox txtCodigoPaciente;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccionPaciente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefonoPaciente;
        private System.Windows.Forms.GroupBox grbDatosGestionPacientes;
        private db_clinicaDataSet db_clinicaDataSet;
        private System.Windows.Forms.BindingSource gestionPacientesBindingSource;
        private db_clinicaDataSetTableAdapters.GestionPacientesTableAdapter gestionPacientesTableAdapter;
        private db_clinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private db_clinicaDataSetTableAdapters.GestionEmpleadosTableAdapter gestionEmpleadosTableAdapter;
        private System.Windows.Forms.BindingSource gestionEmpleadosBindingSource;
        private System.Windows.Forms.DataGridView gestionEmpleadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}