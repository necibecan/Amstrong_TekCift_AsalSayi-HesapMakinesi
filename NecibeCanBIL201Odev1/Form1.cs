using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace NecibeCanBIL201Odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> asalSayilar = new List<int>();
        List<int> armstrongSayilar = new List<int>();

        private void geri_Click(object sender, EventArgs e)
        {
            if (islemler.SelectedIndex != 0)
            {
                islemler.SelectedIndex -= 1;
            }
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            if (islemler.SelectedIndex != 3)
            {
                islemler.SelectedIndex += 1;
            }
        }

        List<int> TekCiftSayi(int islemTipi)
        {
            List<int> tekSayilar = new List<int>();
            List<int> ciftSayilar = new List<int>();
            for (int i = Convert.ToInt32(baslangicTxt.Text); i < Convert.ToInt32(bitisTxt.Text); i++)
            {
                if (i%2 == 0)
                {
                    ciftSayilar.Add(i);
                }
                else
                {
                    tekSayilar.Add(i);
                }
            }
            if (islemTipi==1)
            {
                return ciftSayilar;   
            }
            else
            {
                return tekSayilar;
            }
        }
        void AsalSayi()
        {
            asalSayilar.Clear();
            bool asalKontrolu = true;
            for (int i = Convert.ToInt32(baslangicTxt.Text); i < Convert.ToInt32(bitisTxt.Text); i++)
            {
                for (int j = 2; j < i; j++)
                    if (i % j == 0)
                    {
                        asalKontrolu = false;
                        break;
                    }
                if (asalKontrolu)
                {
                    asalSayilar.Add(i);
                }
                asalKontrolu = true;
            }

        }
        void ArmstrongSayi()
        {
            armstrongSayilar.Clear();
            int toplam;
            int ilkBasamak;
            int mod;
            int ikinciBasamak;
            int ucuncuBasamak;
            for (int i = Convert.ToInt32(baslangicTxt.Text); i < Convert.ToInt32(bitisTxt.Text); i++)
            {
                ucuncuBasamak = i / 100;
                mod = i % 100;
                ikinciBasamak = mod / 10;
                ilkBasamak = mod % 10;
                toplam = ilkBasamak * ilkBasamak * ilkBasamak + ikinciBasamak * ikinciBasamak * ikinciBasamak + ucuncuBasamak * ucuncuBasamak * ucuncuBasamak;
                if (i == toplam)
                {
                    armstrongSayilar.Add(i);
                }

            }
        }
        int Toplam(List<int> toplanacaklar)
        {
            int toplam = 0;
            for (int i = 0; i < toplanacaklar.Count; i++)
                toplam += toplanacaklar[i];

            return toplam;
        }

        int Carpim(List<int> carpilacaklar)
        {
            int carpim = 1;

            for (int i = 0; i < carpilacaklar.Count; i++)
                carpim *= carpilacaklar[i];

            return carpim;
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(baslangicTxt.Text) > Convert.ToInt32(bitisTxt.Text) || Convert.ToInt32(bitisTxt.Text) > 10000)
            {
                MessageBox.Show("Yanlış değer girdiniz!!");
            }
            else
            {

                switch (islemler.SelectedIndex)
                {
                    case 0:
                        tekSayiListe.Items.Clear();
                        List<int> tekSayilar = TekCiftSayi(0);
                        foreach (int sayi in tekSayilar)
                        {
                            tekSayiListe.Items.Add(sayi.ToString());
                        }

                        tekSayiListe.Items.Add("Toplam: " + Toplam(tekSayilar).ToString());
                        tekSayiListe.Items.Add("Çarpım: " + Carpim(tekSayilar).ToString());
                        break;
                    case 1:
                        ciftSayiListe.Items.Clear();
                        List<int> ciftSayilar = TekCiftSayi(1);
                        foreach (int sayi in ciftSayilar)
                        {
                            ciftSayiListe.Items.Add(sayi.ToString());
                        }

                        ciftSayiListe.Items.Add("Toplam: " + Toplam(ciftSayilar).ToString());
                        ciftSayiListe.Items.Add("Çarpım: " + Carpim(ciftSayilar).ToString());
                        break;
                    case 2:
                        asalSayiListe.Items.Clear();
                        AsalSayi();
                        foreach (int sayi in asalSayilar)
                        {
                            asalSayiListe.Items.Add(sayi.ToString());
                        }

                        asalSayiListe.Items.Add("Toplam: " + Toplam(asalSayilar).ToString());
                        asalSayiListe.Items.Add("Çarpım: " + Carpim(asalSayilar).ToString());
                        break;
                    case 3:
                        armstrongListe.Items.Clear();
                        ArmstrongSayi();
                        foreach (int sayi in armstrongSayilar)
                        {
                            armstrongListe.Items.Add(sayi.ToString());
                        }

                        armstrongListe.Items.Add("Toplam: " + Toplam(armstrongSayilar).ToString());
                        armstrongListe.Items.Add("Çarpım: " + Carpim(armstrongSayilar).ToString());
                        break;
                    default:
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            islemler.SelectTab(ConfigurationManager.AppSettings["islem_tipi"]);
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(30000);
        }
    }
}
