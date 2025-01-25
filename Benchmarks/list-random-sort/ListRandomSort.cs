namespace BenchmarksDotnet.Benchmarks;

public class ListRandomSort
{
    [Params(1000, 10_000, 100_000)]
    public int ItemsToAdd;

    private IList<int> _listOrderByNewGuid = default!;
    private IList<int> _listOrderByRandom = default!;

    [IterationSetup()]
    public void Setup()
    {
        _listOrderByNewGuid = Enumerable.Range(0, ItemsToAdd - 1).ToList();
        _listOrderByRandom = Enumerable.Range(0, ItemsToAdd - 1).ToList();
    }

    [Benchmark]
    public void OrderByNewGuid()
    {
        _ = _listOrderByNewGuid.OrderBy(x => Guid.NewGuid()).ToList();
    }

    [Benchmark]
    public void OrderByRandom()
    {
        _ = _listOrderByRandom.OrderBy(x => Random.Shared.Next()).ToList();
    }
}
