using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusAndFahrenheit
{
    public class Main
    {
        public static double FahrenheitToCelsius(double y)
        {
            double x;
            x = (y - 32) / 1.8;
            return x;
        }

        public static double CelsiusToFahrenheit(double x)
        {
            double y;
            y = x * 1.8 + 32;
            return y;
        }
    }
}
