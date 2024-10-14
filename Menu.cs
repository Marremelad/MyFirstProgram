using Spectre.Console;

namespace MyFirstProgram;

public class Menu
{
    private static int _number;
    private static bool _numberHasBeenChoosen = false;

    public static void MainMenu()
    {
        while (true)
        {
            Console.Clear();
            var choice = AnsiConsole.Prompt(new SelectionPrompt<MenuChoice>()
                .Title("Welcome to my first program!!!")
                .PageSize(10)
                .AddChoices(
                    MenuChoice.Number,
                    MenuChoice.Greet,
                    MenuChoice.Count,
                    MenuChoice.Exit));

            switch (choice)
            {
                case MenuChoice.Number:
                    ChoiceNumber();
                    break;
                case MenuChoice.Greet:
                    ChoiceGreet();
                    break;
                case MenuChoice.Count:
                    ChoiceCount();
                    break;
                case MenuChoice.Exit:
                    return;
            }
            Thread.Sleep(3000);
        }

    }

    public static void ChoiceNumber()
    {
        _number = AnsiConsole.Ask<int>("Pick a number!");
        _numberHasBeenChoosen = true;
        Helper.HigherThanTen(_number);
    }

    public static void ChoiceGreet()
    {
        Helper.Greet();
    }

    public static void ChoiceCount()
    {
        if (!_numberHasBeenChoosen)
        {
            Console.WriteLine("You have to pick a number before we can count!");
            return;
        }
        Helper.Count(_number);
    }
}