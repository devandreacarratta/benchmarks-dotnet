using BenchmarkDotNet.Engines;

namespace BenchmarksDotnet.Benchmarks;

public class IEnumerableVersusYield
{
    private readonly Consumer consumer = new Consumer();

    [Params(10, 100, 1_000, 10_000, 100_000, 1_000_000)]
    public int ItemsToAdd;

    private List<int> _list = new();

    [IterationSetup()]
    public void Setup()
    {
        _list = new();
    }

    [Benchmark]
    public void IEnumerableWithList()
    {
        GenerateIEnumerableWithList()
            .Consume(consumer);
    }

    private IEnumerable<int> GenerateIEnumerableWithList()
    {
        for (int i = 0; i < ItemsToAdd; i++)
        {
            _list.Add(i);
        }
        return _list;
    }

    [Benchmark]
    public void IEnumerableWithYield()
    {
        GenerateIEnumerableWithYield()
            .Consume(consumer);
    }

    private IEnumerable<int> GenerateIEnumerableWithYield()
    {
        for (int i = 0; i < ItemsToAdd; i++)
        {
            yield return i;
        }
    }
}