using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine(" ---------- BROUSSART MAXIME ----------\n");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("               LESSON 2                \n");
                System.Threading.Thread.Sleep(500);
                Console.Write("Menu :\n"
                                     + " 1  - Task 1 : Me after Ten\n"
                                     + " 2  - Task 2 : Simple Formulas\n"
                                     + " 3  - Task 3 : Date\n"
                                     + " 4  - Task 4 : Future Birthday\n"
                                     + "\n"
                                     + " 5  - Homework 1  : Hello!\n"
                                     + " 6  - Homework 2  : Sum\n"
                                     + " 7  - Homework 3  : Specified Operations\n"
                                     + " 8  - Homework 4  : Multiplication Of 3 Numbers\n"
                                     + " 9  - Homework 5  : Multiplication Table\n"
                                     + " 10 - Homework 6  : Average of 4 numbers\n"
                                     + " 11 - Homework 7  : Between 100 and 200 ?\n"
                                     + " 12 - Homework 8  : Current Date\n"
                                     + " 13 - Homework 9  : Age of birth\n"
                                     + " 14 - Homework 10 : Operations\n\n"
                                     + "Choose an exersice > ");
                int exerciseSelected = CheckIfStringIsPositiveInteger(Console.ReadLine());
                Console.Clear();
                switch (exerciseSelected)
                {
                    case 1:
                        Console.WriteLine("You chose : 1  - Task 1 : Me After Ten\n");
                        Task1_MeAfterTen();
                        break;
                    case 2:
                        Console.WriteLine("You chose : 2  - Task 2 : Simple Formulas\n");
                        Task2_SimpleFormulas();
                        break;
                    case 3:
                        Console.WriteLine("You chose : 3  - Task 3 : Date\n");
                        Task3_Dates();
                        break;
                    case 4:
                        Console.WriteLine("You chose : 4  - Task 4 : Future Birthday\n");
                        Task4_FutureBirthday();
                        break;
                    case 5:
                        Console.WriteLine("You chose : 5  - Homework 1 : Hello!\n");
                        Homework1_HelloName();
                        break;
                    case 6:
                        Console.WriteLine("You chose : 6  - Homework 2 : Sum\n");
                        Homework2_Sum();
                        break;
                    case 7:
                        Console.WriteLine("You chose : 7  - Homework 3 : Specified Operations\n");
                        Homework3_SpecifiedOperations();
                        break;
                    case 8:
                        Console.WriteLine("You chose : 8  - Homework 4 : Multiplication of 3 Numbers\n");
                        Homework4_MultiplicationOf3Numbers();
                        break;
                    case 9:
                        Console.WriteLine("You chose : 9  - Homework 5 : Multiplication Table\n");
                        Homework5_MultiplicationTable();
                        break;
                    case 10:
                        Console.WriteLine("You chose : 10  - Homework 6 : Average of 4 numbers\n");
                        Homework6_AverageOf4Numbers();
                        break;
                    case 11:
                        Console.WriteLine("You chose : 11  - Homework 7 : Between 100 and 200 ?\n");
                        Homework7_Between100and200();
                        break;
                    case 12:
                        Console.WriteLine("You chose : 12  - Homework 8 : Current Date\n");
                        Homework8_CurrentDay();
                        break;
                    case 13:
                        Console.WriteLine("You chose : 13  - Homework 9 : Age of Birth\n");
                        Homework9_AgeOfBirth();
                        break;
                    case 14:
                        Console.WriteLine("You chose : 14  - Homework 10 : Operations\n");
                        Homework10_Operations();
                        break;
                    default:
                        Console.WriteLine("Error : The number selected is out of range");
                        break;
                }
                Console.WriteLine("\nType Escape to leave or any other key to select another exercise.");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
        }

        static int CheckIfStringIsPositiveInteger(string stringRead)
        {
            int integer;
            bool check = Int32.TryParse(stringRead, out integer);
            while (check == false || integer < 0)
            {
                Console.Write("Error, this is not a positive integer, please try again > ");
                string newTry = Console.ReadLine();
                check = Int32.TryParse(newTry, out integer);
            }
            return integer;
        }

        static void Task1_MeAfterTen()
        {
            Console.Write("Hello, How old are you? ");
            int ageAsInt = CheckIfStringIsPositiveInteger(Console.ReadLine());
            int ageAfterTen = ageAsInt + 10;
            Console.WriteLine($"Your age after 10 years will be {ageAsInt + 10} years");
        }

        static void Task2_SimpleFormulas()
        {
            Console.WriteLine("Choose a geometric shape :\n\n"
                + " 1 - Rectangle\n"
                + " 2 - Isosceles Triangle\n"
                + " 3 - Circle\n");
            int geometricShape = CheckIfStringIsPositiveInteger(Console.ReadLine());
            if (geometricShape == 1)
            {
                Console.Write("Type the length of the rectangle > ");
                int length = CheckIfStringIsPositiveInteger(Console.ReadLine());
                Console.Write("Type the width of the rectangle > ");
                int width = CheckIfStringIsPositiveInteger(Console.ReadLine());
                Console.WriteLine($"\nThe perimeter of the rectangle is {2 * (length + width)}");
                Console.WriteLine($"The area of the rectangle is {length * width}");
            }
            else if (geometricShape == 2)
            { //We consider that the user has information about the triangle
                Console.Write("Type the length of the side 1 > ");
                int side1 = CheckIfStringIsPositiveInteger(Console.ReadLine());
                Console.Write("Type the length of the side 2 > ");
                int side2 = CheckIfStringIsPositiveInteger(Console.ReadLine());
                Console.Write("Type the length of the side 3 > ");
                int side3 = CheckIfStringIsPositiveInteger(Console.ReadLine());
                Console.Write("Type the length of the altitude > ");
                int altitude = CheckIfStringIsPositiveInteger(Console.ReadLine());
                Console.WriteLine($"\nThe perimeter of the isosceles triangle is {side1 + side2 + side3}");
                Console.WriteLine($"The area of the isosceles triangle is {side1 * altitude / 2}");
            }
            else if (geometricShape == 3)
            {
                Console.Write("Type the radius of the circle > ");
                int radius = CheckIfStringIsPositiveInteger(Console.ReadLine());
                double pi = Math.PI;
                Console.WriteLine($"\nThe perimeter of the circle is {Math.Round(2 * pi * radius, 2)}");
                Console.WriteLine($"The area of the circle is {Math.Round(pi * radius * radius, 2)}");
            }
            else
            {
                Console.WriteLine("Error : the number selected doesn't correspond to a geometric shape proposed");
            }
        }

        static void Task3_Dates()
        {
            DateTime date = DateTime.Now;

            Console.Write("Current date: ");
            Console.WriteLine(date.ToShortDateString());

            Console.Write("Current time: ");
            Console.WriteLine(date.ToShortTimeString());

            Console.Write("The date in 10 years will be : ");
            Console.WriteLine(date.AddYears(10).ToShortDateString());

            Console.Write("Please enter a period (number of years) > ");
            int period = CheckIfStringIsPositiveInteger(Console.ReadLine());
            Console.Write($"The date in {period} years will be : ");
            Console.WriteLine(date.AddYears(period).ToShortDateString());
        }

        static void Task4_FutureBirthday()
        {
            Console.Write("Current age > ");
            int currentAge = CheckIfStringIsPositiveInteger(Console.ReadLine());

            Console.Write("Future age > ");
            int futureAge = CheckIfStringIsPositiveInteger(Console.ReadLine());

            Console.Write("BDay month > ");
            int bdayMonth = CheckIfStringIsPositiveInteger(Console.ReadLine());

            Console.Write("BDay day > ");
            int bdayDay = CheckIfStringIsPositiveInteger(Console.ReadLine());

            int ageDifference = futureAge - currentAge;

            int futurYear = DateTime.Now.Year + ageDifference;

            DateTime futureBday = new DateTime(futurYear, bdayMonth, bdayDay);

            Console.WriteLine($"You will have {futureAge} years old the {futureBday.ToLongDateString()}." +
                $"");
        }

        static void Homework1_HelloName()
        {
            Console.Write("What is your name? > ");
            Console.WriteLine($"Hello {Console.ReadLine()}!");
        }

        static void Homework2_Sum()
        {
            Console.Write("Enter an integer > ");
            int a = CheckIfStringIsPositiveInteger(Console.ReadLine());
            Console.Write("Enter another integer > ");
            int b = CheckIfStringIsPositiveInteger(Console.ReadLine());
            Console.WriteLine($"\nThe Sum : {a} + {b} = {a + b}");
        }

        static void Homework3_SpecifiedOperations()
        {
            Console.WriteLine($"The result of -1 + 4 * 6 = {-1 + 4 * 6}");
            Console.WriteLine($"The result of ( 35+ 5 ) % 7 = {(35 + 5) % 7}");
            Console.WriteLine($"The result of 14 + -4 * 6 / 11 = { 14 + -4 * 6 / 11}");
            Console.WriteLine($"The result of 2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");
        }

        static void Homework4_MultiplicationOf3Numbers()
        {
            Console.Write("Enter a first factor > ");
            int a = CheckIfStringIsPositiveInteger(Console.ReadLine());
            Console.Write("Enter a second factor > ");
            int b = CheckIfStringIsPositiveInteger(Console.ReadLine());
            Console.Write("Enter a third factor > ");
            int c = CheckIfStringIsPositiveInteger(Console.ReadLine());
            Console.WriteLine($"\nThe Multiplication of the 3 factors are : {a} x {b} x {c} = {a * b * c}");
        }

        static void Homework5_MultiplicationTable()
        {
            Console.Write("Enter a number > ");
            int number = CheckIfStringIsPositiveInteger(Console.ReadLine());
            Console.WriteLine($"The multiplication table of this number is : ");
            string space = " ";
            for (int i = 1; i < 11; i++)
            {
                if (i >= 10) space = "";
                Console.WriteLine($"    {number} x {i}{space} = {number * i}");
            }
        }

        static void Homework6_AverageOf4Numbers()
        {
            Console.Write("Enter number (1/4) > ");
            int a = CheckIfStringIsPositiveInteger(Console.ReadLine());
            Console.Write("Enter number (2/4) > ");
            int b = CheckIfStringIsPositiveInteger(Console.ReadLine());
            Console.Write("Enter number (3/4) > ");
            int c = CheckIfStringIsPositiveInteger(Console.ReadLine());
            Console.Write("Enter number (4/4) > ");
            int d = CheckIfStringIsPositiveInteger(Console.ReadLine());
            double average = (a + b + c + d) / 4;
            Console.WriteLine($"\nThe average of those 4 number is : {average}");
        }

        static void Homework7_Between100and200()
        {
            Console.Write("Enter a number > ");
            int number = CheckIfStringIsPositiveInteger(Console.ReadLine());
            if(number<100 || number>200)
            {
                Console.Write($"The number {number} is not between 100 and 200.");
            }
            else
            {
                Console.Write($"The number {number} is between 100 and 200.");
            }
        }

        static void Homework8_CurrentDay()
        {
            Console.WriteLine($"The current day, today, is : " +
                $"{DateTime.Now.ToLongDateString()}");
        }

        static void Homework9_AgeOfBirth()
        {
            Console.Write("How old are you? > ");
            int age = CheckIfStringIsPositiveInteger(Console.ReadLine());
            Console.Write("Did you already get your birthday this year? (1-YES  2-NO) > ");
            int answer = CheckIfStringIsPositiveInteger(Console.ReadLine());
            while ((answer != 2) && (answer != 1))
            {
                Console.Write("Error, you need to enter 1 (for YES) or 2 (for NO) > ");
                answer = CheckIfStringIsPositiveInteger(Console.ReadLine());
            }

            int yearOfBirth = DateTime.Now.Year - age + 1 - answer;

            Console.WriteLine($"You were born in {yearOfBirth}.");
        }

        static void Homework10_Operations()
        {
            Console.Write("Enter a first number X > ");
            int x = CheckIfStringIsPositiveInteger(Console.ReadLine());
            Console.Write("Enter a second number Y > ");
            int y = CheckIfStringIsPositiveInteger(Console.ReadLine());
            Console.Write("Enter a third number Z > ");
            int z = CheckIfStringIsPositiveInteger(Console.ReadLine());

            Console.WriteLine($"\nThe result of (X+Y)*Z = {(x+y)*z}\n"
                + $"The result of X*Y + Y*Z = {(x*y)+(y*z)}");
        }
    }
}