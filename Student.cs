using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_POP
{
    public class Student : Person
    {
        string studentNumber;
        int age;
        Address address;
        string fullName;
        int[] scores;
        double averageScore;
        string fullAddress;

        public Student (string firstName, string lastName, string studentNumber, int age, int numberOfStreet, string street,  string city,string country,int[] scores) : base(firstName,lastName)
        {
            NormalizeSizeOfLetters();
            StudentNumber = studentNumber;
            Age = age;
            address = new Address(numberOfStreet,street,city,country);
            fullName = FirstName + " " + LastName;
            Scores = scores;
            averageScore = CalculateAverageScore();
            fullAddress = fullName + "\n" + address.ToString();
        }

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
            NormalizeSizeOfLetters();
            Console.Write("- Enter the new student number : ");
            StudentNumber = Console.ReadLine();
            Console.Write("- Enter the age                : ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("- Address                      : > number of street : ");
            int numberOfStreet = Program.CheckIfStringIsPositiveInteger(Console.ReadLine());
            Console.Write("                                 > street : ");
            string street = Console.ReadLine();
            Console.Write("                                 > city : ");
            string city = Console.ReadLine();
            Console.Write("                                 > country : ");
            string country = Console.ReadLine();
            Address = new Address(numberOfStreet, street, city, country);
            fullName = firstName + " " + lastName;
            Console.Write("- Scores                       : ");
            scores = RegisterStudentsMarks();
            averageScore = CalculateAverageScore();
            fullAddress = fullName + "\n" + address.ToString();
        }

        public string StudentNumber
        {
            get
            {
                return studentNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student Number cannot be null");
                }
                if (int.TryParse(value, out int integer) == false)
                {
                    throw new FormatException("Student number must be an integer");
                }
                if (integer<100 || integer > 999)
                {
                    throw new ArgumentOutOfRangeException("Student number must be between 100 and 999");
                }
                studentNumber = value;
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
                if(value<0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 1 and 100");
                }
                age = value;
            }
        }

        public Address Address
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

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                value = FirstName + " " + LastName;
            }
        }

        public int[] Scores
        {
            get
            {
                return scores;
            }
            set
            {
                scores = value;
            }
        }

        public double AverageScore
        {
            get
            {
                return averageScore;
            }
        }

        public string ToStringMarks()
        {
            string marks = "";
            foreach(int mark in scores)
            {
                marks += mark + " ";
            }
            marks += " (marks are out of 100)";
            return marks;
        }

        public double CalculateAverageScore()
        {
            double average = 0;
            foreach (int mark in scores)
            {
                average += mark;
            }
            average /= scores.Length;
            return Math.Round(average,2);
        }

        //public string NewStudentNumberValid(string newStudentNumber)
        //{
        //    while ((Program.ExistenceOfAStudentNumber(newStudentNumber) == true) || (Int32.TryParse(Console.ReadLine(), out int integer) == true) || (integer<100) || (integer > 999))
        //    {
        //        if (Program.ExistenceOfAStudentNumber(newStudentNumber) == true) Console.Write("Impossible, this student number already exist. Please try again : ");
        //        else Console.Write("The student number must be an integer between 100 and 999. Please try again : ");
        //        newStudentNumber = Console.ReadLine();
        //    }
        //    return newStudentNumber;
        //}

        public int[] RegisterStudentsMarks()
        {
            List<int> markList = new List<int>();
            Console.Write("enter the marks (out of 100) of the student (Type 'ok' to finish the list):\n  > ");
            string markString = Console.ReadLine();
            int markInt;
            while(markString != "ok")
            {
                markInt = Program.CheckIfStringIsPositiveInteger(markString);
                while(markInt>100)
                {
                    Console.Write("Error, mark must be between 0 and 100, please try again  > ");
                    markInt = Program.CheckIfStringIsPositiveInteger(Console.ReadLine());
                }
                markList.Add(markInt);
                Console.Write("  > ");
                markString = Console.ReadLine();
            }
            int[] tab = new int[markList.Count];
            for(int i = 0; i<tab.Length;i++)
            {
                tab[i] = markList[i];
            }
            return tab;
        }

        public override string ToString()
        {
            return $"Student informations :\n\n" +
                   $"Full name      : {fullName}\n" +
                   $"Student number : {studentNumber}\n" +
                   $"Age            : {age}\n" +
                   $"Address        : {address.ToStringInLine()}\n" +
                   $"Scores         : {ToStringMarks()}\n" +
                   $"Average score  : {averageScore}\n" +
                   $"Full address   :\n{fullAddress}\n";
        }
    }
}