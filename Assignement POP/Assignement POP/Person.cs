using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_POP
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty");
                }
                if (value.Length > 14)
                {
                    throw new ArgumentOutOfRangeException("First name must be less than 14 characters");
                }
                firstName = value;
            }
        }


        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty");
                }
                if (value.Length > 15)
                {
                    throw new ArgumentOutOfRangeException("Last name must be less than 15 characters");
                }
                lastName = value;
            }
        }

        public void NormalizeSizeOfLetters()
        {
            firstName = firstName[0].ToString().ToUpper() + firstName.Substring(1).ToLower();
            lastName = lastName.ToUpper();
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
