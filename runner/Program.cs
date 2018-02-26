using System;
using System.Timers;
using System.Threading;
using CSharpBench;
using FSharpBench;

namespace runner
{
    class Program
    {
        private const int RUN_AMOUNT = 100000000;
        static void Main(string[] args)
        {
            var timer = new FrameTimer(1.0);
            // int a = 1;
            // int b = 2;

            // timer.Start();
            // for(int i = 0; i < RUN_AMOUNT; i++){
            //     int res = CSharpBench.Numerics.Add(a,b);
            // }
            // timer.Stop();
            // Console.WriteLine($"C#: {timer.prevFrameTicksInMilliseconds} ms");

            // timer.Start();
            // for(int i = 0; i < RUN_AMOUNT; i++){
            //     int res = FSharpBench.Numerics.add(a, b);
            // }
            // timer.Stop();
            // Console.WriteLine($"F#: {timer.prevFrameTicksInMilliseconds} ms");

            timer.Start();
            float cshrp_res = 0;
            for(int i = 0; i < RUN_AMOUNT; i++){
                CSharpBench.Numerics.Vertex3D v1 = new CSharpBench.Numerics.Vertex3D(1.0f,2.0f,3.0f);
                CSharpBench.Numerics.Vertex3D v2 = new CSharpBench.Numerics.Vertex3D(1.0f,3.0f,3.0f);
                cshrp_res = CSharpBench.Numerics.EuclidianDistance(v1,v2);
            }
            timer.Stop();
            Console.WriteLine($"C#: {timer.prevFrameTicksInMilliseconds} ms");
            Console.WriteLine($"Result - C#: {cshrp_res}");

            timer.Start();
            float fshrp_res = 0;
            for(int i = 0; i < RUN_AMOUNT; i++){
                FSharpBench.Numerics.Vertex3D v1 = new FSharpBench.Numerics.Vertex3D(1.0f,2.0f,3.0f);
                FSharpBench.Numerics.Vertex3D v2 = new FSharpBench.Numerics.Vertex3D(1.0f,3.0f,3.0f);
                fshrp_res = (float)FSharpBench.Numerics.euclidianDistance(v1,v2);
            }
            timer.Stop();
            Console.WriteLine($"F#: {timer.prevFrameTicksInMilliseconds} ms");
            Console.WriteLine($"Result - F#: {fshrp_res}");
            
        }
    }
}