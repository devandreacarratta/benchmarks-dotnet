namespace BenchmarksDotnet.Model;

public class InternalConfiguration
{
    public string BaseFolderResult { get; set; } = default!;
    public string DefaultNamespace { get; set; } = default!;
    public IDictionary<string, InternalConfigurationBenchmark> Benchmarks { get; set; } = default!;
    public string[] CoreRuntimes { get; set; } = default!;
}

public record InternalConfigurationBenchmark(string Type, bool Exclude);