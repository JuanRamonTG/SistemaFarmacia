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
    public partial class GestionEmpleados : Form
    {
        public GestionEmpleados()
        {
            InitializeComponent();
        }

        private void gestionPacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gestionPacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_clinicaDataSet);

        }

        private void GestionEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_clinicaDataSet.GestionEmpleados' Puede moverla o quitarla según sea necesario.
            this.gestionEmpleadosTableAdapter.Fill(this.db_clinicaDataSet.GestionEmpleados);
            // TODO: esta línea de código carga datos en la tabla 'db_clinicaDataSet.GestionPacientes' Puede moverla o quitarla según sea necesario.
            this.gestionPacientesTableAdapter.Fill(this.db_clinicaDataSet.GestionPacientes);

        }

        
    }
}
