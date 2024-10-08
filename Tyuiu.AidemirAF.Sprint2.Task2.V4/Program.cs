﻿using Tyuiu.AidemirAF.Sprint2.Task2.V4.Lib;

/* ЗАДАНИЕ
   Написать программу, которая запрашивает целые значения с клавиатуры и 
   вычисляет находится ли точка с координатами (X, Y) в заштрихованной области.
*/

namespace Tyuiu.AidemirAF.Sprint2.Task2.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");
            if (res)
                Console.WriteLine("Точка находится в заштрихованной области.");
            else
                Console.WriteLine("Точка не находится в заштрихованной области");
        }    
    }
}
