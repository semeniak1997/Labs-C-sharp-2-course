using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Регистрация
{
    public partial class Registration : Form
    {
        private string Familia;
        private string Name;

        private List<string> target;
        private string pol;
        private string days;
        private string month;
        private string year;
        private string email;
        private string number;
        private string place;
        private string otch;
        private int min;
        private int max;
        private string oper;
        private string svedenia;

        public Registration()
        {
            InitializeComponent();
        }

        private void Man_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            pol = radioButton.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            days = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            month = comboBox2.SelectedItem.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = comboBox3.SelectedItem.ToString();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            min = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            max = (int)numericUpDown2.Value;
        }



        private void Saving_Click(object sender, EventArgs e)
        {
            Familia = textFam.Text;
            Name = textName.Text;
            otch = textOtch.Text;
            place = textBox1.Text;
            number = textBox3.Text;
            email = textBox2.Text;
            using (StreamWriter sw = new StreamWriter("regis.txt", true, System.Text.Encoding.Default))
            {
                string line = String.Format("Фамилия: {0} Имя: {1} Отчество: {2}; Пол: {3}; Дата рождения: {4} {5} {6}; Место проживания: {7}; E-mail: {8}; GSM: {9}; Опыт работы: {10}; Объем з/п: от {11} до {12}; Краткое резюме: {13}", Familia, Name, otch);
                
            }
            MessageBox.Show("Вы зарегистрированы", "Сообщение");











        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            svedenia = checkedListBox1.Text;
        }
    }


}
