using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._5.backend
{
    class Person
    {
        private String SLASH = "/";
        private string surName;
        private string name;
        private String patronymic;
        private DateTime date;
        private String address;
        private String OperatorPhone;
        private String mobilePhone;
        private String gender;
        private String experience;
        private int fistWage;
        private int secondWage;
        private String summary;
        private String email;

        public Person()
        {
        }

        public string SurName
        {
            get
            {
                return surName;
            }

            set
            {
                surName = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Patronymic
        {
            get
            {
                return patronymic;
            }

            set
            {
                patronymic = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string MobilePhone
        {
            get
            {
                return mobilePhone;
            }

            set
            {
                mobilePhone = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Experience
        {
            get
            {
                return experience;
            }

            set
            {
                experience = value;
            }
        }

        public int FistWage
        {
            get
            {
                return fistWage;
            }

            set
            {
                fistWage = value;
            }
        }

        public int SecondWage
        {
            get
            {
                return secondWage;
            }

            set
            {
                secondWage = value;
            }
        }

        public string Summary
        {
            get
            {
                return summary;
            }

            set
            {
                summary = value;
            }
        }

        public string OperatorPhone1
        {
            get
            {
                return OperatorPhone;
            }

            set
            {
                OperatorPhone = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(name).Append(SLASH).Append(surName).Append(SLASH).Append(patronymic).Append(SLASH).Append(gender).Append(SLASH).Append(date.ToString()).Append(SLASH).Append(address).Append(SLASH).Append(mobilePhone).Append(SLASH).Append(experience).Append(SLASH).Append(fistWage).Append(SLASH).Append(secondWage).Append(SLASH).Append(summary);
            return builder.ToString();


        }
    }
}
