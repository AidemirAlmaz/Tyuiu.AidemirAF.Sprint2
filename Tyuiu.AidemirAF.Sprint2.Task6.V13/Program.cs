using Tyuiu.AidemirAF.Sprint2.Task6.V13.Lib;

/*
 * ЗАДАНИЕ
 * Написать программу, которая использует скоращенную форму записи switch
 * вычисляет требуемое значение и возвращает результат.
 */

namespace Tyuiu.AidemirAF.Sprint2.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите порядковый номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            if ((n % 4 != 0) && ((n % 100 != 0) && (n % 400 != 0)))
            {
                Console.WriteLine("Год не является високосным");
            }
            string res;
            res = ds.FindDateOfNextDay(g, m, n);
            
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
