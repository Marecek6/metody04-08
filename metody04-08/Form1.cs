using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metody04_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            double Mocnina = CelaCisla.mocnina(a, b);
            MessageBox.Show("mocnina techto dvou cisel je " + Mocnina);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int Faktorial = CelaCisla.faktorial(a);
            MessageBox.Show("faktorial a " + Faktorial);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int soucet = CelaCisla.cifsouc(a);
            MessageBox.Show("ciferny soucet lich " + soucet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            if (CelaCisla.prvocislo(a))
            {
                MessageBox.Show("je prvocislo");
            }
            else
            {
                MessageBox.Show("neni prvocislo");
            }
        }
    }
}
