using Tyuiu.AidemirAF.Sprint2.Task1.V18.Lib;

/* ЗАДАНИЕ
  Написать программу из операций сравнений (==, !=, <, >, <=, >=,
  последовательность можно чередовать, но использовать один раз в выражении)
  и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться,
  а также арифметических выражений, которая вернет логическую последовательность (массив): (True, True, True, False, True, False),
  при а = 155, b = 696, c = 242, d = 541
*/

namespace Tyuiu.AidemirAF.Sprint2.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 155;
            int b = 696;
            int c = 242;
            int d = 541;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");


            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}
