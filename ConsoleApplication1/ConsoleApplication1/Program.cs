using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {//try catch - обработчик исключений
            Console.WriteLine("Введите два числа, для последующего деления: ");
            
            try
            {
                Console.Write("Первое число =  ");
               int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Второе число =  ");
               int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат деления -> {0} ",(double) num/num1);
            }catch (FormatException) // тип исключения, в данном случае: корректность типа данных
            {
                Console.WriteLine("Некорректный формат, введите число типа int");
            }catch(DivideByZeroException) // проверка деления на ноль
            {
                Console.WriteLine("Делить на ноль нельзя!");
            }finally
            {
                //здесь можно писать всё, все команды выполнятся в любом случае
            }

            Console.ReadKey();
        }
    }
}
