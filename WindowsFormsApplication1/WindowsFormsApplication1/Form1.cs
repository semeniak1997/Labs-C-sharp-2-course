using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void EnterR_Click(object sender, EventArgs e) // метод для введения исходных данных
        {
            CalcS.Enabled = true; // перевод кнопки "Вычислить" в активное состояние
            
            TextS.Text = ""; // очистка окон
            TextC.Text = ""; //вывод результата на экран

        }
        private void CalcS_Click(object sender, EventArgs e) // метод для кнопки "Вычислить"
        {
            double r, s, p;
            r = double.Parse(TextR.Text); //преобразование  в строку символов
            s = Math.PI * Math.Pow(r, 2); // нахождение площади круга
            TextS.Text = s.ToString(); //вывод результата в строку и его отбражение
            p = Math.PI * r * 2.0;         //  нахождение периметра круга
            TextC.Text = p.ToString();
            CalcS.Enabled = false; //перевод кнопки "вычислить" в пассивное состояние
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        
       
    }
}
