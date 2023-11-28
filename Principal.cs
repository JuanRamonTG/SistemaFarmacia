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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GestionPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPacientes objGestionPacientes = new GestionPacientes ();
            objGestionPacientes.MdiParent = this;
            objGestionPacientes.Show();
        }

        private void GestionEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPacientes objGestionPacientes = new GestionPacientes();
            objGestionPacientes.MdiParent = this;
            objGestionPacientes.Show();
        }

        private void ResultadoDeAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPacientes objGestionPacientes = new GestionPacientes();
            objGestionPacientes.MdiParent = this;
            objGestionPacientes.Show();
        }

        private void InventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPacientes objGestionPacientes = new GestionPacientes();
            objGestionPacientes.MdiParent = this;
            objGestionPacientes.Show();
        }

        private void DocumentaciónClínicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPacientes objGestionPacientes = new GestionPacientes();
            objGestionPacientes.MdiParent = this;
            objGestionPacientes.Show();
        }
    }
}
