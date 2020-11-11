using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public static class PersonManager
    {
        static List<Person> people = new List<Person>();

        public static List<Person> CreatePersonList(int numberOfPersons)
        {
            for (int i = 1; i <= numberOfPersons; i++)
            {
                try
                {
                    Console.WriteLine($"Person {i}");

                    Console.Write("Name  : ");
                    string name = Console.ReadLine();

                    Console.Write("Email : ");
                    string email = Console.ReadLine();

                    Console.Write("Age   : ");
                    int age = int.Parse(Console.ReadLine());

                    Person person = new Person(name, email, age);

                    people.Add(person);
                }

                catch(Exception ex)
                {
                    Console.WriteLine($"Error while adding a person {ex.Message}.");
                    Console.WriteLine("Please try again : ");
                }
            }
                return people;
            
        }
    }
}
