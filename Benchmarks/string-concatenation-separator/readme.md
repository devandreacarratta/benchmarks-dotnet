```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.204
  [Host]     : .NET 6.0.29 (6.0.2924.17105), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-GRNZLE : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-UQHZVF : .NET 6.0.29 (6.0.2924.17105), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

```
| Method                     | Runtime  | NumberOfItems | Mean           | Error         | StdDev        | Median         | Rank | Gen0        | Gen1       | Gen2       | Allocated   |
|--------------------------- |--------- |-------------- |---------------:|--------------:|--------------:|---------------:|-----:|------------:|-----------:|-----------:|------------:|
| StringJoinToString         | .NET 8.0 | 10            |       2.091 μs |     0.0553 μs |     0.1597 μs |       2.000 μs |    1 |           - |          - |          - |       544 B |
| StringJoinToString         | .NET 6.0 | 10            |       2.117 μs |     0.0460 μs |     0.1020 μs |       2.100 μs |    1 |           - |          - |          - |       688 B |
| StringBuilderInterpolation | .NET 6.0 | 10            |       2.211 μs |     0.0481 μs |     0.0938 μs |       2.200 μs |    2 |           - |          - |          - |      1032 B |
| StringJoinToString         | .NET 8.0 | 100           |       2.615 μs |     0.0581 μs |     0.1648 μs |       2.600 μs |    3 |           - |          - |          - |      1624 B |
| LinqAggregateInterpolation | .NET 6.0 | 10            |       2.753 μs |     0.0541 μs |     0.0842 μs |       2.750 μs |    4 |           - |          - |          - |      1432 B |
| StringJoinToString         | .NET 6.0 | 100           |       2.768 μs |     0.0571 μs |     0.0819 μs |       2.800 μs |    4 |           - |          - |          - |      1768 B |
| LinqAggregate              | .NET 8.0 | 10            |       2.775 μs |     0.0493 μs |     0.1349 μs |       2.700 μs |    4 |           - |          - |          - |      1288 B |
| LinqAggregate              | .NET 6.0 | 10            |       2.800 μs |     0.0591 μs |     0.1369 μs |       2.800 μs |    4 |           - |          - |          - |      1432 B |
| LinqAggregateInterpolation | .NET 8.0 | 10            |       2.888 μs |     0.0638 μs |     0.1788 μs |       2.800 μs |    4 |           - |          - |          - |      1288 B |
| StringBuilderInterpolation | .NET 8.0 | 10            |       2.944 μs |     0.0642 μs |     0.1767 μs |       2.900 μs |    4 |           - |          - |          - |       888 B |
| StringBuilderFormat        | .NET 6.0 | 10            |       3.202 μs |     0.0673 μs |     0.1214 μs |       3.200 μs |    5 |           - |          - |          - |      1032 B |
| StringBuilderInterpolation | .NET 6.0 | 100           |       3.514 μs |     0.0741 μs |     0.1373 μs |       3.500 μs |    6 |           - |          - |          - |      4320 B |
| StringBuilderFormat        | .NET 8.0 | 10            |       3.894 μs |     0.0837 μs |     0.2007 μs |       3.800 μs |    7 |           - |          - |          - |       888 B |
| StringBuilderInterpolation | .NET 8.0 | 100           |       6.105 μs |     0.1243 μs |     0.1432 μs |       6.100 μs |    8 |           - |          - |          - |      4176 B |
| StringJoinToString         | .NET 8.0 | 1000          |       7.669 μs |     0.1498 μs |     0.1251 μs |       7.700 μs |    9 |           - |          - |          - |     12424 B |
| StringBuilderFormat        | .NET 6.0 | 100           |       8.684 μs |     0.1698 μs |     0.2267 μs |       8.700 μs |   10 |           - |          - |          - |      4320 B |
| StringJoinToString         | .NET 6.0 | 1000          |       9.032 μs |     0.1801 μs |     0.2001 μs |       9.000 μs |   11 |           - |          - |          - |     12568 B |
| StringBuilderFormat        | .NET 8.0 | 100           |      10.765 μs |     0.1182 μs |     0.0987 μs |      10.750 μs |   12 |           - |          - |          - |      4176 B |
| LinqAggregateInterpolation | .NET 6.0 | 100           |      11.000 μs |     0.2198 μs |     0.3291 μs |      10.850 μs |   12 |           - |          - |          - |     63352 B |
| LinqAggregate              | .NET 6.0 | 100           |      11.312 μs |     0.2298 μs |     0.4590 μs |      11.200 μs |   12 |           - |          - |          - |     63352 B |
| StringBuilderInterpolation | .NET 6.0 | 1000          |      17.239 μs |     0.3303 μs |     0.3534 μs |      17.350 μs |   13 |           - |          - |          - |     29672 B |
| LinqAggregate              | .NET 8.0 | 100           |      33.974 μs |     4.6903 μs |    13.8295 μs |      41.600 μs |   14 |           - |          - |          - |     63208 B |
| LinqAggregateInterpolation | .NET 8.0 | 100           |      36.219 μs |     4.8064 μs |    14.0963 μs |      41.800 μs |   14 |           - |          - |          - |     63208 B |
| StringBuilderInterpolation | .NET 8.0 | 1000          |      39.625 μs |     0.4454 μs |     0.4374 μs |      39.600 μs |   15 |           - |          - |          - |     29528 B |
| StringJoinToString         | .NET 8.0 | 10000         |      59.325 μs |     1.0190 μs |     0.7956 μs |      59.500 μs |   16 |           - |          - |          - |    120424 B |
| StringBuilderFormat        | .NET 6.0 | 1000          |      64.054 μs |     0.6534 μs |     0.5456 μs |      64.000 μs |   17 |           - |          - |          - |     29672 B |
| StringJoinToString         | .NET 6.0 | 10000         |      70.583 μs |     1.4004 μs |     2.0527 μs |      70.300 μs |   18 |           - |          - |          - |    120568 B |
| StringBuilderFormat        | .NET 8.0 | 1000          |      93.900 μs |     1.9115 μs |     5.3286 μs |      95.700 μs |   19 |           - |          - |          - |     29528 B |
| StringBuilderInterpolation | .NET 8.0 | 10000         |     125.418 μs |     2.4582 μs |     4.3053 μs |     123.700 μs |   20 |           - |          - |          - |    250032 B |
| StringBuilderInterpolation | .NET 6.0 | 10000         |     133.977 μs |     1.2292 μs |     1.0264 μs |     134.200 μs |   21 |           - |          - |          - |    250176 B |
| StringBuilderFormat        | .NET 6.0 | 10000         |     577.434 μs |    11.4553 μs |    18.8213 μs |     568.400 μs |   22 |           - |          - |          - |    250176 B |
| LinqAggregate              | .NET 8.0 | 1000          |     586.063 μs |    11.1166 μs |    28.2953 μs |     576.950 μs |   22 |   1000.0000 |          - |          - |   6028408 B |
| StringBuilderFormat        | .NET 8.0 | 10000         |     620.071 μs |    11.1845 μs |     9.9147 μs |     623.750 μs |   23 |           - |          - |          - |    250032 B |
| LinqAggregateInterpolation | .NET 8.0 | 1000          |     650.581 μs |    14.7523 μs |    42.3270 μs |     648.950 μs |   24 |   1000.0000 |          - |          - |   6028408 B |
| LinqAggregate              | .NET 6.0 | 1000          |     670.405 μs |    17.0852 μs |    49.0206 μs |     661.100 μs |   24 |   1000.0000 |  1000.0000 |          - |   6028552 B |
| LinqAggregateInterpolation | .NET 6.0 | 1000          |     671.696 μs |    16.4192 μs |    47.3732 μs |     657.500 μs |   24 |   1000.0000 |          - |          - |   6028552 B |
| LinqAggregateInterpolation | .NET 6.0 | 10000         | 110,993.267 μs | 1,368.0105 μs | 1,279.6378 μs | 110,647.000 μs |   25 | 162000.0000 | 94000.0000 | 93000.0000 | 600311752 B |
| LinqAggregate              | .NET 6.0 | 10000         | 113,773.287 μs | 1,821.6989 μs | 1,704.0182 μs | 113,756.500 μs |   26 | 162000.0000 | 94000.0000 | 93000.0000 | 600311752 B |
| LinqAggregate              | .NET 8.0 | 10000         | 116,162.493 μs |   749.5020 μs |   701.0846 μs | 116,214.900 μs |   27 | 162000.0000 | 94000.0000 | 93000.0000 | 600311656 B |
| LinqAggregateInterpolation | .NET 8.0 | 10000         | 116,410.333 μs | 1,091.0372 μs | 1,020.5569 μs | 116,081.700 μs |   27 | 162000.0000 | 94000.0000 | 93000.0000 | 600311656 B |
