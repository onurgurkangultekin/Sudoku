using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Sudoku
{
    class Zaman : Label
    {
        private int saat;

        public int SAAT
        {
            get { return saat; }
            set { saat = value; }
        }
        private int dakika;

        public int DAKIKA
        {
            get { return dakika; }
            set { dakika = value; }
        }
        private int saniye;

        public int SANIYE
        {
            get { return saniye; }
            set { saniye = value; }
        }

        public Zaman()
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.AliceBlue;
            this.Font = new Font("arial", 12, FontStyle.Bold);
            this.Text = "00 : 00 : 00";
            Sifirla();
        }

        public void Sifirla()
        {
            this.Text = "00 : 00 : 00";
            this.SAAT = 0;
            this.SANIYE = 0;
            this.DAKIKA = 0;
        }

    }
}
