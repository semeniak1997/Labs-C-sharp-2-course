using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    abstract class Telefonny_spravochnic
    {
        public string name, adress, phonenumber, fax, contactlico, birthday;
        public abstract void Vyvod();
    }
    class Person: Telefonny_spravochnic
    {
        public Person()
        {
            name = "Инструктор";
            adress = "Проспект Румлёвский";
            phonenumber = "+375333222063";
            fax = null;
            contactlico = null;
            birthday = null;
        }
        public override void Vyvod()
        {
            Console.Write("Имя -> {0}, ", name);
            Console.Write("Адрес -> {0}, ", adress);
            Console.WriteLine("Номер телефона -> {0}", phonenumber);
        }
    }
    class Organization: Telefonny_spravochnic
    {
        public Organization()
        {
            name = "ГрГУ им. Янки Купалы";
            adress = "Ожешко 22";
            phonenumber = "578452";
            fax = "578452";
            contactlico = "Ливак Елена Николаевна";
            birthday = null;
        }
        public override void Vyvod()
        {
            Console.Write("Имя -> {0}, ", name);
            Console.Write("Адрес -> {0}, ", adress);
            Console.Write("Номер телефона -> {0}, ", phonenumber);
            Console.Write("Факс -> {0}, ", fax);
            Console.WriteLine("Контактное лицо -> {0}", contactlico);
        }
    }
    class Friend: Telefonny_spravochnic
    {
        public Friend()
        {
            name = "Паша";
            adress = "Поповича 18 - 48";
            phonenumber = "+375293816331";
            birthday = "23.03.1998";
            fax = null;
            contactlico = null;
        }
        public override void Vyvod()
        {
            Console.Write("Имя -> {0}, ", name);
            Console.Write("Адрес -> {0}, ", adress);
            Console.Write("Номер телефона -> {0}, ", phonenumber);
            Console.WriteLine("День рождения -> {0}", birthday);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Vyvod();
            Organization organization = new Organization();
            organization.Vyvod();
            Friend friend = new Friend();
            friend.Vyvod();
            Console.WriteLine("Нажмите Enter, чтобы выполнить запись контактов в массив ->");
            Console.ReadLine();
            Telefonny_spravochnic[] telefon = new Telefonny_spravochnic[3];
            telefon[0] = new Person();
            telefon[1] = new Organization();
            telefon[2] = new Friend();
            foreach(Telefonny_spravochnic tel in telefon)
            {
                Console.WriteLine("Имя -> {0}, Адрес -> {1}, Факс -> {2}, Контактное лицо -> {3}, Дата рождения -> {4}.", tel.name, tel.adress, tel.fax, tel.contactlico, tel.birthday);
            }
            Console.Write("Выполните поиск по имени -> ");
            string poisk = Convert.ToString(Console.ReadLine());
            if (poisk == person.name)
            { person.Vyvod(); }
                if (poisk == organization.name)
                { organization.Vyvod();}
                    if(poisk == friend.name)
                    { friend.Vyvod(); }
            else
            {
                Console.WriteLine("Такого контакта нет.");
            }                    
            Console.ReadKey();
        }
    }
}
