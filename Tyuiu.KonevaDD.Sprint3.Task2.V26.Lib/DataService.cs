using System;

namespace Tyuiu.KonevaDD.Sprint3.Task1.V26.Lib
{
    public class DataService
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
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
