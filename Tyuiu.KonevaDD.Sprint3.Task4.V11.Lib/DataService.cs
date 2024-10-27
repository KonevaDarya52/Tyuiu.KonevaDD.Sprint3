using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KonevaDD.Sprint3.Task4.V11.Lib
{
    public class DataService : ISprint3Task4V11
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1; 
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue; 
                }
                double y = (double)x / (Math.Sin(x) - x) + 2; 
                res *= y; 
            }
            return Math.Round(res, 3); 
        }
    }
}
