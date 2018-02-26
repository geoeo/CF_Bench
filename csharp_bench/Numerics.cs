using System;

namespace CSharpBench
{
    public class Numerics
    {
        public static int Add(int a, int b){
            return a+b;
        }

        public static float EuclidianDistance(Vertex3D v1, Vertex3D v2){
            return (float)Math.Sqrt(Math.Pow(v1.x - v2.x,2.0) + Math.Pow(v1.y - v2.y,2.0) + Math.Pow(v1.z - v2.z,2.0));
        }

        public struct Vertex3D{

            public readonly float x;
            public readonly  float y;
            public readonly  float z;

            public Vertex3D(float x,float y,float z){
                this.x = x;
                this.y = y;
                this.z = z;
            }

        }


    }
}
