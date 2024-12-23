```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-SDPSHZ : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-OMERYI : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-KSFZVY : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2


```
| Method              | Runtime  | Mean      | Error    | StdDev   | Rank | Gen0   | Allocated |
|-------------------- |--------- |----------:|---------:|---------:|-----:|-------:|----------:|
| MethodToString      | .NET 9.0 |  17.28 ns | 0.184 ns | 0.143 ns |    1 | 0.0222 |      96 B |
| MethodToString      | .NET 8.0 |  18.49 ns | 0.342 ns | 0.433 ns |    2 | 0.0222 |      96 B |
| MethodToString      | .NET 6.0 |  36.64 ns | 0.144 ns | 0.120 ns |    3 | 0.0222 |      96 B |
| StringInterpolation | .NET 9.0 |  37.40 ns | 0.331 ns | 0.258 ns |    3 | 0.0222 |      96 B |
| StringInterpolation | .NET 8.0 |  48.98 ns | 0.846 ns | 0.792 ns |    4 | 0.0222 |      96 B |
| StringInterpolation | .NET 6.0 |  66.70 ns | 1.310 ns | 1.657 ns |    5 | 0.0222 |      96 B |
| StringBuilderCheck  | .NET 9.0 |  77.01 ns | 1.535 ns | 1.706 ns |    6 | 0.1019 |     440 B |
| StringBuilderCheck  | .NET 8.0 |  77.36 ns | 1.520 ns | 1.627 ns |    6 | 0.1019 |     440 B |
| StringBuilderCheck  | .NET 6.0 | 107.42 ns | 0.916 ns | 0.765 ns |    7 | 0.1019 |     440 B |
