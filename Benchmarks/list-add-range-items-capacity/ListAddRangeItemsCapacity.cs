namespace BenchmarksDotnet.Benchmarks;

public class ListAddRangeItemsCapacity
{
    [Params(1_000, 10_000,100_000, 1_000_000)]
    public int NumberOfItems;
    
    private List<string> _itemsRangeCapacity = new();
    private List<string> _itemsRangeNoCapacity = new();

    private List<string> _items = new();

    [IterationSetup()]
    public void Setup()
    {
        _itemsRangeNoCapacity = new List<string>();
        _itemsRangeCapacity = new List<string>(NumberOfItems);

        _items = Enumerable.Range(0, NumberOfItems).Select(i =>Guid.NewGuid().ToString() ).ToList();
    }
   
    [Benchmark]
    public void AddRangeWithCapacity()
    {
        _itemsRangeCapacity.AddRange(
            _items
        );
    }

    [Benchmark]
    public void AddRangeWithoutCapacity()
    {
        _itemsRangeNoCapacity.AddRange(
          _items
      );
    }
}

