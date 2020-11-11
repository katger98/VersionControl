using _8hét.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8hét.Entities
{
    class Car : Toy
    {
        protected override void DrawImage(Graphics g)
        {
            Image smolcar = Image.FromFile("Images/car.png");
            g.DrawImage(smolcar, new Rectangle(0, 0, Width, Height));
        }
    }
}
