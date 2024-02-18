using System.Text;

namespace BenchmarksDotnet
{
    public class GuidToString
    {
        public Guid CurrentGuid = Guid.Empty;

        [GlobalSetup]
        public void Setup()
        {
            CurrentGuid = Guid.NewGuid();
        }

        [Benchmark]
        public void MethodToString()
        {
            _ = CurrentGuid.ToString();
        }

        [Benchmark]
        public void StringInterpolation()
        {
            _ = $"{CurrentGuid}";
        }

        [Benchmark]
        public void StringBuilderCheck()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(CurrentGuid);

            _ = stringBuilder.ToString();
        }
    }
}