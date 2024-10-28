using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KonevaDD.Sprint3.Task7.V14.Lib
{
    public class DataService : ISprint3Task7V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];

            for (int i = 0; i < len; i++)
            {
                double x = startValue + i;
                double sinXPlus1 = Math.Sin(x) + 1;

                if (sinXPlus1 == 0)
                {
                    result[i] = 0; 
                }
                else
                {
                    
                    result[i] = Math.Round(Math.Sin(x), 2);  
                }
            }

            return result;
        }
    }
}
