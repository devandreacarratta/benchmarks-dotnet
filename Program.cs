using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using System.Collections.Immutable;

var configuration = ConfigurationEngine.Read();

var items = configuration.Benchmarks
    .Where(x => x.Value != null && x.Value.Exclude == false)
    .ToImmutableList();

var coreRuntimes = configuration.CoreRuntimes
    .Where(x => Array.IndexOf(ConfigurationEngine.VALID_CORE_RUNTIMES, x) != -1)
    .Select(x => ConfigurationEngine.ParseRuntime(x))
    .ToImmutableList();

foreach (var item in items)
{
    var config = DefaultConfig.Instance
        .AddDiagnoser(MemoryDiagnoser.Default)
        .WithOrderer(new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest))
        .AddColumn(RankColumn.Arabic);

    if (string.IsNullOrEmpty(configuration.BaseFolderResult) == false)
    {
        string folder = Path.Combine(configuration.BaseFolderResult, item.Key);
        config.WithArtifactsPath(folder);
    }

    foreach (var coreRuntime in coreRuntimes)
    {
        config.AddJob(
            Job.Default.WithRuntime(
                coreRuntime
            )
        );
    }

    string typeName = string.Format("{0}.{1}", configuration.DefaultNamespace, item.Value.Type);

    Type benchmarkType = Type.GetType(typeName)!;

    BenchmarkRunner.Run(benchmarkType, config);
}