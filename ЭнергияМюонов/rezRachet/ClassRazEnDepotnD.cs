using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ЭнергияМюонов.представление_файлов.stringFile;

namespace ЭнергияМюонов.rezRachet
{
   public class ClassRazEnDepotnD
    {
        public double theta { get; set; }

        public double otn { get; set; }
        public double otnerror { get; set; }
        public List<ClassstringGMSdEdX> eventGMS = new List<ClassstringGMSdEdX>();
        public class pointXY
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
        public double X_Em
        {
            get
            {
                return Density_function1(otn);
            }
        }
        public double X_EmError1
        {
            get
            {
                return Density_function1(otn - otnerror);
            }
        }
        public double X_EmError2
        {
            get
            {
                return Density_function1(otn + otnerror);
            }
        }
        public double Density_function1(double x)
        {
            pointXY ymin = new pointXY();
            pointXY ymax = new pointXY();
            foreach (var points in eventGMS)
            {
                if (points.RatTo100 == x)
                {
                    return points.EGeV;
                }
                if (points.RatTo100 < x)
                {
                    ymin.X = points.EGeV;
                    ymin.Y = points.RatTo100;
                }
                else
                {
                    if (points.RatTo100 > x)
                    {
                        ymax.Y = points.RatTo100;
                        ymax.X = points.EGeV;
                        break;
                    }
                }
            }
            double deltay = ((x - ymin.Y) * (ymax.X - ymin.X)) / (ymax.Y - ymin.Y);
            return ymin.X + deltay;
        }
    }
}
