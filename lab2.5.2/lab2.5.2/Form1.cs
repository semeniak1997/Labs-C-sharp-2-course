using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2._5._2 {
    public partial class Form1 : Form {
        private readonly String MESSAGE = "Вы должны вводить только числа!";
        private readonly ErrorProvider errorProvider; //интерфес наличия ошибок
        public Form1() {
            InitializeComponent();
            errorProvider = new ErrorProvider(this);
            errorProvider.BlinkRate = 0;
        }
        private void SetButtonEnabled() 
        {
            foreach (Control control in Controls) 
            {
                if (string.IsNullOrEmpty(errorProvider.GetError(control))) continue; //указывает на пустые строки
                buttonSum.Enabled = false;
                return;
            }
            buttonSum.Enabled = true;
        }

        private void textBoxFirst_Validating(object sender, CancelEventArgs e) 
        {
            Boolean answ = false;
            foreach (Char c in textBoxFirst.Text.ToCharArray()) {
                if (Char.IsDigit(c)) 
                {
                    answ = true;
                }
                else {
                    answ = false;
                }
            }
            if (!answ) //строка не введена
            {
                errorProvider.SetError(textBoxFirst, MESSAGE);
            }
            else {
                errorProvider.SetError(textBoxFirst, "");
            }
            SetButtonEnabled();
        }

        private void textBoxSecond_TextChanged(object sender, EventArgs e) //не будет показывать, пока не введено первое поле
        {
            Boolean answ = false;
            foreach (Char c in textBoxSecond.Text.ToCharArray()) {
                if (Char.IsDigit(c)) {
                    answ = true;
                }
                else {
                    answ = false;
                }
            }
            if (!answ) {
                errorProvider.SetError(textBoxSecond, MESSAGE);
            }
            else {
                errorProvider.SetError(textBoxSecond, "");
            }
            SetButtonEnabled();

        }

        private void buttonSum_Click(object sender, EventArgs e) // для суммы
        {
            try 
            {
                textBoxSum.Enabled = false;
                textBoxSum.Text = (Int32.Parse(textBoxFirst.Text) + Int32.Parse(textBoxSecond.Text)).ToString();
            }
            catch {
                errorProvider.SetError(textBoxSum, "Ошибка");
            }
            
           }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e) // цвет
        {
            this.BackColor = Color.IndianRed;
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e) 
        {
            this.BackColor = Color.AliceBlue;
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void buttonAdd_Click(object sender, EventArgs e) // должна быть введена фамлия
        {
            if (textBoxPerson.Text != "") {
                listBoxPeople.Items.Add(textBoxPerson.Text);
                textBoxPerson.Text = "";
            }
            else {
                errorProvider.SetError(textBoxPerson, "Нечего добавлять!");
            }
        }

        private void listBoxPeople_SelectedIndexChanged(object sender, EventArgs e) // выбор из листбокса
        {
            textBoxPerson.Text = "";
            try 
            {
                textBoxPerson.Text = listBoxPeople.SelectedItem.ToString();
            }
            catch {
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e) //удаление
        {
            listBoxPeople.Items.Remove(textBoxPerson.Text);
            
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e) //рисование мышкой
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            Point point = new Point(e.X, e.Y);
            if (e.Button.Equals(MouseButtons.Left)) 
            {
                Pen pen = new Pen(Color.IndianRed, 30);
                Size size = new Size(5, 5);
                Rectangle rect1 = new Rectangle(point, size);
                g.DrawEllipse(pen, rect1);
            }
            else {
                Pen redPen = new Pen(Color.Green, 30);
                Rectangle r = new Rectangle(point,new Size(1,1));
                g.DrawRectangle(redPen, r);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) //кнопка "Открыть"
        {
            try {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Title = "Файл";
                fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";

                if (fd.ShowDialog() == DialogResult.OK && fd.FileName != "") {
                    string fileName = fd.FileName;
                    foreach (String s in FileWorker1.readStudents(fileName)) {
                        listBoxPeople.Items.Add(s);
                    }
                }
            }
            catch {
                errorProvider.SetError(menuStrip1, "Ошибка");
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e) //изменить шрифт
        {
            FontDialog f = new FontDialog();
            DialogResult result =  f.ShowDialog();
            if (result == DialogResult.OK) {
                listBoxPeople.Font = f.Font;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) // кнопка "Закрыть"
        {
            DialogResult result = MessageBox.Show("Выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) 
            {
                Close();
            }
            
        }

        private void buttonClickMe_Click(object sender, EventArgs e) // нажми на меня
        {
            buttonClick.Visible = true;
        }

        private void buttonClick_Click(object sender, EventArgs e) 
        {
            buttonClick.Text = "Спасибо!";
        }

       
    }
}
