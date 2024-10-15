using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AidemirAF.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int n, int m, int g)
        {
            switch (n, m, g)
            {
                case (31, 1, 2000): return "1.2.2000";
                case (31, 12, 2000): return "1.1.2001";
                case (29, 2, 2000): return "1.3.2000";
                case (30, 4, 2000): return "1.5.2000";
                default: throw new ArgumentException($"Введены неккоректные значения. Значение {n}, {m}, {g}"); ;
            }
        }
    }
}
