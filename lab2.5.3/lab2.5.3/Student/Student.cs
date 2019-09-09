using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._5._3.Student {
    class Student 
    {
        private String name;
        private String surName;
        private double mark;

        public Student(String name, String surName, double mark) 
        {
            this.name = name;
            this.surName = surName;
            this.mark = mark;
        }
        public override string ToString() 
        {
            return name+" "+surName+" "+mark;
        }

        public static Boolean operator true(Student student) 
        {
            return student.mark >= 4.0;
        }
        public static Boolean operator false(Student student) {
            return student.mark < 4.0;
        }
    }
}
