using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_template
{
    public class Question3
    {
        public static void question3()
        {
            // Question 3:
            Console.WriteLine("\n-------Question 3-------");
            // Enter code and comments here...
            int sum = 0;
int userInput;

Console.WriteLine("Enter numbers to add to the sum. Enter 0 to stop.");
do
{
    Console.Write("Enter a number: ");
    userInput = Convert.ToInt32(Console.ReadLine());
    sum += userInput;
} while (userInput != 0);

Console.WriteLine($"The total sum is: {sum}");
           
        }
    }
}
