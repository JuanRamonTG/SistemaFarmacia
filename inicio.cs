using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaFarmacia
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = "Ram";
            string clave = "1234";

            if (txtusuario.Text == usuario || (txtclave.Text == clave))
            {

                Principal fprincipal = new Principal();
                fprincipal.Show();
                this.Hide();
            }
        }
    }
}
