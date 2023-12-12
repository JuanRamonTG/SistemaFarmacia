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

            actualizarDsPacientes();
            cboOpcionBuscarPacientes.SelectedIndex = 1;
        }

        private void actualizarDsPacientes()
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            miTabla = miDs.Tables["GestionPacientes"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idPacientes"] };
            mostrarPacientes();
            mostrarDatosPacientes();
        }

        private void mostrarPacientes()
        {

            grdGestionPacientes.DataSource = miTabla.DefaultView;
        }

        private void filtrarPacientes(String valor, int opcion)
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
                erpPacientes.SetError(txtBuscarPacientes, "Por favor ingrese un codigo o nombre del paciente a buscar");
            }
        }

        private void mostrarDatosPacientes()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtCodigoPaciente.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtNombrePaciente.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtDireccionPaciente.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtTelefonoPaciente.Text = miTabla.Rows[posicion].ItemArray[4].ToString();

                lblRegistroPaciente.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
            else
            {
                limpiarCajas();
            }

        }

        private void btnSiguientePacientes_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosPacientes();
            }
            else
            {
                MessageBox.Show("Ultimo Registro", "Registro de Materias");
            }
        }

        private void btnUltimoPaciente_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosPacientes();
        }

        private void btnAnteriorPaciente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosPacientes();
            }
            else
            {
                MessageBox.Show("Primer regisro", "Registro de Materias");
            }
        }

        private void btnPrimeroPaciente_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosPacientes();
        }

        private void btnNuevoMateria_Click(object sender, EventArgs e)
        {
            if (btnNuevoPaciente.Text == "Nuevo")
            {
                btnNuevoPaciente.Text = "Guardar";
                btnNuevoPaciente.Text = "Cancelar";
                estadoControles(false);
                limpiarCajas();
                accion = "nuevo";
            }
            else
            {//Guardar
                String[] materias = new string[] {
                    accion,txtCodigoMateria.Text, txtNombreMateria.Text, txtUvMateria.Text,
                    miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String msg = objConexion.mantenimientoMaterias(materias);
                if (msg != "1")
                {
                    MessageBox.Show("Error en el registro de materias: " + msg, "Registro de Materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizarDsMaterias();
                    estadoControles(true);
                    btnNuevoMateria.Text = "Nuevo";
                    btnModificarMateria.Text = "Modificar";
                }
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
