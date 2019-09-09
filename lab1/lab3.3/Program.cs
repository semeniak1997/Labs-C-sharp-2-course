using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Читаем из файла
            string[] allLines = File.ReadAllLines("input.txt");
            // Преобразуем в массив вкладчиков
            Bank[] bank = new Bank[allLines.Length];
            for (int i = 0; i < allLines.Length; i++)
            {
                string line = allLines[i];
                string[] fields = line.Split(';');
                Bank baaank = new Bank(fields[0], (fields[1]), Convert.ToInt32(fields[2]), Convert.ToInt32(fields[3]));
                bank[i] = baaank;
            }

            Array.Sort(bank);
            Array.Reverse(bank);

            foreach (Bank b in bank)
            {
                Console.WriteLine(b);
                Console.WriteLine();
            }
            // Преобразуем в удобный для записи вид
            string[] linesToSave = new string[bank.Length];
            for (int i = 0; i < bank.Length; i++)
            {
                Bank baank = bank[i];
                if (baank.Year > 2015)
                { linesToSave[i] = baank.ToString(); }
            }

            File.WriteAllLines("output.txt", linesToSave);
            Console.WriteLine("Запись в файл выполнена успешно, нажмите Enter, чтобы выйти из программы");
            Console.ReadKey();
        }
        class Bank : IComparable
        {
            public Bank(string name, string number, int summa, int year)
            {
                this.Name = name;
                this.Number = number;
                this.Summa = summa;
                this.Year = year;
            }

            public string Name { get; private set; }

            public string Number { get; private set; }

            public int Summa { get; private set; }
            public int Year { get; private set; }

            public int CompareTo(object obj)
            {
                return Summa.CompareTo(((Bank)obj).Summa);
            }
            public override string ToString()
            {
                return string.Format("FIO: {0}; № scheta - {1}; Summa na schete: {2}; God otkrytia: {3};",
                                     Name, Number, Summa, Year);
            }
        }
    }
}

