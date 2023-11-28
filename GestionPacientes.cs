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
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();
        public int posicion = 0;
        String accion = "nuevo";
        public GestionPacientes()
        {
            InitializeComponent();
        }

        
        private void GestionPacientes_Load(object sender, EventArgs e)
        {

            this.gestionPacientesTableAdapter.Fill(this.db_clinicaDataSet.GestionPacientes);
            actualizarDsPacientes();
            cboOpcionBuscarPacientes.SelectedIndex = 1;
        }

        private void actualizarDsPacientes()
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            miTabla = miDs.Tables["alumnos"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idPaciente"] };
            mostrarPacientes();
            mostrarDatosPacientes();
        }

        private void mostrarPacientes()
        {

            grdGestionPacientes.DataSource = miTabla.DefaultView;
        }

        private void filtrarAlumnos(String valor, int opcion)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = grdGestionPacientes.DataSource;
                bs.Filter = opcion == 0 ? "codigo=" + valor : "nombre like '%" + valor + "%'";
                grdGestionPacientes.DataSource = bs;
                erpPacientes.SetError(txtBuscarPacientes, "");
            }
            catch (Exception e)
            {
                erpPacientes.SetError(txtBuscarPacientes, "Por favor ingrese un codigo o nombre del estudiante a buscr");
            }
        }



        private void estadoControles(Boolean estado)
        {
            txtCodigoPaciente.ReadOnly = estado;
            txtNombrePaciente.ReadOnly = estado;
            txtDireccionPaciente.ReadOnly = estado;
            txtTelefonoPaciente.ReadOnly = estado;

            grbNavegacionPaciente.Enabled = estado;
            btnEliminarPaciente.Enabled = estado;
            txtBuscarPacientes.ReadOnly = !estado;
        }

        private void limpiarCajas()
        {
            txtCodigoPaciente.Text = "";
            txtNombrePaciente.Text = "";
            txtDireccionPaciente.Text = "";
            txtTelefonoPaciente.Text = "";
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

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEliminarPaciente_Click_1(object sender, EventArgs e)
        {  



        }

        private void txtBuscarPacientes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
