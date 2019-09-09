using lab2._5._3.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2._5._3 {
    public partial class Form1 : Form 
    {
        private FileWorker worker = new FileWorker(); // для записи в файл
        private readonly ErrorProvider errorProvider; //интерфейс для ошибок
        private Student.Student student;
        public Form1()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider(this);
            errorProvider.BlinkRate = 0;
        }
        private void SetButtonEnabled() 
        {
            foreach (Control control in Controls) // обязательное для ввода поле
            {
                if (string.IsNullOrEmpty(errorProvider.GetError(control))) continue;
                buttonAdd.Enabled = false;
                return;
            }
            buttonAdd.Enabled = true;
        }


        private void textBoxName_Validating(object sender, CancelEventArgs e) 
        {
            if (textBoxName.Text == "") 
            {
                errorProvider.SetError(textBoxName, "Введите фамилию");
            }
            else 
            {
                errorProvider.SetError(textBoxName, "");
            }
        }

        private void textBoxSurname_Validating(object sender, CancelEventArgs e) 
        {
            if (textBoxSurname.Text == "") 
            {
                errorProvider.SetError(textBoxSurname, "Введите имя");
            }
            else {
                errorProvider.SetError(textBoxSurname, "");
            }
        }

        private void textBoxMark_TextChanged(object sender, EventArgs e) 
        {
            Boolean answ = false;
            foreach (Char c in textBoxMark.Text.ToCharArray()) 
            {
                if (Char.IsDigit(c)) 
                {
                    answ = true;
                }
                else 
                {
                    answ = false;
                }
            }
            if (!answ) 
            {
                errorProvider.SetError(textBoxMark, "Вы должны вводить только числа!");
            }
            else 
            {
                errorProvider.SetError(textBoxMark, "");
            }
            SetButtonEnabled();
        }

        private void buttonAdd_Click(object sender, EventArgs e) 
        {
            student = new Student.Student(textBoxName.Text, textBoxSurname.Text, Int32.Parse(textBoxMark.Text)); // ввод в текстбокс
            listBoxStudet.Items.Add(student.ToString()); // добавление
            textBoxMark.Text = "";
            textBoxSurname.Text = "";
            textBoxName.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e) 
        {
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Title = "Файл";
                fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
                if (fd.ShowDialog() == DialogResult.OK && fd.FileName != "") 
                {
                    string fileName = fd.FileName;
                    worker.writeStudents(listBoxStudet.Items, fileName);
                    labelMessage.Text = "All saved!";
                    labelMessage.Visible = true;
                }
        }
            catch 
            {
                MessageBox.Show("Ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNew_Click(object sender, EventArgs e) 
        {
            buttonExit.Visible = true;
        }

       
        private void buttonExit_Click(object sender, EventArgs e) 
        {
            Close();
        }

       
    }
}
