```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-GKDXUS : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
  Job-OHKURJ : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-ZXQFGE : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL

InvocationCount=1  UnrollFactor=1  

```
| Method                   | Runtime  | ItemsToAdd | Mean        | Error     | StdDev    | Median     | Rank | Allocated |
|------------------------- |--------- |----------- |------------:|----------:|----------:|-----------:|-----:|----------:|
| ListCountGreaterThanZero | .NET 6.0 | 1000       |    75.53 ns |  22.22 ns |  63.39 ns |   100.0 ns |    1 |     640 B |
| ListCountGreaterThanZero | .NET 8.0 | 10000      |    93.18 ns |  40.38 ns | 111.21 ns |   100.0 ns |    1 |     400 B |
| ListCountGreaterThanZero | .NET 8.0 | 1000       |   105.26 ns |  33.09 ns |  94.95 ns |   100.0 ns |    1 |     400 B |
| ListCountGreaterThanZero | .NET 6.0 | 10000      |   107.69 ns |  31.10 ns |  87.22 ns |   100.0 ns |    1 |     640 B |
| ListAny                  | .NET 9.0 | 1000       |   108.33 ns |  37.18 ns | 107.28 ns |   100.0 ns |    1 |     112 B |
| ListCountGreaterThanZero | .NET 9.0 | 1000       |   121.74 ns |  40.31 ns | 113.70 ns |   100.0 ns |    1 |     400 B |
| ListCountGreaterThanZero | .NET 9.0 | 10000      |   156.67 ns |  63.41 ns | 176.77 ns |   100.0 ns |    1 |     400 B |
| ListAny                  | .NET 6.0 | 10000      |   197.78 ns |  40.59 ns | 113.15 ns |   200.0 ns |    2 |     640 B |
| ListAny                  | .NET 8.0 | 1000       |   264.13 ns |  35.87 ns | 101.18 ns |   200.0 ns |    3 |     400 B |
| ListAny                  | .NET 6.0 | 1000       |   273.33 ns |  31.26 ns |  87.15 ns |   300.0 ns |    3 |     640 B |
| ListAny                  | .NET 8.0 | 10000      |   320.69 ns |  74.98 ns | 205.24 ns |   300.0 ns |    3 |     112 B |
| ListAny                  | .NET 9.0 | 10000      |   498.94 ns | 131.80 ns | 376.03 ns |   400.0 ns |    4 |     112 B |
| ListCountGreaterThanZero | .NET 6.0 | 100000     |   573.96 ns | 161.18 ns | 465.04 ns |   400.0 ns |    4 |     640 B |
| ListCountGreaterThanZero | .NET 9.0 | 100000     |   995.79 ns | 203.03 ns | 582.53 ns | 1,000.0 ns |    5 |     400 B |
| ListAny                  | .NET 6.0 | 100000     | 1,126.26 ns | 243.72 ns | 714.80 ns |   900.0 ns |    5 |     640 B |
| ListCountGreaterThanZero | .NET 8.0 | 100000     | 1,347.87 ns | 223.03 ns | 636.31 ns | 1,300.0 ns |    6 |     400 B |
| ListAny                  | .NET 9.0 | 100000     | 1,744.09 ns | 289.49 ns | 821.25 ns | 1,600.0 ns |    7 |     112 B |
| ListAny                  | .NET 8.0 | 100000     | 2,379.17 ns | 343.47 ns | 991.00 ns | 2,350.0 ns |    8 |     400 B |