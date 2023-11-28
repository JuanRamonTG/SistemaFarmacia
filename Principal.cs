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
            GestionEmpleados objGestionEmpleados = new GestionEmpleados();
            objGestionEmpleados.MdiParent = this;
            objGestionEmpleados.Show();
        }

        private void ResultadoDeAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultadoDeAnalisis objResultadoDeAnalisis = new ResultadoDeAnalisis();
            objResultadoDeAnalisis.MdiParent = this;
            objResultadoDeAnalisis.Show();
        }

        private void InventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario objInventario = new Inventario();
            objInventario.MdiParent = this;
            objInventario.Show();
        }

        private void DocumentaciónClínicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentaciónClínica objDocumentaciónClínica = new DocumentaciónClínica();
            objDocumentaciónClínica.MdiParent = this;
            objDocumentaciónClínica.Show();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            inicio objinicio = new inicio();
            objinicio.MdiParent = this;
            objinicio.Show();
        }
    }
    
}
