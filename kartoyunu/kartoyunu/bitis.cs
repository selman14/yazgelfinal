using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
namespace kartoyunu
{
    public partial class bitis : Form
    {
        public static string baslik, puan, isim, sure,seviye;
        public void oku(string bilgi)
        {
            string dosya_yolu = @"./deneme.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            sw.WriteLine(bilgi);

            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (seviye == "Kolay")
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                Form1.isim = isim;
            }
            else if (seviye == "Orta")
            {
                orta ort = new orta();
                ort.Show();
                orta.isim = isim;
            }
            else if (seviye == "Zor")
            {
                zor zr = new zor();
                zr.Show();
                zor.isim = isim;
            }
            
            this.Close();
        }
        public bitis()
        {
            InitializeComponent();
        }

        private void baslik_lbl_Click(object sender, EventArgs e)
        {

        }

        private void bitis_Load(object sender, EventArgs e)
        {
            baslik_lbl.Text = baslik;
            isim_lbl.Text = isim;
            puan_lbl.Text = puan;
            sure_lbl.Text = sure;
            DateTime zaman = DateTime.Now;
            
            oku(isim + "-" + puan.Split(':')[1] + "-" + sure.Split(':')[1] + "-" + zaman.ToString() + "-" +seviye );
        }
    }
}
