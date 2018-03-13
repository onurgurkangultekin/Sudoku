using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SayiGir : Form
    {
        Kolon[] sayi=new Kolon[10];
        MyButton btnIptal;
        public Kolon[,] kolon;

        Kolon k;

        public SayiGir(Kolon[,] kolon)
        {
            InitializeComponent();
            FormDuzenle();
            this.kolon=kolon;
        }

        public void ButonAl(Object sender)
        {
            k = (Kolon)sender;
        }

        private void FormDuzenle()
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Size = new Size(555, 150);
            this.BackColor = Color.Black;
            for (int i = 1; i < 10; i++)
            {
                sayi[i] = new Kolon();
                sayi[i].Text = i.ToString();
                sayi[i].Location=new Point((i-1) * 60+5,10);
                sayi[i].Click += new EventHandler(SayiGir_Click);
                this.Controls.Add(sayi[i]);
            }
            btnIptal = new MyButton(this,"iptal");
            btnIptal.Location = new Point(230, 70);
            this.Controls.Add(btnIptal);
            btnIptal.Click += new EventHandler(btnIptal_Click);
        }

        void SayiGir_Click(object sender, EventArgs e)
        {
            Kolon tus = (Kolon) sender; // sayi gir formundaki basılan buton
            k.Text = tus.Text; // basılan tuşdaki sayıyı butona koy.
            this.Hide();
        }

        void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
