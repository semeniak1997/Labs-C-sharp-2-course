using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2._5._3.Student {
    class FileWorker {

        public void writeStudents(ListBox.ObjectCollection students, String path1) {
            String[] pathString = path1.Split('\\');
            StringBuilder path = new StringBuilder();
            foreach (String s in pathString) {
                path.Append(s).Append("//");
            }
            path.Remove(path.Length - 2, 2);
            using (StreamWriter writer = new StreamWriter(path.ToString(), false, Encoding.Default)) {
                foreach (String student in students) {
                    writer.WriteLine(student);
                }
            }
        }
        
    }
}
