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

        override protected void TestFSharpByRef(ref Matrix4x4 m1, ref Matrix4x4 m2){
        FSharpBench.Numerics.Matrix4x4 fm1 
                = new FSharpBench.Numerics.Matrix4x4(m1.M11,m1.M12,m1.M13,m1.M14,
                                                    m1.M21,m1.M22,m1.M23,m1.M24,
                                                    m1.M31,m1.M32,m1.M33,m1.M34,
                                                    m1.M41,m1.M42,m1.M43,m1.M44);
            FSharpBench.Numerics.Matrix4x4 fm2
                = new FSharpBench.Numerics.Matrix4x4(m2.M11,m2.M12,m2.M13,m2.M14,
                                                    m2.M21,m2.M22,m2.M23,m2.M24,
                                                    m2.M31,m2.M32,m2.M33,m2.M34,
                                                    m2.M41,m2.M42,m2.M43,m2.M44);
            var cshrp_res = FSharpBench.Numerics.matrixMultiply(fm1,fm2);
        }

        override protected void TestFSharp(FSharpBench.Numerics.Matrix4x4 m1, FSharpBench.Numerics.Matrix4x4 m2){
            var fshrp_res = FSharpBench.Numerics.matrixMultiply(m1,m2);
        }

        override protected void TestFSharpFSharpTypesByRef(ref FSharpBench.Numerics.Matrix4x4 m1, ref FSharpBench.Numerics.Matrix4x4 m2){
            var fshrp_res = FSharpBench.Numerics.matrixMultiply(m1,m2);
        }

    }
    
}