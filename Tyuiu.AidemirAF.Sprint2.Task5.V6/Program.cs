using Tyuiu.AidemirAF.Sprint2.Task5.V6.Lib;

/*
 * ЗАДАНИЕ
 * Написать программу, которая использует оператор switch 
 * вычисялет требуемое значение и возвращает результат.
 */

namespace Tyuiu.AidemirAF.Sprint2.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Введите порядковый номер масти: ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер достоинства карты: ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((value1 < 1 || value1 > 4) && (value1 < 6 || value2 > 14))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это карта: " + ds.FindCardNameAndValue(value1, value2);
            }

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
