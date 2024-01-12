using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        Random random = new Random();
        int thisWidth = 800;
        int thisHight = 599;
        int score = 0;
        bool keydown;

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 0001; timer.Start();
            timer.Tick += Timer_Tick;
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.Size = new Size(thisWidth, thisHight);
            this.lbScore.Text = "0";
            this.KeyUp += Form1_KeyUp;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            keydown = false;
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            this.lbScore.Text = score.ToString();
            if (keydown)
            {
                this.pictureBox1.Visible = true;
            }
            else
            {
                this.pictureBox1.Visible = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keydown = true;
            if (plSnake.Location.Y + plSnake.ClientSize.Height < this.ClientSize.Height)
            {
                if (e.KeyCode == Keys.Down)
                {
                    plSnake.Location = new Point(plSnake.Location.X, plSnake.Location.Y + 10);
                }
            }
            if (plSnake.Location.Y > 0)
            {
                if (e.KeyCode == Keys.Up)
                {
                    plSnake.Location = new Point(plSnake.Location.X, plSnake.Location.Y - 10);
                }
            }
            if (plSnake.Location.X > 0)
            {
                if (e.KeyCode == Keys.Left)
                {
                    plSnake.Location = new Point(plSnake.Location.X - 10, plSnake.Location.Y );
                }
            }
            if (plSnake.Location.X + plSnake.ClientSize.Width < this.ClientSize.Width)
            {
                if (e.KeyCode == Keys.Right)
                {
                    plSnake.Location = new Point(plSnake.Location.X + 10, plSnake.Location.Y);
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                this.pictureBox1.Location = new Point(this.plSnake.Location.X - 120, this.plSnake.Location.Y - 50);
            }
            if (e.KeyCode == Keys.Left)
            {
                this.pictureBox1.Location = new Point(this.plSnake.Location.X + 50, this.plSnake.Location.Y - 30);
            }
            if (e.KeyCode == Keys.Up)
            {
                this.pictureBox1.Location = new Point(this.plSnake.Location.X - 50 + 10, this.plSnake.Location.Y+50 );
            }
            if (e.KeyCode == Keys.Down)
            {
                this.pictureBox1.Location = new Point(this.plSnake.Location.X - 50 + 10, this.plSnake.Location.Y - 100);
            }
            Rectangle food = new Rectangle(plFood.Location.X, plFood.Location.Y, plFood.ClientSize.Width, plFood.ClientSize.Height);
            Rectangle snake = new Rectangle(plSnake.Location.X, plSnake.Location.Y, plSnake.ClientSize.Width, plSnake.ClientSize.Height);
            Rectangle fire = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            if (snake.IntersectsWith(food) || fire.IntersectsWith(food))
            {
                int x;
                int y;
                score++;
                x = random.Next(0, this.ClientSize.Width + 1);
                y = random.Next(0, this.ClientSize.Height + 1);

                this.plFood.Location = new Point(x, y);
            }
        }
    }
}
