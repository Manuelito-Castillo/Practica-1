using System;
using System.Windows.Forms;

namespace proyectoEVALUACION2ManuelCastillo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double notaact1;
        double notaact2;
        double notaact3;
        double promediodeactividades;

        double notalab1;
        double notalab2;
        double notalab3;
        double promediodelaboratorios;

        double promediofinal;
        string consejo1;
        string consejo2;
        string consejo3;
        string consejo4;
        private void button1_Click(object sender, EventArgs e)
        {
            notaact1 = Convert.ToDouble(textBox1.Text);
            notaact2 = Convert.ToDouble(textBox2.Text);
            notaact3 = Convert.ToDouble(textBox3.Text);
            promediodeactividades = ((notaact1 + notaact2 + notaact3)/3);

            notalab1 = Convert.ToDouble(textBox4.Text);
            notalab2 = Convert.ToDouble(textBox5.Text);
            notalab3 = Convert.ToDouble(textBox6.Text);
            promediodelaboratorios = ((notalab1 + notalab2 + notalab3)/3);

            promediofinal = ((promediodeactividades + promediodelaboratorios)/2);

            textBox7.Text = "" + Convert.ToDouble(promediofinal);

            consejo1 = "Debe empezar a poner más de su parte si no reprobará la materia.";
            consejo2 = "Necesita poner más empeño y ser más perseverante en sus estudios.";
            consejo3 = "Muy bien, lo felicito, pero necesita mejorar su promedio en las siguientes actividades.";
            consejo4 = "Muchas felicidades, siga así.";

            if (promediofinal <= 2.99)
            {
               textBox8.Text = consejo1.ToString();
                pictureBox1.Visible = true;
;            }
            else if (promediofinal>=3.0 && promediofinal <= 5.99)
            {
                textBox8.Text = consejo2.ToString();
                pictureBox2.Visible = true;
            }
            else if(promediofinal>=6.0 && promediofinal<=6.99)
            {
                textBox8.Text = consejo3.ToString();
                pictureBox3.Visible = true;
            }
            else
            {
                textBox8.Text = consejo4.ToString();
                pictureBox4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            pictureBox1.Visible = false;
        }
    }
}
