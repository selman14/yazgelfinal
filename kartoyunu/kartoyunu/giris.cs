using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kartoyunu
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void baslik_lbl_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem=="Kolay")
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                Form1.isim = txt_isim.Text;
            }
            else if (comboBox1.SelectedItem == "Orta")
            {
                orta ort = new orta();
                ort.Show();
                orta.isim= txt_isim.Text;
            }
            else if (comboBox1.SelectedItem == "Zor")
            {
                zor zr = new zor();
                zr.Show();
                zor.isim = txt_isim.Text;
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
