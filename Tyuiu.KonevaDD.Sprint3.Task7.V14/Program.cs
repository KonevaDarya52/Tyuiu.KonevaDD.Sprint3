using Tyuiu.KonevaDD.Sprint3.Task7.V14.Lib;
namespace Tyuiu.KonevaDD.Sprint3.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);

            int len = valueArray.Length;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-------------+------------+");
            Console.WriteLine("|      X     |    f(x)     |");
            Console.WriteLine("+-------------+------------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,7:d}     |  {1, 7:f2}    |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+------------+-------------+");
            Console.ReadKey();
        }
    }

    public class DataService
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
                    result[i] = Math.Round(2 * x - 4 + (-2 * x - 1) / sinXPlus1, 2);
                }
            }

            return result;
        }
    }
}
