namespace Sudoku
{
    partial class SudokuHakkinda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSudoku = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSudoku
            // 
            this.txtSudoku.BackColor = System.Drawing.Color.Black;
            this.txtSudoku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSudoku.ForeColor = System.Drawing.Color.White;
            this.txtSudoku.Location = new System.Drawing.Point(37, 21);
            this.txtSudoku.Name = "txtSudoku";
            this.txtSudoku.Size = new System.Drawing.Size(541, 570);
            this.txtSudoku.TabIndex = 0;
            this.txtSudoku.Text = "label1";
            // 
            // SudokuHakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(613, 614);
            this.Controls.Add(this.txtSudoku);
            this.Name = "SudokuHakkinda";
            this.Text = "SudokuHakkinda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtSudoku;
    }
}