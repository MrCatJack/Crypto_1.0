using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptologia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Zashifr_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA(Convert.ToInt64(textBox1.Text),Convert.ToInt64(textBox2.Text));
            rsa.Nahojdeniye_E();
            textBox6.Text = Convert.ToString(rsa.e+" , " +rsa.n);
            textBox4.Text = rsa.Encrypt(textBox3.Text);
            rsa.Secret_Gay();
            Zakritiy_kluch.Text = Convert.ToString(rsa.d + " , " + rsa.n);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rashifrovat_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA(Convert.ToInt64(textBox1.Text), Convert.ToInt64(textBox2.Text));
            rsa.Nahojdeniye_E();
            rsa.Secret_Gay();
            textBox5.Text = rsa.decrypt(textBox4.Text);
        }
    }
}
