using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint3.Task5.V22.Lib;


namespace Tyuiu.NeldnerMK.Sprint3.Task5.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К . | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт  #3                                                               *");
            Console.WriteLine("* Задание #5                                                            *");
            Console.WriteLine("* Вариант #22                                                          *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу используя цикл которая вычисляет произведение ряда по формуле");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: y=(cos(x)+sin(x))/x ");
            Console.WriteLine();

            DataService ds = new DataService();

            int x = 2;
            int startValue = 1;
            int stopValue = 3;
            int startValue1 = 1;
            int stopValue2 = 12;


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.GetSumSumSeries(x, startValue, startValue, startValue1, stopValue2));
        }
    }
}
