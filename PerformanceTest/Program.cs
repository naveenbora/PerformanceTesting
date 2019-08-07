using System;
using System.Diagnostics;
using System.Security.Cryptography;
using BenchmarkDotNet.Running;

namespace PerformanceTest
{

    class Program
    {
      
        static void Main(string[] args)
        {

            var stringVsBuilder = BenchmarkRunner.Run<StringVsStringBuilder>();
            var listVsArray = BenchmarkRunner.Run<ListVsArray>();
            var forvsforeach = BenchmarkRunner.Run<ForVsForeach>();
            var taskVsThread = BenchmarkRunner.Run<TaskVsThread>();
            var structureVsClass= BenchmarkRunner.Run<StructureVsClass>();
            Console.ReadLine();
        }
    }
}
