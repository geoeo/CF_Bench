namespace FSharpBench

open System

module Numerics = 
    let add a b =
        a + b

    // struct makes a big difference in performance
    type Vertex3D =
        struct
            val x:float
            val y:float
            val z:float
            new(x,y,z) = { x = x; y = y; z = z}
        end
    type Matrix4x4 = 
        struct
            val M11:float
            val M12:float
            val M13:float
            val M14:float
            val M21:float
            val M22:float
            val M23:float
            val M24:float
            val M31:float
            val M32:float
            val M33:float
            val M34:float
            val M41:float
            val M42:float
            val M43:float
            val M44:float

            new(m11,m12,m13,m14,
                m21,m22,m23,m24,
                m31,m32,m33,m34,
                m41,m42,m43,m44) = {
                    M11 = m11; M12 = m12; M13 = m13; M14 = m14;
                    M21 = m21; M22 = m22; M23 = m23; M24 = m24;
                    M31 = m31; M32 = m32; M33 = m33; M34 = m34;
                    M41 = m41; M42 = m42; M43 = m43; M44 = m44;
                }
        end
            

    let euclidianDistance (v1 : Vertex3D) (v2 : Vertex3D) =
        sqrt(Math.Pow(v1.x - v2.x,2.0) + Math.Pow(v1.y - v2.y,2.0) + Math.Pow(v1.z-v2.z,2.0))

    // https://github.com/dotnet/corefx/blob/221950b31c1057b040670936519ddbc13f893062/src/System.Numerics.Vectors/src/System/Numerics/Matrix4x4.cs#L118
    let matrixMultiply (m1 :Matrix4x4) (m2 : Matrix4x4) = 
        new Matrix4x4(
            // First row
            m1.M11 * m2.M11 + m1.M12 * m2.M21 + m1.M13 * m2.M31 + m1.M14 * m2.M41,
            m1.M11 * m2.M12 + m1.M12 * m2.M22 + m1.M13 * m2.M32 + m1.M14 * m2.M42,
            m1.M11 * m2.M13 + m1.M12 * m2.M23 + m1.M13 * m2.M33 + m1.M14 * m2.M43,
            m1.M11 * m2.M14 + m1.M12 * m2.M24 + m1.M13 * m2.M34 + m1.M14 * m2.M44,

            // Second row
            m1.M21 * m2.M11 + m1.M22 * m2.M21 + m1.M23 * m2.M31 + m1.M24 * m2.M41,
            m1.M21 * m2.M12 + m1.M22 * m2.M22 + m1.M23 * m2.M32 + m1.M24 * m2.M42,
            m1.M21 * m2.M13 + m1.M22 * m2.M23 + m1.M23 * m2.M33 + m1.M24 * m2.M43,
            m1.M21 * m2.M14 + m1.M22 * m2.M24 + m1.M23 * m2.M34 + m1.M24 * m2.M44,

            // Third row
            m1.M31 * m2.M11 + m1.M32 * m2.M21 + m1.M33 * m2.M31 + m1.M34 * m2.M41,
            m1.M31 * m2.M12 + m1.M32 * m2.M22 + m1.M33 * m2.M32 + m1.M34 * m2.M42,
            m1.M31 * m2.M13 + m1.M32 * m2.M23 + m1.M33 * m2.M33 + m1.M34 * m2.M43,
            m1.M31 * m2.M14 + m1.M32 * m2.M24 + m1.M33 * m2.M34 + m1.M34 * m2.M44,

            // Fourth row
            m1.M41 * m2.M11 + m1.M42 * m2.M21 + m1.M43 * m2.M31 + m1.M44 * m2.M41,
            m1.M41 * m2.M12 + m1.M42 * m2.M22 + m1.M43 * m2.M32 + m1.M44 * m2.M42,
            m1.M41 * m2.M13 + m1.M42 * m2.M23 + m1.M43 * m2.M33 + m1.M44 * m2.M43,
            m1.M41 * m2.M14 + m1.M42 * m2.M24 + m1.M43 * m2.M34 + m1.M44 * m2.M44
        )

    

 





