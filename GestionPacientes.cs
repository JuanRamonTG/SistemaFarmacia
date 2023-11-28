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

        private void txtNombrePaciente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
