using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
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
                Console.WriteLine("               PoP LESSON 3                \n");
                System.Threading.Thread.Sleep(500);
                Console.Write("Menu :\n"
                                     + " 1  - Task 1 : Triangle\n"
                                     + " 2  - Task 2 : Numbers\n"
                                     + " 3  - Task 3 : Sport Selector\n"
                                     + " 4  - Task 4 : Greeting\n"
                                     + " 5  - Task 5 : Form Validation\n\n"
                                     + "Choose an exersice > ");
                int exerciseSelected = CheckIfStringIsPositiveInteger(Console.ReadLine());
                Console.Clear();
                switch (exerciseSelected)
                {
                    case 1:
                        Console.WriteLine("You chose : 1  - Task 1 : Triangle\n");
                        Task01_Triangle();
                        break;
                    case 2:
                        Console.WriteLine("You chose : 2  - Task 2 : Numbers\n");
                        Task02_Numbers();
                        break;
                    case 3:
                        Console.WriteLine("You chose : 3  - Task 3 : Sport Selector\n");
                        Task03_SportSelector();
                        break;
                    case 4:
                        Console.WriteLine("You chose : 4  - Task 4 : Greeting\n");
                        Task04_Greeting();
                        break;
                    case 5:
                        Console.WriteLine("You chose : 5  - Task 5 : Form Validation\n");
                        Task05_FormValidation();
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

        private static void Task01_Triangle()
        {
            Console.Write("Enter side A: ");
            int sideA = CheckIfStringIsPositiveInteger(Console.ReadLine());

            Console.Write("Enter side B: ");
            int sideB = CheckIfStringIsPositiveInteger(Console.ReadLine());

            Console.Write("Enter side C: ");
            int sideC = CheckIfStringIsPositiveInteger(Console.ReadLine());

            if (sideA == sideB && sideB == sideC)
            {
                Console.WriteLine("There are 3 equals sides.\nA, B, C are equal");
            }
            else if (sideA == sideB || sideB == sideC || sideA == sideC)
            {
                Console.WriteLine("There are 2 equals sides.");
                if (sideA == sideB)
                {
                    Console.WriteLine("A is equal to B");
                }
                if (sideB == sideC)
                {
                    Console.WriteLine("B is equal to C");
                }
                else
                {
                    Console.WriteLine("A is equal to C");
                }
            }
            else
            {
                Console.WriteLine("There is no equal sides.");
            }
        }

        private static void Task02_Numbers()
        {
            int countOfNumbers = 0;
            int sumOfNumbers = 0;

            for (int i = 1; i<=10; i++)
            {
                Console.Write($"Please, enter number {i} > ");
                int number = int.Parse(Console.ReadLine());

                if (number <= 20 && number >= 10)
                {
                    countOfNumbers++;
                    sumOfNumbers += number;
                }
            }
        
            Console.WriteLine($"There are {countOfNumbers} between 10 and 20");
            Console.WriteLine($"The sum of all the members between 10 and 20 is {sumOfNumbers}");
        }

        private static void Task03_SportSelector()
        {
            Console.Write("Please enter your height in cm >");
            int height = int.Parse(Console.ReadLine());

            if (height > 190)
            {
                Console.WriteLine("Basketball");
            }
            else if (height < 175)
            {
                Console.WriteLine("Horse Riding");
            }
            else
            {
                Console.WriteLine("Athletics");
            }
        }

        private static void Task04_Greeting()
        {
            DateTime time = DateTime.Now;
            string phrase = "";
            int dayOfWeek = (int)time.DayOfWeek;
            int hour = time.Hour;

            if (hour > 4 && hour < 12) { phrase += "Good Mordning"; }
            if (hour >= 12 && hour <18) { phrase += "Good afternoon"; }
            else { phrase += "Good evening"; }

            phrase += "! It is a lovely ";
            phrase += DayOfTheWeekEnglish(dayOfWeek);
            phrase += " today. Weekend is ";

            if (dayOfWeek <= 5)
            {
                phrase += $" coming in {6 - dayOfWeek} days.";
            }
            else
            {
                phrase += " now!";
            }

            Console.WriteLine(phrase);
        }

        private static string DayOfTheWeekEnglish(int dayFR)
        {
            string dayENG = "Monday";
            switch(dayFR)
            {
                case 2: dayENG = "Tuesday"; break;
                case 3: dayENG = "Wednesday"; break;
                case 4: dayENG = "Thursday"; break;
                case 5: dayENG = "Friday"; break;
                case 6: dayENG = "Saturday"; break;
                case 7: dayENG = "Sunday"; break;
                default: dayENG = "Monday"; break;
            }
            return dayENG;
        }

        private static void Task05_FormValidation()
        {
            Console.WriteLine("Please, complete the form: \n");

            Console.Write("First name (max length=100) > ");
            string firstName = LessThan100caracteres(Console.ReadLine());

            Console.Write(" Last name (max length=100) > ");
            string lastName = LessThan100caracteres(Console.ReadLine());

            DateTime birthDate = BirthDate();

            string studentNumber = StudentNumber(birthDate.Year);

            Console.WriteLine("\n\nProfile Validated!");
            Console.WriteLine($"First Name : {firstName}\nLast Name  : {lastName}");
            Console.WriteLine($"Birth Date : {birthDate.ToShortDateString()}\nStudent Number : {studentNumber}");
        }

        private static string LessThan100caracteres(string phrase)
        {
            while(phrase.Length >100)
            {

                Console.Write("Error! The name must be shorter than 100 characters. Try again > ");
                phrase = Console.ReadLine();
            }
            return phrase;
        }

        private static DateTime BirthDate()
        {
            int year = -1;
            int month = 0;
            int day = 0;
            while (CheckBirthDate(year, month, day) == false)
            {
                Console.WriteLine("What is your birth day?");
                Console.Write("    - DAY   > ");
                day = CheckIfStringIsPositiveInteger(Console.ReadLine());
                Console.Write("    - MONTH > ");
                month = CheckIfStringIsPositiveInteger(Console.ReadLine());
                Console.Write("    - YEAR  > ");
                year = CheckIfStringIsPositiveInteger(Console.ReadLine());
            }
            DateTime birthDate = new DateTime(year, month, day);
            return birthDate;
        }

        private static bool CheckBirthDate(int year, int month, int day)
        {
            bool valid = false;
            if (year != -1)
            {
                DateTime currentDay = DateTime.Now;
                if (month >= 1 && month <= 12 && day >= 1 && day <= 31 && year <= currentDay.Year && (currentDay.Year - year < 100))
                {
                    if ((year %4 == 0) && month == 2 && day > 29)
                    {
                        Console.WriteLine("Error, the date is not valid. Try again :");
                    }
                    else if ((year %4 != 0) && month == 2 && day > 28)
                    {
                        Console.WriteLine("Error, the date is not valid. Try again :");
                    }
                    else if ((month == 4 || month == 6 || month == 9 || month == 11) && month == 31)
                    {
                        Console.WriteLine("Error, the date is not valid. Try again :");
                    }
                    else
                    {
                        valid = true;
                    }
                }
                else
                {
                    Console.WriteLine("Error, the date is not valid. Try again :");
                }
            }
            return valid;
        }

        private static string StudentNumber(int year)
        {
            string studentNumber = null;
            while((studentNumber == null) || (CheckStudentNumber(studentNumber,year) == false))
            {
                Console.Write("Enter your student Number (YYYYFFSSNNNN) > ");
                studentNumber = Console.ReadLine();
            }
            return studentNumber;
        }

        private static bool CheckStudentNumber(string studentNumber, int year)
        {
            bool valid = false;
            long integer;
            if ((long.TryParse(studentNumber, out integer) == true) && (integer >= 191900000000) && (integer<= 999999999999))
            {
                int yearCheck = (Convert.ToInt16(studentNumber[0] - 48) * 1000) + ((Convert.ToInt16(studentNumber[1]) - 48) * 100) + ((Convert.ToInt16(studentNumber[2]) - 48) * 10) + (Convert.ToInt16(studentNumber[3]) - 48);
                int codeOfFaculty = ((Convert.ToInt16(studentNumber[4]) - 48) * 10) + (Convert.ToInt16(studentNumber[5]) - 48);
                int codeFaculty = (Convert.ToInt16(studentNumber[4] - 48) * 10) + Convert.ToInt16(studentNumber[5] - 48);
                int codeOfSpeciality = ((Convert.ToInt16(studentNumber[6]) - 48) * 10) + (Convert.ToInt16(studentNumber[7]) - 48);

                if ((yearCheck == year) && (codeOfFaculty>1) && (codeOfFaculty<10) && (codeOfSpeciality>1)&& (codeOfSpeciality<6))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Error. There is an error in the student number. Try again :");
                }
            }
            else
            {
                Console.WriteLine("Error. The value is not possible for a student number. Try again : ");
            }
            return valid;
        }
    }
}
