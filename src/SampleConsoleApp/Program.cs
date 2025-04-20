// See https://aka.ms/new-console-template for more information
using Levenshteiner.NET;
using Levenshteiner.NET.Extensions;

string? src = "a bunch of characters";
string? target = "characterisation is key";

var levenshteinDistance = src.ToLevenshteinDistance(target);

Console.WriteLine($"Source: \"{src}\"\nTarget: \"{target}\"\n");

foreach (var op in levenshteinDistance.Operations)
{
    switch (op)
    {
        case NoOperation noOp:
            //Console.ForegroundColor = ConsoleColor.White;
            Console.Write(noOp.Character);
            break;
        case InsertOperation insertOp:
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(insertOp.Character);
            break;
        case DeleteOperation deleteOp:
            Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(deleteOp.Character);
            break;
        case SubstitutionOperation replaceOp:
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(replaceOp.Character);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(replaceOp.Substitution);
            break;
    }

    Console.ResetColor();
}

Console.WriteLine($"\n\nDistance: {levenshteinDistance.Distance}; Percentage: {(levenshteinDistance.Percentage * 100):00.00}%");

internal static class CharExtensions
{
    
    public static char ReplaceIf(this char ch, char condition, char replacement)
        => ch == condition ? replacement : ch;

    public static char ReplaceIfWhiteSpace(this char ch, char replacement)
        => char.IsWhiteSpace(ch) ? replacement : ch;
}