using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Stroka
    {
        public StringBuilder line;
        private int n;
        public bool F;
        private string strChar;
        public string sr;

        public Stroka(int n)
        {
            this.n = n;
            line = new StringBuilder("Здравствуйте! Вы учитесь в ГрГУ им. Янки Купалы, или в ГрГМУ?", n);
        }
        public void KolichestvoProbelov()
        {
            
            strChar = line.ToString();
            string[]st2 = strChar.Split(' ');
            Console.WriteLine(st2.Length - 1);
        }
        public void Zamena()
        {
            line.Replace('З', 'з').Replace('В', 'в').Replace('Г' , 'г').Replace('У' , 'у').Replace('Я' , 'я').Replace('К' , 'к').Replace('М' , 'м');           
        }
        public void Udalenie()
        {
           string strChar =  line.ToString();
           string[] st2 = strChar.Split(',' , '.' , '?', '!');
            string s = null;
            foreach (string ss in st2)
                s += ss;
            Console.WriteLine(s);           
        }

        public int KolvoElementov
        {
            get
            {
                return line.Length;
            }
        }
        public bool ZnacheniePola
        {
            get
            {               
                if (sr == line.ToString())
                {
                    F = true;
                }
                else
                {
                    F = false;
                }
                
                return F;
            }
            set
            {                              
            }
            
            }
       
        public static Stroka operator +(Stroka strochka)
        {
            
            string s = null;
            s += strochka.line.ToString().ToUpper();
            strochka.line.Clear();
            strochka.line.Append(s);
            return strochka;
        }
        public static Stroka operator -(Stroka strochka)
        {
            string s = null;
            s += strochka.line.ToString().ToLower();
            strochka.line.Clear();
            strochka.line.Append(s);
            return strochka;
        }
        public static bool operator true(Stroka strochka)
        {
            if (strochka.line.Length > 0)
                return true;
            else
                return false;
        }
        public static bool operator false(Stroka strochka)
        {
            if(strochka.line.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool operator &(Stroka strochka, Stroka strok)
        {
            if (strochka.line == strok.line)
                return true;
            else
                return false;
        }
        }

    }

