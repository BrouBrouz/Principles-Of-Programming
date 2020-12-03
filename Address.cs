using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_POP
{
    public class Address
    {
        int numberOfStreet;
        string street;
        string city;
        string country;

        public Address(int numberOfStreet, string street, string city, string country)
        {
            NumberOfStreet = numberOfStreet;
            Street = street;
            City = city;
            Country = country;
        }

        public int NumberOfStreet
        {
            get
            {
                return numberOfStreet;
            }
            set
            {
                if(value < 1 || value > 2000)
                {
                    throw new ArgumentOutOfRangeException("number of street must be between 1 and 2000");
                }
                numberOfStreet = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Street cannot be empty");
                }
                street = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("City cannot be empty");
                }
                city = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Country cannot be empty");
                }
                country = value;
            }
        }

        public override string ToString()
        {
            return $"{numberOfStreet} {street}\n" +
                   $"{city}\n" +
                   $"{country}";
        }

        public string ToStringInLine()
        {
            return $"{numberOfStreet} {street} - {city} - {country}";
        }
    }
}
