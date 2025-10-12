
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DyuvenzhiMI.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            n = n + 1;
            while (n > 12)
            {
                n -= 12;
            }

            switch (n)
            {
                case 1: return "январь";
                case 2: return "февраль";
                case 3: return "март";
                case 4: return "апрель";
                case 5: return "май";
                case 6: return "июнь";
                case 7: return "июль";
                case 8: return "август";
                case 9: return "сентябрь";
                case 10: return "октябрь";
                case 11: return "ноябрь";
                case 12: return "декабрь";
                default: throw new ArgumentException("Ты ввёл не число!");
            }

        }
    }
}
