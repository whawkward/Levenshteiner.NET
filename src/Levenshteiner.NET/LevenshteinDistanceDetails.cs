using Levenshteiner.NET.Extensions;

namespace Levenshteiner.NET;

public readonly struct LevenshteinDistanceDetails
{
    public IEnumerable<LevenshteinOperation> Operations { get; }
    public int Distance { get; }
    public double Percentage { get; }

    public static LevenshteinDistanceDetails Create(string? src, string? target, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
        => src.ToLevenshteinDistance(target, stringComparison);

    public LevenshteinDistanceDetails() => Operations = [];

    internal LevenshteinDistanceDetails(IEnumerable<LevenshteinOperation> operations, int distance, double percentage)
    {
        Operations = [.. operations];
        Distance = distance;
        Percentage = percentage;
    }
}

