```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-SLZKTL : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
  Job-QBPARD : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-JEZIMU : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL

InvocationCount=1  UnrollFactor=1  

```
| Method                | Runtime  | ItemsToAdd | Mean         | Error       | StdDev      | Median       | Rank | Allocated |
|---------------------- |--------- |----------- |-------------:|------------:|------------:|-------------:|-----:|----------:|
| AddToDictionary       | .NET 6.0 | 10         |     1.762 μs |   0.0744 μs |   0.2135 μs |     1.800 μs |    1 |    1336 B |
| AddToDictionary       | .NET 9.0 | 10         |     2.503 μs |   0.1223 μs |   0.3490 μs |     2.400 μs |    2 |     808 B |
| AddToDictionary       | .NET 8.0 | 10         |     2.776 μs |   0.1308 μs |   0.3773 μs |     2.700 μs |    3 |    1096 B |
| AddToDictionary       | .NET 6.0 | 100        |     2.996 μs |   0.0635 μs |   0.1639 μs |     3.000 μs |    3 |    7952 B |
| AddToSortedDictionary | .NET 6.0 | 10         |     3.167 μs |   0.0672 μs |   0.1326 μs |     3.100 μs |    4 |    1120 B |
| AddToDictionary       | .NET 8.0 | 100        |     4.432 μs |   0.1622 μs |   0.4468 μs |     4.400 μs |    5 |    7712 B |
| AddToDictionary       | .NET 9.0 | 100        |     4.434 μs |   0.2003 μs |   0.5618 μs |     4.400 μs |    5 |    7712 B |
| AddToSortedDictionary | .NET 9.0 | 10         |     5.093 μs |   0.1034 μs |   0.0917 μs |     5.100 μs |    6 |     880 B |
| AddToSortedDictionary | .NET 8.0 | 10         |     5.705 μs |   0.1171 μs |   0.2982 μs |     5.650 μs |    7 |    1360 B |
| AddToDictionary       | .NET 6.0 | 1000       |    17.859 μs |   0.3581 μs |   0.6080 μs |    17.800 μs |    8 |   73728 B |
| AddToDictionary       | .NET 9.0 | 1000       |    24.997 μs |   0.7217 μs |   2.0238 μs |    24.700 μs |    9 |   73200 B |
| AddToDictionary       | .NET 8.0 | 1000       |    27.829 μs |   2.0127 μs |   5.8072 μs |    24.950 μs |    9 |   73488 B |
| AddToSortedDictionary | .NET 6.0 | 100        |    32.235 μs |   2.5339 μs |   7.1883 μs |    27.800 μs |   10 |    5440 B |
| AddToSortedDictionary | .NET 9.0 | 100        |    66.920 μs |   1.3372 μs |   3.1519 μs |    66.000 μs |   11 |    5200 B |
| AddToSortedDictionary | .NET 8.0 | 100        |    72.875 μs |   2.0118 μs |   5.6414 μs |    71.500 μs |   12 |    9712 B |
| AddToDictionary       | .NET 9.0 | 10000      |   199.662 μs |   2.8652 μs |   2.3925 μs |   199.000 μs |   13 |  673384 B |
| AddToDictionary       | .NET 8.0 | 10000      |   199.900 μs |   3.0294 μs |   2.6855 μs |   199.100 μs |   13 |  673384 B |
| AddToDictionary       | .NET 6.0 | 10000      |   213.860 μs |   4.0785 μs |   4.8552 μs |   213.650 μs |   14 |  673624 B |
| AddToSortedDictionary | .NET 6.0 | 1000       |   378.123 μs |   4.8512 μs |   4.0510 μs |   376.400 μs |   15 |   48640 B |
| AddToSortedDictionary | .NET 9.0 | 1000       |   902.958 μs |   5.4015 μs |   4.2172 μs |   902.500 μs |   16 |   48400 B |
| AddToSortedDictionary | .NET 8.0 | 1000       |   927.738 μs |   5.1375 μs |   4.2900 μs |   927.200 μs |   16 |   96400 B |
| AddToSortedDictionary | .NET 9.0 | 10000      | 1,311.720 μs |  21.8914 μs |  48.9632 μs | 1,300.450 μs |   17 |  480064 B |
| AddToSortedDictionary | .NET 8.0 | 10000      | 1,565.798 μs |  63.9376 μs | 173.9471 μs | 1,467.750 μs |   18 |  480400 B |
| AddToSortedDictionary | .NET 6.0 | 10000      | 3,553.111 μs | 229.6889 μs | 662.7051 μs | 3,212.950 μs |   19 |  480640 B |