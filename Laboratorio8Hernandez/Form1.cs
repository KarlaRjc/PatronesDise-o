using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio8Hernandez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdapterDiseño form2 = new AdapterDiseño();

            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Compuesto c = new Compuesto("Cualquiera"); //Compuesto solo, no adapto
            c.Mostrar();

            Compuesto agua = new CompuestoCompleto("Agua"); //Acá adapto a agua
            agua.Mostrar();

        }
    }
}
