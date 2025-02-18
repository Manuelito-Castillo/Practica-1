using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEVALUACION1Manuel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cantidaddepupusas;
        double costodepupusas;
        int cantidaddebebidas;
        double costodelabebida;
        double total;
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cantidaddepupusas = Convert.ToInt32(textBox1.Text);
            costodepupusas = Convert.ToDouble(textBox2.Text);
            cantidaddebebidas = Convert.ToInt32(textBox3.Text);
            costodelabebida = Convert.ToDouble(textBox4.Text);

            total = ((cantidaddepupusas * costodepupusas) + (cantidaddebebidas * costodelabebida));
            textBox5.Text = total.ToString();
        }
    }
}
