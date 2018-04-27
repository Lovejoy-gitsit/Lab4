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
            double input = 0;
            Console.WriteLine("\t\t\t\t\tLearn your Squares and Cubes!");
            
            while (true)
            {
                
                Console.WriteLine("Enter a integer:");
                input = int.Parse(Console.ReadLine());
                
                Console.Write($"{"Number", -10}");
                Console.Write($"{"Squared",-10}");
                Console.WriteLine($"{"Cubed"}");

                Console.Write($"{"=====", -10}");
                Console.Write($"{"=====",-10}");
                Console.WriteLine($"{"====="}");

                for (int i = 1; i <= input; i++)
                {
                    double squared = Math.Pow(i, 2);
                    double cubed = Math.Pow(i, 3);

                    Console.Write($"{i, -10}");

                    
                    //double squared = Math.Pow(i, 2);
                    Console.Write($"{squared,-10}");

                    
                    
                    //double cubed = Math.Pow(i, 3);
                    Console.WriteLine($"{cubed}");
                    
                }
                string userInput;
                Console.WriteLine("Do you want to continue: y/n");
                userInput = Console.ReadLine();

                if(userInput != "y")
                {
                    break;
                }
                else
                {
                    continue;
                }
                

            }


        }
    }
}
