using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace PerformanceTest
{
    public class ListVsArray
    {
        [Benchmark]
        public void Array()
        {
            int[] array = new int[1000];
            for (int index = 0; index < 1000; index++)
                array[index] = index;
        }
        [Benchmark]
        public void List()
        {
            List<int> list = new List<int>();
            for (int index = 0; index < 1000; index++)
                list.Add(index);
        }
    }
}
