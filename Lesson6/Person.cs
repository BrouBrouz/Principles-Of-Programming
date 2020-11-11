using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, string email, int age)
        {
            Name = name;
            Email = email;
            Age = age;
        }

        public Person(string name, int age) : this(name, null,age)
        {

        }

        public string Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentNullException("Name cannot be okey");
                }

                name = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value == null)
                {
                    email = value;
                }
                else if (value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    throw new SystemException("Incorrect e-mail.");
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if(value<0 || value > 100)
                {
                    throw new System.ArgumentOutOfRangeException("Age must been between 1 and 100");
                }
            }
        }

        public override string ToString()
        {
            return $"{Name} {age} {Email}";
        }
    }
}
