using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace Sudoku
{
    class SudokuFacade
    {
        Form SudokuForm;

        SureTut sure;
        Sahne sahne;
        Oyun oyun;
        ComboBox kombo; // oyun zorluğunu belirler

        //onur gürkan gültekin
        public SudokuFacade(Form f)
        {
            this.SudokuForm = f;
            PencereAyarla();
            sahne.ArayuzYukle(SudokuForm);
            //SudokuForm.Icon = kaynak.ikon;
        }

        private void PencereAyarla()
        {
            SudokuForm.Size = new Size(740, 560);
            SudokuForm.Text = "SUDOKU C# 2010";
            SudokuForm.FormBorderStyle = FormBorderStyle.Fixed3D;
            SudokuForm.MaximizeBox = false;
            SudokuForm.BackColor = Color.Black;
            SudokuForm.Font = new System.Drawing.Font("arial", 11, FontStyle.Bold);
            sahne = new Sahne();
            KomboAyarla();
            ButonlariAyarla();
            SaatEkle();
            //ResimEkle();
            IsimEkle();
        }

        private void IsimEkle()
        {
            Label isim = new Label();
            isim.Text = "Designed by Onur Gürkan GÜLTEKİN";
            isim.AutoSize = true;
            isim.Font = new Font("Matura MT Script Capitals", 15f, FontStyle.Italic);
            isim.ForeColor = Color.White;
            isim.BackColor = Color.Black;
            isim.Location = new Point(15, 480);
            SudokuForm.Controls.Add(isim);
        }

        private void ResimEkle()
        {
            Label resim = new Label();
            resim.Height = 150;
            resim.Width = 200;
            resim.Image = kaynak.c_;
            resim.Location = new Point(500, 350);
            SudokuForm.Controls.Add(resim);
        }

        private void SaatEkle()
        {
            Label sureBaslik = new Label();
            sureBaslik.Text = "Süre : ";
            sureBaslik.BackColor = Color.Black;
            sureBaslik.ForeColor = Color.White;
            sureBaslik.Font = new Font("arial", 12f, FontStyle.Bold);
            sureBaslik.Location = new Point(500, 300);
            SudokuForm.Controls.Add(sureBaslik);
            sure = new SureTut();
            sure.zaman.Location = new Point(500, 330);
            SudokuForm.Controls.Add(sure.zaman);
        }

        private void KomboAyarla()
        {
            Label zorluk = new Label();
            zorluk.Location = new Point(500, 20);
            zorluk.Text = "Zorluk Derecesi:";
            zorluk.AutoSize = true;
            zorluk.ForeColor = Color.AliceBlue;
            SudokuForm.Controls.Add(zorluk);

            kombo = new ComboBox();

            kombo.ForeColor = Color.AliceBlue;
            kombo.BackColor = Color.Black;
            kombo.Items.Add("kolay");
            kombo.Items.Add("normal");
            kombo.Items.Add("zor");
            kombo.SelectedItem = "kolay";
            kombo.Location = new Point(500, 45);
            SudokuForm.Controls.Add(kombo);
        }

        private void ButonlariAyarla()
        {
            MyButton yeniOyun = new MyButton(SudokuForm, "Yeni Oyun");
            yeniOyun.Location = new Point(500, 100);
            yeniOyun.Click += new EventHandler(yeniOyun_Click);

            MyButton cevapGoster = new MyButton(SudokuForm, "Cevaplar  ");
            cevapGoster.Location = new Point(500, 130);
            cevapGoster.Click += new EventHandler(cevapGoster_Click);

            MyButton kontrolEt = new MyButton(SudokuForm, "Kontrol Et");
            kontrolEt.Location = new Point(500, 160);
            kontrolEt.Click += new EventHandler(kontrolEt_Click);

            MyButton cikis = new MyButton(SudokuForm, "Çıkış         ");
            cikis.Location = new Point(500, 190);
            cikis.Click += new EventHandler(cikis_Click);

            MyButton hakkinda = new MyButton(SudokuForm, "Sudoku Hakkında");
            hakkinda.Location = new Point(500, 250);
            hakkinda.Click += new EventHandler(hakkinda_Click);
        }

        void hakkinda_Click(object sender, EventArgs e)
        {
            SudokuHakkinda hakkinda =new SudokuHakkinda();
        }

        void kontrolEt_Click(object sender, EventArgs e)
        {
            if (oyun != null)
            {
                oyun.KontrolEt(sahne.kolon);
            }
        }

        void cevapGoster_Click(object sender, EventArgs e)
        {
            
            DialogResult cevap = MessageBox.Show("Oyunu bitirip cevapları görmek istermisiniz ?", "Cevaplar",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes && oyun!=null)
            {
                oyun.cevaplariYukle(sahne.kolon);
                sure.Durdur();
                oyun = null;
                sahne.OyunAl(oyun);
            }
        }

        void yeniOyun_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Yeni oyun başlamak ister misiniz ?", "Yeni Oyun", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                sure.zaman.Sifirla();
                sure.Baslat();
                string zorluk = kombo.SelectedItem.ToString();
                oyun = new Oyun(zorluk);
                sahne.OyunAl(oyun);
                oyun.butonlaraOyunuYukle(sahne.kolon);
            }
        }

        void cikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Emin misiniz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}