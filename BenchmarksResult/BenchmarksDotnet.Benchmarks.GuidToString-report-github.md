```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-XQDGVE : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-IXLBGF : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT AVX2


```
| Method              | Runtime  | Mean      | Error    | StdDev   | Rank | Gen0   | Allocated |
|-------------------- |--------- |----------:|---------:|---------:|-----:|-------:|----------:|
| MethodToString      | .NET 8.0 |  17.84 ns | 0.300 ns | 0.280 ns |    1 | 0.0222 |      96 B |
| MethodToString      | .NET 6.0 |  36.73 ns | 0.324 ns | 0.287 ns |    2 | 0.0222 |      96 B |
| StringInterpolation | .NET 8.0 |  45.94 ns | 0.354 ns | 0.314 ns |    3 | 0.0222 |      96 B |
| StringBuilderCheck  | .NET 8.0 |  77.65 ns | 0.387 ns | 0.323 ns |    4 | 0.1019 |     440 B |
| StringInterpolation | .NET 6.0 |  78.95 ns | 0.290 ns | 0.242 ns |    5 | 0.0222 |      96 B |
| StringBuilderCheck  | .NET 6.0 | 111.45 ns | 2.007 ns | 1.676 ns |    6 | 0.1019 |     440 B |
