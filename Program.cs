using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using BenchmarksDotnet.Benchmarks;
using System.Reflection;

List<Type> benchmarkTypes = new()
{
    //typeof(GuidToString),
    //typeof(StringEqualsPerformance),
    //typeof(StringComparePerformance),
    //typeof(DictionaryVersusSortedAddItems),
    //typeof(DictionaryVersusSortedTryAddItems),
    //typeof(NewtonsoftVersusJsonSerializerDeserialize),
    //typeof(NewtonsoftVersusJsonSerializerSerialize),
    //typeof(ListSortVersusLinq),
    //typeof(ListSortVersusLinqDescending),
    //typeof(IEnumerableVersusYield),
    //typeof(ListVersusSortedSetSearchItems)
    typeof(ListVersusSortedSetSearchItems)
};

var config = DefaultConfig.Instance
    .AddDiagnoser(MemoryDiagnoser.Default)
    .WithOrderer(new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest))
    .AddColumn(RankColumn.Arabic)
    .AddJob(Job.Default.WithRuntime(CoreRuntime.Core60))
    .AddJob(Job.Default.WithRuntime(CoreRuntime.Core80));

if (benchmarkTypes == null || benchmarkTypes.Count == 0)
{
    _ = BenchmarkRunner.Run(Assembly.GetExecutingAssembly(), config);
}
else
{
    foreach (var type in benchmarkTypes)
    {
        BenchmarkRunner.Run(type, config);
    }
}