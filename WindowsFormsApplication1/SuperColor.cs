using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
namespace WindowsFormsApplication1
{


    class SuperColor
    {
        //the complexty time is O(1).
        public static Color FromAhsl(double hue, double saturation = 100, double lightness = 50)
        {

            int Red, Green, Blue;
            Hue(hue, out  Red, out Green, out Blue);
            Lightness(lightness, ref Red, ref Green, ref Blue);
            Saturation(saturation, ref Red, ref Green, ref Blue, lightness);
            return Color.FromArgb(Red, Green, Blue);
        }
        //the complexty time is O(1).
        public static HSLValue GetHSLValue(Color c)
        {
            double hue = c.GetHue();
            double lightness = c.GetBrightness();
            double saturation = c.GetSaturation();
            return new HSLValue(Math.Ceiling(hue), saturation, lightness);
        }
        public static string StringFormTextBox(Color color, string TheForm = "rgb")
        {
            switch (TheForm)
            {
                case "rgb":
                    {
                        return color.R + "," + color.G + "," + color.B;
                    }
                case "hex":
                    {
                        return "#"+color.R.ToString("X").PadLeft(2,'0') + color.G.ToString("X").PadLeft(2,'0')  + color.B.ToString("X").PadLeft(2,'0');
                    }
                    
            }
            return "";
        }
        public static Color ColorFormTextBox(string str, string TheForm = "rgb")
        {

            switch (TheForm)
            {
                case "rgb":
                    {
                        Regex regex = new Regex(@"^\d{1,3}\,\d{1,3}\,\d{1,3}\s*$");
                        if (regex.IsMatch(str))
                        {
                            List<int> BasicColor = new List<int>();
                            regex = new Regex(@"\d{1,3}");
                            Match match = regex.Match(str);
                            while (match.Success)
                            {
                                BasicColor.Add(Convert.ToInt16(match.Groups[0].Value));
                                match = match.NextMatch();
                            }
                            if (BasicColor[0] <= 255 && BasicColor[1] <= 255 && BasicColor[2] <= 255)
                                return Color.FromArgb(BasicColor[0], BasicColor[1], BasicColor[2]);

                        }
                        break;
                    }
                case "hex":
                    {
                        Regex regex = new Regex(@"^\#([0-9a-fA-Z]{2}){3}\s*$");
                        if (regex.IsMatch(str))
                        {
                            List<int> BasicColor = new List<int>();
                            regex = new Regex(@"[0-9a-fA-Z]{2}");
                            Match match = regex.Match(str);
                            while (match.Success)
                            {
                                BasicColor.Add(Convert.ToInt16(match.Groups[0].Value,16));
                                match = match.NextMatch();
                            }
                            if (BasicColor[0] <= 255 && BasicColor[1] <= 255 && BasicColor[2] <= 255)
                                return Color.FromArgb(BasicColor[0], BasicColor[1], BasicColor[2]);

                        }
                        
                        break;
                    }
                 
            }
           
           
             throw new Exception("The expression is match");
        }
        private static void Saturation(double value, ref int red, ref int green, ref int blue, double lightness)
        {
            double l = Math.Ceiling(lightness * 2.55);
            double x = value / 100;
            red = (int)((red - l) * x + l);
            green = (int)((green - l) * x + l);
            blue = (int)((blue - l) * x + l);
        }
        private static void Lightness(double value, ref int red, ref int green, ref int blue)
        {
            if (value < 50)
            {
                double x = value / 50;
                red = (int)(red * x);
                green = (int)(green * x);
                blue = (int)(blue * x);
            }
            else if (value > 50)
            {
                double x = (value - 50) / 50;
                red = (int)((255 - red) * x + red);
                green = (int)((255 - green) * x + green);
                blue = (int)((255 - blue) * x + blue);
            }
        }
        private static void Hue(double Value, out int red, out int green, out int blue)
        {
            int value = (int)(1535 * Value / 360);
            int q, r;
            red = green = blue = 0;
            q = value / 256;
            r = value % 256;
            switch (q)
            {
                case 0: red = 255; green = r; blue = 0; break;
                case 1: red = 255 - r; green = 255; blue = 0; break;
                case 2: red = 0; green = 255; blue = r; break;
                case 3: red = 0; green = 255 - r; blue = 255; break;
                case 4: red = r; green = 0; blue = 255; break;
                case 5: red = 255; green = 0; blue = 255 - r; break;
            }
        }
        private static int GetHueValue(int red,int green,int blue)
        {
            int n=0;
            n += red == 0 ? 0 : 100;
            n += green == 0 ? 0 : 10;
            n += blue == 0 ? 0 : 1;

            switch (n)
            {
                case 000: { break; }
                case 100: { return 0; }
                case 110: { return red == 255 ? green : (511- red); }
                case 010: { return 511; }
                case 011: { return green == 255 ? 511 + blue : (1023 - green); }
                case 001: { return 1023; }
                case 101: { return blue == 255 ? 1023 + red : 1535 - blue; }
            }

            return -1;
        }
        private static double GetHue(double red, double green, double blue)
        {
            if(red==0&&green==0&&blue==0 ||(red==green&&green==blue))return -1;
            double max=red, min = red,length;
            
            max = max < green ? green : max; max = max < blue ? blue : max;
            min = min > green ? green : min; min = min > blue ? blue : min;
            length=max-min;
            red = (red - min) * 255.0 / length;
            green = (green - min) * 255.0 / length;
            blue = (blue - min) * 255.0 / length;
            return GetHueValue((int)red, (int)green, (int)blue) * 360.0 / 1535;            
           
        }
        private static double GetHue(Color color,bool IsInt=true)
        {
            if (IsInt) return Math.Ceiling(GetHue(color.R, color.G, color.B));
            return GetHue(color.R, color.G, color.B);
        }
        
        private static double GetLightness(int red ,int green ,int blue,double HueValue)
        {
            double lightness=50;
            Color n = FromAhsl(HueValue);
            if (red < n.R)
            {
                lightness = 50.0 / n.R * red;
            }
            else if (red != n.R)
            {
                lightness = (255 + red - 2 * n.R) * 50.0 / (255 - n.R);
            }
            return lightness;
            
        }
        private static double GetSaturation(int red, int green, int blue,double HueValue,double lightness)
        {
            double saturation;
            Color n = FromAhsl(HueValue);
            double l = lightness * 2.55;
            saturation = (red - l) * 100.0 / (l - n.R);
            return saturation;
        }
    }

    class HSLValue
    {
        public double hue { get; set; }
        public double saturation { get; set; }
        public double lightness { get; set; }
        public HSLValue(double hue, double saturation=100, double lightness=50)
        {
            this.hue = hue;
            this.saturation = saturation;
            this.lightness = lightness;
        }
        public HSLValue()
        {}
        public override string ToString()
        {
            return "h:" + hue + "° ,s:" + (int)(saturation*100) + "% ,l:" + (int)(lightness*100) + "%";
        }
    }
}
