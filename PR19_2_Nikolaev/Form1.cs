using PR19_2_Nikolaev.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Bitmap image;
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
            BackColor = bc.FonColor;
            image = new Bitmap(imageList1.Images[0], 100, 100);
            player.New_player(this);
            nlo = new Enemies();
            nlo.New_Enemies();
        }

        private void StartBut_Click(object sender, EventArgs e)
        {
            nlo.K_generation = 0;
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
           
        }
    }
}
