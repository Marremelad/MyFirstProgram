//Lab 1 - Mitt första program.
//Mauricio Corte
//.NET24

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 11; //int variable "number" with the value 11.

            if (number > 10) { // if-statement that checks if "number" is larger than 10.
                Console.WriteLine("Talet är stort!");
            }

            Console.WriteLine("Vad heter du?"); //Promots the user for input.
            string? name = Console.ReadLine(); //Declaring the string variable "name" and letting the user input the value. We have a "?" after the type beacuse the value can be null.

            Console.WriteLine($"Hej {name}!"); //Printing out the users name with string interpolation using "$".

            for (int i = 0; i <= number; i++) { //A for-loop that prints out the value of "i" until it is equal to the value of "number".
                Console.WriteLine(i);
            }
        }
    }
}
