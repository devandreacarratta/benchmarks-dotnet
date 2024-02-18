```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL


```
| Method                    | Mean     | Error   | StdDev  |
|-------------------------- |---------:|--------:|--------:|
| NewtonsoftSerializeObject | 238.3 ns | 1.85 ns | 1.64 ns |
| JsonSerializerSerialize   | 145.8 ns | 2.94 ns | 3.27 ns |
