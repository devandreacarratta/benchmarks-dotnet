using System.Text;

namespace BenchmarksDotnet.Benchmarks;

public class StringConcatenationWithSeparator
{
    [Params(10, 100, 1000, 10000)]
    public int NumberOfItems;

    private const string SEPARATOR = "|";

    private List<string> _items = new();

    [IterationSetup()]
    public void Setup()
    {
        _items = new List<string>();
        for (int i = 0; i < NumberOfItems; i++)
        {
            _items.Add(i.ToString("D5"));
        }
    }

    [Benchmark]
    public void StringBuilderInterpolation()
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (string item in _items)
        {
            stringBuilder.Append($"{item}{SEPARATOR}");
        }
        _ = stringBuilder.ToString();
    }

    [Benchmark]
    public void StringBuilderFormat()
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (string item in _items)
        {
            stringBuilder.AppendFormat("{0}{1}", item, SEPARATOR);
        }
        _ = stringBuilder.ToString();
    }

    [Benchmark]
    public void StringJoinToString()
    {
        _ = string.Join(SEPARATOR, _items);
    }

    [Benchmark]
    public void LinqAggregate()
    {
        _ = _items.Aggregate((current, next) => current + SEPARATOR + next);
    }

    [Benchmark]
    public void LinqAggregateInterpolation()
    {
        _ = _items.Aggregate((current, next) => $"{current}{SEPARATOR}{next}");
    }
}