using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AidemirAF.Sprint2.Task0.V1.Lib
{
    public class DataService : ISprint2Task0V1
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = y + 111 == x;
            res[1] = y + 111 != x;
            res[2] = y < x;
            res[3] = y > x;
            res[4] = y <= x;
            res[5] = y >= x;

            return res;
        }
    }
}
