using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickolorderer
{
    internal class ColorSorter
    {
        Dictionary<HSLColor, string> HSLValues { get; } = new Dictionary<HSLColor, string>();

        public Dictionary<HSLColor, string> SortedHSLValues = new Dictionary<HSLColor, string>();
        public ColorSorter(Dictionary<Color, string> values)
        {
            foreach (Color color in values.Keys)
            {

                HSLColor newColor = new HSLColor(color.GetHue(), color.GetSaturation(), color.GetBrightness());
                HSLValues.Add(newColor, values[color]);
            }
            SortThatBiatch(HSLValues);
        }

        void SortThatBiatch(Dictionary<HSLColor, string> dict)
        {
                List<HSLColor> list = dict.Keys.ToList();
                list.Sort(delegate (HSLColor x, HSLColor y)
                {
                    if (x.H < y.H)
                        return -1;
                    else if (x.H == y.H && x.S == y.S && x.L == y.L)
                        return 0;
                    else
                        return 1;
                });
            
            for (int i = 0; i<list.Count; i++)
            {
                SortedHSLValues.Add(list[i], dict[list[i]]);
            }

        }


        public static Color calculateHSLtoRGB(HSLColor color)
        {
            double H = color.H;
            double S= color.S;
            double L = color.L;

            double[] rgb = new double[3];
            double C = L * S;
            double h1 = H / 60;
            double X = C * (1 - Math.Abs((h1 % 2 - 1)));

            double rp = 0;
            double gp = 0;
            double bp = 0;

            if (0 <= h1 && h1 < 1)
            {
                rp = C;
                gp = X;
                bp = 0;
            }
            else if (1 <= h1 && h1 < 2)
            {
                rp = X;
                gp = C;
                bp = 0;
            }
            else if (2 <= h1 && h1 < 3)
            {
                rp = 0;
                gp = C;
                bp = X;
            }
            else if (3 <= h1 && h1 < 4)
            {
                rp = 0;
                gp = X;
                bp = C;
            }
            else if (4 <= h1 && h1 < 5)
            {
                rp = X;
                gp = 0;
                bp = C;
            }
            else if (5 <= h1 && h1 < 6)
            {
                rp = C;
                gp = 0;
                bp = X;
            }

            double m = (L - C);

            rgb[0] = (rp + m);
            rgb[1] = (gp + m);
            rgb[2] = (bp + m);

            double R = DoubleMap(rgb[0], 0d, 1d, 0d, 255d);
            double G = DoubleMap(rgb[1], 0d, 1d, 0d, 255d);
            double B = DoubleMap(rgb[2], 0d, 1d, 0d, 255d);

            return Color.FromArgb((int)R, (int)G, (int)B);
        }

        static double DoubleMap(double x, double in_min, double in_max, double out_min, double out_max)
        {
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }


    }
}
