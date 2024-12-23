using System.Text;

namespace BenchmarksDotnet.Benchmarks;

public class GuidToString
{
    private Guid _currentGuid = Guid.Empty;

    [GlobalSetup]
    public void Setup()
    {
        _currentGuid = Guid.NewGuid();
    }

    [Benchmark]
    public void MethodToString()
    {
        _ = _currentGuid.ToString();
    }

    [Benchmark]
    public void StringInterpolation()
    {
        _ = $"{_currentGuid}";
    }

    [Benchmark]
    public void StringBuilderCheck()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(_currentGuid);

        _ = stringBuilder.ToString();
    }
}