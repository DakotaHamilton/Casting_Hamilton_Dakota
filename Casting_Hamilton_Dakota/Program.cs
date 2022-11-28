using System;

namespace Casting_Hamilton_Dakota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Whole Number!"); // Whole number Question prompt #1
            int myFaveNum = Convert.ToInt32(Console.ReadLine()); // User Input

            Console.WriteLine("Your Favorite Number is" + myFaveNum); // User Input Response #1

            Console.WriteLine("Do you like Video Games?(Please enter 'true' or 'false')"); // Whole number Question promt #2
            bool isTrue = Convert.ToBoolean(Console.ReadLine()); // User Input Confirmation

            Console.WriteLine($"It is {isTrue} that I like Video Games!"); // User Input Confirmation Response
        }
    }
}
