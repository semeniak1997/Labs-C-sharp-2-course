using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] allLines = File.ReadAllLines("input.txt");
            
            Student[] students = new Student[allLines.Length];
            for (int i = 0; i < allLines.Length; i++)
            {
                string line = allLines[i];
                string[] fields = line.Split(';');
                Student student = new Student(fields[0], fields[1], Convert.ToInt32(fields[2]), Convert.ToInt32(fields[3]), Convert.ToInt32(fields[4]), Convert.ToInt32(fields[5]));
                students[i] = student;
            }

            Array.Sort(students);

            foreach (Student student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
            
            string[] linesToSave = new string[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                Student student = students[i];
                if (student.Ball1 > 3)
                    if (student.Ball2 > 3)
                        if (student.Ball3 > 3)
                        { linesToSave[i] = student.ToString(); }
            }

            File.WriteAllLines("output.txt", linesToSave);
            Console.WriteLine("Succeeded. Press enter to exit");
            Console.ReadKey();
        }
        class Student : IComparable
        {
            public Student(string name, string homeAddress, int yearOfBirth, int Ball1, int Ball2, int Ball3)

            {
                this.Name = name;
                this.HomeAddress = homeAddress;
                this.YearOfBirth = yearOfBirth;
                this.Ball1 = Ball1;
                this.Ball2 = Ball2;
                this.Ball3 = Ball3;
            }

            public string Name { get; private set; }

            public int YearOfBirth { get; private set; }

            public string HomeAddress { get; private set; }

            public int Ball1 { get; private set; }
            public int Ball2 { get; private set; }
            public int Ball3 { get; private set; }

            public int CompareTo(object obj)
            {
                return YearOfBirth.CompareTo(((Student)obj).YearOfBirth);
            }
            public override string ToString()
            {
                return string.Format("{0}; {1}; {2}; {3}; {4}; {5};",
                                     Name, HomeAddress, YearOfBirth, Ball1, Ball2, Ball3);
            }
        }
        }
}
