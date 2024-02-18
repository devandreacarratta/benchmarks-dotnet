using BenchmarksDotnet.Entities;
using System.Reflection;

namespace BenchmarksDotnet.Benchmarks
{
    public class NewtonsoftVersusJsonSerializerDeserialize
    {
        private string _json = string.Empty;

        [GlobalSetup]
        public void Setup()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "BenchmarksDotnet.EmbeddedResource.products.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                _json = reader.ReadToEnd();
            }
        }

        [Benchmark]
        public void NewtonsoftDeserializeObject()
        {
            _ = Newtonsoft.Json.JsonConvert.DeserializeObject<Products>(_json);
        }

        [Benchmark]
        public void JsonSerializerDeserialize()
        {
            _ = System.Text.Json.JsonSerializer.Deserialize<Products>(_json);
        }
    }
}