using System.Threading;
using BenchmarkDotNet.Attributes;
using System.Threading.Tasks;

namespace PerformanceTest
{
    public class TaskVsThread
    {
        public async Task Save()
        {
           await Task.Delay(100);
            //Console.WriteLine("Save");
        }
        public async Task Load()
        {
            await Task.Delay(200);
            //Console.WriteLine("Load");
        }
        public void Save1()
        {
            Thread.Sleep(100);
            //Console.WriteLine("SaveThread");
        }
        public void Load1()
        {
            Thread.Sleep(200);
            //Console.WriteLine("LoadThread");
        }
        [Benchmark]
        public void Threads()
        {
            var save = new Thread(Save1);
            var load = new Thread(Load1);
            save.Start();
            load.Start();
        }
        [Benchmark]
        public void Tasks()
        {
            Task.Run(async () =>
            {
                await Task.WhenAll(Save(), Load());
            }
            ).GetAwaiter().GetResult();
        }
    }
}
