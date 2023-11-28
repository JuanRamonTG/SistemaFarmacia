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
                grdDatosPacientes.DataSource = miTablaPacientes.DefaultView;
            }

            private void filtrarPacientes(String valor, int opcion)
            {
                try
                {
                    BindingSource bsPacientes = new BindingSource();
                    bsPacientes.DataSource = grdDatosPacientes.DataSource;
                    bsPacientes.Filter = opcion == 0 ? "codigo=" + valor : "nombre like '%" + valor + "%'";
                    grdDatosPacientes.DataSource = bsPacientes;
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

                    lblnRegistroPaciente.Text = (posicion + 1) + " de " + miTablaPacientes.Rows.Count;
                }
                else
                {
                    limpiarCajas();
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
