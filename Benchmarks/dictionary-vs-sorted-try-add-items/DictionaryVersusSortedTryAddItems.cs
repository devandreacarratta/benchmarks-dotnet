namespace BenchmarksDotnet.Benchmarks;

public class DictionaryVersusSortedTryAddItems
{
    [Params(10, 100, 1000, 10000)]
    public int ItemsToAdd;

    private Dictionary<int, bool> _dictionary = new();
    private SortedDictionary<int, bool> _sorted = new();

    [IterationSetup()]
    public void Setup()
    {
        _dictionary = new();
        _sorted = new();
    }

    [Benchmark]
    public void AddToDictionary()
    {
        for (int i = 0; i < ItemsToAdd; i++)
        {
            _dictionary.TryAdd(i, true);
        }
    }

    [Benchmark]
    public void AddToSortedDictionary()
    {
        for (int i = 0; i < ItemsToAdd; i++)
        {
            _sorted.TryAdd(i, true);
        }
    }
}