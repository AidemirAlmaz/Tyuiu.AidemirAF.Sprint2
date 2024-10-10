using Tyuiu.AidemirAF.Sprint2.Task4.V30.Lib;

/* ЗАДАНИЕ
 * Написать программу, которая вычисляет требуемое значение с использованием тернарного оператора,
 * где пользователь вводит значение переменных x, y с клавиатуры.
 */

namespace Tyuiu.AidemirAF.Sprint2.Task4.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y);

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
