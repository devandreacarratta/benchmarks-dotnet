```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-BDSGSG : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-KBRTQP : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-CPIYAJ : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2


```
| Method        | Runtime  | Mean      | Error     | StdDev    | Rank | Allocated |
|-------------- |--------- |----------:|----------:|----------:|-----:|----------:|
| ContainChar   | .NET 9.0 |  1.911 ns | 0.0698 ns | 0.0776 ns |    1 |         - |
| ContainChar   | .NET 8.0 |  2.442 ns | 0.0147 ns | 0.0115 ns |    2 |         - |
| ContainString | .NET 9.0 |  5.117 ns | 0.0579 ns | 0.0484 ns |    3 |         - |
| ContainChar   | .NET 6.0 |  5.140 ns | 0.1318 ns | 0.1294 ns |    3 |         - |
| ContainString | .NET 8.0 |  6.733 ns | 0.0466 ns | 0.0389 ns |    4 |         - |
| ContainString | .NET 6.0 | 10.263 ns | 0.1437 ns | 0.1411 ns |    5 |         - |
