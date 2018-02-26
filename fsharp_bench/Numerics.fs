namespace FSharpBench

open System

module Numerics = 
    let add a b =
        a + b

    type Vertex3D =
        struct
            val x:float
            val y:float
            val z:float
            new(x,y,z) = { x = x; y = y; z = z}
        end

    let euclidianDistance (v1 : Vertex3D) (v2 : Vertex3D) =
        sqrt(Math.Pow(v1.x - v2.x,2.0) + Math.Pow(v1.y - v2.y,2.0) + Math.Pow(v1.z-v2.z,2.0))
    





