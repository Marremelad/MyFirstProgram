using System.Reflection;
namespace MyFirstProgram;

using System.ComponentModel;

public enum MenuChoice
{
    [Description("Pick a number!")]
    Number,

    [Description("What is your name?")]
    Greet,

    [Description("Let's count!")]
    Count
}

public static class EnumExtensions
{
    public static string GetDescription(this Enum value)
    {
        FieldInfo? field = value.GetType().GetField(value.ToString());
        DescriptionAttribute? attribute = field!.GetCustomAttribute<DescriptionAttribute>();

        return attribute != null ? attribute.Description : value.ToString();
    }
}

public static class Helper
{
    public static void HigherThanTen(int number)
    {
        Console.WriteLine(number > 10 ? "Your number is higher than 10!" : "Your number is not higher than 10!");
    }

    public static void Greet()
    {
        string? name;
        while (string.IsNullOrEmpty(name = Console.ReadLine()))
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
        }
    }
}