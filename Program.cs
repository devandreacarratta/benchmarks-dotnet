using BenchmarkDotNet.Running;
using BenchmarksDotnet;
using System.Reflection;

bool fullBenchmarks = false;

if (fullBenchmarks)
{
    var summary = BenchmarkRunner.Run(Assembly.GetExecutingAssembly());
}
else
{
    List<Type> benchmarkTypes = new List<Type>()
    {
        typeof(GuidToString)
    };

    foreach (var type in benchmarkTypes)
    {
        BenchmarkRunner.Run(type);
    }
}