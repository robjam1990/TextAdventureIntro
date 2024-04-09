using static System.Console;
using System;
using System.Collections.Generic;

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

internal class CommandLineArguments
    {
        /// <summary>
        /// Builds a dictionary of command-line arguments.
        /// </summary>
        /// <param name="args">Array of command-line arguments.</param>
        /// <returns>A dictionary containing parsed command-line arguments.</returns>
        internal static Dictionary<string, string> Build(string[] args)
        {
            Dictionary<string, string> result = new Dictionary<string, string>(
                StringComparer.OrdinalIgnoreCase);

            if (args == null)
                return result;

            List<string> trimmedArguments = TrimArgs(args);

            int index = 0;

            while (index < trimmedArguments.Count)
            {
                if (IsKeyValueArgumentAtIndex(trimmedArguments, index))
                {
                    result[trimmedArguments[index]] = trimmedArguments[index + 1];
                    index += 2;
                }
                else
                {
                    result[trimmedArguments[index]] = null;
                    index += 1;
                }
            }

            return result;
        }

        /// <summary>
        /// Trims the whitespace from each command-line argument.
        /// </summary>
        /// <param name="args">Array of command-line arguments.</param>
        /// <returns>List of trimmed command-line arguments.</returns>
        static List<string> TrimArgs(string[] args)
        {
            List<string> trimmedArguments = new List<string>(args.Length);

            foreach (string argument in args)
                trimmedArguments.Add(argument.Trim());

            return trimmedArguments;
        }

        /// <summary>
        /// Checks if the argument at the specified index is a key-value pair.
        /// </summary>
        /// <param name="trimmedArguments">List of trimmed command-line arguments.</param>
        /// <param name="index">Index of the argument to check.</param>
        /// <returns>True if the argument is a key-value pair; otherwise, false.</returns>
        static bool IsKeyValueArgumentAtIndex(List<string> trimmedArguments, int index)
        {
            if (index + 1 < trimmedArguments.Count)
                return !trimmedArguments[index + 1].StartsWith("-");

            return false;
        }
    }

        private static void Intro()
        {
            string response = ReadLine()!;
            WriteLine("Would you like to play a text game?");
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
        }

    static void Main()
        {
            WriteLine("Hello World!");
            Intro();
            Outro();
        }
    }
}