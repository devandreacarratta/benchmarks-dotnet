namespace BenchmarksDotnet.Benchmarks
{
    public class StringEqualsPerformance
    {
        public IEnumerable<string> FirstItems => new[] { "Hello World", "hello world" };
        public IEnumerable<string> SecondItems => new[] { "Hello World", "HELLO WORLD" };

        [ParamsSource(nameof(FirstItems))]
        public string FirstItem { get; set; } = string.Empty;

        [ParamsSource(nameof(SecondItems))]
        public string SecondItem { get; set; } = string.Empty;

        [Params(
            StringComparison.CurrentCulture,
            StringComparison.CurrentCultureIgnoreCase,
            StringComparison.InvariantCulture,
            StringComparison.InvariantCultureIgnoreCase,
            StringComparison.Ordinal,
            StringComparison.OrdinalIgnoreCase)]
        public StringComparison StringComparisonItem;

        [GlobalSetup()]
        public void Setup()
        {
        }

        [Benchmark]
        public void StringEqual()
        {
            _ = string.Equals(FirstItem, SecondItem, StringComparisonItem);
        }
    }
}