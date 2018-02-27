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

## Matrix4x4 (Structs)

Avg. Results (x100000000) | Matrix4x4 Alloc and Multiply 
--- | --- 
*C#* | 5245.6 ms
*F#* | 5259.2 ms

Avg. Results (x100000000) | Matrix4x4 Alloc
--- | --- 
*C#* | 1586 ms
*F#* | 1589 ms
