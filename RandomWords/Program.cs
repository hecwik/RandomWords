// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;

string text = File.ReadAllText(@"C:\Users\hecke\source\repos\RandomWords\RandomWords\Resources\SvenskaOrd.txt");
string[] lines = File.ReadAllLines(@"C:\Users\hecke\source\repos\RandomWords\RandomWords\Resources\SvenskaOrd.txt");
int nrOfLines = 0;
foreach (var line in lines) { nrOfLines++; }

Console.WriteLine($"The txt file contains {nrOfLines} number of lines.");
Console.WriteLine();

string randomWordsArray;

Random randomWord = new();

Console.WriteLine("How many words do you want to generate?");
int.TryParse(Console.ReadLine(), out int nrOfWords);
Console.WriteLine();

if (nrOfWords == 1)
{
    for (int i = 0; i < nrOfWords; i++)
    {
        int randomWordNumber1 = randomWord.Next(0, nrOfLines);

        for (int j = 0; j < 1; j++)
        {
            Console.Write($"{lines[randomWordNumber1]}.");
            Console.WriteLine();
        }
    }
}
else if (nrOfWords > 1)
{
    for (int i = 0; i < nrOfWords - 1; i++)
    {
        int randomWordNumber1 = randomWord.Next(0, nrOfLines);

        for (int j = 0; j < 1; j++)
        {
            Console.Write($"{lines[randomWordNumber1]} ");
            if (i + 1 == nrOfWords + 1)
            {
                Console.Write($".");
            }
        }
    }
}





/*int randomWordNumber2 = randomWord.Next(0, nrOfLines);
int randomWordNumber3 = randomWord.Next(0, nrOfLines);

for (int i = 0; i < 1; i++)
{
    if(lines[randomWordNumber1] != lines[randomWordNumber2] && 
        lines[randomWordNumber2] != lines[randomWordNumber3] && 
        lines[randomWordNumber1] != lines[randomWordNumber3])
    Console.WriteLine($"{lines[randomWordNumber1]} {lines[randomWordNumber2]} {lines[randomWordNumber3]}.");
}*/
