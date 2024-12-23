using System.Reflection;

namespace BenchmarksDotnet.Benchmarks;

public class NewtonsoftVersusJsonSerializerSerialize
{
    private Products _products = new Products();

    [GlobalSetup]
    public void Setup()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = "BenchmarksDotnet.EmbeddedResource.products.json";

        using (Stream stream = assembly.GetManifestResourceStream(resourceName)!)
        using (StreamReader reader = new StreamReader(stream))
        {
            var json = reader.ReadToEnd();

            _products = System.Text.Json.JsonSerializer.Deserialize<Products>(json)!;
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

public class Products
{
    public Product[] Items { get; set; } = Array.Empty<Product>();
}

public class Product
{
    public int id { get; set; }
    public string title { get; set; } = string.Empty;
    public string description { get; set; } = string.Empty;
    public int price { get; set; }
    public float discountPercentage { get; set; }
    public float rating { get; set; }
    public int stock { get; set; }
    public string brand { get; set; } = string.Empty;
    public string category { get; set; } = string.Empty;
    public string thumbnail { get; set; } = string.Empty;
    public string[] images { get; set; } = new string[] { };
}