using PR19_2_Nikolaev.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR19_2_Nikolaev
{
    public partial class Form1 : Form
    {
        public const int N_max = 200;
        public Player player = new Player();
        public Boolean laser = false;
        public Bitmap imageP;
        public int Result = 0;
        public Graphics g;
        public BrushColor bc = new BrushColor();
        public Enemies nlo = new Enemies();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            imageP = new Bitmap(imageList1.Images[0], 100, 100);
            player.New_player(this);
            nlo = new Enemies();
            nlo.New_Enemies(this);
        }

        private void StartBut_Click(object sender, EventArgs e)
        {
            nlo.k_generation = 0;
            nlo.Enemy(this);
            timer1.Start();
            timer2.Start();
            StopBut.Enabled = true;
            StartBut.Enabled = false;
        }

        private void LaserBut_Click(object sender, EventArgs e)
        {
            if (laser)
            {
                laser = false;
                LaserBut.Text = "Включить Лазер";
            }
            else
            {
                laser = true;
                LaserBut.Text = "Выключить Лазер";
            }
        }

        private void StopBut_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            imageP = new Bitmap(imageList1.Images[1], 100, 100);
            int procent = Result * 100 / (nlo.Delta_N * nlo.N_generation);
            string msg = $"Подбито {Result} НЛО, {procent}% результат";
            MessageBox.Show(msg, "Ваш результат!", MessageBoxButtons.OK);
            player.Show_player(this,50,50);
            nlo.N = 0;
            StartBut.Enabled = true;
            Result = 0;
            ResultBox.Text = Result.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            Result += nlo.Select_bugs();
            nlo.Show_bugs(this);
            ResultBox.Text = Result.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            nlo.k_generation++;
            timer2.Interval -= 100;
            if (nlo.k_generation < nlo.N_generation)
                nlo.Enemy(this);
            else
                timer2.Stop();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            player.Show_player(this,e.X,e.Y);
            if (laser)
                g.DrawLine(player.laser_pen, player.point.X + player.size.Width / 2, player.point.Y, player.point.X + player.size.Width / 2, 0);
            nlo.Killed_bugs(this, e.X, e.Y);
        }
    }
}
