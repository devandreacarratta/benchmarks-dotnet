namespace BenchmarksDotnet.Benchmarks;

public class ListAddItemsCapacity
{
    [Params(1_000, 10_000, 100_000, 1_000_000)]
    public int NumberOfItems;

    private List<string> _itemsCapacity = new();
    private List<string> _itemsNoCapacity = new();    

    private List<string> _items = new();

    [IterationSetup()]
    public void Setup()
    {
        _itemsNoCapacity = new List<string>();
        _itemsCapacity = new List<string>(NumberOfItems);

        _items = Enumerable.Range(0, NumberOfItems).Select(i => Guid.NewGuid().ToString()).ToList();
    }

    [Benchmark]
    public void AddWithCapacity()
    {
        foreach (var item in _items)
        {
            _itemsCapacity.Add(item);
        }
    }

    [Benchmark]
    public void AddWithoutCapacity()
    {
        foreach (var item in _items)
        {
            _itemsNoCapacity.Add(item);
        }
    }   
}

