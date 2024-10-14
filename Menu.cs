using Spectre.Console;

namespace MyFirstProgram;

public class Menu
{
    public static void MainMenu()
    {
        
        var choice = AnsiConsole.Prompt(new SelectionPrompt<MenuChoice>()
            .Title("Welcome to my first program!!!")
            .PageSize(10)
            .AddChoices(
                MenuChoice.Number,
                MenuChoice.Greet,
                MenuChoice.Count));
        
        switch (choice)
        {
            case MenuChoice.Number:
                Console.WriteLine("Number");
                break;
            case MenuChoice.Greet:
                Console.WriteLine("Greet");
                break;
            case MenuChoice.Count:
                Console.WriteLine("Count");
                break;
        }
    }

    public static void ChoiceNumber()
    {
        var number = AnsiConsole.Ask<int>("Pick a number!");
        Helper.HigherThanTen(number);
    }

    public static void ChoiceGreet()
    {
        Helper.Greet();
    }
}