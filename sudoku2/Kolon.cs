using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Sudoku
{
    public class Kolon:Button
    {
        public Kolon()
        {
            this.Height = 50;
            this.Width = 50;
            this.BackColor = Color.AliceBlue;
            this.Font = new System.Drawing.Font("arial", 12, FontStyle.Bold);
            this.ForeColor = Color.Black;
        }
    }
}
