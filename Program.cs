using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //making a variable (input) to store the users input
            double input = 0;

            while (true)
            {
                //asking user for input
                Console.WriteLine("Enter a number: ");
                //printing users input to screen
                /*validates that user inputs a number--if user input (input) is not a 
                number print invalid and return to "Enter a number" */
                if (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid");
                    continue;
                }

                /*this section is spreading the rows apart and creating 
                 readable columns*/
                Console.Write($"{"Number",-10}{"Squared",-10}");
                Console.WriteLine($"{"Cubed"}");
                Console.Write($"{"=====",-10}{"=====",-10}");
                Console.WriteLine($"{"====="}");



                /*for loop translates to... start this column at 1 and end it
                 at whatever the user input is-until then keep going up one*/
                for (int i = 1; i <= input; i++)
                {
                    /*these are the formulas that take the i
                     (that started at 1) and takes the starting 1 and each increase and squares
                     and cubes it until user input is reached--the formulas
                     are in the for loop becasue the formula needs to be calculated
                     for each increase in the number until user input is reached*/

                    double squared = Math.Pow(i, 2);
                    double cubed = Math.Pow(i, 3);
                    /*prints the number i (started at 1) to screen and lines it up with the
                    number column*/
                    Console.Write($"{i,-10}");
                    //prints the number i to the screen and squares each increase
                    Console.Write($"{squared,-10}");
                    //prints the number i to the screen and cubes each increase
                    Console.WriteLine($"{cubed}");
                }

                
                    //storing user input in a variable called userInput
                    string userInput;
                    //asking a question
                    Console.WriteLine("Do you want to continue: y/n");
                    //printing user input to the screen
                    userInput = Console.ReadLine();


                    //if userInput equals n then break from program
                    if (userInput == "n")
                    {
                        Console.WriteLine("bye");
                        break;  
                    }
                    //if userInput is y then continue the program and loop around to the beginning
                    else if (userInput =="y")
                    {
                        continue;
                    }
                    //if user enters anything else ask them to enter y or n
                    else
                    {
                    Console.WriteLine("Please enter y/n: ");
                    userInput = Console.ReadLine();
                    
                    }
                            
                            
                

                

                
            }


        }
    }
}
