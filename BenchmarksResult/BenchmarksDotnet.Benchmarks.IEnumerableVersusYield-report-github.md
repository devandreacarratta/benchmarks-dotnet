```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4170/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.202
  [Host]     : .NET 6.0.28 (6.0.2824.12007), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-DPZAIE : .NET 6.0.28 (6.0.2824.12007), X64 RyuJIT AVX2
  Job-SHRRQM : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX-512F+CD+BW+DQ+VL

InvocationCount=1  UnrollFactor=1  

```
| Method               | Runtime  | ItemsToAdd | Mean          | Error       | StdDev      | Median        | Rank | Gen0      | Gen1      | Gen2      | Allocated |
|--------------------- |--------- |----------- |--------------:|------------:|------------:|--------------:|-----:|----------:|----------:|----------:|----------:|
| IEnumerableWithYield | .NET 6.0 | 10         |      1.398 μs |   0.0508 μs |   0.1465 μs |      1.400 μs |    1 |         - |         - |         - |     584 B |
| IEnumerableWithYield | .NET 6.0 | 100        |      1.826 μs |   0.0402 μs |   0.1031 μs |      1.800 μs |    2 |         - |         - |         - |     584 B |
| IEnumerableWithYield | .NET 8.0 | 10         |      2.002 μs |   0.0716 μs |   0.2067 μs |      1.950 μs |    3 |         - |         - |         - |     440 B |
| IEnumerableWithList  | .NET 6.0 | 10         |      2.544 μs |   0.1086 μs |   0.2990 μs |      2.500 μs |    4 |         - |         - |         - |     768 B |
| IEnumerableWithList  | .NET 6.0 | 100        |      3.304 μs |   0.0699 μs |   0.1766 μs |      3.300 μs |    5 |         - |         - |         - |    1736 B |
| IEnumerableWithList  | .NET 8.0 | 10         |      3.556 μs |   0.0741 μs |   0.0727 μs |      3.600 μs |    6 |         - |         - |         - |     624 B |
| IEnumerableWithYield | .NET 8.0 | 100        |      5.082 μs |   0.1071 μs |   0.2037 μs |      5.100 μs |    7 |         - |         - |         - |     440 B |
| IEnumerableWithYield | .NET 6.0 | 1000       |      5.530 μs |   0.1118 μs |   0.1898 μs |      5.500 μs |    8 |         - |         - |         - |     584 B |
| IEnumerableWithList  | .NET 8.0 | 100        |      7.262 μs |   0.1490 μs |   0.1774 μs |      7.300 μs |    9 |         - |         - |         - |    1592 B |
| IEnumerableWithList  | .NET 6.0 | 1000       |     11.846 μs |   0.2362 μs |   0.3071 μs |     11.800 μs |   10 |         - |         - |         - |    8976 B |
| IEnumerableWithYield | .NET 8.0 | 1000       |     41.104 μs |   0.9313 μs |   2.5961 μs |     40.200 μs |   11 |         - |         - |         - |     440 B |
| IEnumerableWithList  | .NET 8.0 | 1000       |     46.691 μs |   0.9227 μs |   2.1568 μs |     46.000 μs |   12 |         - |         - |         - |    8832 B |
| IEnumerableWithYield | .NET 6.0 | 10000      |     52.850 μs |   0.1699 μs |   0.1506 μs |     52.850 μs |   13 |         - |         - |         - |     584 B |
| IEnumerableWithYield | .NET 8.0 | 10000      |     63.574 μs |   1.2613 μs |   2.1757 μs |     62.500 μs |   14 |         - |         - |         - |     440 B |
| IEnumerableWithList  | .NET 6.0 | 10000      |     99.628 μs |   0.5078 μs |   0.6779 μs |     99.500 μs |   15 |         - |         - |         - |  131952 B |
| IEnumerableWithList  | .NET 8.0 | 10000      |     99.863 μs |   1.9377 μs |   2.7164 μs |     99.400 μs |   15 |         - |         - |         - |  131808 B |
| IEnumerableWithYield | .NET 8.0 | 100000     |    287.192 μs |   4.0480 μs |   3.1604 μs |    286.550 μs |   16 |         - |         - |         - |     440 B |
| IEnumerableWithYield | .NET 6.0 | 100000     |    518.792 μs |   3.9552 μs |   3.0879 μs |    518.700 μs |   17 |         - |         - |         - |     584 B |
| IEnumerableWithList  | .NET 8.0 | 100000     |    815.015 μs |  11.0458 μs |   9.2238 μs |    813.300 μs |   18 |         - |         - |         - | 1049384 B |
| IEnumerableWithList  | .NET 6.0 | 100000     |  1,115.967 μs |   2.5712 μs |   2.0074 μs |  1,115.650 μs |   19 |         - |         - |         - | 1049528 B |
| IEnumerableWithYield | .NET 8.0 | 1000000    |  2,515.032 μs |  48.7689 μs |  69.9429 μs |  2,501.050 μs |   20 |         - |         - |         - |     440 B |
| IEnumerableWithYield | .NET 6.0 | 1000000    |  4,371.408 μs |  84.5682 μs | 109.9626 μs |  4,359.700 μs |   21 |         - |         - |         - |     584 B |
| IEnumerableWithList  | .NET 8.0 | 1000000    |  8,813.909 μs | 176.2566 μs | 367.9132 μs |  8,829.100 μs |   22 | 1000.0000 | 1000.0000 | 1000.0000 | 8389824 B |
| IEnumerableWithList  | .NET 6.0 | 1000000    | 12,214.867 μs | 240.0884 μs | 224.5788 μs | 12,178.000 μs |   23 | 1000.0000 | 1000.0000 | 1000.0000 | 8389968 B |
