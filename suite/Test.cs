using System.Numerics;

namespace Benchmark
{
    public abstract class Test
    {
        protected const int RUN_AMOUNT = 100000000;


        public void RunCSharpTests(){

            for(int i = 0; i < RUN_AMOUNT; i++)
                TestCSharp();
            
        }

        public void RunFSharpTests(){

            for(int i = 0; i < RUN_AMOUNT; i++)
                TestFSharp();
            
        }

        public void RunCSharpTests(Matrix4x4 m1, Matrix4x4 m2){

            for(int i = 0; i < RUN_AMOUNT; i++)
                TestCSharp(m1,m2);
            
        }

        public void RunFSharpTests(FSharpBench.Numerics.Matrix4x4 m1 ,FSharpBench.Numerics.Matrix4x4 m2){

            for(int i = 0; i < RUN_AMOUNT; i++)
                TestFSharp(m1,m2);
            
        }

        protected abstract void TestCSharp();
        protected abstract void TestFSharp();

        protected virtual void TestCSharp(Matrix4x4 m1, Matrix4x4 m2){}
        protected virtual void TestFSharp(FSharpBench.Numerics.Matrix4x4 m1, FSharpBench.Numerics.Matrix4x4 m2){}

    }
    
}