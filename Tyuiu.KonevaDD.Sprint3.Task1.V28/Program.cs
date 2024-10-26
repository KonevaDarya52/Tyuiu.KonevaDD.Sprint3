using Tyuiu.KonevaDD.Sprint3.Task1.V28.Lib;
namespace Tyuiu.KonevaDD.Sprint3.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = 1;
            int stopValue = 18; 
            double a = 0.5; 
            Console.WriteLine("Переменная  a =  " + a);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага =  " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(a, startValue, stopValue));
            Console.ReadKey();
        }
    }    }

