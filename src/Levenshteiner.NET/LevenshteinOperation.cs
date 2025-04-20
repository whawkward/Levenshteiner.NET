namespace Levenshteiner.NET;

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