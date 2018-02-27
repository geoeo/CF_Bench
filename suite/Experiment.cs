using System;
using System.Numerics;
using System.Collections.Generic;

namespace Benchmark
{
    public static class Experiment
    {
        private const int EXPERIMENT_COUNT = 10;

        public static float performExperiment(Action test, FrameTimer timer){
            var results = new List<float>();

            for(int i = 0; i < EXPERIMENT_COUNT; i++){
                timer.Start();
                test.Invoke();
                timer.Stop();
                results.Add(timer.prevFrameTicksInMilliseconds);
            }

            return averageResults(results);


        }

        public static float performExperimentActionMatrix(Action<Matrix4x4,Matrix4x4> test, FrameTimer timer){
            Console.WriteLine("C# : Performing Experiment with Inputs");
            var results = new List<float>();

            Matrix4x4 m1 = new Matrix4x4(1.0f,0.0f,0.0f,0.0f,
                                        0.0f,1.0f,0.0f,0.0f,
                                        0.0f,0.0f,1.0f,0.0f,
                                        0.0f,0.0f,0.0f,1.0f);
            Matrix4x4 m2 = new Matrix4x4(1.0f,0.0f,0.0f,0.0f,
                                        0.0f,1.0f,0.0f,0.0f,
                                        0.0f,0.0f,1.0f,0.0f,
                                        0.0f,0.0f,0.0f,1.0f);

            for(int i = 0; i < EXPERIMENT_COUNT; i++){
                timer.Start();
                test.Invoke(m1,m2);
                timer.Stop();
                results.Add(timer.prevFrameTicksInMilliseconds);
            }

            return averageResults(results);


        }

        public static float performExperimentActionMatrix(Action<FSharpBench.Numerics.Matrix4x4,FSharpBench.Numerics.Matrix4x4> test, FrameTimer timer){
            Console.WriteLine("F# : Performing Experiment with Inputs");
            var results = new List<float>();

            var m1 = new FSharpBench.Numerics.Matrix4x4(1.0f,0.0f,0.0f,0.0f,
                                        0.0f,1.0f,0.0f,0.0f,
                                        0.0f,0.0f,1.0f,0.0f,
                                        0.0f,0.0f,0.0f,1.0f);
            var m2 = new FSharpBench.Numerics.Matrix4x4(1.0f,0.0f,0.0f,0.0f,
                                        0.0f,1.0f,0.0f,0.0f,
                                        0.0f,0.0f,1.0f,0.0f,
                                        0.0f,0.0f,0.0f,1.0f);

            for(int i = 0; i < EXPERIMENT_COUNT; i++){
                timer.Start();
                test.Invoke(m1,m2);
                timer.Stop();
                results.Add(timer.prevFrameTicksInMilliseconds);
            }

            return averageResults(results);


        }

        private static float averageResults(IList<float> results){
            
            var acc = 0.0f;
            foreach (var result in results)
            {
                acc+=result;
            }
            return acc / results.Count;
        }

    }
    
}