using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.NeldnerMK.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1.0;
            int k = startValue;

            while (k <= stopValue)
            {
                p *= Math.Pow((2.0/ Math.Cos(value)),k);
                k++;
            }
            return Math.Round(p,3);
        }
    }
}