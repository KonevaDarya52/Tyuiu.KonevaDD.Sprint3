using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KonevaDD.Sprint3.Task1.V26.Lib
{
    public class DataService : ISprint3Task2V26
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double product = 1;
            int i = startValue;

            do
            {
                product *= Math.Pow(value, 3) * i + 2;
                i++;
            }
            while (i <= stopValue);

            return product;
        }
    }

        
        
    
}