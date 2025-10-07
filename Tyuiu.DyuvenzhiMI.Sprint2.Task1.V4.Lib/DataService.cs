
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DyuvenzhiMI.Sprint2.Task1.V4.Lib
{
    public class DataService : ISprint2Task1V4
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            // int a = 175; int b = 176; int c = 414; int d = 414;
            bool[] res = new bool[6];

            res[0] = (c != d) | (a > b);
            res[1] = (a > b) & (c == b);
            res[2] = (a > c) || (a == b);
            res[3] = (c != d) && (b > a);
            res[4] = !(res[0]);
            res[5] = (a > b) ^ (c != d);
            return res;
        }
    }
}
