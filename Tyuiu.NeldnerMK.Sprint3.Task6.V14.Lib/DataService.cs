using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.NeldnerMK.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int c = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        if (d > 5)
                        {
                            c += 1;
                        }
                    }
;
                }
            }
            return c;
        }
    }
}
