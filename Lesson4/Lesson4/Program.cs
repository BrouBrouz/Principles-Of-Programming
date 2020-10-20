using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
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
                                     + " 1  - Task 1 : Angle triangle of patterns\n"
                                     + " 2  - Task 2 : Diamond of patterns\n"
                                     + " 3  - Task 3 : Encode/Decode a text\n\n"
                                     + "Choose an exersice > ");
                int exerciseSelected = CheckIfStringIsPositiveInteger(Console.ReadLine());
                Console.Clear();
                switch (exerciseSelected)
                {
                    case 1:
                        Console.WriteLine("You chose : 1  - Task 1 : Angle triangle of patterns\n");
                        Task01_Triangle();
                        break;
                    case 2:
                        Console.WriteLine("You chose : 2  - Task 2 : Diamond of patterns\n");
                        Task02_Diamond();
                        break;
                    case 3:
                        Console.WriteLine("You chose : 3  - Task 3 : Encode/Decode a text\n");
                        Task03_EncodeDecodeAText();
                        break;
                    default:
                        Console.WriteLine("Error : The number of exercise selected does not exist");
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

        static void Task01_Triangle()
        {
            int counter = 0;
            for (int i = 1; i <= 4; i++)
            {
                counter = i;
                while (counter != 0)
                {
                    Console.Write("*");
                    counter--;
                }
                Console.WriteLine("");
            }
        }

        static void Task02_Diamond()
        {
            Console.Write("Enter a size for the diamond > ");
            int size = CheckIfStringIsPositiveInteger(Console.ReadLine());
            int counter = 0;

            if (size % 2 == 0)
            {
                size--;
            }

            for (int numberOfAsterix = 1; numberOfAsterix <= size; numberOfAsterix += 2)
            {
                counter = (size - numberOfAsterix) / 2;
                Space(counter);
                Asterix(numberOfAsterix);
                Console.WriteLine("\n");
            }
            for (int numberOfAsterix = size - 2; numberOfAsterix > 0; numberOfAsterix -= 2)
            {
                counter = (size - numberOfAsterix) / 2;
                Space(counter);
                Asterix(numberOfAsterix);
                Console.WriteLine("\n");
            }
        }

        static void Space(int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                Console.Write(" ");
            }
        }

        static void Asterix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
        }

        static void Task03_EncodeDecodeAText()
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'é', 'è', 'à', 'ç',' ','\'','"', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] secret = { 'l', '0', 'm', 'n', 'é', '1', 'o', 'p', '2', 'q', 'è', 'r', 'à', 's', 't', '3', '4', 'u', '5', 'v', 'w','\'', 'x', '6', 'y', 'z', 'a',' ', 'b', 'c', '7', 'd', 'e', 'f', '8', 'g', 'h', 'i', 'j', 'ç', 'k', '9','"' };

            Console.Write("Write the text to encode > ");
            string secretText = EncodeText(Console.ReadLine().ToLower(), alphabet, secret);
            Console.WriteLine("The text was successfuly encoded : " + secretText+"\n");
            Console.Write("Do you want to decode the text now ? (1-Yes / 2-No) : ");
            int answer = CheckIfStringIsPositiveInteger(Console.ReadLine());
            while((answer != 1)&&(answer != 2))
            {
                Console.Write("You must entered 1 for Yes or 2 for No, try again please > ");
                answer = CheckIfStringIsPositiveInteger(Console.ReadLine());
            }
            if(answer == 1)
            {
                string text = DecodeText(secretText.ToLower(), alphabet, secret);
                Console.WriteLine("The secret text was successfuly decoded : "+ text);
            }
            else
            {
                Console.WriteLine("Okey, the secret text will not be decoded. Goodbye!");
            }
        }

        static string EncodeText(string text,char[] alphabet, char[]secret)
        {
            string secretText = "";
            int index;
            foreach(char character in text)
            {
                index = 0;
                while((character != alphabet[index]) && index != 39)
                {
                    index++;
                }
                if (index == 39)
                {
                    secretText += '%';
                }
                else
                {
                    secretText += secret[index];
                }
            }
            return secretText;
        }

        static string DecodeText(string secretText,char[] alphabet, char[]secret)
        {
            string text="";
            int index = 0;
            foreach(char character in secretText)
            {
                index = 0;
                while((character != secret[index])&& (index != 39))
                {
                    index++;
                }
                if (index == 39) text += '%';
                else text += alphabet[index];
            }
            return text;
        }
    }
}
