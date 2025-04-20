using Levenshteiner.NET.Extensions;

namespace Levenshteiner.NET;

public readonly struct LevenshteinDistance
{
    public IEnumerable<LevenshteinOperation> Operations { get; } = [];
    public int Distance { get; }
    public double Percentage { get; }

    public static LevenshteinDistance Create(string? src, string? target, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
        => src.ToLevenshteinDistance(target, stringComparison);

    internal LevenshteinDistance(IEnumerable<LevenshteinOperation> operations, int distance, double percentage)
    {
        Operations = [.. operations];
        Distance = distance;
        Percentage = percentage;
    }
}

public abstract class LevenshteinOperation(char character, int index)
{
    public char Character { get; } = character;
    public int Index { get; } = index;
}

public sealed class NoOperation(char character, int index) : LevenshteinOperation(character, index);

public sealed class InsertOperation(char character, int index) : LevenshteinOperation(character, index);

public sealed class DeleteOperation(char character, int index) : LevenshteinOperation(character, index);

public sealed class SubstitutionOperation(char character, char substitution, int index) : LevenshteinOperation(character, index)
{
    public char Substitution { get; } = substitution;
}