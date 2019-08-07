using System.Text;
using BenchmarkDotNet.Attributes;

namespace PerformanceTest
{
    public class StringVsStringBuilder
    {
        [Benchmark]
        public void String()
        {
            string name = "Naveen";
            for (int index = 0; index < 1000; index++)
                name += index.ToString();
        }
        [Benchmark]
        public void StringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Naveen");
            for (int index = 0; index < 1000; index++)
                stringBuilder.Append(index.ToString());

        }
    }
}
