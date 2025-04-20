#if !NET9_0_OR_GREATER
using System.Buffers;
#endif

namespace Levenshteiner.NET.Extensions;

public static class StringExtensions
{
    public static int CalculateLevenshteinDistance(this string? src, string? target, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
    {
        var srcLength = src?.Length ?? 0;
        var targetLength = target?.Length ?? 0;
        if (srcLength == 0 || targetLength == 0)
        {
            return int.Max(srcLength, targetLength);
        }

        if (string.Equals(src, target, stringComparison))
        {
            return 0;
        }

#if NET9_0_OR_GREATER
        using var matrix = new LevenshteinMatrix(src, target, stringComparison);
        return matrix.Distance;
#else
        int bufferSize = LevenshteinMatrix.CalculateBufferSize(src, target);
        int[] rentedBuffer = ArrayPool<int>.Shared.Rent(bufferSize);
        try
        {
            var matrix = new LevenshteinMatrix(rentedBuffer, src, target, stringComparison);
            return matrix.Distance;
        }
        finally
        {
            ArrayPool<int>.Shared.Return(rentedBuffer, clearArray: true);
        }
#endif
    }

    public static double CalculateLevenshteinDistancePercentage(this string? src, string? target, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
    {
        var srcLength = src?.Length ?? 0;
        var targetLength = target?.Length ?? 0;
        if (srcLength == 0 || targetLength == 0)
        {
            var max = int.Max(srcLength, targetLength);
            return max > 0 ? 1.0 : 0.0;
        }

        if (string.Equals(src, target, stringComparison))
        {
            return 0.0;
        }

#if NET9_0_OR_GREATER
        using var matrix = new LevenshteinMatrix(src, target, stringComparison);
        return matrix.Percentage;
#else
        int bufferSize = LevenshteinMatrix.CalculateBufferSize(src, target);
        int[] rentedBuffer = ArrayPool<int>.Shared.Rent(bufferSize);
        try
        {
            var matrix = new LevenshteinMatrix(rentedBuffer, src, target, stringComparison);
            return matrix.Percentage;
        }
        finally
        {
            ArrayPool<int>.Shared.Return(rentedBuffer, clearArray: true);
        }
#endif
    }

    public static (int distance, double percentage) CalculateLevenshteinDistanceWithPercentage(this string? src, string? target, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
    {
        var srcLength = src?.Length ?? 0;
        var targetLength = target?.Length ?? 0;
        if (srcLength == 0 || targetLength == 0)
        {
            var max = int.Max(srcLength, targetLength);
            return (max, max > 0 ? 1.0 : 0.0);
        }

        if (string.Equals(src, target, stringComparison))
        {
            return (0, 0.0);
        }

#if NET9_0_OR_GREATER
        using var matrix = new LevenshteinMatrix(src, target, stringComparison);
        return (matrix.Distance, matrix.Percentage);
#else
        int bufferSize = LevenshteinMatrix.CalculateBufferSize(src, target);
        int[] rentedBuffer = ArrayPool<int>.Shared.Rent(bufferSize);
        try
        {
            var matrix = new LevenshteinMatrix(rentedBuffer, src, target, stringComparison);
            return (matrix.Distance, matrix.Percentage);
        }
        finally
        {
            ArrayPool<int>.Shared.Return(rentedBuffer, clearArray: true);
        }
#endif
    }

    public static IEnumerable<LevenshteinOperation> CalculateLevenshteinOperations(this string? src, string? target, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
    {
        if ((src?.Length ?? 0) == 0 || (target?.Length ?? 0) == 0)
        {
            return CreateDefaultOperations(src, target);
        }

        if (string.Equals(src, target, stringComparison))
        {
            return [];
        }

#if NET9_0_OR_GREATER
        using var matrix = new LevenshteinMatrix(src, target, stringComparison);
        return matrix.CreateOperations();
#else
        int bufferSize = LevenshteinMatrix.CalculateBufferSize(src, target);
        int[] rentedBuffer = ArrayPool<int>.Shared.Rent(bufferSize);
        try
        {
            var matrix = new LevenshteinMatrix(rentedBuffer, src, target, stringComparison);
            return matrix.CreateOperations();
        }
        finally
        {
            ArrayPool<int>.Shared.Return(rentedBuffer, clearArray: true);
        }
#endif
    }

    public static LevenshteinDistanceDetails ToLevenshteinDistance(this string? src, string? target, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
    {
        var srcLength = src?.Length ?? 0;
        var targetLength = target?.Length ?? 0;
        if (srcLength == 0 || targetLength == 0)
        {
            var max = int.Max(srcLength, targetLength);
            var percentage = max > 0 ? 1.0 : 0.0;

            return new LevenshteinDistanceDetails(CreateDefaultOperations(src, target), max, percentage);
        }

        if (string.Equals(src, target, stringComparison))
        {
            return new LevenshteinDistanceDetails();
        }

#if NET9_0_OR_GREATER
        using var matrix = new LevenshteinMatrix(src, target, stringComparison);
        return new LevenshteinDistanceDetails(matrix.CreateOperations(), matrix.Distance, matrix.Percentage);
#else
        int bufferSize = LevenshteinMatrix.CalculateBufferSize(src, target);
        int[] rentedBuffer = ArrayPool<int>.Shared.Rent(bufferSize);
        try
        {
            var matrix = new LevenshteinMatrix(rentedBuffer, src, target, stringComparison);
            return new LevenshteinDistanceDetails(matrix.CreateOperations(), matrix.Distance, matrix.Percentage);
        }
        finally
        {
            ArrayPool<int>.Shared.Return(rentedBuffer, clearArray: true);
        }
#endif
    }

    public static void ToLevenshteinDistance(this string? src, string? target, out LevenshteinDistanceDetails levenshteinDistance)
        => ToLevenshteinDistance(src, target, StringComparison.OrdinalIgnoreCase, out levenshteinDistance);

    public static void ToLevenshteinDistance(this string? src, string? target, StringComparison stringComparison, out LevenshteinDistanceDetails levenshteinDistance)
    {
        if (src?.Length == 0 || target?.Length == 0)
        {
            var max = int.Max(src?.Length ?? 0, target?.Length ?? 0);
            var percentage = max > 0 ? 1.0 : 0.0;

            levenshteinDistance = new LevenshteinDistanceDetails(CreateDefaultOperations(src, target), max, percentage);
            return;
        }

        if (string.Equals(src, target, stringComparison))
        {
            levenshteinDistance = new LevenshteinDistanceDetails([], 0, 0.0);
            return;
        }

#if NET9_0_OR_GREATER
        using var matrix = new LevenshteinMatrix(src, target, stringComparison);
        levenshteinDistance = new LevenshteinDistanceDetails(matrix.CreateOperations(), matrix.Distance, matrix.Percentage);
#else
        int bufferSize = LevenshteinMatrix.CalculateBufferSize(src, target);
        int[] rentedBuffer = ArrayPool<int>.Shared.Rent(bufferSize);
        try
        {
            var matrix = new LevenshteinMatrix(rentedBuffer, src, target, stringComparison);
            levenshteinDistance = new LevenshteinDistanceDetails(matrix.CreateOperations(), matrix.Distance, matrix.Percentage);
        }
        finally
        {
            ArrayPool<int>.Shared.Return(rentedBuffer, clearArray: true);
        }
#endif
    }

    private static IEnumerable<LevenshteinOperation> CreateDefaultOperations(string? src, string? target)
        => (src, target) switch
        {
            (null or { Length: 0 }, null or { Length: 0 }) => [],
            (null or { Length: 0 }, { Length: > 0 }) => [.. target.Select((ch, i) => new InsertOperation(ch, i))],
            ({ Length: > 0 }, null or { Length: 0 }) => [.. src.Select((ch, i) => new DeleteOperation(ch, i))],
            // This case should not occur due to the previous checks as this is only called when either src or target is null or empty
            _ => []
        };
}
