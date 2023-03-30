using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciBilgiSistemi
{
    public partial class ogrenciBilgileri : Form
    {
        public ogrenciBilgileri()
        {
            InitializeComponent();
        }
        double not1, not2, not3, ort;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                not1 = Convert.ToDouble(textBox1.Text);
                not2 = Convert.ToDouble(textBox2.Text);
                not3 = Convert.ToDouble(textBox3.Text);
                ort = (not1 + not2 + not3) / 3;
                label4.Text = ort.ToString();

                if (ort >= 50)
                {
                    label5.BackColor = Color.Green;
                    label5.Text = "GEÇTİ";
                }
                else
                {
                    label5.BackColor = Color.Red;
                    label5.Text = "KALDI";
                }
            }  
            else
            {
                MessageBox.Show("Boş Bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
