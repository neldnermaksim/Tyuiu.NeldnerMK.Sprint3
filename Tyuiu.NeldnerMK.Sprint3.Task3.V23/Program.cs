using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint3.Task3.V23.Lib;


namespace Tyuiu.NeldnerMK.Sprint3.Task3.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К . | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт  #3                                                               *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #23                                                          *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Используя цикл foreach заменить буквы s на цифру 8 в строке: fdsst siu vsrs ");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: fdsst siu vsrs ");
            Console.WriteLine();

            DataService ds = new DataService();

            string value = "fdsst siu vsrs";
            char replaceable = 's';
            char replacement = '8';

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.ReplaceCharOnNum(value,replaceable,replacement));
        }
    }
}
