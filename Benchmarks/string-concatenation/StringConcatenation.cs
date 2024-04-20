using System.Text;

namespace BenchmarksDotnet.Benchmarks
{
    public class StringConcatenation
    {
        [Params(10, 100, 1000, 10000)]
        public int NumberOfItems;

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
        public void StringBuilderConcatenation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string item in _items)
            {
                stringBuilder.Append(item);
            }
            _ = stringBuilder.ToString();
        }

        [Benchmark]
        public void StringConcat()
        {
            _ = string.Concat(_items);
        }

        [Benchmark]
        public void StringJoinToString()
        {
            _ = string.Join(string.Empty, _items);
        }

        [Benchmark]
        public void LinqAggregate()
        {
            _ = _items.Aggregate((current, next) => current + next);
        }

        [Benchmark]
        public void LinqAggregateInterpolation()
        {
            _ = _items.Aggregate((current, next) => $"{current}{next}");
        }
    }
}