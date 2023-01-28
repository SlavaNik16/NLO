using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR19_2_Nikolaev.models
{
    public class Player
    {
        public Point point;
        public Size size;
        public Region reg;
        public Pen laser_pen;

        public void New_player(Form1 F)
        {
            size = F.imageP.Size;
            point.X = 0;
            point.Y = 0;
            Rectangle rec = new Rectangle(point, size);
            reg = new Region(rec);
            laser_pen = new Pen(Color.Red);
                //new HatchBrush(HatchStyle.DashedUpwardDiagonal,F.bc.LaserColor, F.bc.LaserColor), 3);
        }
        public void Show_player(Form1 F, int x, int y) 
        {
            F.g.ResetClip();
            F.g.FillRegion(new SolidBrush(F.BackColor), reg);
            point.X = x - size.Width / 2;
            point.Y = y;
            Rectangle rec = new Rectangle(point, size);
            reg = new Region(rec);
            F.g.DrawImage(F.imageP, point);
            F.g.ExcludeClip(reg);
        }
    }

   
}
