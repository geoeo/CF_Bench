# CF_Bench
Comparisons Between F# and C#

# Results


## 3D Vertecies (Structs)

    for(int i = 0; i < RUN_AMOUNT; i++){
                var v1 = new {CSharpBench|FSharpBench}.Numerics.Vertex3D(1.0f,2.0f,3.0f);
                var v2 = new {CSharpBench|FSharpBench}.Numerics.Vertex3D(1.0f,3.0f,3.0f);
                var res = {CSharpBench|FSharpBench}.Numerics.EuclidianDistance(v1,v2);
            } 
            
Results (x100000000) | Euclidian Distance 
--- | --- 
*C#* | 3045 ms
*F#* | 2957 ms
