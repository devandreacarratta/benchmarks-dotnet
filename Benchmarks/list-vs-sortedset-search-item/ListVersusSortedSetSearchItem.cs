namespace BenchmarksDotnet.Benchmarks
{
    public class ListVersusSortedSetSearchItem
    {
        [Params(10, 100, 1_000, 10_000, 100_000)]
        public int ItemsToAdd;

        private List<int> _list = new();
        private SortedSet<int> _sorted = new();
        private int _valueToSearch = 0;

        [IterationSetup()]
        public void Setup()
        {
            int[] items = Enumerable.Range(0, ItemsToAdd)
                .OrderBy(x => Guid.NewGuid())
                .ToArray();

            _valueToSearch = items
                .OrderBy(x => Guid.NewGuid())
                .First();

            _list = new List<int>(items);
            _sorted = new SortedSet<int>(items);
        }

        [Benchmark]
        public void ContainsItemFromList()
        {
            _ = _list.Contains(_valueToSearch);
        }

        [Benchmark]
        public void ContainsItemFromSortedSet()
        {
            _ = _sorted.Contains(_valueToSearch);
        }

        [Benchmark]
        public void AnyItemFromList()
        {
            _ = _list.Any(x => x == _valueToSearch);
        }

        [Benchmark]
        public void AnyItemFromSortedSet()
        {
            _ = _sorted.Any(x => x == _valueToSearch);
        }

        [Benchmark]
        public void ExistsItemFromList()
        {
            _ = _list.Exists(x => x == _valueToSearch);
        }
    }
}