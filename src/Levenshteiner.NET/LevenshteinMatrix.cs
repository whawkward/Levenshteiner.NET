using CommunityToolkit.HighPerformance;
#if NET9_0_OR_GREATER
using System.Buffers;
#endif

namespace Levenshteiner.NET;

internal readonly ref struct LevenshteinMatrix
#if NET9_0_OR_GREATER
    : IDisposable
#endif
{
    public readonly int Distance => _matrix[^1, ^1];
    public readonly double Percentage { get; }

    private readonly Span2D<int> _matrix;
    private readonly ReadOnlySpan<char> _src;
    private readonly ReadOnlySpan<char> _target;

#if NET9_0_OR_GREATER
    private readonly int[]? _rented;

    public void Dispose()
    {
        if (_rented is not null)
        {
            ArrayPool<int>.Shared.Return(_rented, clearArray: true);
        }
    }

    internal LevenshteinMatrix(ReadOnlySpan<char> src, ReadOnlySpan<char> target, StringComparison stringComparison)
    {
        var width = src.Length + 1;
        var height = target.Length + 1;
        var size = width * height;

        _rented = ArrayPool<int>.Shared.Rent(size);
        _matrix = _rented.AsSpan(..size).AsSpan2D(width, height);
        _src = src;
        _target = target;
        PopulateMatrix(ref _matrix, src, target, stringComparison);
        var distance = _matrix[^1, ^1];
        var divisor = Math.Max(src.Length, target.Length);

        Percentage = divisor switch
        {
            0 => 0.0,
            _ when distance == divisor => 1.0,
            _ => (double)distance / divisor
        };
    }
#else
    internal LevenshteinMatrix(int[] array, ReadOnlySpan<char> src, ReadOnlySpan<char> target, StringComparison stringComparison)
    {
        var width = src.Length + 1;
        var height = target.Length + 1;
        var size = width * height;

        _matrix = array.AsSpan(..size).AsSpan2D(width, height);
        _src = src;
        _target = target;
        PopulateMatrix(ref _matrix, src, target, stringComparison);
        var distance = _matrix[^1, ^1];
        var divisor = Math.Max(src.Length, target.Length);

        Percentage = divisor switch
        {
            0 => 0.0,
            _ when distance == divisor => 1.0,
            _ => (double)distance / divisor
        };
    }

    public static int CalculateBufferSize(ReadOnlySpan<char> src, ReadOnlySpan<char> target)
    {
        var width = src.Length + 1;
        var height = target.Length + 1;
        return width * height;
    }
#endif

    public IEnumerable<LevenshteinOperation> CreateOperations()
    {
        var x = _src.Length;
        var y = _target.Length;

        if (x == 0 && y == 0)
        {
            return [];
        }

        int cell;

        Stack<LevenshteinOperation> operations = [];

        while ((cell = _matrix[x, y]) != 0)
        {
            // Check cell above
            int above = y > 0 ? _matrix[x, y - 1] : int.MaxValue;
            // Check cell to the left
            int left = x > 0 ? _matrix[x - 1, y] : int.MaxValue;
            // Check cell diagonally (above left)
            int diagonal = x > 0 && y > 0 ? _matrix[x - 1, y - 1] : int.MaxValue;

            if (left < cell)
            {
                x -= 1;
                operations.Push(new DeleteOperation(_src[x], x));
            }
            else if (above < cell)
            {
                y -= 1;
                operations.Push(new InsertOperation(_target[y], y));
            }
            else
            {
                x -= 1;
                y -= 1;
                operations.Push(diagonal < cell ? new SubstitutionOperation(_src[x], _target[y], x) : new NoOperation(_src[x], x));
            }
        }

        return [.. operations];
    }

    private static void PopulateMatrix(ref Span2D<int> distanceMatrix, ReadOnlySpan<char> srcSpan, ReadOnlySpan<char> targetSpan, StringComparison stringComparison)
    {
        for (int s = 0; s <= srcSpan.Length; s++)
        {
            for (int t = 0; t <= targetSpan.Length; t++)
            {
                if (s == 0)
                {
                    distanceMatrix[s, t] = t;
                }
                else if (t == 0)
                {
                    distanceMatrix[s, t] = s;
                }
                else
                {
                    var cost = srcSpan[(s - 1)..s].Equals(targetSpan[(t - 1)..t], stringComparison) ? 0 : 1;

                    var aboveCost = distanceMatrix[s, t - 1] + 1;
                    var leftCost = distanceMatrix[s - 1, t] + 1;
                    var diagonalCost = distanceMatrix[s - 1, t - 1] + cost;

                    distanceMatrix[s, t] = Math.Min(Math.Min(aboveCost, leftCost), diagonalCost);
                }
            }
        }
    }
}