using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a, b;
            double toplam, fark, carpim, bolum;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            toplam = a + b;
            fark = a - b;
            carpim = a * b;
            bolum = a / b;

            Lbtoplam.Text = toplam.ToString();
            Lblfark.Text = fark.ToString();
            Lblcarpim.Text = carpim.ToString();
            Lblbolum.Text = bolum.ToString();
        }
    }
}
