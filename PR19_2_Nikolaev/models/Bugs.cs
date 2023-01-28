using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR19_2_Nikolaev.models
{
    public class Bugs
    {

        public Point point;
        public Size size;
        int veloX, veloY;
        public HatchBrush br;
        public Region reg = new Region();
        public Boolean life = true;

        public void New_bug(Form1 F, int rch)
        {
            Random rv = new Random(rch);
            point.X = rv.Next(10, Form1.ActiveForm.Width - 40);
            point.Y = rv.Next(10, Form1.ActiveForm.Height / 5);
            size.Width = rv.Next(20, 50);
            size.Height = size.Width * 2 / 3;
            veloX = rv.Next(7) - 3;
            veloY = rv.Next(3, 10);
            br = F.bc.New_br(rch);
            reg = Form_bug();
        }
        public Region Form_bug() 
        {
            Point pt = new Point();
            Size st = new Size();
            pt.X = point.X;
            pt.Y = point.Y + size.Height / 4;
            st.Width = size.Width;
            st.Height = size.Height / 2;
            Rectangle rec = new Rectangle(pt, st);
            GraphicsPath path1 = new GraphicsPath();
            path1.AddEllipse(rec);
            Region reg = new Region(path1);
            rec.X = point.X + size.Width / 4;
            rec.Y = point.Y;
            rec.Width = size.Width / 2;
            rec.Height = size.Height;
            path1.AddEllipse(rec);
            reg.Union(path1);
            return reg;

        }
        public void Move_bug() 
        {
            point.X += veloX;
            point.Y += veloY;
            reg = Form_bug();
        }
    }
}
