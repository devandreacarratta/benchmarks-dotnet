```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4170/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.202
  [Host]     : .NET 6.0.28 (6.0.2824.12007), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-ZOXBHM : .NET 6.0.28 (6.0.2824.12007), X64 RyuJIT AVX2
  Job-UPMPYD : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX-512F+CD+BW+DQ+VL

InvocationCount=1  UnrollFactor=1  

```
| Method              | Runtime  | ItemsToAdd | Mean          | Error       | StdDev        | Median        | Rank | Allocated |
|-------------------- |--------- |----------- |--------------:|------------:|--------------:|--------------:|-----:|----------:|
| AddItemsToList      | .NET 6.0 | 10         |      1.853 μs |   0.0409 μs |     0.0889 μs |      1.900 μs |    1 |     760 B |
| AddItemsToList      | .NET 6.0 | 100        |      2.022 μs |   0.0439 μs |     0.0887 μs |      2.000 μs |    2 |    1728 B |
| AddItemsToList      | .NET 8.0 | 10         |      2.088 μs |   0.0475 μs |     0.1332 μs |      2.000 μs |    2 |     616 B |
| AddItemsToSortedSet | .NET 6.0 | 10         |      2.422 μs |   0.0584 μs |     0.1667 μs |      2.400 μs |    3 |     992 B |
| AddItemsToList      | .NET 8.0 | 100        |      3.167 μs |   0.0903 μs |     0.2575 μs |      3.100 μs |    4 |    1584 B |
| AddItemsToList      | .NET 6.0 | 1000       |      3.805 μs |   0.0554 μs |     0.0941 μs |      3.800 μs |    5 |    8968 B |
| AddItemsToSortedSet | .NET 8.0 | 10         |      4.301 μs |   0.1045 μs |     0.3014 μs |      4.300 μs |    6 |     848 B |
| AddItemsToSortedSet | .NET 6.0 | 100        |     13.214 μs |   0.2647 μs |     0.5407 μs |     13.200 μs |    7 |    4592 B |
| AddItemsToList      | .NET 8.0 | 1000       |     17.596 μs |   1.1751 μs |     3.4464 μs |     19.000 μs |    8 |    8824 B |
| AddItemsToList      | .NET 6.0 | 10000      |     26.413 μs |   0.5301 μs |     0.6703 μs |     26.400 μs |    9 |  131944 B |
| AddItemsToList      | .NET 8.0 | 10000      |     34.246 μs |   0.6805 μs |     1.1556 μs |     34.100 μs |   10 |  131800 B |
| AddItemsToSortedSet | .NET 8.0 | 100        |     42.123 μs |   1.1565 μs |     3.2995 μs |     43.200 μs |   11 |    4448 B |
| AddItemsToSortedSet | .NET 6.0 | 1000       |    143.414 μs |   1.7187 μs |     1.5236 μs |    143.450 μs |   12 |   40592 B |
| AddItemsToList      | .NET 6.0 | 100000     |    281.709 μs |  19.6343 μs |    57.5841 μs |    313.300 μs |   13 | 1049472 B |
| AddItemsToList      | .NET 8.0 | 100000     |    414.023 μs |  36.8726 μs |   108.1410 μs |    409.500 μs |   14 | 1049376 B |
| AddItemsToSortedSet | .NET 8.0 | 1000       |    447.108 μs |   4.7597 μs |     3.9746 μs |    448.300 μs |   15 |   40448 B |
| AddItemsToSortedSet | .NET 6.0 | 10000      |  1,779.414 μs |  15.9737 μs |    14.1602 μs |  1,774.750 μs |   16 |  400592 B |
| AddItemsToSortedSet | .NET 8.0 | 10000      |  5,277.889 μs | 102.7821 μs |   109.9757 μs |  5,321.800 μs |   17 |  400448 B |
| AddItemsToSortedSet | .NET 8.0 | 100000     | 22,158.351 μs | 438.7831 μs | 1,076.3424 μs | 21,759.700 μs |   18 | 4000448 B |
| AddItemsToSortedSet | .NET 6.0 | 100000     | 23,797.722 μs | 401.5014 μs |   562.8489 μs | 23,611.800 μs |   19 | 4000544 B |
