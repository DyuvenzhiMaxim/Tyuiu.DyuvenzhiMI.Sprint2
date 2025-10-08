
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DyuvenzhiMI.Sprint2.Task2.V19.Lib
{
    public class DataService : ISprint2Task2V19
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            // 1st square
            if ((3 <= x) && (x <= 5) && (3 <= y) && (y <= 7))
                res = true;
            // 2nd square
            else if ((x >= 6) && (x <= 10) && (y >= 6) && (y <= 7))
                res = true;
            // 3rd square
            else if ((x >= 9) && (x <= 12) && (y == 3))
                res = true;
            // 4st square
            else if ((x >= 9) && (x <= 10) && (y == 4))
                res = true;
            // 5st square
            else if ((x == 6) && (y >= 8) && (y <= 11))
                res = true;
            // 6st square
            else if ((x >= 3) && (x <= 6) && (y == 11))
                res = true;
            // 7st square
            else if ((x >= 11) && (x <= 13) && (y >= 6) && (y <= 8))
                res = true;
            // 8st square
            else if ((x >= 11) && (x <= 12) && (y >= 9) && (y <= 11))
                res = true;
            // 9st square
            else if ((x >= 9) && (x <= 11) && (y >= 11) && (y <= 14))
                res = true;
            // 10st square
            else if ((x >= 7) && (x <= 11) && (y == 13))
                res = true;
            // 11st square
            else if ((x >= 9) && (x <= 13) && (y == 14))
                res = true;
            else
                res = false;
            return res;
        }
    }
}
