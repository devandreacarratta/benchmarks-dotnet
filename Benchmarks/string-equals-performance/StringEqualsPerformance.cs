namespace BenchmarksDotnet
{
    public class StringEqualsPerformance
    {
        private string _firstItem = string.Empty;
        private string _secondItem = string.Empty;

        [Params(
            StringComparison.CurrentCulture,
            StringComparison.CurrentCultureIgnoreCase,
            StringComparison.InvariantCulture,
            StringComparison.InvariantCultureIgnoreCase,
            StringComparison.Ordinal,
            StringComparison.OrdinalIgnoreCase)]
        public StringComparison _stringComparison;

        [GlobalSetup()]
        public void Setup()
        {
            _firstItem = "Hello World";
            _secondItem = "hello world";
        }

        [Benchmark]
        public void StringEqual()
        {
            _ = string.Equals(_firstItem, _secondItem, _stringComparison);
        }
    }
}