using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        
        /*
         * 1. Rastgele bir kelime seç +
         * 2. Seçilen kelime kadar * işareti koy. +
         * 3. Kullanıcı harf girer. +
         * 4 a. Harf yoksa, "harf yok" der. Haktan 1 düşer. (Asılan adamın çizimi başlar) +
         * 4 b. Harf varsa * yerine harfi koy.  Örnek: adana a harfi için a*a*a 
         * 5 3. Adım, kelime bilinene ya da adam asılana dek devam eder.
         */
        public Form1()
        {
            InitializeComponent();
        }

        int kalanHak = 0;
        string secilenKelime = string.Empty;
        char[] bulmaca;
        string rastgeleKelimeSec()
        {
            string[] kelimeler = { "araba", "yugoslavya", "dürümbüs", "bitcoin" };
            Random random = new Random();
            int rastgeleSayi = random.Next(0, kelimeler.Length);
            string rastgeleKelime = kelimeler[rastgeleSayi];
            return rastgeleKelime;

        }

        private void buttonSec_Click(object sender, EventArgs e)
        {
            secilenKelime = rastgeleKelimeSec();
            bulmaca = yildizlaraDonustur(secilenKelime);
            ekranaYaz(bulmaca);
            /*
             * araba
             * *****
             * a*a*a
             */
        }

        char[] yildizlaraDonustur(string secilenKelime)
        {
            char[] harfler = new char[secilenKelime.Length];
            for (int i = 0; i < harfler.Length; i++)
            {
                harfler[i] = '*';
            }
            return harfler;

        }
        
        void ekranaYaz(char[] gizliKelime)
        {
            string sonuc = "";
            foreach (char item in gizliKelime)
            {
                sonuc += item.ToString();
            }
            labelYildiz.Text = sonuc;
        }

        private void buttonTahmin_Click(object sender, EventArgs e)
        {
            if (secilenKelimedeHarfVarmi(secilenKelime,textBoxHarf.Text))
            {
                harfinYerleriniBul(Convert.ToChar(textBoxHarf.Text));
                ekranaYaz(bulmaca);
            }
            else
            {
                kalanHak++;
                pictureBoxAdam.Image = Image.FromFile(Application.StartupPath +"/../../images/a" + kalanHak + ".png");
                labelKalanHak.Text = kalanHak.ToString();
                if (kalanHak == 10)
                {
                    MessageBox.Show("kaybettiniz!");
                    buttonTahmin.Enabled = false;
                }
                MessageBox.Show("aradığınız kelime yok!");
            }
        }
        bool secilenKelimedeHarfVarmi(string kelime, string harf)
        {
            return kelime.Contains(harf);
        }

        void harfinYerleriniBul(char harf)
        {
            int baslangic = 0;
            while (secilenKelime.IndexOf(harf,baslangic)!=-1)
            {
                baslangic = secilenKelime.IndexOf(harf, baslangic);
                bulmaca[baslangic] = harf;
                baslangic++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelKalanHak.Text = kalanHak.ToString();
        }
    }
}
