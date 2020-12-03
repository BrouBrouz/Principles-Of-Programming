using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_POP
{
    class Program  // Maxime BROUSSART - Principles Of Programming - Assignement
    {
        public static List<Student> dataBase = new List<Student>();

        static void Main(string[] args)
        {
            Console.WindowHeight = 45;
            Console.WindowWidth = 130;
            int[] marks_student1 = { 65, 28, 71, 87, 100, 95 };
            int[] marks_student2 = { 98, 90, 67, 88, 99 };
            Student student1 = new Student("maXIme", "broussart", "207", 20, 13, "A Oborishte Street", "Varna", "Bulgaria", marks_student1);
            Student student2 = new Student("alessio", "laDOSo", "409", 23, 2, "Sveti Sveti Kiril I Metodiy", "Varna", "Bulgaria", marks_student2);
            dataBase.Add(student1);
            dataBase.Add(student2);
            //Person person1 = new Person("Jack", "Smith");
            //Console.WriteLine(student1);
            //Console.WriteLine(student2);
            //Console.WriteLine(person1);

            Console.WriteLine("            _________________________________________________________________________\n"
                + "           |                                                                         |\n"
                + "           |    Welcome on the student Data Base of Varna University of Management   |\n"
                + "           |_________________________________________________________________________|\n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("              VUM - SE - Principles Of Programming - Assignement\n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                         BROUSSART Maxime\n" +
                              "                                           December 2020\n\n");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Menu();
        }

        static void Menu()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.Write("Menu :\n\n" +
                                          "Current data base : \n" + DisplayTheListOfStudents() + "\n"+
                                          "    1  - Create a new student profil\n" +
                                          "    2  - Display average score of a student\n" +
                                          "    3  - Display the city of a student\n" +
                                          "    4  - Display the full address of a student\n" +
                                          "    5  - Display all the informations about a student\n" +
                                          "    6  - Exit\n\n" +
                                          
                                          "    Choose a task > ");
                int exerciseSelected = CheckIfStringIsPositiveInteger(Console.ReadLine());
                Console.Clear();
                switch (exerciseSelected)
                {
                    case 1:
                        Console.WriteLine("1 - Create a new student profil\n");
                        CreateANewStudentProfil();
                        break;
                    case 2:
                        Console.WriteLine("2  - Display average score of a student\n");
                        DisplayAverageScore();
                        break;
                    case 3:
                        Console.WriteLine("3  - Display the city of a student\n");
                        DisplayTheCityOfAStudent();
                        break;
                    case 4:
                        Console.WriteLine("4  - Display the full address of a student\n");
                        DisplayTheFullAddressOfAStudent();
                        break;
                    case 5:
                        Console.WriteLine("5  - Display all the informations about a student\n");
                        DisplayStudentInformations();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Error : The number selected is out of range");
                        break;
                }
                Console.WriteLine("\nType Escape to leave or any other key to select another exercise.");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
        }

        static int SelectAStudentNumber()
        {
            Console.Write("Choose a student number > ");
            string studentNumber = Console.ReadLine();
            for(int i = 0; i<dataBase.Count;i++)
            {
                if(studentNumber == dataBase[i].StudentNumber)
                {
                    return i;
                }
            }
            Console.WriteLine("This student number does not exist in the data base.");
            return -1;
        }

        public static bool ExistenceOfAStudentNumber(string studentNumber)
        {
            bool exist = false;
            for (int i = 0; i < dataBase.Count; i++)
            {
                if (studentNumber == dataBase[i].StudentNumber)
                {
                    exist = true;
                }
            }
            return exist;
        }

        static void CreateANewStudentProfil()
        {
            Console.WriteLine("Create a new student profil :\n");
            Console.Write("- Enter the first name : ");
            string firstName = Console.ReadLine();
            Console.Write("- Enter the last name : ");
            string lastName = Console.ReadLine();
            Student newStudent = new Student(firstName,lastName);
            dataBase.Add(newStudent);
            Console.WriteLine("New student was successfully added");
        }

        static void DisplayAverageScore()
        {
            int index = SelectAStudentNumber();
            if(index != -1)
            {
                Console.WriteLine($"Student {dataBase[index].FullName} average score is {dataBase[index].AverageScore}");
            }
        }

        static void DisplayTheCityOfAStudent()
        {
            int index = SelectAStudentNumber();
            if (index != -1)
            {
                Console.WriteLine($"Student {dataBase[index].FullName} is living in {dataBase[index].Address.City}");
            }
        }

        static void DisplayTheFullAddressOfAStudent()
        {
            int index = SelectAStudentNumber();
            if (index != -1)
            {
                Console.WriteLine($"Student {dataBase[index].FullName} address is {dataBase[index].Address.ToStringInLine()}");
            }
        }

        static void DisplayStudentInformations()
        {
            int index = SelectAStudentNumber();
            if (index != -1)
            {
                Console.WriteLine(dataBase[index]);
            }
        }
        
        static string DisplayTheListOfStudents()
        {
            string list = "";
            int numberOfLetters;
            list += " __________________________________________________\n" +
                    "|  Student Number   |             Name             |\n" +
                    "|___________________|______________________________|\n";
            foreach (Student student in dataBase)
            {
                list += $"|        {student.StudentNumber}        |";
                numberOfLetters = student.FullName.Count();
                numberOfLetters = (30 - numberOfLetters) / 2;
                for(int i=0; i < numberOfLetters;i++)
                {
                    list += " ";
                }
                list += student.FullName;
                for (int i = 0; i < numberOfLetters; i++)
                {
                    list += " ";
                }
                if(student.FullName.Count()%2==1)
                {
                    list += " ";
                }
                list += "|\n";
            }
            list += "|___________________|______________________________|\n";
            return list;
        }

        public static int CheckIfStringIsPositiveInteger(string stringRead)
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
    }
}
