using static System.Console;

namespace TextAdventureGame
{
    public class Program
    {
        private static readonly string[] Choices = ["north", "south", "east", "west"];

        private static void Run()
        {
            Clear();
            WriteLine("Welcome to the text game!");
            WriteLine($"You are in a dark room and you can go {string.Join(", ", Choices)}.");
            string direction = ReadLine()!;
            if (direction == "north" || direction == "south" || direction == "east" || direction == "west")
            {
                WriteLine("You chose to go " + direction + ".");
            }
            else
            {
                WriteLine("Invalid direction.");
            }
            switch (direction)
            {
                case "north":
                    WriteLine("You go north and find a treasure chest.");
                    break;
                case "south":
                    WriteLine("You go south and find a dragon.");
                    break;
                case "east":
                    WriteLine("You go east and find a river.");
                    break;
                case "west":
                    WriteLine("You go west and find a forest.");
                    break;
                default:
                    WriteLine("Invalid direction.");
                    break;
            }
        }

        private static void Outro()
        {
            WriteLine("Thanks for playing the text game!");
        }

        static void Main()
        {
            WriteLine("Hello World!");
            WriteLine("Would you like to play a text game?");
            string response = ReadLine()!;
            if (response == "yes")
            {
                WriteLine("Great! Let's play the text game.");
                ReadKey(true);
                Run();
            }
            else
            {
                WriteLine("That's too bad. Maybe next time.");
                ReadKey(true);
            }
            Outro();
        }
    }
}