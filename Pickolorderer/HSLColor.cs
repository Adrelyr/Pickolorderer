using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickolorderer
{
    internal class HSLColor
    {
        public float H { get; set; } = 0;
        public float S { get; set; } = 0;
        public float L { get; set; } = 0;


        public HSLColor(float Hue, float Saturation, float Luminosity)
        {
            H = Hue;
            S = Saturation;
            L = Luminosity;
        }
    }
}
