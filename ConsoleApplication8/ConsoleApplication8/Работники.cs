using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication8
{
    class Program
    {
       static void Main(string[] args)
        {
            // Читаем из файла
            string[] allLines = File.ReadAllLines("input.txt");
            // Преобразуем в массив работников
            Rabotniki[] rabotniki = new Rabotniki[allLines.Length];
            for (int i = 0; i < allLines.Length; i++)
            {
                string line = allLines[i];
                string[] fields = line.Split(';');
                Rabotniki rabotnikiii = new Rabotniki(fields[0], Convert.ToInt32(fields[1]), ( fields[2]), Convert.ToInt32(fields[3]), Convert.ToInt32(fields[4]));
                rabotniki[i] = rabotnikiii;
            }
            
            Array.Sort(rabotniki);
            Array.Reverse(rabotniki);
            
            foreach (Rabotniki rab in rabotniki)
            {
                Console.WriteLine(rab);
                Console.WriteLine();
            }
            // Преобразуем в удобный для записи вид
            string[] linesToSave = new string[rabotniki.Length];
            for (int i = 0; i < rabotniki.Length; i++)
            {
                Rabotniki rabot = rabotniki[i];
                if (rabot.Zp < 800)
                { linesToSave[i] = rabot.ToString(); }
            }
           
            File.WriteAllLines("output.txt", linesToSave);
            Console.WriteLine("Запись в файл выполнена успешно, нажмите Enter, чтобы выйти из программы");
            Console.ReadKey();
        }
        class Rabotniki: IComparable
        {
            public Rabotniki(string name, int godPrinatia, string doljnost, int zp, int rabochyStaj)
                
            {
                this.Name = name;
                this.GodPrinatis = godPrinatia;
                this.Doljnost = doljnost;          
                this.Zp = zp;
                this.RabochyStaj = rabochyStaj;              
            }
            public string Name { get; private set; }
            public int GodPrinatis { get; private set; }
            public string Doljnost { get; private set; }
            public int Zp { get; private set; }
            public int RabochyStaj { get; private set; }
      
            public int CompareTo(object obj)
            {
                return RabochyStaj.CompareTo(((Rabotniki)obj).RabochyStaj); 
            }
            public override string ToString()
            {
                return string.Format("FIO: {0}; God Prinyatia - {1}; Doljnost: {2}; z/p: {3}; Rabochy Staj - {4};",
                                     Name, GodPrinatis, Doljnost, Zp, RabochyStaj);
            }
        }
    }
    }

