using Spectre.Console;

namespace MyFirstProgram;

public class Menu
{
    public static void MainMenu()
    {
        var choice = AnsiConsole.Prompt(new SelectionPrompt<string>()
            .Title("Welcome to my first program!!!")
            .PageSize(10)
            .AddChoices(
                MenuChoice.Number.GetDescription(),
                MenuChoice.Greet.GetDescription(),
                MenuChoice.Count.GetDescription()));

        switch (choice)
        {
            case "Pick a number":
                throw new NotImplementedException();
                break;
            case "Tell me your name":
                throw new NotImplementedException();
                break;
            case "Count":
                throw new NotImplementedException();
                break;
        }
    }
}