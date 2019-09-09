using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    abstract class Klient
    {
        public string name, date_of_open, razmer, procent, number, ostatok;
        public abstract void InformationOutput();
    }
    class Vlkadchik : Klient
    {
        public Vlkadchik()
        {
            name = "Вячеслав";
            date_of_open = "17.05.2014";
            razmer = "20 млн. рублей";
            procent = "13% годовых";
            
        }
        public override void InformationOutput()
        {
            Console.Write("Фамилия -> {0}, ", name);
            Console.Write("Дата открытия вклада -> {0}, ", date_of_open);
            Console.Write("Сумма на счету -> {0}, ", razmer);
            Console.WriteLine("Процент -> {0}", procent);
        }
    }
    class Kreditor : Klient
    {

        public Kreditor()
        {
            name = "Лобань";
            date_of_open = "18.10.2016";
            razmer = "37 млн. рублей";
            procent = "38% годовых";
            ostatok = "28 млн. рублей";
           
        }
        public override void InformationOutput()
        {
            Console.Write("Фамилия -> {0}, ", name);
            Console.Write("Дата выдачи кредита -> {0}, ", date_of_open);
            Console.Write("Размер кредита -> {0}, ", razmer);
            Console.Write("Процент -> {0}, ", procent);
            Console.WriteLine("Остаток долга -> {0}", ostatok);
        }
    }
    class Organization : Klient
    {
        public Organization()
        {
            name = "Гродно-Азот";
            date_of_open = "06.11.2009";
            razmer = "120 млрд. рублей";
            number = "8752128786";
            
        }
        public override void InformationOutput()
        {
            Console.Write("Наименование -> {0}, ", name);
            Console.Write("Дата открытия счета -> {0}, ", date_of_open);
            Console.Write("Номер -> {0}, ", number);
            Console.WriteLine("Сумма счета -> {0}, ", razmer);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vlkadchik vkladchic = new Vlkadchik();
            vkladchic.InformationOutput();
            Kreditor kreditor = new Kreditor();
            kreditor.InformationOutput();
            Organization organization = new Organization();
            organization.InformationOutput();
            Console.WriteLine();
            Console.WriteLine("Нажмите Enter, чтобы выполнить запись контактов в массив ->");
            Console.ReadLine();
            Klient[] klient = new Klient[3];
            klient[0] = new Vlkadchik();
            klient[1] = new Kreditor();
            klient[2] = new Organization();
            foreach (Klient kl in klient)
            {
                Console.WriteLine("Фамилия/Наименование -> {0}, Дата -> {1}, Размер -> {2}, Процент {3}, Остаток {4}, Номер {5}", kl.name, kl.date_of_open, kl.razmer, kl.procent, kl.ostatok, kl.number);
            }
            Console.WriteLine();
            Console.Write("Введите поиск по дате -> ");
            string poisk = Convert.ToString(Console.ReadLine());
            if (poisk == vkladchic.date_of_open)
            {
                vkladchic.InformationOutput();
            }

            else
            {
                if (poisk == kreditor.date_of_open)
                { kreditor.InformationOutput(); }
                else 
                {
                    if (poisk == organization.date_of_open)
                    { organization.InformationOutput(); }
                    else
                    {
                        Console.WriteLine("Информация отстутствует.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}