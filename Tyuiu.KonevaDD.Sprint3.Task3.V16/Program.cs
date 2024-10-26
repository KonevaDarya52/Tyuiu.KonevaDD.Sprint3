using Tyuiu.KonevaDD.Sprint3.Task3.V16.Lib;
namespace Tyuiu.KonevaDD.Sprint3.Task3.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value = "ice nice ice creamcc";
            char chr = 'c';
            Console.WriteLine("Исходная строка  = " + value);
            Console.WriteLine("Искомый символ = " + chr);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество символов = " + ds.GetCharCount(value, chr));
            Console.ReadKey();



        }






    }
    
        








 } 
