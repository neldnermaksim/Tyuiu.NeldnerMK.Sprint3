using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint3.Task2.V2.Lib;


namespace Tyuiu.NeldnerMK.Sprint3.Task2.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К . | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт  #3                                                               *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #2                                                          *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет произведение ряда по формуле");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
            Console.WriteLine();

            DataService ds = new DataService();
           
            int startValue = 1;
            int stopValue = 7;


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.GetMultiplySeries(startValue, stopValue));
        }
    }
}
