using Tyuiu.KonevaDD.Sprint3.Task5.V19.Lib;
namespace Tyuiu.KonevaDD.Sprint3.Task5.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 2;
            int startValue1 = 1; 
            int stopValue1 = 1;
            int startValue2 = 3;
            int stopValue2 = 6;
            Console.WriteLine("Переменная Х  = " + x);
            Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
            Console.WriteLine("Конец шага первой суммы ряда = " + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда = " + startValue2);
            Console.WriteLine("Конец шага второй суммы ряда = " + stopValue2);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда  = " + ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2));
            Console.ReadKey();
        }
    }
}
