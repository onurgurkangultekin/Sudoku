using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Sudoku
{
    public class Oyun
    {
        static int oncekiSayi=-1;

        int[,] soru = new int[9, 9];

        int[,] oyun = new int[9, 9];

        public Oyun(String zorluk)
        {
            OyunYukle(zorluk);
        }



        private void OyunYukle(string zorluk)
        {

            StreamReader dosyaOku;
            Random rasgele = new Random();
            int sayi = rasgele.Next(6);

            if (oncekiSayi == sayi)
                sayi = rasgele.Next(6);

            dosyaOku = new StreamReader(zorluk + "/oyun" + sayi + ".txt");
            oncekiSayi=sayi;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    oyun[i, j] = Convert.ToInt32(((char)dosyaOku.Read()).ToString());
                }
            }
            dosyaOku.Close();

            dosyaOku = new StreamReader( zorluk + "/oyun" + sayi + "baslat.txt");

            while (!dosyaOku.EndOfStream)
            {
                int i = Convert.ToInt32(((char)dosyaOku.Read()).ToString()); // burda çekiyo dosyadan
                int j = Convert.ToInt32(((char)dosyaOku.Read()).ToString());
                soru[i, j] = oyun[i, j];
            }
        }

        public void butonlaraOyunuYukle(Kolon[,] kolon)
        {
            
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    kolon[i, j].Text = "";
                    kolon[i, j].BackColor = System.Drawing.Color.AliceBlue;
                    kolon[i, j].Enabled = true;
                }
            }
            
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (soru[i, j] != 0)
                    {
                        kolon[i, j].Text = oyun[i, j].ToString();
                        kolon[i, j].Enabled = false;
                        kolon[i,j].BackColor=System.Drawing.Color.Gray;
                    }
                }
            }
        }

        public void cevaplariYukle(Kolon[,] kolon)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                        kolon[i, j].Text = oyun[i, j].ToString();
                }
            }
        }

        public void KontrolEt(Kolon[,] kolon)
        {
            bool sonuc = true;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (kolon[i, j].Text != oyun[i, j].ToString())
                    {
                        kolon[i, j].BackColor = System.Drawing.Color.Red;
                        sonuc = false;
                    }
                    else if(soru[i,j]==0)
                        kolon[i, j].BackColor = System.Drawing.Color.Aqua;
                }
            }

            if (!sonuc)
            {
                System.Windows.Forms.MessageBox.Show("hatalı girişler var...", "Sonuçlar", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if(soru[i, j]!=oyun[i,j])
                            kolon[i, j].BackColor = System.Drawing.Color.AliceBlue;
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Tebrikler kazandınız !!!", "Sonuçlar", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

            }
        }

    }
}