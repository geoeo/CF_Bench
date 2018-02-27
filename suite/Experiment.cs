using System;
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