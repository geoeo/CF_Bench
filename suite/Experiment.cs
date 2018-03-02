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
            Console.WriteLine("Performing Experiment with Inputs Matrix4x4");
            var results = new List<float>();

            Matrix4x4 m1 = new Matrix4x4(1.0f,0.0f,0.0f,0.0f,
                                        0.0f,1.0f,0.0f,0.0f,
                                        0.0f,0.0f,1.0f,0.0f,
                                        0.0f,0.0f,0.0f,1.0f);
            Matrix4x4 m2 = new Matrix4x4(1.0f,0.0f,0.0f,0.0f,
                                        0.0f,1.0f,0.0f,0.0f,
                                        0.0f,0.0f,1.0f,0.0f,
                                        0.0f,0.0f,0.0f,1.0f);

            var sw = new System.Diagnostics.Stopwatch();

            for(int i = 0; i < EXPERIMENT_COUNT; i++){
                timer.Start();
                // sw.Start();
                test.Invoke(m1,m2);
                timer.Stop();
                // sw.Stop();
                results.Add(timer.prevFrameTicksInMilliseconds);
                // results.Add(sw.ElapsedMilliseconds);
                // sw.Reset();
            }

            return averageResults(results);


        }

        public static float performExperimentActionMatrixbyRef(MatrixMultiplyTest test, FrameTimer timer){
            Console.WriteLine("Performing Experiment with Inputs Matrix4x4");
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
                test.RunFSharpTestsByRef(ref m1,ref m2);
                timer.Stop();
                results.Add(timer.prevFrameTicksInMilliseconds);
            }

            return averageResults(results);


        }

        public static float performExperimentActionMatrixFSharpTypesbyRef(MatrixMultiplyTest test, FrameTimer timer){
            Console.WriteLine("Performing Experiment with Inputs FSharpBench.Numerics.Matrix4x4 By Ref");
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
                test.RunFSharpTestsFSharpTypesByRef(ref m1,ref m2);
                timer.Stop();
                results.Add(timer.prevFrameTicksInMilliseconds);
            }

            return averageResults(results);


        }

        public static float performExperimentActionMatrix(Action<FSharpBench.Numerics.Matrix4x4,FSharpBench.Numerics.Matrix4x4> test, FrameTimer timer){
            Console.WriteLine("Performing Experiment with Inputs FSharpBench.Numerics.Matrix4x4");
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