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
    public partial class Form1 : Form
    {
        long  chislo, stepen, mod;
        public Form1()
        {
            InitializeComponent();
        }
        Vozvedenie_v_stepen Vozvedeniye;
        Shanks Shanks;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            chislo = Convert.ToInt64(textBox1.Text);                //a
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            mod = Convert.ToInt64(textBox3.Text);                  //p(модуль)
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Vozvedeniye = new Vozvedenie_v_stepen(chislo, stepen, mod);
            //label2.Text = Convert.ToString((Vozvedeniye.result));
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shanks shanks = new Shanks();
            x.Text = Convert.ToString(shanks.Rezultat(Convert.ToInt32(a.Text),Convert.ToInt32(b.Text),Convert.ToInt32(Znacheniye_MOD.Text)));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            Hide();
            frm.Show();
        }

        private void Rsa_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            Hide();
            frm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            stepen = Convert.ToInt64(textBox2.Text);        //x
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vozvedeniye = new Vozvedenie_v_stepen(chislo, stepen, mod);
            label1.Text = Vozvedeniye.Vivod_massiva(Vozvedeniye.tablica);
            Rezi.Text = Convert.ToString(Vozvedeniye.Podschet(Convert.ToInt64(textBox1.Text),Convert.ToInt64(textBox2.Text),Convert.ToInt64(textBox3.Text)));
            //Shanks = new Shanks();
            //Shanks.Bolshoy_shag(Convert.ToInt32(Znacheniye_MOD.Text));
            //Shanks.Predvichisleniya(Convert.ToInt32(a.Text));




        }


    }
}
