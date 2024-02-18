using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using System.Reflection;

List<Type> benchmarkTypes = new();
//{
//    //typeof(BenchmarksDotnet.Benchmarks.GuidToString),
//    //typeof(BenchmarksDotnet.Benchmarks.StringEqualsPerformance),
//    //typeof(BenchmarksDotnet.Benchmarks.StringComparePerformance),
//    //typeof(BenchmarksDotnet.Benchmarks.DictionaryVersusSortedAddItems),
//    //typeof(BenchmarksDotnet.Benchmarks.DictionaryVersusSortedTryAddItems),
//    //typeof(BenchmarksDotnet.Benchmarks.NewtonsoftVersusJsonSerializerDeserialize),
//    //typeof(BenchmarksDotnet.Benchmarks.NewtonsoftVersusJsonSerializerSerialize),
//    //typeof(BenchmarksDotnet.Benchmarks.ListSortVersusLinq),
//    //typeof(BenchmarksDotnet.Benchmarks.ListSortVersusLinqDescending),
//};

var config = DefaultConfig.Instance
    .AddDiagnoser(MemoryDiagnoser.Default)
    .WithOrderer(new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest))
    .AddColumn(RankColumn.Arabic)
    .AddJob(Job.Default.WithRuntime(CoreRuntime.Core60))
    .AddJob(Job.Default.WithRuntime(CoreRuntime.Core80));

if (benchmarkTypes == null || benchmarkTypes.Count == 0)
{
    _ = BenchmarkRunner.Run(Assembly.GetExecutingAssembly());
}
else
{
    foreach (var type in benchmarkTypes)
    {
        BenchmarkRunner.Run(type, config);
    }
}