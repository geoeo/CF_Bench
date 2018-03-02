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
            var matrixTest = new MatrixMultiplyTest();
            var matrixAllocTest = new MatrixAllocTest();
            Console.WriteLine("Start..");
            float avgTime = 0f;

            avgTime = Experiment.performExperimentActionMatrix(matrixTest.RunFSharpTests,timer);
            Console.WriteLine($"F# Average Time: {avgTime} ms");

            avgTime = Experiment.performExperimentActionMatrix(matrixTest.RunCSharpTests,timer);
            Console.WriteLine($"C# Average Time: {avgTime} ms");

            // avgTime = Experiment.performExperimentVector3(eucliddianDistanceTest.RunFSharpTests,timer);
            // Console.WriteLine($"F# Average Time: {avgTime} ms");

            // avgTime = Experiment.performExperimentVector3(eucliddianDistanceTest.RunCSharpTests,timer);
            // Console.WriteLine($"C# Average Time: {avgTime} ms");



            
        }
    }
}