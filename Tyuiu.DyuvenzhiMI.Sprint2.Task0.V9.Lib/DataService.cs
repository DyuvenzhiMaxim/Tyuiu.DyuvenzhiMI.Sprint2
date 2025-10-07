
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DyuvenzhiMI.Sprint2.Task0.V9.Lib
{
    public class DataService : ISprint2Task0V9
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == x;
            res[1] = x != y;
            res[2] = y < x;
            res[3] = x > y;
            res[4] = y <= x;
            res[5] = y >= x;
            return res;
        }
    }
}
