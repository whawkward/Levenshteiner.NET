using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Levenshteiner.NET.Extensions;

namespace Benchmarks;

[MemoryDiagnoser(false)]
[SimpleJob(runtimeMoniker: RuntimeMoniker.Net80)]
[SimpleJob(runtimeMoniker: RuntimeMoniker.Net90)]
public class LevenshteinBenchmarks
{
    [Params(null, "a bunch of characters")]
    public string? Src;

    [Params("", "characterisation is key")]
    public string? Target;

    [Benchmark]
    public void CalculateLevenshteinDistance()
    {
        var distance = Src.CalculateLevenshteinDistance(Target);
    }

    [Benchmark]
    public void CalculateLevenshteinOperations()
    {
        var operations = Src.CalculateLevenshteinOperations(Target);
    }

    [Benchmark]
    public void ToLevenshteinDistanceModel()
    {
        var distance = Src.ToLevenshteinDistance(Target);
    }

    [Benchmark]
    public void ToLevenshteinDistanceModelOut()
    {
        Src.ToLevenshteinDistance(Target, out var operations);
    }
}
