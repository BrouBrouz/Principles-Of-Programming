using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Dog
    {
        
        public string Name { get; set; }

        public string Breed { get; set; }



        public void Bark()
        {
            Console.WriteLine("Woof woof!");
        }
    }
}
