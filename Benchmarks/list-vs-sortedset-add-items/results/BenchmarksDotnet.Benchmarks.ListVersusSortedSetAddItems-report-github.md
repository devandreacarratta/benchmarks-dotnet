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
| Method              | Runtime  | ItemsToAdd | Mean          | Error       | StdDev      | Median        | Rank | Allocated |
|-------------------- |--------- |----------- |--------------:|------------:|------------:|--------------:|-----:|----------:|
| AddItemsToList      | .NET 6.0 | 10         |      1.596 μs |   0.0489 μs |   0.1435 μs |      1.600 μs |    1 |     856 B |
| AddItemsToList      | .NET 9.0 | 10         |      1.763 μs |   0.0657 μs |   0.1885 μs |      1.700 μs |    2 |     616 B |
| AddItemsToList      | .NET 8.0 | 10         |      1.939 μs |   0.0713 μs |   0.2079 μs |      1.900 μs |    3 |     616 B |
| AddItemsToList      | .NET 6.0 | 100        |      2.022 μs |   0.0438 μs |   0.1042 μs |      2.000 μs |    3 |    1824 B |
| AddItemsToSortedSet | .NET 6.0 | 10         |      2.566 μs |   0.1004 μs |   0.2898 μs |      2.600 μs |    4 |    1088 B |
| AddItemsToList      | .NET 9.0 | 100        |      2.789 μs |   0.1099 μs |   0.3063 μs |      2.700 μs |    4 |    1248 B |
| AddItemsToList      | .NET 8.0 | 100        |      3.020 μs |   0.0871 μs |   0.2528 μs |      3.000 μs |    5 |    1584 B |
| AddItemsToList      | .NET 6.0 | 1000       |      3.732 μs |   0.0782 μs |   0.2061 μs |      3.700 μs |    6 |    9064 B |
| AddItemsToSortedSet | .NET 9.0 | 10         |      3.899 μs |   0.1058 μs |   0.3070 μs |      3.900 μs |    6 |     560 B |
| AddItemsToSortedSet | .NET 8.0 | 10         |      4.158 μs |   0.1139 μs |   0.3211 μs |      4.100 μs |    7 |     512 B |
| AddItemsToSortedSet | .NET 6.0 | 100        |     13.284 μs |   0.2694 μs |   0.4647 μs |     13.300 μs |    8 |    4688 B |
| AddItemsToList      | .NET 8.0 | 1000       |     18.400 μs |   1.1449 μs |   3.2849 μs |     19.300 μs |    9 |    8824 B |
| AddItemsToList      | .NET 9.0 | 1000       |     18.410 μs |   1.0065 μs |   2.9201 μs |     19.300 μs |    9 |    8824 B |
| AddItemsToList      | .NET 6.0 | 10000      |     25.589 μs |   0.5149 μs |   0.7218 μs |     25.300 μs |   10 |  132040 B |
| AddItemsToList      | .NET 8.0 | 10000      |     34.131 μs |   0.6677 μs |   1.6504 μs |     33.650 μs |   11 |  131800 B |
| AddItemsToList      | .NET 9.0 | 10000      |     38.503 μs |   1.6829 μs |   4.8287 μs |     36.600 μs |   12 |  131512 B |
| AddItemsToSortedSet | .NET 8.0 | 100        |     41.534 μs |   1.1114 μs |   3.1349 μs |     42.250 μs |   12 |    4160 B |
| AddItemsToSortedSet | .NET 9.0 | 100        |     42.254 μs |   1.3209 μs |   3.7472 μs |     42.900 μs |   12 |    4160 B |
| AddItemsToSortedSet | .NET 6.0 | 1000       |    145.493 μs |   2.7332 μs |   2.5566 μs |    146.600 μs |   13 |   40688 B |
| AddItemsToList      | .NET 6.0 | 100000     |    319.904 μs |   6.3557 μs |   8.6998 μs |    316.950 μs |   14 | 1049616 B |
| AddItemsToList      | .NET 9.0 | 100000     |    345.797 μs |  19.8744 μs |  57.6594 μs |    348.100 μs |   14 | 1049088 B |
| AddItemsToList      | .NET 8.0 | 100000     |    347.195 μs |  20.4608 μs |  59.6852 μs |    354.200 μs |   14 | 1049376 B |
| AddItemsToSortedSet | .NET 8.0 | 1000       |    440.179 μs |   5.9157 μs |   5.2441 μs |    439.250 μs |   15 |   40112 B |
| AddItemsToSortedSet | .NET 9.0 | 1000       |    446.115 μs |   4.1702 μs |   3.4823 μs |    446.200 μs |   15 |   40448 B |
| AddItemsToSortedSet | .NET 9.0 | 10000      |  1,293.888 μs |  20.8096 μs |  51.4362 μs |  1,280.050 μs |   16 |  400160 B |
| AddItemsToSortedSet | .NET 8.0 | 10000      |  1,374.142 μs |  25.4522 μs |  52.5631 μs |  1,352.550 μs |   17 |  400448 B |
| AddItemsToSortedSet | .NET 6.0 | 10000      |  1,838.158 μs |  11.8978 μs |   9.2890 μs |  1,837.500 μs |   18 |  400688 B |
| AddItemsToSortedSet | .NET 9.0 | 100000     | 19,988.907 μs | 396.5176 μs | 593.4890 μs | 19,750.100 μs |   19 | 4000160 B |
| AddItemsToSortedSet | .NET 8.0 | 100000     | 21,122.613 μs | 396.5142 μs | 593.4838 μs | 21,024.400 μs |   20 | 4000448 B |
| AddItemsToSortedSet | .NET 6.0 | 100000     | 24,117.266 μs | 476.7045 μs | 822.2919 μs | 23,879.500 μs |   21 | 4000688 B |
