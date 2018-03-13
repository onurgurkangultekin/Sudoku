using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    class SureTut : Timer
    {
        public Zaman zaman;

        public SureTut()
        {
            zaman = new Zaman();
            this.Interval = 1000;
            this.Tick += new EventHandler(SureTut_Tick);
            
        }

        void SureTut_Tick(object sender, EventArgs e)
        {
            zaman.SANIYE++;
            if (zaman.SANIYE == 60)
            {
                zaman.SANIYE = 0;
                zaman.DAKIKA++;

                if (zaman.DAKIKA == 60)
                {
                    zaman.DAKIKA = 0;
                    zaman.SAAT++;
                }
            }

            ZamanYenile();
        }

        private void ZamanYenile()
        {
            if (zaman.SAAT < 10)
                zaman.Text = "0" + zaman.SAAT.ToString() + " : ";
            else
                zaman.Text = zaman.SAAT.ToString() +" : ";

            if (zaman.DAKIKA < 10)
                zaman.Text += "0" + zaman.DAKIKA.ToString() + " : ";
            else
                zaman.Text += zaman.DAKIKA.ToString() + " : ";

            if(zaman.SANIYE<10)
                zaman.Text += "0" + zaman.SANIYE.ToString() + " : ";
            else
                zaman.Text += zaman.SANIYE.ToString();
        }

        public void Baslat()
        {
            this.Start();
        }

        public void Durdur()
        {
            this.Stop();
        }
    }
}
