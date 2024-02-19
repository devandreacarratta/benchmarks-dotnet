```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-XQDGVE : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-IXLBGF : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT AVX2


```
| Method                      | Runtime  | Mean     | Error    | StdDev   | Rank | Gen0    | Allocated |
|---------------------------- |--------- |---------:|---------:|---------:|-----:|--------:|----------:|
| JsonSerializerDeserialize   | .NET 8.0 | 26.53 μs | 0.061 μs | 0.048 μs |    1 |       - |      48 B |
| JsonSerializerDeserialize   | .NET 6.0 | 40.72 μs | 0.196 μs | 0.183 μs |    2 |       - |      48 B |
| NewtonsoftDeserializeObject | .NET 8.0 | 77.01 μs | 0.320 μs | 0.299 μs |    3 | 12.0850 |   52176 B |
| NewtonsoftDeserializeObject | .NET 6.0 | 96.88 μs | 1.747 μs | 1.549 μs |    4 | 12.0850 |   52176 B |
