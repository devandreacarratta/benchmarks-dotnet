```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-QTMWMW : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT AVX2
  Job-GWBGSO : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL

InvocationCount=1  UnrollFactor=1  

```
| Method                | Runtime  | ItemsToAdd | Mean         | Error       | StdDev      | Median       | Rank | Allocated |
|---------------------- |--------- |----------- |-------------:|------------:|------------:|-------------:|-----:|----------:|
| AddToDictionary       | .NET 6.0 | 10         |     2.035 μs |   0.0833 μs |   0.2335 μs |     2.000 μs |    1 |   1.21 KB |
| AddToSortedDictionary | .NET 6.0 | 10         |     2.431 μs |   0.0524 μs |   0.1035 μs |     2.400 μs |    2 |      1 KB |
| AddToDictionary       | .NET 8.0 | 10         |     3.150 μs |   0.1124 μs |   0.3059 μs |     3.100 μs |    3 |   1.07 KB |
| AddToDictionary       | .NET 6.0 | 100        |     3.156 μs |   0.0664 μs |   0.1678 μs |     3.100 μs |    3 |   7.67 KB |
| AddToDictionary       | .NET 8.0 | 100        |     4.618 μs |   0.0950 μs |   0.1362 μs |     4.600 μs |    4 |   7.53 KB |
| AddToSortedDictionary | .NET 8.0 | 10         |     5.042 μs |   0.0996 μs |   0.1966 μs |     5.000 μs |    5 |   1.09 KB |
| AddToSortedDictionary | .NET 6.0 | 100        |    17.400 μs |   0.1595 μs |   0.1414 μs |    17.400 μs |    6 |   5.22 KB |
| AddToDictionary       | .NET 6.0 | 1000       |    18.315 μs |   0.3678 μs |   0.6442 μs |    18.100 μs |    7 |  71.91 KB |
| AddToDictionary       | .NET 8.0 | 1000       |    28.374 μs |   1.8796 μs |   5.4232 μs |    25.600 μs |    8 |  71.77 KB |
| AddToSortedDictionary | .NET 8.0 | 100        |    43.443 μs |   0.8678 μs |   1.8113 μs |    42.800 μs |    9 |   7.42 KB |
| AddToDictionary       | .NET 6.0 | 10000      |   143.988 μs |   2.7372 μs |   2.8109 μs |   142.800 μs |   10 | 657.74 KB |
| AddToDictionary       | .NET 8.0 | 10000      |   205.857 μs |   2.2707 μs |   2.0129 μs |   205.750 μs |   11 |  657.6 KB |
| AddToSortedDictionary | .NET 6.0 | 1000       |   221.108 μs |   1.0997 μs |   0.8586 μs |   220.650 μs |   12 |  47.41 KB |
| AddToSortedDictionary | .NET 8.0 | 1000       |   559.557 μs |  10.3123 μs |   9.1416 μs |   555.550 μs |   13 |  70.68 KB |
| AddToSortedDictionary | .NET 6.0 | 10000      | 2,680.207 μs |  41.2491 μs |  38.5844 μs | 2,676.200 μs |   14 | 469.28 KB |
| AddToSortedDictionary | .NET 8.0 | 10000      | 6,752.669 μs | 124.4864 μs | 103.9518 μs | 6,756.100 μs |   15 | 492.55 KB |
