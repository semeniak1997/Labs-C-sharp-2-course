using lab2._5.backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab2._5
{
    public partial class Form1 : Form
    {
        private String MESSAGE = "Поле не обозначено для ввода.";
        private readonly ErrorProvider errorProvider;
        private Person person = new Person();

        public Form1()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider(this); //ссылка на ошибки
            errorProvider.BlinkRate = 0;
            errorProvider.SetError(textBoxAddress, MESSAGE); //сообщение, если неверный адрес
            errorProvider.SetError(textBoxSurname, MESSAGE); // фамилия
            errorProvider.SetError(textBoxName, MESSAGE); // имя

        }

        private void textBoxMobile_Validating(object sender, CancelEventArgs e) // если не введен номер
        {
            if (!IsPhoneNumberValid(textBoxMobile.Text))
            {
                errorProvider.SetError(textBoxMobile, "Введите номер");
            }
        }

        private bool IsPhoneNumberValid(string phoneNumber) // форма для заполнения номера
        {
            string pattern = @"^\+375(29|33|44)[0-9]{7}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void textBoxMobile_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxMobile, "");
        }

        private void radioButtonGender_CheckedChanged(object sender, EventArgs e) //выбор пола 
        {
            RadioButton radioButton = (RadioButton)sender;
            person.Gender = radioButton.Text;
        }

        private void radioButtonExperience_CheckedChanged(object sender, EventArgs e) //выбор опыта работы
        {
            RadioButton radioButton = (RadioButton)sender;
            person.Experience = radioButton.Text;
        }


        private void richTextBoxSummary_TextChanged(object sender, EventArgs e) // желаемая з.п.
        {
            person.Summary = richTextBoxSummary.Rtf;
        }

        private void buttonSave_Click(object sender, EventArgs e) //сохранение
        {
            if (textBoxName.Text == "" || textBoxSurname.Text == "" || textBoxAddress.Text == "")
            {
                labelAdd.Text = "Вы были не добавлены!";
                labelAdd.Visible = true;
            }
            else
            {
                person.SurName = textBoxSurname.Text;
                person.Name = textBoxName.Text;
                person.Patronymic = textBoxPatr.Text;
                person.Date = dateTimeBirth.Value;
                person.Address = textBoxAddress.Text;
                person.OperatorPhone1 = comboBoxProvider.Text;
               
                    using (StreamWriter sw = new StreamWriter("registration.txt", true, System.Text.Encoding.Default))
                    {
                        string line = String.Format("Фамилия: {0} Имя: {1} Отчество: {2}; Пол: {3}; Дата рождения: {4} Место проживания: {5}; E-mail: {6}; GSM: {7}; Опыт работы: {8}; Объем з/п: от {9} до {10}; Краткое резюме: {11}", person.Name, person.SurName, person.Patronymic, person.Gender, person.Date, person.Address, person.Email, person.MobilePhone, person.Experience, person.FistWage, person.SecondWage, person.Summary);
                        sw.Write(person.ToString());
                    }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e) //отмена
        {
            Close();
        }


        private void SetButtonEnabled()
        {
            foreach (Control control in Controls) // если поле пустое
            {
                if (string.IsNullOrEmpty(errorProvider.GetError(control))) continue;
                buttonSave.Enabled = false;
                return;
            }
            buttonSave.Enabled = true;
        }
        private void textBoxAddress_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxAddress.Text == "")
            {
                errorProvider.SetError(textBoxAddress, MESSAGE);
            }
            else
            {
                errorProvider.SetError(textBoxAddress, "");
            }
            SetButtonEnabled();
        }


        private void textBoxSurname_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxSurname.Text == "")
            {
                errorProvider.SetError(textBoxSurname, MESSAGE);
            }
            else
            {
                errorProvider.SetError(textBoxSurname, "");
            }
            SetButtonEnabled();

        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxName.Text == "")
            {
                errorProvider.SetError(textBoxName, MESSAGE);
            }
            else
            {
                errorProvider.SetError(textBoxName, "");
            }
            SetButtonEnabled();
        }

       

    }
}