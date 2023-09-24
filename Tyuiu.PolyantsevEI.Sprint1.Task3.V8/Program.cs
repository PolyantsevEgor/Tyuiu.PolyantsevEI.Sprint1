using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PolyantsevEI.Sprint1.Task3.V8.Lib;

namespace Tyuiu.PolyantsevEI.Sprint1.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Полянцев Е. И. | ИСТНб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Полянцев Егор Ильич | ИСТНб-23-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя значения величины*");
            Console.WriteLine("* вклада, срока хранения в днях, процентной ставки вклада, вычисляет      *");
            Console.WriteLine("* величину дохода и печатает результат на экране.                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double startAmount;
            double timeDays;
            double percent;

            Console.WriteLine("Введите значение величины вклада: ");
            startAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение срока хранения вклада в днях: ");
            timeDays = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение процентной ставки: ");
            percent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Доход по вкладу = " + ds.IncomeAmount(startAmount, percent, timeDays));

            Console.ReadKey();
        }
    }
}
