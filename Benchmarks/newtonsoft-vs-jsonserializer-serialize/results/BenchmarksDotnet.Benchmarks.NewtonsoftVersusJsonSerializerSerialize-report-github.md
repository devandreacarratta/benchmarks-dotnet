```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-SDPSHZ : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-OMERYI : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-KSFZVY : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2


```
| Method                    | Runtime  | Mean     | Error    | StdDev   | Median   | Rank | Gen0   | Allocated |
|-------------------------- |--------- |---------:|---------:|---------:|---------:|-----:|-------:|----------:|
| JsonSerializerSerialize   | .NET 9.0 | 212.6 ns |  4.00 ns |  4.11 ns | 211.5 ns |    1 | 0.0834 |     360 B |
| JsonSerializerSerialize   | .NET 8.0 | 243.9 ns |  3.59 ns |  2.99 ns | 242.7 ns |    2 | 0.0834 |     360 B |
| JsonSerializerSerialize   | .NET 6.0 | 289.2 ns |  2.96 ns |  2.31 ns | 289.2 ns |    3 | 0.1259 |     544 B |
| NewtonsoftSerializeObject | .NET 9.0 | 337.7 ns |  2.37 ns |  1.85 ns | 337.9 ns |    4 | 0.3300 |    1424 B |
| NewtonsoftSerializeObject | .NET 8.0 | 386.4 ns |  7.37 ns | 11.90 ns | 384.2 ns |    5 | 0.3300 |    1424 B |
| NewtonsoftSerializeObject | .NET 6.0 | 524.9 ns | 10.05 ns | 21.41 ns | 516.1 ns |    6 | 0.3300 |    1424 B |
