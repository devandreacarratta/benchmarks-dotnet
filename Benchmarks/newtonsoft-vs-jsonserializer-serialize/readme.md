```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-XQDGVE : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-IXLBGF : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT AVX2


```
| Method                    | Runtime  | Mean     | Error   | StdDev  | Rank | Gen0   | Allocated |
|-------------------------- |--------- |---------:|--------:|--------:|-----:|-------:|----------:|
| JsonSerializerSerialize   | .NET 8.0 | 236.0 ns | 1.70 ns | 1.51 ns |    1 | 0.0834 |     360 B |
| JsonSerializerSerialize   | .NET 6.0 | 294.0 ns | 1.65 ns | 1.54 ns |    2 | 0.1259 |     544 B |
| NewtonsoftSerializeObject | .NET 8.0 | 377.3 ns | 2.33 ns | 1.95 ns |    3 | 0.3300 |    1424 B |
| NewtonsoftSerializeObject | .NET 6.0 | 510.7 ns | 3.43 ns | 2.87 ns |    4 | 0.3300 |    1424 B |
