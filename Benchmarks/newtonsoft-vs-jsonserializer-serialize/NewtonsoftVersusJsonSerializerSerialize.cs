using BenchmarksDotnet.Entities;
using System.Reflection;

namespace BenchmarksDotnet.Benchmarks
{
    public class NewtonsoftVersusJsonSerializerSerialize
    {
        private Products _products = new Products();

        [GlobalSetup]
        public void Setup()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "BenchmarksDotnet.EmbeddedResource.products.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();

                _products = System.Text.Json.JsonSerializer.Deserialize<Products>(json);
            }
        }

        [Benchmark]
        public void NewtonsoftSerializeObject()
        {
            _ = Newtonsoft.Json.JsonConvert.SerializeObject(_products);
        }

        [Benchmark]
        public void JsonSerializerSerialize()
        {
            _ = System.Text.Json.JsonSerializer.Serialize(_products);
        }
    }
}