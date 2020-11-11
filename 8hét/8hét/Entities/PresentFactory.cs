using _8hét.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8hét.Entities
{
    public class PresentFactory : IToyFactory
    {
        public Color color1 { get; set; }
        public Color color2 { get; set; }
        public Toy CreateNew()
        {
            return new Present(color1, color2);
        }
    }
}
