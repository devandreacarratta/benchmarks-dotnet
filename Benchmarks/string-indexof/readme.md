```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-BDSGSG : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-KBRTQP : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-CPIYAJ : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2


```
| Method          | Runtime  | Mean      | Error     | StdDev    | Median    | Rank | Allocated |
|---------------- |--------- |----------:|----------:|----------:|----------:|-----:|----------:|
| StartWithChar   | .NET 9.0 |  2.166 ns | 0.0297 ns | 0.0232 ns |  2.168 ns |    1 |         - |
| StartWithChar   | .NET 8.0 |  2.968 ns | 0.0371 ns | 0.0290 ns |  2.961 ns |    2 |         - |
| StartWithChar   | .NET 6.0 |  4.780 ns | 0.0846 ns | 0.0750 ns |  4.751 ns |    3 |         - |
| StartWithString | .NET 8.0 | 35.226 ns | 0.5351 ns | 0.4468 ns | 35.056 ns |    4 |         - |
| StartWithString | .NET 9.0 | 42.821 ns | 0.4093 ns | 0.3418 ns | 42.905 ns |    5 |         - |
| StartWithString | .NET 6.0 | 64.536 ns | 2.0933 ns | 5.9041 ns | 62.041 ns |    6 |         - |
