using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Statements
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool myBool = false;
            

            do
            {
                int myFavoriteNumber = 14;

                Console.WriteLine("Guess my favorite number, it is between 0 and 20.");

                var userInput = int.Parse(Console.ReadLine());

                if (userInput == myFavoriteNumber)
                {
                    Console.WriteLine("Thats Correct!");
                    
                    myBool = true;
                }
                else if (userInput < myFavoriteNumber)
                {
                    Console.WriteLine("That is to low, try again");
                    
                }
                else if (userInput > myFavoriteNumber)
                {
                    Console.WriteLine("That is to high, try again");
                }

            } while (!myBool); 

            Console.WriteLine("What is your favorite school subject?");

            string userSubject = Console.ReadLine().ToLower();

            switch (userSubject)
            {
                case "math":
                    Console.WriteLine("Math is boring");
                    break;
                case "english":
                    Console.WriteLine("That is cool");
                    break;
                case "spanish":
                    Console.WriteLine("Hola");
                    break;
                case "history":
                    Console.WriteLine("History can be interesting");
                    break;
                case "reading":
                    Console.WriteLine("I enjoy a book sometimes");
                    break;
                default:
                    Console.WriteLine("Did not understand");
                    break;
            }
            Console.ReadLine();
        }
    }
}
