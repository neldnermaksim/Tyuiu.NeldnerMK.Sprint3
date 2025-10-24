using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.NeldnerMK.Sprint3.Task0.V30.Lib
{
    public class DataService : ISprint3Task0V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            {
                double product = 1.0;
                double sinValuePower = Math.Pow(Math.Sin(1), -10);

                for (int k = startValue; k <= stopValue; k++)
                {
                    product *= (double)k / sinValuePower;
                }

                return Math.Round(product, 3);
            }
        }
    }
}

