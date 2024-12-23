using BenchmarkDotNet.Environments;
using BenchmarksDotnet.Model;
using System.Reflection;

public class ConfigurationEngine
{
    private const string CORE_20 = "Core20";
    private const string CORE_21 = "Core21";
    private const string CORE_22 = "Core22";
    private const string CORE_30 = "Core30";
    private const string CORE_31 = "Core31";
    private const string CORE_50 = "Core50";
    private const string CORE_60 = "Core60";
    private const string CORE_70 = "Core70";
    private const string CORE_80 = "Core80";
    private const string CORE_90 = "Core90";

    public static readonly string[] VALID_CORE_RUNTIMES = new string[] {
        CORE_20,
        CORE_21,
        CORE_22,
        CORE_30,
        CORE_31,
        CORE_50,
        CORE_60,
        CORE_70,
        CORE_80,
        CORE_90
    };

    internal   string Export(InternalConfiguration item)
    {
        var result = System.Text.Json.JsonSerializer.Serialize(item);
        return result;
    }

    internal static InternalConfiguration Read(string resourceName = "BenchmarksDotnet.EmbeddedResource.configuration.json")
    {
        var assembly = Assembly.GetExecutingAssembly();

        using (Stream stream = assembly.GetManifestResourceStream(resourceName)!)
        using (StreamReader reader = new StreamReader(stream))
        {
            var json = reader.ReadToEnd();
            var result = System.Text.Json.JsonSerializer.Deserialize<InternalConfiguration>(json)!;
            return result;
        }
    }

    internal static CoreRuntime ParseRuntime(string runtimeName)
    {
        return runtimeName switch
        {
            CORE_20 => CoreRuntime.Core20,
            CORE_21 => CoreRuntime.Core21,
            CORE_22 => CoreRuntime.Core22,
            CORE_30 => CoreRuntime.Core30,
            CORE_31 => CoreRuntime.Core31,
            CORE_50 => CoreRuntime.Core50,
            CORE_60 => CoreRuntime.Core60,
            CORE_70 => CoreRuntime.Core70,
            CORE_80 => CoreRuntime.Core80,
            CORE_90 => CoreRuntime.Core90,
            _ => throw new ArgumentException("Unsupported runtime")
        };
    }
}