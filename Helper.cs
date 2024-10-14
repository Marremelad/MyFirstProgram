using Spectre.Console;
namespace MyFirstProgram;

public enum MenuChoice
{
    Number,
    Greet,
    Count,
    Exit,
}

public static class Helper
{
    public static void HigherThanTen(int number)
    {
        Console.WriteLine(number > 10 ? "Your number is higher than 10!" : "Your number is not higher than 10!");
    }

    public static void Greet()
    {
        string name;
        while (string.IsNullOrEmpty(name = AnsiConsole.Ask<string>("What is your name?")))
        {
            Console.WriteLine("Your name can not be empty!");
        }
        
        Console.WriteLine($"Hello {name}!");
    }

    public static void Count(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(i + 1);
            Thread.Sleep(1000);
        }
    }
}