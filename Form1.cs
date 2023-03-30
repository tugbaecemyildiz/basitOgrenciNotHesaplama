using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciBilgiSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi, sifre;
            kadi = textBox1.Text;
            sifre = textBox2.Text;
            if (kadi == "admin" && sifre == "123") 
            {
                MessageBox.Show("Hoşgeldiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ogrenciBilgileri frm = new ogrenciBilgileri();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Girişi Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
            }
        }  
    }
}
