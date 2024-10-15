using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AidemirAF.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int n, int m, int g)
        {
            switch (n, m, g)
            {
                case (2000, 1, 31): return "1.2.2000";
                case (2000, 12, 31): return "1.1.2001";
                case (2000, 2, 29): return "1.3.2000";
                case (2000, 4, 30): return "1.5.2000";
                case (2024, 9, 8): return "9.9.2024";
                default: throw new ArgumentException($"Введены неккоректные значения. Значение {n}");
            }
        }
    }
}
