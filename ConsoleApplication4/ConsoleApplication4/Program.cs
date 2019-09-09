using ConsoleApplication4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    abstract class Figure
    {
        public string name;
        public double a, b, c, h, R;

        public Figure(double a, double b, double c, double h, double R)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.h = h;
            this.R = R;
        }
        public abstract double Ploschad1();
        public abstract double Perimetr1();
        public abstract string Name1();
    }
    class Rectangle : Figure
    {
        public Rectangle(double a, double b, double c, double h, double R) : base(a, b, c, h, R) { }
        public override double Ploschad1()
        {
            this.a = a;
            this.b = b;
            double ploschad;
            ploschad = a * b;
            return ploschad;
        }
        public override double Perimetr1()
        {
            this.a = a;
            this.b = b;
            double perimetr = 2 * (a + b);
            return perimetr;
        }
        public override string Name1()
        {
            name = "Прямоугольник";
            return name;
        }
    }
    class Circle : Figure
    {
        public Circle(double a, double b, double c, double h, double R) : base(a, b, c, h, R) { }
        public override double Perimetr1()
        {
            this.R = R;
            double perimetr = 2 * Math.PI * R;
            return perimetr;
        }
        public override double Ploschad1()
        {
            this.R = R;
            double ploschad = Math.PI * Math.Pow(R, 2);
            return ploschad;
        }
        public override string Name1()
        {
            this.name = name;
            name = "Круг";
            return name;
        }
    }
    class Triangle : Figure
    {
        public Triangle(double a, double b, double c, double h, double R) : base(a, b, c, h, R) { }
        public override double Perimetr1()
        {
            this.a = a;
            this.b = b;
            this.c = c;
            double perimetr = a + b + c;
            return perimetr;
        }
        public override double Ploschad1()
        {
            this.c = c;
            this.h = h;
            double ploschad = 0.5 * c * h;
            return ploschad;
        }
        public override string Name1()
        {
            name = "Треугольник";
            return name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(12.0, 6.0, 0, 0, 0);
            Console.Write("Ваша фигура: ");
            Console.WriteLine(rectangle.Name1());
            Console.Write("Площадь: ");
            Console.WriteLine(rectangle.Ploschad1());
            Console.Write("Периметр: ");
            Console.WriteLine(rectangle.Perimetr1());
            Console.WriteLine("Нажмите Enter, чтобы продолжить ->");
            Console.ReadLine();

            Circle circle = new Circle(0, 0, 0, 0, 3.0);
            Console.Write("Ваша фигура: ");
            Console.WriteLine(circle.Name1());
            Console.Write("Площадь: ");
            Console.WriteLine(circle.Ploschad1());
            Console.Write("Периметр: ");
            Console.WriteLine(circle.Perimetr1());
            Console.WriteLine("Нажмите Enter, чтобы продолжить ->");
            Console.ReadLine();


            Triangle triangle = new Triangle(8.0, 10.0, 12.0, 6.0, 0);
            Console.Write("Ваша фигура: ");
            Console.WriteLine(triangle.Name1());
            Console.Write("Площадь: ");
            Console.WriteLine(triangle.Ploschad1());
            Console.Write("Периметр: ");
            Console.WriteLine(triangle.Perimetr1());
            Console.WriteLine("Нажмите Enter, чтобы продолжить ->");
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}