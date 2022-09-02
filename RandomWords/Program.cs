// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Runtime.CompilerServices;

bool isRunning = true;
string text = File.ReadAllText(@"C:\Users\hecke\source\repos\RandomWords\RandomWords\Resources\SvenskaOrd.txt");
string[] lines = File.ReadAllLines(@"C:\Users\hecke\source\repos\RandomWords\RandomWords\Resources\SvenskaOrd.txt");
int nrOfLines = 0;
foreach (var line in lines) { nrOfLines++; }

Console.WriteLine($"The dictionary contains {nrOfLines} number of lines (one word per line, meaning {nrOfLines} words).");
Console.WriteLine();

// for getting the string at a random line number.
Random randomWord = new();
while (isRunning == true)
{
    Console.WriteLine("How many words do you want to generate?");
    int.TryParse(Console.ReadLine(), out int nrOfWords);
    Console.WriteLine();

    TextInfo myTI = new CultureInfo("sv-SE", false).TextInfo; // used for capitalizing the first word in the sequence.

    if (nrOfWords == 1)
    {
        for (int i = 0; i < nrOfWords; i++)
        {
            int randomWordNumber1 = randomWord.Next(0, nrOfLines);

            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine("{1}", lines[randomWordNumber1], myTI.ToTitleCase(lines[randomWordNumber1]));
                //Console.Write($"{lines[randomWordNumber1].Replace(lines[randomWordNumber1][0], char.ToUpper(lines[randomWordNumber1][0]))}");
                Console.WriteLine();
            }
        }
        Console.WriteLine("Do you want to quit? Y/N");
        string input = Console.ReadLine();
        if (input == "y" || input == "Y")
        {
            isRunning = false;
        }
        else { continue; }
    }
    else if (nrOfWords > 1 && nrOfWords < 40000)
    {
        for (int i = 0; i < nrOfWords + 1; i++)
        {
            int randomWordNumber1 = randomWord.Next(0, nrOfLines);

            for (int j = 0; j < 1; j++)
            {
                if (i == 0)
                {
                    Console.Write("{1} ", lines[randomWordNumber1], myTI.ToTitleCase(lines[randomWordNumber1]));
                }
                if (i > 0 && i < nrOfWords - 1)
                {
                    Console.Write($"{lines[randomWordNumber1]} ");
                }
                if (i == nrOfWords - 1)
                {
                    Console.Write($"{lines[randomWordNumber1 + 1]}.");
                    Console.WriteLine();
                }
            }
        }
        Console.WriteLine("Do you want to quit? Y/N");
        string input = Console.ReadLine();
        if (input == "y" || input == "Y")
        {
            isRunning = false;
        }
        else { continue; }
    }
    else if (nrOfWords >= 40000)
    {
        Console.WriteLine("Can't make more than 40 000 words! And you won't read all of them anyways, so don't push your machine that much for no reason. :)");
        Console.WriteLine();
        Console.WriteLine("Do you want to quit? Y/N");
        string input = Console.ReadLine();
        if(input == "y" || input == "Y")
        {
            isRunning = false;
        }
        else { continue; }
        Console.ReadLine();
    }
}
