# CF_Bench
Comparisons Between F# and C#


    for(int i = 0; i < RUN_AMOUNT; i++)
        Test{C|F}Sharp();

# Results


## 3D Vertecies (Structs)

            
Avg. Results (x100000000) | Euclidian Distance 
--- | --- 
*C#* | 4114.1 ms
*F#* | 4052.9 ms

## System.Numerics.Vector3 

Avg. Results (x100000000) | Euclidian Distance 
--- | --- 
*C#* | 3395.6 ms
*F#* | 2820.6 ms

## Matrix4x4 (Structs)

Avg. Results (x100000000) | Pass Matrix4x4 into function
--- | --- 
*C#* | 844 ms
*F#* | 844.3 ms

Avg. Results (x100000000) | Matrix4x4 Alloc
--- | --- 
*C#* | 1581.2 ms
*F#* | 1579.2 ms

Avg. Results (x100000000) | Matrix4x4 Alloc and Multiply 
--- | --- 
*C#* | 5245.6 ms
*F#* | 5259.2 ms

Avg. Results (x100000000) | Matrix4x4 Multiply - Matrix passed by value into method (C# and F#)
--- | --- 
*C#* | 4843.4 ms
*F#* | 4145.3 ms 

