```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-PXLHCR : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-SLYGXL : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-ZLKGYE : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2


```
| Method        | Runtime  | IgnoreCaseItem | FirstItem   | SecondItem  | Mean       | Error     | StdDev    | Median     | Rank | Allocated |
|-------------- |--------- |--------------- |------------ |------------ |-----------:|----------:|----------:|-----------:|-----:|----------:|
| StringCompare | .NET 8.0 | False          | Hello World | Hello World |   1.361 ns | 0.0273 ns | 0.0242 ns |   1.355 ns |    1 |         - |
| StringCompare | .NET 8.0 | True           | Hello World | Hello World |   1.374 ns | 0.0590 ns | 0.0606 ns |   1.342 ns |    1 |         - |
| StringCompare | .NET 9.0 | False          | Hello World | Hello World |   1.675 ns | 0.0664 ns | 0.0589 ns |   1.649 ns |    2 |         - |
| StringCompare | .NET 9.0 | True           | Hello World | Hello World |   1.678 ns | 0.0630 ns | 0.0700 ns |   1.645 ns |    2 |         - |
| StringCompare | .NET 6.0 | False          | Hello World | Hello World |   2.671 ns | 0.0324 ns | 0.0271 ns |   2.674 ns |    3 |         - |
| StringCompare | .NET 6.0 | True           | Hello World | Hello World |   2.676 ns | 0.0581 ns | 0.0485 ns |   2.675 ns |    3 |         - |
| StringCompare | .NET 8.0 | True           | hello world | Hello World | 135.557 ns | 1.0547 ns | 0.8807 ns | 135.576 ns |    4 |         - |
| StringCompare | .NET 9.0 | True           | Hello World | HELLO WORLD | 135.662 ns | 1.9679 ns | 1.6433 ns | 135.041 ns |    4 |         - |
| StringCompare | .NET 9.0 | True           | hello world | HELLO WORLD | 135.952 ns | 2.6692 ns | 2.7410 ns | 135.097 ns |    4 |         - |
| StringCompare | .NET 8.0 | True           | hello world | HELLO WORLD | 137.455 ns | 2.7395 ns | 2.5625 ns | 135.958 ns |    4 |         - |
| StringCompare | .NET 9.0 | True           | hello world | Hello World | 140.781 ns | 2.8470 ns | 8.1226 ns | 136.204 ns |    4 |         - |
| StringCompare | .NET 8.0 | True           | Hello World | HELLO WORLD | 140.862 ns | 2.8186 ns | 3.1329 ns | 139.822 ns |    4 |         - |
| StringCompare | .NET 8.0 | False          | hello world | HELLO WORLD | 142.483 ns | 1.1232 ns | 0.8769 ns | 142.240 ns |    4 |         - |
| StringCompare | .NET 9.0 | False          | hello world | Hello World | 143.441 ns | 2.8262 ns | 2.9023 ns | 141.733 ns |    4 |         - |
| StringCompare | .NET 9.0 | False          | Hello World | HELLO WORLD | 143.668 ns | 2.7184 ns | 4.4663 ns | 141.946 ns |    4 |         - |
| StringCompare | .NET 8.0 | False          | hello world | Hello World | 144.251 ns | 2.8881 ns | 3.4380 ns | 143.192 ns |    4 |         - |
| StringCompare | .NET 9.0 | False          | hello world | HELLO WORLD | 146.844 ns | 2.9869 ns | 7.6566 ns | 143.028 ns |    4 |         - |
| StringCompare | .NET 6.0 | True           | hello world | Hello World | 147.869 ns | 1.9341 ns | 3.0112 ns | 146.759 ns |    4 |         - |
| StringCompare | .NET 8.0 | False          | Hello World | HELLO WORLD | 148.142 ns | 2.9882 ns | 5.0742 ns | 145.884 ns |    4 |         - |
| StringCompare | .NET 6.0 | True           | hello world | HELLO WORLD | 151.290 ns | 2.8764 ns | 2.4019 ns | 150.622 ns |    4 |         - |
| StringCompare | .NET 6.0 | False          | hello world | Hello World | 151.850 ns | 2.4007 ns | 2.0047 ns | 151.000 ns |    4 |         - |
| StringCompare | .NET 6.0 | True           | Hello World | HELLO WORLD | 155.423 ns | 2.5477 ns | 2.5022 ns | 155.370 ns |    4 |         - |
| StringCompare | .NET 6.0 | False          | hello world | HELLO WORLD | 158.009 ns | 2.5943 ns | 2.2998 ns | 157.320 ns |    4 |         - |
| StringCompare | .NET 6.0 | False          | Hello World | HELLO WORLD | 160.209 ns | 3.1915 ns | 5.5052 ns | 157.478 ns |    4 |         - |
