using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace PerformanceTest
{
    public class ForVsForeach
    {
        List<int> TestList = new List<int>();
        public ForVsForeach()
        {
            for (int index = 0; index < 1000; index++)
                TestList.Add(index);
        }
        [Benchmark]
        public void For()
        {
            List<int> ForList = new List<int>();
            for (int index = 0; index < 1000; index++)
                ForList.Add(TestList[index]);
        }
        [Benchmark]
        public void Foreach()
        {
            List<int> ForEachlist = new List<int>();
            foreach (var item in TestList)
                ForEachlist.Add(item);      
        }
    }
}
