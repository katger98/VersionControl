using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak7.Entities
{
   public class DeathProbability
    {
        public Gender Gender { get; set; }
        public byte Age { get; set; }
        public double Probability { get; set; }
    }
}
