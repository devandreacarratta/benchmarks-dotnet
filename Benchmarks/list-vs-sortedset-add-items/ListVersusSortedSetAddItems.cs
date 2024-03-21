using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarksDotnet.Benchmarks
{
    public class ListVersusSortedSetAddItems
    {
        [Params(10, 100, 1_000, 10_000, 100_000)]
        public int ItemsToAdd;

        private int[] _items = new int[] { };

        [IterationSetup()]
        public void Setup()
        {
            _items= Enumerable.Range(0, ItemsToAdd)
                .OrderBy(x => Guid.NewGuid())
                .ToArray();
        }

        [Benchmark]
        public void AddItemsToList()
        {
            var list = new List<int>();
            foreach(var item in _items) {
                list.Add(item);
            }
        }

        [Benchmark]
        public void AddItemsToSortedSet()
        {
            var list = new SortedSet<int>();
            foreach (var item in _items)
            {
                list.Add(item);
            }
        }       
    }
}
