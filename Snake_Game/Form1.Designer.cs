namespace Snake_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plFood = new System.Windows.Forms.PictureBox();
            this.plSnake = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plSnake)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.Location = new System.Drawing.Point(10, 15);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(100, 37);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 536);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // plFood
            // 
            this.plFood.Image = ((System.Drawing.Image)(resources.GetObject("plFood.Image")));
            this.plFood.Location = new System.Drawing.Point(1116, 249);
            this.plFood.Name = "plFood";
            this.plFood.Size = new System.Drawing.Size(65, 68);
            this.plFood.TabIndex = 4;
            this.plFood.TabStop = false;
            // 
            // plSnake
            // 
            this.plSnake.BackColor = System.Drawing.Color.DimGray;
            this.plSnake.Location = new System.Drawing.Point(193, 330);
            this.plSnake.Name = "plSnake";
            this.plSnake.Size = new System.Drawing.Size(282, 259);
            this.plSnake.TabIndex = 5;
            this.plSnake.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2050, 1250);
            this.Controls.Add(this.plSnake);
            this.Controls.Add(this.plFood);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbScore);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "Snake Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plSnake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox plFood;
        private System.Windows.Forms.PictureBox plSnake;
    }
}

