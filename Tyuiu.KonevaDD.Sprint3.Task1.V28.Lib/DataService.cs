using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KonevaDD.Sprint3.Task1.V28.Lib
{
    public class DataService : ISprint3Task1V28
    {
        public double GetSumSeries(double a, int startValue, int stopValue)
        {
            double sumSeries = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                double term = (Math.Pow(a, k) + 0.25) * Math.Cos(k * Math.PI / 180);
                sumSeries += term;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}