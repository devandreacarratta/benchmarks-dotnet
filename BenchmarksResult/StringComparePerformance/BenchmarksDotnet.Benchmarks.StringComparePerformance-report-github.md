```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-XQDGVE : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-IXLBGF : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT AVX2


```
| Method        | Runtime  | IgnoreCaseItem | FirstItem   | SecondItem  | Mean       | Error     | StdDev    | Median     | Rank | Allocated |
|-------------- |--------- |--------------- |------------ |------------ |-----------:|----------:|----------:|-----------:|-----:|----------:|
| StringCompare | .NET 8.0 | True           | Hello World | Hello World |   1.311 ns | 0.0103 ns | 0.0091 ns |   1.314 ns |    1 |         - |
| StringCompare | .NET 8.0 | False          | Hello World | Hello World |   1.315 ns | 0.0074 ns | 0.0065 ns |   1.314 ns |    1 |         - |
| StringCompare | .NET 6.0 | True           | Hello World | Hello World |   2.232 ns | 0.0168 ns | 0.0157 ns |   2.232 ns |    2 |         - |
| StringCompare | .NET 6.0 | False          | Hello World | Hello World |   2.238 ns | 0.0208 ns | 0.0184 ns |   2.236 ns |    2 |         - |
| StringCompare | .NET 8.0 | True           | hello world | Hello World | 133.000 ns | 0.6663 ns | 0.5906 ns | 133.015 ns |    3 |         - |
| StringCompare | .NET 8.0 | True           | Hello World | HELLO WORLD | 135.633 ns | 0.9102 ns | 0.7600 ns | 135.512 ns |    4 |         - |
| StringCompare | .NET 8.0 | True           | hello world | HELLO WORLD | 137.870 ns | 1.8130 ns | 1.6072 ns | 137.376 ns |    4 |         - |
| StringCompare | .NET 8.0 | False          | hello world | HELLO WORLD | 142.356 ns | 2.8789 ns | 3.4271 ns | 140.640 ns |    5 |         - |
| StringCompare | .NET 8.0 | False          | Hello World | HELLO WORLD | 143.206 ns | 1.4643 ns | 1.1432 ns | 142.808 ns |    5 |         - |
| StringCompare | .NET 8.0 | False          | hello world | Hello World | 145.237 ns | 2.4010 ns | 2.0049 ns | 144.418 ns |    5 |         - |
| StringCompare | .NET 6.0 | True           | Hello World | HELLO WORLD | 147.235 ns | 0.4890 ns | 0.4084 ns | 147.229 ns |    5 |         - |
| StringCompare | .NET 6.0 | True           | hello world | Hello World | 148.647 ns | 1.3111 ns | 1.1623 ns | 148.558 ns |    5 |         - |
| StringCompare | .NET 6.0 | True           | hello world | HELLO WORLD | 148.677 ns | 2.9455 ns | 4.5858 ns | 145.924 ns |    5 |         - |
| StringCompare | .NET 6.0 | False          | hello world | Hello World | 151.226 ns | 0.6266 ns | 0.5555 ns | 151.164 ns |    6 |         - |
| StringCompare | .NET 6.0 | False          | hello world | HELLO WORLD | 151.363 ns | 1.1532 ns | 0.9003 ns | 151.138 ns |    6 |         - |
| StringCompare | .NET 6.0 | False          | Hello World | HELLO WORLD | 152.995 ns | 0.6728 ns | 0.5964 ns | 152.937 ns |    6 |         - |
