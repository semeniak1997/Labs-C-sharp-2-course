using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrIn singleArr = new ArrIn(5);
            singleArr = new ArrIn(5, -3, 4);
            singleArr = new ArrIn(5, -10, 1, true);
            Console.WriteLine();
            Console.WriteLine("Введите элементы массива с клавиатуры: ");
            singleArr.AIPvvod();
            Console.WriteLine();
            singleArr.AIPvyvod();
            Console.WriteLine();
            singleArr.AIPsortirovka();
            singleArr.AIPvyvod();
            Console.WriteLine("Размерность массива: " + singleArr.Razmernost);
            Console.WriteLine("Максимальный элемент массива: " + singleArr.MaxElem);
            Console.WriteLine("Минимальный элемент массива: " + singleArr.MinElem);
            Console.WriteLine("Сумма всех элементов массива: " + singleArr.Summa);
            Console.WriteLine("Умножение на скаляр: " + singleArr.Umnogenie); //?
            singleArr.AIPvyvod();
            
            Console.ReadKey();
        }
    }
}
