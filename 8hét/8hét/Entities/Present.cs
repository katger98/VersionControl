using _8hét.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8hét.Entities
{
    public class Present : Toy
    {
        public SolidBrush PresentMain { get; private set; }
        public SolidBrush PresentSecond { get; private set; }
        public Present(Color color1, Color color2)
        {
            PresentMain = new SolidBrush(color1);
            PresentSecond = new SolidBrush(color2);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(PresentMain, 0, 0, Width, Height);
            g.FillRectangle(PresentSecond, 20, 0, 10, 50);
            g.FillRectangle(PresentSecond, 0, 20, 50, 10);
        }
    }
}
