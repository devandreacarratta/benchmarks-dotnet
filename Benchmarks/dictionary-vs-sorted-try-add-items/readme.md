```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-QTMWMW : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT AVX2
  Job-GWBGSO : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL

InvocationCount=1  UnrollFactor=1  

```
| Method                | Runtime  | ItemsToAdd | Mean         | Error      | StdDev     | Median       | Rank | Allocated |
|---------------------- |--------- |----------- |-------------:|-----------:|-----------:|-------------:|-----:|----------:|
| AddToDictionary       | .NET 6.0 | 10         |     1.974 μs |  0.0598 μs |  0.1715 μs |     1.900 μs |    1 |   1.21 KB |
| AddToDictionary       | .NET 8.0 | 10         |     2.845 μs |  0.0628 μs |  0.1588 μs |     2.800 μs |    2 |   1.07 KB |
| AddToDictionary       | .NET 6.0 | 100        |     3.186 μs |  0.0669 μs |  0.1578 μs |     3.200 μs |    3 |   7.67 KB |
| AddToSortedDictionary | .NET 6.0 | 10         |     4.306 μs |  0.5401 μs |  1.5840 μs |     3.500 μs |    4 |      1 KB |
| AddToDictionary       | .NET 8.0 | 100        |     4.638 μs |  0.0920 μs |  0.0768 μs |     4.700 μs |    5 |   7.53 KB |
| AddToSortedDictionary | .NET 8.0 | 10         |     6.060 μs |  0.1199 μs |  0.1121 μs |     6.000 μs |    6 |   1.33 KB |
| AddToDictionary       | .NET 6.0 | 1000       |    18.331 μs |  0.3692 μs |  0.5412 μs |    18.200 μs |    7 |  71.91 KB |
| AddToDictionary       | .NET 8.0 | 1000       |    24.753 μs |  0.5401 μs |  1.5322 μs |    24.200 μs |    8 |  71.77 KB |
| AddToSortedDictionary | .NET 6.0 | 100        |    27.846 μs |  0.3374 μs |  0.2817 μs |    27.800 μs |    9 |   5.22 KB |
| AddToSortedDictionary | .NET 8.0 | 100        |    67.177 μs |  1.3393 μs |  2.9955 μs |    66.950 μs |   10 |   9.77 KB |
| AddToDictionary       | .NET 6.0 | 10000      |   141.620 μs |  2.0778 μs |  1.9436 μs |   140.700 μs |   11 | 657.74 KB |
| AddToDictionary       | .NET 8.0 | 10000      |   205.850 μs |  2.7581 μs |  2.4450 μs |   205.500 μs |   12 |  657.6 KB |
| AddToSortedDictionary | .NET 6.0 | 1000       |   373.862 μs |  2.0455 μs |  1.7081 μs |   373.600 μs |   13 |  47.41 KB |
| AddToSortedDictionary | .NET 8.0 | 1000       |   889.879 μs |  6.0498 μs |  5.3630 μs |   888.300 μs |   14 |  94.14 KB |
| AddToSortedDictionary | .NET 8.0 | 10000      | 1,448.141 μs | 13.3300 μs | 22.6354 μs | 1,436.500 μs |   15 | 469.14 KB |
| AddToSortedDictionary | .NET 6.0 | 10000      | 4,714.320 μs | 84.6204 μs | 79.1539 μs | 4,751.200 μs |   16 | 469.28 KB |
