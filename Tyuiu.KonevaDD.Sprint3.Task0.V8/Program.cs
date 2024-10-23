using Tyuiu.KonevaDD.Sprint3.Task0.V8.Lib;
namespace Tyuiu.KonevaDD.Sprint3.Task0.V8
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
            int stopValue = 10;
            double value = 0.25;
            Console.WriteLine("Переменная X =  " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага =  " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма рада = " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();



        }






    }






}