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
            DataTable miTablaPacientes = new DataTable();
            public int posicion = 0;
            String accion = "nuevo";

        public GestionPacientes()
        {
            InitializeComponent();
        }
        private void GestionPacientes_Load(object sender, EventArgs e)
        {

            this.gestionPacientesTableAdapter.Fill(this.db_clinicaDataSet.GestionPacientes);

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
    }
}
