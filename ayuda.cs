using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class ayuda : Form
    {
        public ayuda()
        {
            InitializeComponent();
        }
        private void ayuda_Load(object sender, EventArgs e)
        {


            StreamReader Archivo = new StreamReader("c:\\ayuda.txt");


            string Linea = "";


            ArrayList Contenido = new ArrayList();


            while (Linea != null)
            {
                Linea = Archivo.ReadLine();
                if (Linea != null)
                    Contenido.Add(Linea);
                texto.Text = Linea;
            }
            Archivo.Close();


            texto.Text = "";


            foreach (string Linea_mostrar in Contenido)
            {

                texto.Text = texto.Text + Linea_mostrar + "Strings.Chr(13)";
            }

        }
    }
}
