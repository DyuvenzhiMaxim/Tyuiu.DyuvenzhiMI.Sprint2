
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DyuvenzhiMI.Sprint2.Task3.V13.Lib
{
    public class DataService : ISprint2Task3V13
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
                y = x - Math.Pow((x + 1) / (x - 1), x);
            else if (x == 0)
                y = ((7 * Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (8 * Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12));
            else if ((x > -17) && (x < 2))
                y = Math.Pow(3 + (8 / Math.Pow(x, 2)), x);
            else
                y = (x + 10*x - (1 / x));

            return Math.Round(y, 3);
        }
    }
}
