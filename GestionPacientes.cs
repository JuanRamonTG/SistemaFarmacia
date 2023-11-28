using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class GestionPacientes : Form
    {
        public GestionPacientes()
        {
            InitializeComponent();
        }

        private void gestionPacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gestionPacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_clinicaDataSet);

        }

        private void GestionPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_clinicaDataSet.GestionPacientes' Puede moverla o quitarla según sea necesario.
            this.gestionPacientesTableAdapter.Fill(this.db_clinicaDataSet.GestionPacientes);

        }
        
        
            Conexion objConexion = new Conexion();
            DataSet miDs = new DataSet();
            DataTable miTablaPacientes = new DataTable();
            public int posicion = 0;
            String accion = "nuevo";

            private void pacientes_Load(object sender, EventArgs e)
            {
                this.gestionPacientesTableAdapter.Fill(this.db_clinicaDataSet.GestionPacientes);
                actualizarDsPacientes();
                cboOpcionBuscarPacientes.SelectedIndex = 1;
            }

            private void actualizarDsPacientes()
            {
                miDs.Clear();
                miDs = objConexion.obtenerDatos();
                miTablaPacientes = miDs.Tables["pacientes"];
                miTablaPacientes.PrimaryKey = new DataColumn[] { miTablaPacientes.Columns["idPaciente"] };
                mostrarPacientes();
                mostrarDatosPaciente();
            }

            private void mostrarPacientes()
            {
                grdGestionPacientes.DataSource = miTablaPacientes.DefaultView;
            }

            private void filtrarPacientes(String valor, int opcion)
            {
                try
                {
                    BindingSource bsPacientes = new BindingSource();
                    bsPacientes.DataSource = grdGestionPacientes.DataSource;
                    bsPacientes.Filter = opcion == 0 ? "codigo=" + valor : "nombre like '%" + valor + "%'";
                grdGestionPacientes.DataSource = bsPacientes;
                    erpPacientes.SetError(txtBuscarPacientes, "");
                }
                catch (Exception ex)
                {
                    erpPacientes.SetError(txtBuscarPacientes, "Por favor ingrese un código o nombre del paciente a buscar");
                }
            }

            private void mostrarDatosPaciente()
            {
                if (miTablaPacientes.Rows.Count > 0)
                {
                    txtCodigoPaciente.Text = miTablaPacientes.Rows[posicion].ItemArray[1].ToString();
                    txtNombrePaciente.Text = miTablaPacientes.Rows[posicion].ItemArray[2].ToString();
                    txtDireccionPaciente.Text = miTablaPacientes.Rows[posicion].ItemArray[3].ToString();
                    txtTelefonoPaciente.Text = miTablaPacientes.Rows[posicion].ItemArray[4].ToString();

                    lblRegistroPaciente.Text = (posicion + 1) + " de " + miTablaPacientes.Rows.Count;
                }
                else
                {
                    limpiarCajas();
                }
            }

        private void btnUltimoPaciente_Click(object sender, EventArgs e)
        {
            posicion = miTablaPacientes.Rows.Count - 1;
            mostrarDatosPaciente();
        }

        private void btnAnteriorPaciente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosPaciente();
            }
            else
            {
                MessageBox.Show("Primer registro", "Registro de Pacientes");
            }
        }

        private void btnPrimeroPaciente_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosPaciente();
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            if (btnNuevoPaciente.Text == "Nuevo")
            {
                btnNuevoPaciente.Text = "Guardar";
                btnModificarPaciente.Text = "Cancelar";
                estadoControles(false);
                limpiarCajas();
                accion = "nuevo";
            }
            else
            {//Guardar
                String[] pacientes = new string[] {
            accion, txtCodigoPaciente.Text, txtNombrePaciente.Text, txtDireccionPaciente.Text, txtTelefonoPaciente.Text,
            miTablaPacientes.Rows[posicion].ItemArray[0].ToString()
        };
                String msg = objConexion.mantenimientoPacientes(pacientes);
                if (msg != "1")
                {
                    MessageBox.Show("Error en el registro de pacientes: " + msg, "Registro de Pacientes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizarDsPacientes();
                    estadoControles(true);
                    btnNuevoPaciente.Text = "Nuevo";
                    btnModificarPaciente.Text = "Modificar";
                }
            }
        }



        private void txtNombrePaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblnRegistroPaciente_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistroPaciente_Click(object sender, EventArgs e)
        {

        }

        
    }
}
