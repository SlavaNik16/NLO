using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR19_3_Nikolaev
{
   
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        List<String> icons = new List<string>()
        {
            "!","!","c","c","b","b","%","%","f",
            "f","?","?","H","H","Й","Й","ж","ж",
            "F","F","X","X","z","z","Q","Q","o",
            "o","m","m","/","/","w","w","@","@"
        };
        Label firstClick = null;
        Label secondClick = null;
        private double s = 5, m = 0, h = 0;
        public Form1()
        {
            InitializeComponent();
            AssignIconToSquares();
         
        }

        private void AssignIconToSquares()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconLab= control as Label;
                if (iconLab != null)
                {
                    int randomNum = rnd.Next(icons.Count);
                    iconLab.Text = icons[randomNum];

                    iconLab.ForeColor = iconLab.BackColor;

                    icons.RemoveAt(randomNum);
                }
            }
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClick.ForeColor = firstClick.BackColor;
            secondClick.ForeColor = secondClick.BackColor;

            firstClick = null;
            secondClick = null;

        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLab = control as Label;

                if (iconLab != null)
                {
                    if (iconLab.ForeColor == iconLab.BackColor)
                        return;
                }

            }
            timer2.Stop();
            MessageBox.Show("Вы сопоставили все значки!","Поздравляем!!!");
            Close();
        }

        private void label17_Click_1(object sender, EventArgs e)
        {
            Label LabClick = sender as Label;
            if (LabClick != null)
            {
                if (LabClick.ForeColor == Color.Black)
                    return;

                if (firstClick == null)
                {
                    firstClick = LabClick;
                    firstClick.ForeColor = Color.Black;
                    return;
                }
                if (secondClick == null)
                {
                    secondClick = LabClick;
                    secondClick.ForeColor = Color.Black;
                    if (firstClick.Text == secondClick.Text)
                    {
                        CheckForWinner();
                        firstClick = null;
                        secondClick = null;
                        return;
                    }
                    else
                    {
                        timer1.Start();
                    }
                    return;
                }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (h == 0 && m == 0 && s == 0)
            {
                timer2.Stop();
                MessageBox.Show("Время вышло, вы проиграли!", "Проигрыш!!!");
                Close();
            }
            else
            {
                
                if (s == 0)
                {
                    m--;
                    s = 59;
                }
                else if (m == 0 && h != 0)
                {
                    h--;
                    m = 59;
                }
                s--;
                string text = $"{h}:{m}:{s}";
                this.Text = $"Игра 'Найди пару' Время: {text}";
            }

        }
    }
}
