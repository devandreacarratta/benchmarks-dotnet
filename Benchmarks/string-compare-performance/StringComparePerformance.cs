namespace BenchmarksDotnet.Benchmarks
{
    public class StringComparePerformance
    {
        public IEnumerable<string> FirstItems => new[] { "Hello World", "hello world" };
        public IEnumerable<string> SecondItems => new[] { "Hello World", "HELLO WORLD" };

        [ParamsSource(nameof(FirstItems))]
        public string FirstItem { get; set; } = string.Empty;

        [ParamsSource(nameof(SecondItems))]
        public string SecondItem { get; set; } = string.Empty;

        [Params(true, false)]
        public bool IgnoreCaseItem { get; set; } = false;

        [GlobalSetup()]
        public void Setup()
        {
        }

        [Benchmark]
        public void StringCompare()
        {
            _ = string.Compare(FirstItem, SecondItem, IgnoreCaseItem);
        }
    }
}