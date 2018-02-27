using System.Numerics;


namespace Benchmark
{

    public class MatrixAllocTest : Test
    {


        override protected void TestCSharp(){

            Matrix4x4 M1 = new Matrix4x4(1.0f,0.0f,0.0f,0.0f,
                                        0.0f,1.0f,0.0f,0.0f,
                                        0.0f,0.0f,1.0f,0.0f,
                                        0.0f,0.0f,0.0f,1.0f);
            Matrix4x4 M2 = new Matrix4x4(1.0f,0.0f,0.0f,0.0f,
                                        0.0f,1.0f,0.0f,0.0f,
                                        0.0f,0.0f,1.0f,0.0f,
                                        0.0f,0.0f,0.0f,1.0f);
            

        }

        override protected void TestFSharp(){

            FSharpBench.Numerics.Matrix4x4 m1 
                = new FSharpBench.Numerics.Matrix4x4(1.0f,0.0f,0.0f,0.0f,
                                                    0.0f,1.0f,0.0f,0.0f,
                                                    0.0f,0.0f,1.0f,0.0f,
                                                    0.0f,0.0f,0.0f,1.0f);
            FSharpBench.Numerics.Matrix4x4 m2
                = new FSharpBench.Numerics.Matrix4x4(1.0f,0.0f,0.0f,0.0f,
                                                    0.0f,1.0f,0.0f,0.0f,
                                                    0.0f,0.0f,1.0f,0.0f,
                                                    0.0f,0.0f,0.0f,1.0f);
            

        }

    }
    
}