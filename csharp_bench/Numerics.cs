using System;
using System.Numerics;

namespace CSharpBench
{
    public class Numerics
    {
        public static int Add(int a, int b){
            return a+b;
        }

        public static float Empty(Matrix4x4 m1, Matrix4x4 m2){
            return 0.0f;
        }

        public static Matrix4x4 StandardMult(Matrix4x4 m1, Matrix4x4 m2){
            return m1*m2;
        }

        public static float EuclidianDistance(Vertex3D v1, Vertex3D v2){
            return (float)Math.Sqrt(Math.Pow(v1.x - v2.x,2.0) + Math.Pow(v1.y - v2.y,2.0) + Math.Pow(v1.z - v2.z,2.0));
        }

        public static float EuclidianDistance(Vector3 v1, Vector3 v2){
            return Vector3.Distance(v1,v2);
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
