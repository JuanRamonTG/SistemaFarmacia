namespace SistemaFarmacia
{
    partial class GestionPacientes
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
            this.lblCodigoPaciente = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.db_clinicaDataSet = new SistemaFarmacia.db_clinicaDataSet();
            this.gestionPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionPacientesTableAdapter = new SistemaFarmacia.db_clinicaDataSetTableAdapters.GestionPacientesTableAdapter();
            this.tableAdapterManager = new SistemaFarmacia.db_clinicaDataSetTableAdapters.TableAdapterManager();
            this.grdGestionPacientes = new System.Windows.Forms.DataGridView();
            this.idPacientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoPaciente = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.txtDireccionPaciente = new System.Windows.Forms.TextBox();
            this.txtTelefonoPaciente = new System.Windows.Forms.TextBox();
            this.grbDatosGestionPacientes = new System.Windows.Forms.GroupBox();
            this.grbEdicionPaciente = new System.Windows.Forms.GroupBox();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.grbNavegacionPaciente = new System.Windows.Forms.GroupBox();
            this.lblRegistroPaciente = new System.Windows.Forms.Label();
            this.btnUltimoPaciente = new System.Windows.Forms.Button();
            this.btnAnteriorPaciente = new System.Windows.Forms.Button();
            this.btnPrimeroPaciente = new System.Windows.Forms.Button();
            this.cboOpcionBuscarPacientes = new System.Windows.Forms.ComboBox();
            this.txtBuscarPacientes = new System.Windows.Forms.TextBox();
            this.lblBuscarPacientes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.erpPacientes = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.db_clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGestionPacientes)).BeginInit();
            this.grbEdicionPaciente.SuspendLayout();
            this.grbNavegacionPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoPaciente
            // 
            this.lblCodigoPaciente.AutoSize = true;
            this.lblCodigoPaciente.Location = new System.Drawing.Point(89, 74);
            this.lblCodigoPaciente.Name = "lblCodigoPaciente";
            this.lblCodigoPaciente.Size = new System.Drawing.Size(42, 13);
            this.lblCodigoPaciente.TabIndex = 4;
            this.lblCodigoPaciente.Text = "codigo:";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(89, 113);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(45, 13);
            this.lblNombrePaciente.TabIndex = 6;
            this.lblNombrePaciente.Text = "nombre:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(89, 151);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(53, 13);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "direccion:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(89, 197);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(48, 13);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "telefono:";
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
            this.tableAdapterManager.GestionPacientesTableAdapter = this.gestionPacientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = SistemaFarmacia.db_clinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // grdGestionPacientes
            // 
            this.grdGestionPacientes.AllowUserToAddRows = false;
            this.grdGestionPacientes.AllowUserToDeleteRows = false;
            this.grdGestionPacientes.AutoGenerateColumns = false;
            this.grdGestionPacientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdGestionPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGestionPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPacientes,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdGestionPacientes.DataSource = this.gestionPacientesBindingSource;
            this.grdGestionPacientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdGestionPacientes.Location = new System.Drawing.Point(382, 47);
            this.grdGestionPacientes.Name = "grdGestionPacientes";
            this.grdGestionPacientes.ReadOnly = true;
            this.grdGestionPacientes.Size = new System.Drawing.Size(535, 230);
            this.grdGestionPacientes.TabIndex = 1;
            // 
            // idPacientes
            // 
            this.idPacientes.DataPropertyName = "idPacientes";
            this.idPacientes.HeaderText = "ID";
            this.idPacientes.Name = "idPacientes";
            this.idPacientes.ReadOnly = true;
            this.idPacientes.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gestionPacientesBindingSource, "codigo", true));
            this.txtCodigoPaciente.Location = new System.Drawing.Point(163, 71);
            this.txtCodigoPaciente.Name = "txtCodigoPaciente";
            this.txtCodigoPaciente.Size = new System.Drawing.Size(90, 20);
            this.txtCodigoPaciente.TabIndex = 5;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gestionPacientesBindingSource, "nombre", true));
            this.txtNombrePaciente.Location = new System.Drawing.Point(163, 110);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(174, 20);
            this.txtNombrePaciente.TabIndex = 7;
            this.txtNombrePaciente.TextChanged += new System.EventHandler(this.txtNombrePaciente_TextChanged);
            // 
            // txtDireccionPaciente
            // 
            this.txtDireccionPaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gestionPacientesBindingSource, "direccion", true));
            this.txtDireccionPaciente.Location = new System.Drawing.Point(163, 148);
            this.txtDireccionPaciente.Name = "txtDireccionPaciente";
            this.txtDireccionPaciente.Size = new System.Drawing.Size(184, 20);
            this.txtDireccionPaciente.TabIndex = 9;
            // 
            // txtTelefonoPaciente
            // 
            this.txtTelefonoPaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gestionPacientesBindingSource, "telefono", true));
            this.txtTelefonoPaciente.Location = new System.Drawing.Point(163, 194);
            this.txtTelefonoPaciente.Name = "txtTelefonoPaciente";
            this.txtTelefonoPaciente.Size = new System.Drawing.Size(123, 20);
            this.txtTelefonoPaciente.TabIndex = 11;
            // 
            // grbDatosGestionPacientes
            // 
            this.grbDatosGestionPacientes.Location = new System.Drawing.Point(49, 47);
            this.grbDatosGestionPacientes.Name = "grbDatosGestionPacientes";
            this.grbDatosGestionPacientes.Size = new System.Drawing.Size(326, 193);
            this.grbDatosGestionPacientes.TabIndex = 12;
            this.grbDatosGestionPacientes.TabStop = false;
            this.grbDatosGestionPacientes.Text = "Datos";
            // 
            // grbEdicionPaciente
            // 
            this.grbEdicionPaciente.Controls.Add(this.btnEliminarPaciente);
            this.grbEdicionPaciente.Controls.Add(this.btnModificarPaciente);
            this.grbEdicionPaciente.Controls.Add(this.btnNuevoPaciente);
            this.grbEdicionPaciente.Location = new System.Drawing.Point(634, 300);
            this.grbEdicionPaciente.Name = "grbEdicionPaciente";
            this.grbEdicionPaciente.Size = new System.Drawing.Size(282, 79);
            this.grbEdicionPaciente.TabIndex = 17;
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
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click_1);
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
            this.btnNuevoPaciente.Click += new System.EventHandler(this.btnNuevoPaciente_Click);
            // 
            // grbNavegacionPaciente
            // 
            this.grbNavegacionPaciente.Controls.Add(this.button1);
            this.grbNavegacionPaciente.Controls.Add(this.lblRegistroPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnUltimoPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnAnteriorPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnPrimeroPaciente);
            this.grbNavegacionPaciente.Location = new System.Drawing.Point(404, 300);
            this.grbNavegacionPaciente.Name = "grbNavegacionPaciente";
            this.grbNavegacionPaciente.Size = new System.Drawing.Size(225, 79);
            this.grbNavegacionPaciente.TabIndex = 16;
            this.grbNavegacionPaciente.TabStop = false;
            this.grbNavegacionPaciente.Text = "Navegacion";
            // 
            // lblRegistroPaciente
            // 
            this.lblRegistroPaciente.AutoSize = true;
            this.lblRegistroPaciente.Location = new System.Drawing.Point(99, 41);
            this.lblRegistroPaciente.Name = "lblRegistroPaciente";
            this.lblRegistroPaciente.Size = new System.Drawing.Size(36, 13);
            this.lblRegistroPaciente.TabIndex = 18;
            this.lblRegistroPaciente.Text = "x de n";
            this.lblRegistroPaciente.Click += new System.EventHandler(this.lblRegistroPaciente_Click);
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
            // cboOpcionBuscarPacientes
            // 
            this.cboOpcionBuscarPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarPacientes.FormattingEnabled = true;
            this.cboOpcionBuscarPacientes.Items.AddRange(new object[] {
            "Codigo",
            "Materia"});
            this.cboOpcionBuscarPacientes.Location = new System.Drawing.Point(450, 12);
            this.cboOpcionBuscarPacientes.Name = "cboOpcionBuscarPacientes";
            this.cboOpcionBuscarPacientes.Size = new System.Drawing.Size(163, 21);
            this.cboOpcionBuscarPacientes.TabIndex = 19;
            // 
            // txtBuscarPacientes
            // 
            this.txtBuscarPacientes.Location = new System.Drawing.Point(634, 13);
            this.txtBuscarPacientes.Name = "txtBuscarPacientes";
            this.txtBuscarPacientes.Size = new System.Drawing.Size(233, 20);
            this.txtBuscarPacientes.TabIndex = 18;
            // 
            // lblBuscarPacientes
            // 
            this.lblBuscarPacientes.AutoSize = true;
            this.lblBuscarPacientes.Location = new System.Drawing.Point(390, 15);
            this.lblBuscarPacientes.Name = "lblBuscarPacientes";
            this.lblBuscarPacientes.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarPacientes.TabIndex = 20;
            this.lblBuscarPacientes.Text = "Buscar:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // erpPacientes
            // 
            this.erpPacientes.ContainerControl = this;
            // 
            // GestionPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 413);
            this.Controls.Add(this.lblBuscarPacientes);
            this.Controls.Add(this.cboOpcionBuscarPacientes);
            this.Controls.Add(this.txtBuscarPacientes);
            this.Controls.Add(this.grbEdicionPaciente);
            this.Controls.Add(this.grbNavegacionPaciente);
            this.Controls.Add(this.grdGestionPacientes);
            this.Controls.Add(this.lblCodigoPaciente);
            this.Controls.Add(this.txtCodigoPaciente);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccionPaciente);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefonoPaciente);
            this.Controls.Add(this.grbDatosGestionPacientes);
            this.Name = "GestionPacientes";
            this.Text = "GestionPacientes";
            this.Load += new System.EventHandler(this.GestionPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGestionPacientes)).EndInit();
            this.grbEdicionPaciente.ResumeLayout(false);
            this.grbNavegacionPaciente.ResumeLayout(false);
            this.grbNavegacionPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_clinicaDataSet db_clinicaDataSet;
        private System.Windows.Forms.BindingSource gestionPacientesBindingSource;
        private db_clinicaDataSetTableAdapters.GestionPacientesTableAdapter gestionPacientesTableAdapter;
        private db_clinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView grdGestionPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.TextBox txtCodigoPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.TextBox txtDireccionPaciente;
        private System.Windows.Forms.TextBox txtTelefonoPaciente;
        private System.Windows.Forms.GroupBox grbDatosGestionPacientes;
        private System.Windows.Forms.GroupBox grbEdicionPaciente;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.Button btnModificarPaciente;
        private System.Windows.Forms.Button btnNuevoPaciente;
        private System.Windows.Forms.GroupBox grbNavegacionPaciente;
        private System.Windows.Forms.Button btnUltimoPaciente;
        private System.Windows.Forms.Button btnAnteriorPaciente;
        private System.Windows.Forms.Button btnPrimeroPaciente;
        private System.Windows.Forms.Label lblCodigoPaciente;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblRegistroPaciente;
        private System.Windows.Forms.ComboBox cboOpcionBuscarPacientes;
        private System.Windows.Forms.TextBox txtBuscarPacientes;
        private System.Windows.Forms.Label lblBuscarPacientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider erpPacientes;
    }
}