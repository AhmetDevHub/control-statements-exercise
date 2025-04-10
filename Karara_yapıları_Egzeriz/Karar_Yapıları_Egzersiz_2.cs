using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karara_yapıları_Egzeriz
{
    public partial class Karar_Yapıları_Egzersiz_2 : Form
    {
        public Karar_Yapıları_Egzersiz_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt16(textBox1.Text);
            if (kitapadet >= 0 && kitapadet <= 20)
            {
                toplam = (kitapadet * 100) - (kitapadet * 100 * 20 / 100);
                label3.Text = toplam + "TL";
            }
            if (kitapadet >= 21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 100) - (kitapadet * 100 * 40 / 100);
                label3.Text = toplam + "TL";
            }
            if (kitapadet >= 41)
            {
                toplam = (kitapadet * 100) - (kitapadet * 100 * 50 / 100);
                label3.Text = toplam + "TL";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "";
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
// 0-20 ==> %20 indirirm
// 21-40 ==> %40
// 41++ ==> %50
// Kitap = 100TL