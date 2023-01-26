using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR19_2_Nikolaev.models
{
    public class BrushColor
    {
        public Color FonColor;
        public Color LaserColor;
        public Color DashBug;
        public Color KilledBug;

        public BrushColor() { }
        public HatchBrush New_br(int rch) 
        {
            return new HatchBrush(HatchStyle.DarkDownwardDiagonal, DashBug, RandomColor(rch));
        }
        public Color RandomColor(int rch) 
        {
            int r, g, b;
            byte[] bytes1= new byte[3];
            Random rnd1 = new Random();
            rnd1.NextBytes(bytes1);
            r = Convert.ToInt16(bytes1[0]);
            g = Convert.ToInt16(bytes1[1]);
            b = Convert.ToInt16(bytes1[2]);
            return Color.FromArgb(r, g, b);
        }

    }
}
