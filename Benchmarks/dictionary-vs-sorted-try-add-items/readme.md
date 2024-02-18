```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL [AttachedDebugger]
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL


```
| Method                | ItemsToAdd | Mean           | Error         | StdDev        |
|---------------------- |----------- |---------------:|--------------:|--------------:|
| **AddToDictionary**       | **1**          |       **5.437 ns** |     **0.0231 ns** |     **0.0205 ns** |
| AddToSortedDictionary | 1          |       3.084 ns |     0.0127 ns |     0.0113 ns |
| **AddToDictionary**       | **10**         |      **53.931 ns** |     **1.1080 ns** |     **1.2316 ns** |
| AddToSortedDictionary | 10         |      88.309 ns |     0.3743 ns |     0.3126 ns |
| **AddToDictionary**       | **100**        |     **545.715 ns** |     **5.4204 ns** |     **5.0703 ns** |
| AddToSortedDictionary | 100        |   1,771.124 ns |    17.3197 ns |    15.3535 ns |
| **AddToDictionary**       | **1000**       |   **5,519.717 ns** |    **32.5981 ns** |    **28.8974 ns** |
| AddToSortedDictionary | 1000       |  50,140.028 ns |   148.1125 ns |   138.5445 ns |
| **AddToDictionary**       | **10000**      |  **50,985.554 ns** |   **145.8878 ns** |   **136.4635 ns** |
| AddToSortedDictionary | 10000      | 574,932.392 ns | 2,241.3650 ns | 1,871.6413 ns |
