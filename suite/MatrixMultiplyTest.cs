using System.Numerics;


namespace Benchmark
{

    public class MatrixMultiplyTest : Test
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
            var cshrp_res = M1*M2;
            

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
            var fshrp_res = FSharpBench.Numerics.matrixMultiply(m1,m2);
            

        }

    }
    
}