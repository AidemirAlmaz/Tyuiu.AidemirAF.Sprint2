using Tyuiu.AidemirAF.Sprint2.Task3.V1.Lib;

/* 
 * ЗАДАНИЕ
 * Написать программу, которая вычисляет требуемое значение функции Y
 * с использованием вложенных операторов if-else,
 * где пользователь вводит значение переменной X с клавиатуры.
 * Округлить полученное значение до трёх знаков после запятой.
 */

namespace Tyuiu.AidemirAF.Sprint2.Task3.V1
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
            double res = ds.Calculate(x);

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
