using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Dvumer
    {
        private double[][] doubleArray;
        private double n, m;

        public Dvumer(int n, int m)
        {
            this.n = n;
            this.m = m;
            doubleArray = new double[n][];
            for (int i = 0; i < doubleArray.Length; i++)
            {
                doubleArray[i] = new double[m];
            }

        }
        public void VvodMatrizy()
        {
            for (int i = 0; i < doubleArray.Length; i++)
                for (int j = 0; j < doubleArray.Length; j++)
                {
                    Console.Write("Матрица [{0},{1}] = ", i + 1, j + 1);
                    doubleArray[i][j] = double.Parse(Console.ReadLine());
                }
        }
        public void VyvodMatrizy()
        {
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < doubleArray.Length; j++)
                {
                    Console.Write(doubleArray[i][j] + "\t");
                }
            }
        }
        public void SortirovkaMatrizy()
        {
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Array.Sort(doubleArray[i]);
                Array.Reverse(doubleArray[i]);
            }
        }
        public double RazmerMatrizy
        {
            get
            {
                return (n * m);
            }
            set { }
        }
        public double Scal
        {
            set
            {
                for (int i = 0; i < doubleArray.Length; i++)
                    for (int j = 0; j < doubleArray.Length; j++)
                    {
                        doubleArray[i][j] *= value;
                    }

            }
        }
        public static Dvumer operator ++(Dvumer matr)
        {
            for (int i = 0; i < matr.doubleArray.Length; i++)
                for (int j = 0; j < matr.doubleArray.Length; j++)
                {
                    matr.doubleArray[i][j]++;
                }
            return matr;
        }
        public static Dvumer operator --(Dvumer matr)
        {
            for (int i = 0; i < matr.doubleArray.Length; i++)
                for (int j = 0; j < matr.doubleArray.Length; j++)
                {
                    matr.doubleArray[i][j]--;
                }
            return matr;
        }
        public static bool operator !(Dvumer matr)
        {
            bool f = false;
            for (int i = 0; i < matr.doubleArray.Length - 1; i++)
                for (int j = 0; j < matr.doubleArray.Length - 1; j++)
                {
                    if (matr.doubleArray[i][j] > matr.doubleArray[i + 1][j + 1])
                    {
                        f = true;
                        break;
                    }
                }
            return f;
        }
        public static Dvumer operator *(Dvumer matr, int sc)
        {
            for (int i = 0; i < matr.doubleArray.Length; i++)
                for (int j = 0; j < matr.doubleArray.Length; j++)
                {
                    matr.doubleArray[i][j] *= sc;
                }
            return matr;
        } 
    }
}