using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Task01();
            Task02();
            Task03();
        }

        private static void Task01()
        {
            Console.WriteLine("TASK 01 - Dogs\n");

            Dog dog = new Dog();
            dog.Name = "Sharo";
            dog.Breed = "Street Universal";
            dog.Bark();

            Console.WriteLine("Type on any key to continue ...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void Task02()
        {
            Console.WriteLine("TASK 02 - Persons\n");

            Person person1 = new Person("John Smith", 22, "jojo@smith.com");

            //Person person2 = new Person("Jana Smith", 20);

            //Person person3 = new Person("", 70);

            //Person person4 = new Person("Ivan", 129);

            Console.WriteLine(person1);

            Console.WriteLine("Type on any key to continue ...");
            Console.ReadKey();
            Console.Clear();

        }

        private static void Task03()
        {
            Laptop computer1 = new Laptop("Lenovo Yoga 2 Pro","Lenovo","Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache", 8, "Intel HD Graphics 4400", 128, "13.3\" (33.78 cm) - 3200 x 1800 (QHD+), IPS sensor display", "Li-Ion, 4-cells, 2550 mAh", 4.5, 2259.00);
            Laptop computer2 = new Laptop("HP 250 G2", 699.00);

            Console.WriteLine(computer1+"\n");
            Console.WriteLine(computer2);

            Console.WriteLine("Type on any key to close the console...");
            Console.ReadKey();
        }
    }
}
