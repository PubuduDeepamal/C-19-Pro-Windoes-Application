using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19_Vacination
{
    public static class Themecolor
    {
        public static Color primaryColor { get; set; }
        public static Color secondaryColor { get; set; }
        public static List<string> ColorList = new List<string>() { "#3F51B5",
                                                                    "#009688",
                                                                    "#B71C46",
                                                                    "#126881",
                                                                    "#A12059",
                                                                    "#9C27B0",
                                                                    "#721D47",
                                                                    "#0094BC",
                                                                    "#E4126B",
                                                                    "#B71C46",
                                                                    "#EF937E",
                                                                    "#018790",
                                                                    "#FF5722",
                                                                    "#FF9800"
                                                                    };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                blue *= correctionFactor;
                green *= correctionFactor;
            }

            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;

            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);

        }
    }
}
