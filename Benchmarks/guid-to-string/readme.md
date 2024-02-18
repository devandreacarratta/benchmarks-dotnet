```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL


```
| Method              | Mean     | Error    | StdDev   |
|-------------------- |---------:|---------:|---------:|
| MethodToString      | 16.98 ns | 0.366 ns | 0.392 ns |
| StringInterpolation | 45.48 ns | 0.277 ns | 0.259 ns |
| StringBuilderCheck  | 73.83 ns | 1.451 ns | 1.426 ns |
