using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AidemirAF.Sprint2.Task1.V18.Lib
{
    public class DataService : ISprint2Task1V18
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (c < d);
            res[1] = (a <= b) & (d >= c);
            res[2] = (a > b) || (c < d);
            res[3] = (a >= b) && (d <= c);
            res[4] = !(!res[0]);
            res[5] = (a > b) ^ (d < c);
            return res;
        }
    } 
}
