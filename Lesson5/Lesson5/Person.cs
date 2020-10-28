using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Person
    {
        public string name;
        public int age;
        public string email;

        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        public Person(string name, int age) : this(name, age, "")
        {

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value<0 || value>100)
                {
                    throw new ArgumentOutOfRangeException("The age must be between 1 and 100");
                }
                age = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new FormatException("Invalid e-mail format!");
                }
                email = value;
            }
        }

        public override string ToString()
        {
            return $"Person {Name}, age = {Age}, E-Mail = {email}";
        }
    }
}
