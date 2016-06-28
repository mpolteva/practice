using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP___2_2
{
    public class MyClass
    {
        static public void Square(double a, double b, double c, ref string x1, ref string x2)//Метод для вычисления x1,x2
        {
            double d = (b * b) - (4 * a * c);
            if (d >= 0)
            {
                x1 = (Convert.ToString(Math.Round((((-b) + Math.Sqrt(d)) / (2 * a)), 2)));
                x2 = (Convert.ToString(Math.Round((((-b) - Math.Sqrt(d)) / (2 * a)), 2)));
            }
            if (d < 0)
            {
                x1 = Convert.ToString(Math.Round((-b) / (2 * a), 2) + " + " + Math.Round(Math.Sqrt(-d) / (2 * a), 2) + "i");
                x2 = Convert.ToString(Math.Round((-b) / (2 * a), 2) + " - " + Math.Round(Math.Sqrt(-d) / (2 * a), 2) + "i");
            }
        }
    }
}
