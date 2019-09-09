using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ArrIn
    {
        public int[] IntArray;
        private int n;
        int a, b;
        private int max, min, sum;
        bool T;

        public ArrIn(int n) //конструктор
        {
            this.n = n;
            IntArray = new int[n];
            Console.WriteLine("Запаолнение массива нулями");

            for (int i = 0; i < IntArray.Length; i++) // заполнение 1-го массива нулями
            {
                IntArray[i] = 0;
                Console.Write(IntArray[i] + " ");
            }
            Console.WriteLine();
        }

        public ArrIn(int n, int a, int b)
        {
            this.a = a;
            this.b = b;
            IntArray = new int[n];
            Random values = new Random();
            Console.WriteLine("Массив случайных чисел на отрезке [a,b] без сортировки: ");
            for (int j = 0; j < n; j++)
            {
                IntArray[j] = values.Next(-10, 20);        //Заполнение нового массива с рандомом
                if (j > a && j < b)
                    Console.Write(IntArray[j] + " ");    //Вывод массива с рандомом
            }
            Console.WriteLine();
        }
        public ArrIn(int n, int a, int b, bool T)
        {
            this.n = n;
            this.a = a;
            this.b = b;
            this.T = T;
            IntArray = new int[n];
            Random values = new Random();
            Console.WriteLine("Новый массив случайных чисел с сортировкой на отрезке [a,b]: ");
            for (int k = 0; k < n; k++)
            {
                IntArray[k] = values.Next(-20, 10);
                if (IntArray[k] >= a && IntArray[k] < b) //Проверяем каждый индекс в массиве для отрезка
                {
                    Console.Write(IntArray[k] + " "); //вывод пребразованного массива для отрезка
                }


            }
        }
        public void AIPvvod()
        {

            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write("{0}-й элемент -> ", i + 1);
                IntArray[i] = int.Parse(Console.ReadLine());
            }

        }

        public void AIPvyvod()
        {
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.WriteLine(IntArray[i] + " ");
            }

        }
        public void AIPsortirovka()
        {
            int temp;
            for (int k = 0; k < IntArray.Length; k++)
                for (int m = k + 1; m < IntArray.Length; m++)
                    if (IntArray[k] > IntArray[m])
                    {
                        temp = IntArray[k];
                        IntArray[k] = IntArray[m];
                        IntArray[m] = temp;
                    }
        }

        public int Razmernost
        {
            get
            {
                return n;

            }
            set { }
        }
        public int MaxElem
        {
            get
            {
                return max = IntArray.Max();
            }
            set
            { }
        }
        public int MinElem
        {
            get
            {
                return min = IntArray.Min();
            }
            set
            { }
        }
        public int Umnogenie
        {

            set
            {

                for (int i = 0; i < IntArray.Length; i++)
                {
                    IntArray[i] *= value;
                }
                string s = IntArray.ToString();
            }
        }
        public int Summa
        {
            get
            {
                return sum = IntArray.Sum(); ;
            }
            set
            {
            }
        }

        public static ArrIn operator ++(ArrIn array)
        {
            for (int i = 0; i < array.IntArray.Length; i++)
                array.IntArray[i]++;
            return array;

        }
        public static ArrIn operator --(ArrIn array)
        {
            for (int i = 0; i < array.IntArray.Length; i++)
                array.IntArray[i]--;
            return array;
        }
        public static bool operator !(ArrIn array)
        {
            bool f = false;
            for (int i = 0; i < array.IntArray.Length - 1; i++)
            {
                if (array.IntArray[i] > array.IntArray[i + 1])
                {
                    f = true;
                    break;
                }
            }
            return f;
        }
        public static ArrIn operator *(ArrIn array, int sc)
        {
            for (int i = 0; i < array.IntArray.Length; i++)
                array.IntArray[i] *= sc;
            return array;
        } 
    }
}