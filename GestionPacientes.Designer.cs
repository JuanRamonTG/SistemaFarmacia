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
            System.Windows.Forms.Label lblCodigoPaciente;
            System.Windows.Forms.Label lblNombrePaciente;
            System.Windows.Forms.Label lblDireccion;
            System.Windows.Forms.Label lblTelefono;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPacientes));
            this.db_clinicaDataSet = new SistemaFarmacia.db_clinicaDataSet();
            this.gestionPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionPacientesTableAdapter = new SistemaFarmacia.db_clinicaDataSetTableAdapters.GestionPacientesTableAdapter();
            this.tableAdapterManager = new SistemaFarmacia.db_clinicaDataSetTableAdapters.TableAdapterManager();
            this.gestionPacientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.lblBuscarPaciente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            lblCodigoPaciente = new System.Windows.Forms.Label();
            lblNombrePaciente = new System.Windows.Forms.Label();
            lblDireccion = new System.Windows.Forms.Label();
            lblTelefono = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionPacientesBindingNavigator)).BeginInit();
            this.gestionPacientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGestionPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoPaciente
            // 
            lblCodigoPaciente.AutoSize = true;
            lblCodigoPaciente.Location = new System.Drawing.Point(89, 74);
            lblCodigoPaciente.Name = "lblCodigoPaciente";
            lblCodigoPaciente.Size = new System.Drawing.Size(42, 13);
            lblCodigoPaciente.TabIndex = 4;
            lblCodigoPaciente.Text = "codigo:";
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.Location = new System.Drawing.Point(89, 113);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new System.Drawing.Size(45, 13);
            lblNombrePaciente.TabIndex = 6;
            lblNombrePaciente.Text = "nombre:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new System.Drawing.Point(89, 151);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new System.Drawing.Size(53, 13);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "direccion:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new System.Drawing.Point(89, 197);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(48, 13);
            lblTelefono.TabIndex = 10;
            lblTelefono.Text = "telefono:";
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
            // gestionPacientesBindingNavigator
            // 
            this.gestionPacientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gestionPacientesBindingNavigator.BindingSource = this.gestionPacientesBindingSource;
            this.gestionPacientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gestionPacientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gestionPacientesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gestionPacientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.gestionPacientesBindingNavigator.Location = new System.Drawing.Point(0, 331);
            this.gestionPacientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gestionPacientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gestionPacientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gestionPacientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gestionPacientesBindingNavigator.Name = "gestionPacientesBindingNavigator";
            this.gestionPacientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gestionPacientesBindingNavigator.Size = new System.Drawing.Size(973, 25);
            this.gestionPacientesBindingNavigator.TabIndex = 0;
            this.gestionPacientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // lblBuscarPaciente
            // 
            this.lblBuscarPaciente.AutoSize = true;
            this.lblBuscarPaciente.Location = new System.Drawing.Point(401, 17);
            this.lblBuscarPaciente.Name = "lblBuscarPaciente";
            this.lblBuscarPaciente.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarPaciente.TabIndex = 13;
            this.lblBuscarPaciente.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(657, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(450, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // GestionPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 356);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBuscarPaciente);
            this.Controls.Add(this.grdGestionPacientes);
            this.Controls.Add(lblCodigoPaciente);
            this.Controls.Add(this.txtCodigoPaciente);
            this.Controls.Add(lblNombrePaciente);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(lblDireccion);
            this.Controls.Add(this.txtDireccionPaciente);
            this.Controls.Add(lblTelefono);
            this.Controls.Add(this.txtTelefonoPaciente);
            this.Controls.Add(this.gestionPacientesBindingNavigator);
            this.Controls.Add(this.grbDatosGestionPacientes);
            this.Name = "GestionPacientes";
            this.Text = "GestionPacientes";
            this.Load += new System.EventHandler(this.GestionPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionPacientesBindingNavigator)).EndInit();
            this.gestionPacientesBindingNavigator.ResumeLayout(false);
            this.gestionPacientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGestionPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_clinicaDataSet db_clinicaDataSet;
        private System.Windows.Forms.BindingSource gestionPacientesBindingSource;
        private db_clinicaDataSetTableAdapters.GestionPacientesTableAdapter gestionPacientesTableAdapter;
        private db_clinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gestionPacientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
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
        private System.Windows.Forms.Label lblBuscarPaciente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}