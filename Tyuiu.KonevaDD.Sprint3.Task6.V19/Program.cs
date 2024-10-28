using Tyuiu.KonevaDD.Sprint3.Task6.V19.Lib;
namespace Tyuiu.KonevaDD.Sprint3.Task6.V19
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = 10;
            int stopValue = 15;
            Console.WriteLine("Начала отрезка  = " + startValue);
            Console.WriteLine("Конец отрезка  =  " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();

        }


    }




}