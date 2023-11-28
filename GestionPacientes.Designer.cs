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
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnNuevoAlumno = new System.Windows.Forms.Button();
            this.grbNavegacionPaciente = new System.Windows.Forms.GroupBox();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.btnPrimeroPaciente = new System.Windows.Forms.Button();
            this.lblRegistroPaciente = new System.Windows.Forms.Label();
            this.cboOpcionBuscarPacientes = new System.Windows.Forms.ComboBox();
            this.txtBuscarPacientes = new System.Windows.Forms.TextBox();
            this.lblBuscarPacientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGestionPacientes)).BeginInit();
            this.grbEdicionAlumno.SuspendLayout();
            this.grbNavegacionPaciente.SuspendLayout();
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
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnNuevoAlumno);
            this.grbEdicionAlumno.Location = new System.Drawing.Point(634, 300);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Size = new System.Drawing.Size(282, 91);
            this.grbEdicionAlumno.TabIndex = 17;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "Edicion";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarAlumno.Location = new System.Drawing.Point(192, 33);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(70, 27);
            this.btnEliminarAlumno.TabIndex = 9;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumno.Location = new System.Drawing.Point(95, 33);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(80, 27);
            this.btnModificarAlumno.TabIndex = 8;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnNuevoAlumno
            // 
            this.btnNuevoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAlumno.Location = new System.Drawing.Point(6, 33);
            this.btnNuevoAlumno.Name = "btnNuevoAlumno";
            this.btnNuevoAlumno.Size = new System.Drawing.Size(73, 27);
            this.btnNuevoAlumno.TabIndex = 7;
            this.btnNuevoAlumno.Text = "Nuevo";
            this.btnNuevoAlumno.UseVisualStyleBackColor = true;
            // 
            // grbNavegacionPaciente
            // 
            this.grbNavegacionPaciente.Controls.Add(this.lblRegistroPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacionPaciente.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacionPaciente.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacionPaciente.Controls.Add(this.btnPrimeroPaciente);
            this.grbNavegacionPaciente.Location = new System.Drawing.Point(404, 300);
            this.grbNavegacionPaciente.Name = "grbNavegacionPaciente";
            this.grbNavegacionPaciente.Size = new System.Drawing.Size(225, 79);
            this.grbNavegacionPaciente.TabIndex = 16;
            this.grbNavegacionPaciente.TabStop = false;
            this.grbNavegacionPaciente.Text = "Navegacion";
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoAlumno.Location = new System.Drawing.Point(172, 33);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(37, 27);
            this.btnUltimoAlumno.TabIndex = 3;
            this.btnUltimoAlumno.Text = ">|";
            this.btnUltimoAlumno.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(141, 33);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(25, 27);
            this.btnSiguienteAlumno.TabIndex = 2;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(64, 33);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(29, 27);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.UseVisualStyleBackColor = true;
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
            // GestionPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 413);
            this.Controls.Add(this.lblBuscarPacientes);
            this.Controls.Add(this.cboOpcionBuscarPacientes);
            this.Controls.Add(this.txtBuscarPacientes);
            this.Controls.Add(this.grbEdicionAlumno);
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
            this.grbEdicionAlumno.ResumeLayout(false);
            this.grbNavegacionPaciente.ResumeLayout(false);
            this.grbNavegacionPaciente.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnNuevoAlumno;
        private System.Windows.Forms.GroupBox grbNavegacionPaciente;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Button btnPrimeroPaciente;
        private System.Windows.Forms.Label lblCodigoPaciente;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblRegistroPaciente;
        private System.Windows.Forms.ComboBox cboOpcionBuscarPacientes;
        private System.Windows.Forms.TextBox txtBuscarPacientes;
        private System.Windows.Forms.Label lblBuscarPacientes;
    }
}