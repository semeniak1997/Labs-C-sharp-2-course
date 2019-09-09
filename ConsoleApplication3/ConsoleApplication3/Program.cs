using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    abstract class Function
    {
        public double x, A, B, C, k;
        public string name, uravnenie;
        public Function(double x, double A, double B, double C)
        {
            this.x = x;
            this.A = A;
            this.B = B;
            this.C = C;

        }
        public Function(double x, double k)
        {
            this.x = x;
            this.k = k;
        }
        public abstract double f();
        public abstract string Name1();
        public abstract string Uravnenie1();
    }
    class Line: Function
    {
        public Line(double x, double A, double B, double C) : base(x, A, B, C) { }
        public override double f()
        {
            this.x = x;
            this.A = A;
            this.B = B;
            double y = A * x + B;
            return y;
        }
        public override string Name1()
        {
            name = "Прямая";
            return name;
        }
        public override string Uravnenie1()
        {
            uravnenie = "y = ax + b";
            return uravnenie;
        }
    }
    class Kub : Function
    {
        public Kub(double x, double A, double B, double C) : base(x, A, B, C) { }
        public override double f()
        {
            this.x = x;
            this.A = A;
            this.B = B;
            this.C = C;
            double y = A * Math.Pow(x, 2) + B * x + C;
            return y;
        }
        public override string Name1()
        {
            name = "Парабола";
            return name;
        }
        public override string Uravnenie1()
        {
            uravnenie = "y = ax^2 + bx + c";
            return uravnenie;
        }
    }
    class Hyperbola: Function
    {
        public Hyperbola(double x, double k) : base(x, k) { }
        public override double f()
        {
            this.x = x;
            this.k = k;
            double y = k / x;
            return y;
        }
        public override string Name1()
        {
            name = "Гипербола";
            return name;
        }
        public override string Uravnenie1()
        {
            uravnenie = "y = k / x (k < 0)";
            return uravnenie;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Function[] function = new Function[3];
            function[0] = new Line(1.2, 0.3, 1.5, 1.7);
            function[1] = new Kub(1.2, 0.3, 1.5, 1.7);
            function[2] = new Hyperbola(1.2, -1.5);
            foreach(Function fun in function)
            {
                Console.WriteLine("График '{0}' имеет уравнение вида {1} при x = 1.2, A = 0.3, B = 1.5, C = 1.7, k = -1.5. Функция принимает значение -> {2}", fun.Name1(), fun.Uravnenie1(), fun.f());
            }
            Console.ReadKey();
        }
    }
}
