using System.Numerics;

namespace Benchmark
{

    public class EuclidianDistanceTest : Test
    {


        override protected void TestCSharp(){

            float cshrp_res = 0;

            CSharpBench.Numerics.Vertex3D v1 = new CSharpBench.Numerics.Vertex3D(1.0f,2.0f,3.0f);
            CSharpBench.Numerics.Vertex3D v2 = new CSharpBench.Numerics.Vertex3D(1.0f,3.0f,3.0f);
            cshrp_res = CSharpBench.Numerics.EuclidianDistance(v1,v2);
            

        }

        override protected void TestFSharp(){

            float fshrp_res = 0;
            FSharpBench.Numerics.Vertex3D v1 = new FSharpBench.Numerics.Vertex3D(1.0f,2.0f,3.0f);
            FSharpBench.Numerics.Vertex3D v2 = new FSharpBench.Numerics.Vertex3D(1.0f,3.0f,3.0f);
            fshrp_res = (float)FSharpBench.Numerics.euclidianDistance(v1,v2);
            

        }

        override protected void TestCSharp(Vector3 v1, Vector3 v2){

            var cshrp_res = CSharpBench.Numerics.EuclidianDistance(v1,v2);
        }

        override protected void TestFSharp(Vector3 v1, Vector3 v2){

            var fshrp_res = FSharpBench.Numerics.standardEuclidianDistance(v1,v2);
            

        }

    }
    
}