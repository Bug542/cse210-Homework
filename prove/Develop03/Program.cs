using System;

class Program
{
    static void Main(string[] args)
    {

        Reference scripture1 = new Reference("2 Timothy", "1", "7", "-9", "For God hath not given us the spirit of fear; but of power, and of love, and of a sound mind." );

        scripture1.Display();

        string words = scripture1.GetWords();

        Scripture verse = new Scripture(words);

        verse.Display();
        Console.WriteLine();
        Console.WriteLine("Press enter to continue, or type 'quit' to quit.");

        string userChoice = Console.ReadLine();

        while (userChoice == "") {
            
           verse.HideWords();
            Console.Clear();
            scripture1.Display();
            verse.Display();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue, or type 'quit' to quit.");

            userChoice = Console.ReadLine();

        }

    }
}