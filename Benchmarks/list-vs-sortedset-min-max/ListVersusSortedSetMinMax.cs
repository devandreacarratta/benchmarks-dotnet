namespace BenchmarksDotnet.Benchmarks;

public class ListVersusSortedSetMinMax
{
    [Params(10, 100, 1_000, 10_000, 100_000)]
    public int ItemsToAdd;

    private List<int> _list = new();
    private SortedSet<int> _sorted = new();

    [IterationSetup()]
    public void Setup()
    {
        int[] items = Enumerable.Range(0, ItemsToAdd)
            .OrderBy(x => Guid.NewGuid())
            .ToArray();

        _list = new List<int>(items);
        _sorted = new SortedSet<int>(items);
    }

    [Benchmark]
    public void MixItemFromList()
    {
        _ = _list.Min();
    }

    [Benchmark]
    public void MinItemFromSortedSet()
    {
        _ = _sorted.Min();
    }

    [Benchmark]
    public void MaxItemFromList()
    {
        _ = _list.Max();
    }

    [Benchmark]
    public void MaxItemFromSortedSet()
    {
        _ = _sorted.Max();
    }
}