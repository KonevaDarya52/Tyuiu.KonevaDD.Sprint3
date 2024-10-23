using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KonevaDD.Sprint3.Task0.V8.Lib
{
    public class DataService : ISprint3Task0V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            double cosValue = Math.Cos(4); 

            for (int k = startValue; k <= stopValue; k++)
            {
                multiplySeries *= (Math.Pow(value, k) + 1) * cosValue;
            }

            return Math.Round(multiplySeries, 3); 
        }
    }
}
