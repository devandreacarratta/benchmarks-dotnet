```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-LQCQGL : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-TELGYO : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
  Job-WEACSW : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL

InvocationCount=1  UnrollFactor=1  

```
| Method                     | Runtime  | NumberOfItems | Mean          | Error         | StdDev        | Median        | Rank | Gen0        | Gen1       | Gen2       | Allocated   |
|--------------------------- |--------- |-------------- |--------------:|--------------:|--------------:|--------------:|-----:|------------:|-----------:|-----------:|------------:|
| StringJoinToString         | .NET 9.0 | 10            |      1.491 μs |     0.0742 μs |     0.2176 μs |      1.500 μs |    1 |           - |          - |          - |       528 B |
| LinqAggregateInterpolation | .NET 9.0 | 10            |      1.821 μs |     0.0805 μs |     0.2361 μs |      1.750 μs |    2 |           - |          - |          - |      1168 B |
| StringBuilderConcatenation | .NET 6.0 | 10            |      1.842 μs |     0.0757 μs |     0.2171 μs |      1.800 μs |    2 |           - |          - |          - |      1112 B |
| StringJoinToString         | .NET 6.0 | 10            |      1.848 μs |     0.0666 μs |     0.1932 μs |      1.800 μs |    2 |           - |          - |          - |       768 B |
| LinqAggregate              | .NET 9.0 | 10            |      1.895 μs |     0.0912 μs |     0.2661 μs |      1.850 μs |    2 |           - |          - |          - |      1168 B |
| StringJoinToString         | .NET 8.0 | 10            |      1.926 μs |     0.0763 μs |     0.2189 μs |      1.900 μs |    2 |           - |          - |          - |       528 B |
| StringConcat               | .NET 6.0 | 10            |      2.017 μs |     0.0744 μs |     0.2181 μs |      2.000 μs |    2 |           - |          - |          - |       808 B |
| StringBuilderConcatenation | .NET 8.0 | 10            |      2.181 μs |     0.1152 μs |     0.3360 μs |      2.100 μs |    2 |           - |          - |          - |       872 B |
| StringBuilderConcatenation | .NET 9.0 | 10            |      2.208 μs |     0.0933 μs |     0.2602 μs |      2.100 μs |    2 |           - |          - |          - |       872 B |
| StringJoinToString         | .NET 9.0 | 100           |      2.320 μs |     0.0910 μs |     0.2612 μs |      2.300 μs |    2 |           - |          - |          - |      1424 B |
| LinqAggregateInterpolation | .NET 8.0 | 10            |      2.489 μs |     0.1493 μs |     0.4136 μs |      2.350 μs |    2 |           - |          - |          - |      1208 B |
| LinqAggregateInterpolation | .NET 6.0 | 10            |      2.550 μs |     0.1226 μs |     0.3377 μs |      2.500 μs |    2 |           - |          - |          - |      1448 B |
| StringConcat               | .NET 8.0 | 10            |      2.559 μs |     0.0949 μs |     0.2693 μs |      2.550 μs |    2 |           - |          - |          - |       568 B |
| LinqAggregate              | .NET 8.0 | 10            |      2.586 μs |     0.1204 μs |     0.3375 μs |      2.500 μs |    2 |           - |          - |          - |      1208 B |
| StringBuilderConcatenation | .NET 6.0 | 100           |      2.736 μs |     0.0717 μs |     0.2102 μs |      2.700 μs |    2 |           - |          - |          - |      3120 B |
| StringConcat               | .NET 9.0 | 10            |      2.776 μs |     0.1751 μs |     0.4968 μs |      2.700 μs |    2 |           - |          - |          - |       568 B |
| StringJoinToString         | .NET 8.0 | 100           |      2.798 μs |     0.1039 μs |     0.2913 μs |      2.700 μs |    2 |           - |          - |          - |      1424 B |
| LinqAggregate              | .NET 6.0 | 10            |      2.816 μs |     0.2641 μs |     0.7789 μs |      2.400 μs |    2 |           - |          - |          - |      1448 B |
| StringConcat               | .NET 6.0 | 100           |      3.768 μs |     0.1257 μs |     0.3312 μs |      3.700 μs |    3 |           - |          - |          - |      1704 B |
| StringBuilderConcatenation | .NET 9.0 | 100           |      3.893 μs |     0.1271 μs |     0.3748 μs |      3.750 μs |    3 |           - |          - |          - |      2880 B |
| StringJoinToString         | .NET 6.0 | 100           |      3.934 μs |     0.4734 μs |     1.3809 μs |      3.100 μs |    3 |           - |          - |          - |      1664 B |
| StringBuilderConcatenation | .NET 8.0 | 100           |      4.049 μs |     0.1691 μs |     0.4771 μs |      3.900 μs |    3 |           - |          - |          - |      2880 B |
| StringConcat               | .NET 9.0 | 100           |      4.460 μs |     0.0942 μs |     0.2146 μs |      4.400 μs |    4 |           - |          - |          - |      1464 B |
| StringConcat               | .NET 8.0 | 100           |      4.712 μs |     0.0939 μs |     0.2339 μs |      4.700 μs |    5 |           - |          - |          - |      1464 B |
| LinqAggregate              | .NET 6.0 | 100           |      9.496 μs |     0.1868 μs |     0.4754 μs |      9.300 μs |    6 |           - |          - |          - |     53648 B |
| LinqAggregateInterpolation | .NET 6.0 | 100           |      9.767 μs |     0.1739 μs |     0.3046 μs |      9.700 μs |    6 |           - |          - |          - |     53648 B |
| StringJoinToString         | .NET 9.0 | 1000          |     10.300 μs |     0.2016 μs |     0.1787 μs |     10.250 μs |    6 |           - |          - |          - |     10424 B |
| StringJoinToString         | .NET 8.0 | 1000          |     10.473 μs |     0.1999 μs |     0.1870 μs |     10.400 μs |    6 |           - |          - |          - |     10424 B |
| StringBuilderConcatenation | .NET 6.0 | 1000          |     11.967 μs |     0.2420 μs |     0.4043 μs |     11.800 μs |    7 |           - |          - |          - |     27768 B |
| StringJoinToString         | .NET 6.0 | 1000          |     12.100 μs |     0.1467 μs |     0.1301 μs |     12.050 μs |    7 |           - |          - |          - |     10664 B |
| StringConcat               | .NET 6.0 | 1000          |     16.223 μs |     0.3243 μs |     0.4439 μs |     16.000 μs |    8 |           - |          - |          - |     10704 B |
| StringConcat               | .NET 8.0 | 1000          |     23.595 μs |     1.0490 μs |     3.0096 μs |     25.000 μs |    9 |           - |          - |          - |     10464 B |
| StringConcat               | .NET 9.0 | 1000          |     25.238 μs |     1.0963 μs |     3.1099 μs |     25.850 μs |    9 |           - |          - |          - |     10464 B |
| LinqAggregate              | .NET 8.0 | 100           |     29.162 μs |     4.0689 μs |    11.9973 μs |     36.250 μs |   10 |           - |          - |          - |     53408 B |
| LinqAggregateInterpolation | .NET 9.0 | 100           |     29.270 μs |     4.2450 μs |    11.6921 μs |     35.300 μs |   10 |           - |          - |          - |     53368 B |
| LinqAggregate              | .NET 9.0 | 100           |     30.547 μs |     4.8489 μs |    14.2971 μs |     36.400 μs |   10 |           - |          - |          - |     53080 B |
| LinqAggregateInterpolation | .NET 8.0 | 100           |     32.727 μs |     5.1895 μs |    15.3013 μs |     37.600 μs |   10 |           - |          - |          - |     53408 B |
| StringBuilderConcatenation | .NET 9.0 | 1000          |     36.949 μs |     3.3651 μs |     9.7090 μs |     40.750 μs |   10 |           - |          - |          - |     27528 B |
| StringBuilderConcatenation | .NET 8.0 | 1000          |     40.983 μs |     3.9663 μs |    11.4437 μs |     42.500 μs |   10 |           - |          - |          - |     27528 B |
| StringBuilderConcatenation | .NET 9.0 | 10000         |     76.203 μs |     1.4456 μs |     1.3522 μs |     76.150 μs |   11 |           - |          - |          - |    213672 B |
| StringBuilderConcatenation | .NET 8.0 | 10000         |     78.762 μs |     1.2422 μs |     1.0373 μs |     78.700 μs |   11 |           - |          - |          - |    213960 B |
| StringBuilderConcatenation | .NET 6.0 | 10000         |     79.147 μs |     1.4127 μs |     2.4368 μs |     78.600 μs |   11 |           - |          - |          - |    214200 B |
| StringJoinToString         | .NET 8.0 | 10000         |     88.800 μs |     1.0067 μs |     0.8406 μs |     88.900 μs |   12 |           - |          - |          - |    100424 B |
| StringJoinToString         | .NET 9.0 | 10000         |     89.962 μs |     0.3676 μs |     0.3070 μs |     89.900 μs |   12 |           - |          - |          - |    100136 B |
| StringJoinToString         | .NET 6.0 | 10000         |    106.838 μs |     1.5191 μs |     1.2686 μs |    107.200 μs |   13 |           - |          - |          - |    100664 B |
| StringConcat               | .NET 6.0 | 10000         |    134.908 μs |     2.4791 μs |     1.9355 μs |    135.300 μs |   14 |           - |          - |          - |    100704 B |
| StringConcat               | .NET 8.0 | 10000         |    163.738 μs |     1.1471 μs |     0.9579 μs |    163.700 μs |   15 |           - |          - |          - |    100464 B |
| StringConcat               | .NET 9.0 | 10000         |    174.608 μs |     0.8831 μs |     0.6895 μs |    174.600 μs |   16 |           - |          - |          - |    100464 B |
| LinqAggregate              | .NET 9.0 | 1000          |    434.127 μs |     8.6494 μs |    15.3744 μs |    430.800 μs |   17 |   1000.0000 |          - |          - |   5030080 B |
| LinqAggregateInterpolation | .NET 9.0 | 1000          |    451.132 μs |     8.8787 μs |    20.7538 μs |    448.100 μs |   17 |   1000.0000 |          - |          - |   5030080 B |
| LinqAggregateInterpolation | .NET 8.0 | 1000          |    453.585 μs |     9.0187 μs |    21.0809 μs |    449.600 μs |   17 |   1000.0000 |          - |          - |   5030408 B |
| LinqAggregate              | .NET 8.0 | 1000          |    470.533 μs |    10.7091 μs |    30.5536 μs |    465.850 μs |   17 |   1000.0000 |          - |          - |   5030120 B |
| LinqAggregate              | .NET 6.0 | 1000          |    521.840 μs |    15.4472 μs |    45.0603 μs |    518.400 μs |   18 |   1000.0000 |  1000.0000 |          - |   5030648 B |
| LinqAggregateInterpolation | .NET 6.0 | 1000          |    617.813 μs |    37.8029 μs |   107.2405 μs |    593.000 μs |   19 |   1000.0000 |          - |          - |   5030648 B |
| LinqAggregateInterpolation | .NET 8.0 | 10000         | 73,842.871 μs |   717.0348 μs |   635.6327 μs | 73,822.650 μs |   20 | 125000.0000 | 44000.0000 | 43000.0000 | 500314856 B |
| LinqAggregateInterpolation | .NET 9.0 | 10000         | 74,026.807 μs | 1,026.6459 μs |   960.3252 μs | 74,024.800 μs |   20 | 125000.0000 | 44000.0000 | 43000.0000 | 500314528 B |
| LinqAggregate              | .NET 9.0 | 10000         | 74,205.527 μs | 1,281.4789 μs | 1,198.6962 μs | 73,776.400 μs |   20 | 125000.0000 | 44000.0000 | 43000.0000 | 500314816 B |
| LinqAggregate              | .NET 8.0 | 10000         | 75,106.610 μs | 1,226.9790 μs | 1,798.4901 μs | 75,008.900 μs |   20 | 125000.0000 | 44000.0000 | 43000.0000 | 500314520 B |
| LinqAggregateInterpolation | .NET 6.0 | 10000         | 75,321.300 μs | 1,232.4848 μs | 1,152.8670 μs | 75,358.600 μs |   20 | 125000.0000 | 44000.0000 | 43000.0000 | 500315096 B |
| LinqAggregate              | .NET 6.0 | 10000         | 75,808.492 μs | 1,469.0842 μs | 2,010.8992 μs | 75,132.400 μs |   20 | 125000.0000 | 44000.0000 | 43000.0000 | 500315096 B |
