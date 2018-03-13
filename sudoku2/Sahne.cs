using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Sudoku
{
    public class Sahne
    {
        public Kolon[,] kolon = new Kolon[9, 9];
        SayiGir sayiGir;
        Oyun oyun;
        
        public Sahne()
        {
            sayiGir = new SayiGir(kolon);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    kolon[i, j] = new Kolon();
                    kolon[i, j].Click += new EventHandler(Sahne_Click);
                }
            }
        }

        public void OyunAl(Oyun oyun)
        {
            this.oyun = oyun;
        }
        void Sahne_Click(object sender, EventArgs e)
        {
            if (oyun != null)
            {
                sayiGir.ButonAl(sender); // üzerine basılan butonu sayı girebilmek için sayi gir sınıfına gönderiyoruz.
                sayiGir.ShowDialog();
            }
        }

        public void ArayuzYukle(System.Windows.Forms.Form form)
        {
            
            int x = 10;
            int y = 10;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    kolon[i, j].Location = new Point(x, y);
                    if (j == 2 || j == 5)
                        x += 55;
                    else
                        x += 50;
                    form.Controls.Add(kolon[i, j]);
                }
                if (i == 2 || i == 5)
                    y += 55;
                else
                    y += 50;
                x = 10;
            }
        }
    }
}
