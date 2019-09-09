using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab2._5._2 {
    internal class FileWorker1 {
        public static List<String> readStudents(String path1) {
            
            String[] pathString = path1.Split('\\');
            StringBuilder path = new StringBuilder();
            foreach (String s in pathString) 
            {
                path.Append(s).Append("//");
            }
            path.Remove(path.Length - 2,2);
            List<String> students = new List<String>();
            using (StreamReader reader = new StreamReader(path.ToString(),Encoding.Default)) {
                String line;
                while ((line = reader.ReadLine()) != null) {
                    students.Add(line);
                }
            }
            return students;
        }
    }
}