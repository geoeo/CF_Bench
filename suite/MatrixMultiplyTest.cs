using System.Numerics;


namespace Benchmark
{

    public class MatrixMultiplyTest : Test
    {


        override protected void TestCSharp(){

            Matrix4x4 m1 = new Matrix4x4(1.0f,0.0f,0.0f,0.0f,
                                        0.0f,1.0f,0.0f,0.0f,
                                        0.0f,0.0f,1.0f,0.0f,
                                        0.0f,0.0f,0.0f,1.0f);
            Matrix4x4 m2 = new Matrix4x4(1.0f,0.0f,0.0f,0.0f,
                                        0.0f,1.0f,0.0f,0.0f,
                                        0.0f,0.0f,1.0f,0.0f,
                                        0.0f,0.0f,0.0f,1.0f);
            var cshrp_res = m1*m2;
            

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

        override protected void TestCSharp(Matrix4x4 m1, Matrix4x4 m2){
            var cshrp_res = m1*m2;
        }

        override protected void TestFSharp(FSharpBench.Numerics.Matrix4x4 m1, FSharpBench.Numerics.Matrix4x4 m2){
            var fshrp_res = FSharpBench.Numerics.matrixMultiply(m1,m2);
        }

    }
    
}