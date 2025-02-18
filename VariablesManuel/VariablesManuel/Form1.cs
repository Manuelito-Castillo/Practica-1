using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesManuel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double majonchoCost;
        int CantidadMajonchos;
        double totalMajonchocost;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            majonchoCost = Convert.ToDouble(textBox2.Text);
            CantidadMajonchos = Convert.ToInt32(textBox1.Text);
            totalMajonchocost = CantidadMajonchos * majonchoCost;
            textBox3.Text = totalMajonchocost.ToString();
        }
    }
}
