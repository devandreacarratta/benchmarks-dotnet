namespace BenchmarksDotnet.Benchmarks;

public class ListSortVersusLinqDescending
{
    [Params(10, 100, 1000, 10000)]
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
    public void ListSort()
    {
        _list.Sort();
        _list.Reverse();
    }

    [Benchmark]
    public void LinqSort()
    {
        _ = _list.OrderByDescending(x => x);
    }
}