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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Knopka_dlya_vivoda_Click(object sender, EventArgs e)
        {
            Polig_Hellman phl = new Polig_Hellman();
            phl.ogranicheniya = Convert.ToInt64(Ogran.Text);
            X.Text = Convert.ToString(phl.sborshik(Convert.ToInt64(A.Text), Convert.ToInt64(B.Text), Convert.ToInt64(Mod.Text)));
        }

        private void A_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
