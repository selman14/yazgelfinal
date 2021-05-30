using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
namespace kartoyunu
{
    public partial class Form1 : Form
    {

        SoundPlayer player = new SoundPlayer();
        Image[] resimler = { Image.FromFile("bitki/1.png"), Image.FromFile("bitki/2.png"), Image.FromFile("bitki/3.png"), Image.FromFile("bitki/4.png"), Image.FromFile("bitki/5.png") };
        int[] indisler = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4 };
        PictureBox ilkkutu;
        int iindeks, bulunan, deneme,kareno2,kareno;
        int sayac=0,s=0;
        PictureBox[] boxlar = { null, null, null, null, null, null, null, null, null, null};
        PictureBox[] boxlar2 = { null, null, null, null, null, null, null, null, null, null };
        bool kosul = true;
        public static string isim;
        public Form1()
        {
            InitializeComponent();
            

            

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void resimlerikaristir(PictureBox[] boxlar)
        { //yer değiştirme işlemi yapıldı. Resimler karıstırıldı
            Random r = new Random();
            for (int i = 0; i < indisler.Length; i++)
            {
                int s = r.Next(10);
                int t = indisler[i];
                indisler[i] = indisler[s];
                indisler[s] = t;


            }
            for (int i = 0; i < indisler.Length; i++)
            {
                boxlar[i].Image = resimler[indisler[i]];

            }
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox[] boxlar1 = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };
            boxlar = boxlar1;
            PictureBox[] boxlar3 = { pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
            boxlar2 = boxlar3;
            resimlerikaristir(boxlar);
            timer1.Start();
            
            for (int i = 0; i < boxlar2.Length; i++)
            {
                boxlar2[i].Visible = false;
            }
            
           




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < boxlar.Length; i++)
            {
                boxlar[i].Enabled = false;
            }
            sayac += 1;
            if (sayac==3)
            {
                for (int i = 0; i < 10; i++)
                {
                    boxlar[i].Image = Image.FromFile("desen.jpg");

                }
                timer1.Stop();
                timer2.Start();
                for (int i = 0; i < boxlar.Length; i++)
                {
                    boxlar[i].Enabled = true;
                }
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bitis.puan = "TOPLAM PUAN: " + puan_lbl.Text;
            bitis.sure = "KALAN SÜRE: " + sure_lbl.Text;
            bitis.baslik = "OYUNDAN ÇIKTINIZ";
            bitis.seviye = "Kolay";
            this.Close();
            bitis.isim = isim;
            bitis bts = new bitis();
            bts.Show();
            
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            s++;
            for (int i = 0; i < boxlar.Length; i++)
            {
                boxlar[i].Enabled = false;
            }
            if (s==3)
            {
                if (kosul)
                {
                    boxlar[kareno - 1].Visible = false;
                    boxlar[kareno2 - 1].Visible = false;
                }
                else
                {
                    boxlar2[kareno - 1].Visible = false;
                    boxlar2[kareno2 - 1].Visible = false;
                    boxlar[kareno - 1].Image = Image.FromFile("desen.jpg");
                    boxlar[kareno2 - 1].Image = Image.FromFile("desen.jpg");
                }
            
                s = 0;
                timer3.Stop();
                for (int i = 0; i < boxlar.Length; i++)
                {
                    boxlar[i].Enabled = true;
                }
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int sure1=int.Parse(sure_lbl.Text);
            sure1--;
            sure_lbl.Text = sure1.ToString();
            if (sure1==0)
            {
                timer2.Stop();
                sure_lbl.Text = "00";
                player.SoundLocation = "muzik/gameover.wav";
                player.Play();
                bitis.puan = "TOPLAM PUAN: " + puan_lbl.Text;
                bitis.sure = "KALAN SÜRE: " + sure_lbl.Text;
                bitis.baslik = "SÜRE BİTTİ";
                bitis.isim = isim;
                bitis.seviye = "Kolay";
                this.Close();
                bitis bts = new bitis();
                bts.Show();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox kare = (PictureBox)sender;
            bunifuTransition1.HideSync(kare);
            kareno = int.Parse(kare.Name.Substring(10));
            int indeksno = indisler[kareno - 1];
            kare.Image = resimler[indeksno];
            kare.Refresh();
            bunifuTransition1.ShowSync(kare);
            if (ilkkutu == null)
            {
                ilkkutu = kare;
                iindeks = indeksno;
                kareno2 = kareno;
                deneme++;
            }
            else
            {
                
                if (iindeks == indeksno)
                {
                    if(kareno != kareno2)
                    {
                        boxlar2[kareno - 1].Visible = true;
                    boxlar[kareno-1].Controls.Add(boxlar2[kareno-1]);
                    boxlar2[kareno - 1].Location = new Point(0, 0);
                    boxlar2[kareno - 1].BackColor = Color.Transparent;
                    boxlar2[kareno - 1].Image = Image.FromFile("tik.png");
                    boxlar2[kareno2 - 1].Visible = true;
                    boxlar[kareno2 - 1].Controls.Add(boxlar2[kareno2 - 1]);
                    boxlar2[kareno2 - 1].Location = new Point(0, 0);
                    boxlar2[kareno2 - 1].BackColor = Color.Transparent;
                    boxlar2[kareno2 - 1].Image = Image.FromFile("tik.png");
                    player.SoundLocation = "muzik/dogru.wav";
                    player.Play();
                    puan_lbl.Text = (int.Parse(puan_lbl.Text) + 20).ToString();
                    bulunan++;
                        bunifuTransition2.HideSync(kare);
                        bunifuTransition2.HideSync(ilkkutu);
                        kosul = true;
                    timer3.Start();
                    if (bulunan == 5)
                    {
                        player.SoundLocation = "muzik/win.wav";
                        player.Play();
                        MessageBox.Show("Tebrikler " + " " + deneme + " denemede buldunuz puanınız "+puan_lbl.Text+" kalan süreniz "+sure_lbl.Text);
                            bitis.puan = "TOPLAM PUAN: "+puan_lbl.Text;
                            bitis.sure = "KALAN SÜRE: "+sure_lbl.Text;
                            bitis.baslik = "OYUN BİTTİ";
                            bitis.isim = isim;
                            bitis.seviye = "Kolay";
                            this.Close();
                            bitis bts = new bitis();
                            bts.Show();
                        bulunan = 0;
                        deneme = 0;
                        foreach (Control kontrol in Controls)
                        {
                            kontrol.Visible = true;
                        }


                    }
                        ilkkutu = null;
                    }
                    

                }
                
                else
                {

                    boxlar2[kareno - 1].Visible = true;
                    boxlar[kareno - 1].Controls.Add(boxlar2[kareno - 1]);
                    boxlar2[kareno - 1].Location = new Point(0, 0);
                    boxlar2[kareno - 1].BackColor = Color.Transparent;
                    boxlar2[kareno - 1].Image = Image.FromFile("carpi.png");
                    boxlar2[kareno2 - 1].Visible = true;
                    boxlar[kareno2 - 1].Controls.Add(boxlar2[kareno2 - 1]);
                    boxlar2[kareno2 - 1].Location = new Point(0, 0);
                    boxlar2[kareno2 - 1].BackColor = Color.Transparent;
                    boxlar2[kareno2 - 1].Image = Image.FromFile("carpi.png");
                    kosul = false;
                    
                   
                    player.SoundLocation = "muzik/yanlis.wav";
                    player.Play();
                    puan_lbl.Text = (int.Parse(puan_lbl.Text)-5).ToString();
                    timer3.Start();
                    ilkkutu = null;
                }
                
            }

        }
    }
}