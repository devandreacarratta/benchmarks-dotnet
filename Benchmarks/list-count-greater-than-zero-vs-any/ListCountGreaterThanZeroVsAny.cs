namespace BenchmarksDotnet.Benchmarks;

public class ListCountGreaterThanZeroVsAny
{
    [Params(1000, 10_000, 100_000)]
    public int ItemsToAdd;

    private List<Guid> _list = new();

    [IterationSetup()]
    public void Setup()
    {
        _list = new();

        for (int i = 0; i < ItemsToAdd; i++)
        {
            _list.Add(Guid.NewGuid());
        }
    }

    [Benchmark]
    public void ListCountGreaterThanZero()
    {
        _=_list.Count > 0;
    }

    [Benchmark]
    public void ListAny()
    {
        _ = _list.Any();
    }
}
