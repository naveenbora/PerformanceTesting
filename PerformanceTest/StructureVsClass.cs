using BenchmarkDotNet.Attributes;

namespace PerformanceTest
{
    public class StructureVsClass
    {
        [Benchmark]
        public void Structure()
        {
            Structure TestStructure;
            for (int index = 0; index < 100; index++)
                TestStructure = new Structure { Name = "Naveen", age = 22 };

        }
        [Benchmark]
        public void Class()
        {
                Employee TestClass;
            for (int index = 0; index < 100; index++)
                TestClass = new Employee { Name = "Naveen", age = 22 };

        }
    }
}
