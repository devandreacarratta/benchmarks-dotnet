using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using System.Reflection;

List<Type> benchmarkTypes = new List<Type>()
    {
    //typeof(BenchmarksDotnet.Benchmarks.GuidToString),
    //typeof(BenchmarksDotnet.Benchmarks.StringEqualsPerformance),
    //typeof(BenchmarksDotnet.Benchmarks.DictionaryVersusSortedAddItems),
    //typeof(BenchmarksDotnet.Benchmarks.DictionaryVersusSortedTryAddItems),
    //typeof(BenchmarksDotnet.Benchmarks.NewtonsoftVersusJsonSerializerDeserialize),
    //typeof(BenchmarksDotnet.Benchmarks.NewtonsoftVersusJsonSerializerSerialize),
    typeof(BenchmarksDotnet.Benchmarks.ListSortVersusLinq),
    typeof(BenchmarksDotnet.Benchmarks.ListSortVersusLinqDescending),
};

var config = DefaultConfig.Instance
    .AddDiagnoser(MemoryDiagnoser.Default)
    .WithOrderer(new DefaultOrderer(SummaryOrderPolicy.Method, MethodOrderPolicy.Alphabetical))
    .AddColumn(RankColumn.Arabic)
    .With(Job.Default.WithRuntime(CoreRuntime.Core60))
    .With(Job.Default.WithRuntime(CoreRuntime.Core80));

//[MemoryDiagnoser]
//[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
//[RankColumn]

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