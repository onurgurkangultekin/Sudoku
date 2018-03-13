using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Sudoku
{
    class MyButton :Button
    {
        public MyButton(Form form,string s)
        {
            this.Font = new System.Drawing.Font("arial", 11, FontStyle.Bold);
            this.Text = s;
            this.AutoSize = true;
            this.ForeColor = Color.AliceBlue;
            this.BackColor = Color.Black;
            form.Controls.Add(this);
        }
    }
}
