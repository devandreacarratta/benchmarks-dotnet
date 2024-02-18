using BenchmarkDotNet.Running;
using BenchmarksDotnet;
using System.Reflection;

List<Type> benchmarkTypes = new List<Type>()
    {
        typeof(GuidToString),
        typeof(StringEqualsPerformance),
        typeof(DictionaryVersusSortedAddItems),
        typeof(DictionaryVersusSortedTryAddItems),
        typeof(NewtonsoftVersusJsonSerializerDeserialize),
        typeof(NewtonsoftVersusJsonSerializerSerialize),
    };

if (benchmarkTypes == null || benchmarkTypes.Count == 0)
{
    _ = BenchmarkRunner.Run(Assembly.GetExecutingAssembly());
}
else
{
    foreach (var type in benchmarkTypes)
    {
        BenchmarkRunner.Run(type);
    }
}