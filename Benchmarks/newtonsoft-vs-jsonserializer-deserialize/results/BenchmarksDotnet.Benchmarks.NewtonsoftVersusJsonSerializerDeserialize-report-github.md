```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-SDPSHZ : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-OMERYI : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-KSFZVY : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2


```
| Method                      | Runtime  | Mean     | Error    | StdDev   | Median   | Rank | Gen0    | Allocated |
|---------------------------- |--------- |---------:|---------:|---------:|---------:|-----:|--------:|----------:|
| JsonSerializerDeserialize   | .NET 9.0 | 24.81 μs | 0.431 μs | 0.382 μs | 24.71 μs |    1 |       - |      24 B |
| JsonSerializerDeserialize   | .NET 8.0 | 27.68 μs | 0.526 μs | 0.585 μs | 27.57 μs |    2 |       - |      24 B |
| JsonSerializerDeserialize   | .NET 6.0 | 40.68 μs | 0.229 μs | 0.191 μs | 40.61 μs |    3 |       - |      24 B |
| NewtonsoftDeserializeObject | .NET 9.0 | 73.30 μs | 1.440 μs | 2.365 μs | 72.18 μs |    4 | 12.0850 |   52152 B |
| NewtonsoftDeserializeObject | .NET 8.0 | 78.24 μs | 1.358 μs | 1.947 μs | 77.36 μs |    5 | 12.0850 |   52152 B |
| NewtonsoftDeserializeObject | .NET 6.0 | 99.97 μs | 1.791 μs | 1.495 μs | 99.43 μs |    6 | 12.0850 |   52154 B |
