using System;
using System.Timers;
using System.Threading;
using CSharpBench;
using FSharpBench;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new FrameTimer(1.0);

            var eucliddianDistanceTest = new EuclidianDistanceTest();
            Console.WriteLine("Start..");
            float avgTime = 0f;

            avgTime = Experiment.performExperiment(eucliddianDistanceTest.RunCSharpTests,timer);
            Console.WriteLine($"C# Average Time: {avgTime} ms");


            avgTime = Experiment.performExperiment(eucliddianDistanceTest.RunCSharpTests,timer);
            Console.WriteLine($"F# Average Time: {avgTime} ms");
            
        }
    }
}