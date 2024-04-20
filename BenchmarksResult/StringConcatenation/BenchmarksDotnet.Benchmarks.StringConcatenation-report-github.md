```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.204
  [Host]     : .NET 6.0.29 (6.0.2924.17105), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-UQHZVF : .NET 6.0.29 (6.0.2924.17105), X64 RyuJIT AVX2
  Job-GRNZLE : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX-512F+CD+BW+DQ+VL

InvocationCount=1  UnrollFactor=1  

```
| Method                     | Runtime  | NumberOfItems | Mean          | Error         | StdDev        | Median        | Rank | Gen0        | Gen1       | Gen2       | Allocated   |
|--------------------------- |--------- |-------------- |--------------:|--------------:|--------------:|--------------:|-----:|------------:|-----------:|-----------:|------------:|
| StringBuilderConcatenation | .NET 6.0 | 10            |      2.101 μs |     0.0473 μs |     0.1373 μs |      2.100 μs |    1 |           - |          - |          - |      1016 B |
| StringConcat               | .NET 6.0 | 10            |      2.185 μs |     0.0447 μs |     0.1225 μs |      2.200 μs |    2 |           - |          - |          - |       712 B |
| StringJoinToString         | .NET 8.0 | 10            |      2.206 μs |     0.0687 μs |     0.1961 μs |      2.100 μs |    2 |           - |          - |          - |       528 B |
| StringJoinToString         | .NET 6.0 | 10            |      2.220 μs |     0.0480 μs |     0.1034 μs |      2.200 μs |    2 |           - |          - |          - |       672 B |
| StringBuilderConcatenation | .NET 8.0 | 10            |      2.366 μs |     0.0635 μs |     0.1864 μs |      2.300 μs |    3 |           - |          - |          - |       872 B |
| LinqAggregate              | .NET 8.0 | 10            |      2.668 μs |     0.0591 μs |     0.1525 μs |      2.600 μs |    4 |           - |          - |          - |      1208 B |
| LinqAggregate              | .NET 6.0 | 10            |      2.710 μs |     0.0582 μs |     0.1394 μs |      2.700 μs |    4 |           - |          - |          - |      1352 B |
| LinqAggregateInterpolation | .NET 6.0 | 10            |      2.735 μs |     0.1009 μs |     0.2846 μs |      2.700 μs |    4 |           - |          - |          - |      1352 B |
| StringBuilderConcatenation | .NET 6.0 | 100           |      2.884 μs |     0.0611 μs |     0.1417 μs |      2.900 μs |    5 |           - |          - |          - |      3024 B |
| LinqAggregateInterpolation | .NET 8.0 | 10            |      2.885 μs |     0.0636 μs |     0.1805 μs |      2.800 μs |    5 |           - |          - |          - |      1208 B |
| StringJoinToString         | .NET 8.0 | 100           |      2.911 μs |     0.0734 μs |     0.2047 μs |      2.800 μs |    5 |           - |          - |          - |      1424 B |
| StringConcat               | .NET 8.0 | 10            |      3.091 μs |     0.0633 μs |     0.1679 μs |      3.100 μs |    6 |           - |          - |          - |       568 B |
| StringJoinToString         | .NET 6.0 | 100           |      3.198 μs |     0.0676 μs |     0.1513 μs |      3.200 μs |    7 |           - |          - |          - |      1568 B |
| StringBuilderConcatenation | .NET 8.0 | 100           |      4.036 μs |     0.0864 μs |     0.2003 μs |      4.000 μs |    8 |           - |          - |          - |      2880 B |
| StringConcat               | .NET 6.0 | 100           |      4.325 μs |     0.1568 μs |     0.4131 μs |      4.300 μs |    9 |           - |          - |          - |      1608 B |
| StringConcat               | .NET 8.0 | 100           |      5.243 μs |     0.1118 μs |     0.3061 μs |      5.150 μs |   10 |           - |          - |          - |      1464 B |
| LinqAggregate              | .NET 6.0 | 100           |      9.790 μs |     0.2190 μs |     0.6212 μs |      9.700 μs |   11 |           - |          - |          - |     53552 B |
| LinqAggregateInterpolation | .NET 6.0 | 100           |      9.993 μs |     0.2229 μs |     0.6250 μs |     10.000 μs |   12 |           - |          - |          - |     53552 B |
| StringBuilderConcatenation | .NET 6.0 | 1000          |     11.913 μs |     0.2316 μs |     0.2167 μs |     11.900 μs |   13 |           - |          - |          - |     27672 B |
| StringJoinToString         | .NET 6.0 | 1000          |     12.882 μs |     0.2553 μs |     0.4404 μs |     12.800 μs |   14 |           - |          - |          - |     10568 B |
| StringConcat               | .NET 6.0 | 1000          |     15.988 μs |     0.2873 μs |     0.2399 μs |     15.950 μs |   15 |           - |          - |          - |     10608 B |
| StringJoinToString         | .NET 8.0 | 1000          |     16.213 μs |     1.2315 μs |     3.6311 μs |     17.900 μs |   16 |           - |          - |          - |     10424 B |
| StringConcat               | .NET 8.0 | 1000          |     20.608 μs |     0.2698 μs |     0.2253 μs |     20.600 μs |   17 |           - |          - |          - |     10464 B |
| LinqAggregateInterpolation | .NET 8.0 | 100           |     31.023 μs |     4.4246 μs |    12.9069 μs |     36.650 μs |   18 |           - |          - |          - |     53408 B |
| LinqAggregate              | .NET 8.0 | 100           |     32.423 μs |     4.2673 μs |    12.3801 μs |     36.900 μs |   18 |           - |          - |          - |     53408 B |
| StringBuilderConcatenation | .NET 8.0 | 1000          |     39.948 μs |     3.3497 μs |     9.7713 μs |     42.600 μs |   19 |           - |          - |          - |     27528 B |
| StringBuilderConcatenation | .NET 8.0 | 10000         |     78.993 μs |     1.0688 μs |     0.9474 μs |     79.100 μs |   20 |           - |          - |          - |    213960 B |
| StringBuilderConcatenation | .NET 6.0 | 10000         |     82.169 μs |     0.4072 μs |     0.3401 μs |     82.100 μs |   21 |           - |          - |          - |    214104 B |
| StringJoinToString         | .NET 8.0 | 10000         |     92.917 μs |     1.3401 μs |     1.9643 μs |     92.100 μs |   22 |           - |          - |          - |    100424 B |
| StringJoinToString         | .NET 6.0 | 10000         |    113.370 μs |     2.2513 μs |     4.0017 μs |    113.600 μs |   23 |           - |          - |          - |    100568 B |
| StringConcat               | .NET 6.0 | 10000         |    133.446 μs |     1.5862 μs |     1.3245 μs |    133.200 μs |   24 |           - |          - |          - |    100608 B |
| StringConcat               | .NET 8.0 | 10000         |    166.460 μs |     1.5799 μs |     1.4778 μs |    165.500 μs |   25 |           - |          - |          - |    100464 B |
| LinqAggregateInterpolation | .NET 8.0 | 1000          |    538.694 μs |    10.1837 μs |    10.8964 μs |    539.050 μs |   26 |   1000.0000 |          - |          - |   5030408 B |
| LinqAggregate              | .NET 8.0 | 1000          |    569.886 μs |    11.2756 μs |    16.1712 μs |    569.250 μs |   27 |   1000.0000 |          - |          - |   5030408 B |
| LinqAggregateInterpolation | .NET 6.0 | 1000          |    608.194 μs |    18.0695 μs |    52.1345 μs |    601.150 μs |   28 |   1000.0000 |          - |          - |   5030552 B |
| LinqAggregate              | .NET 6.0 | 1000          |    616.804 μs |    23.0297 μs |    66.0764 μs |    611.500 μs |   28 |   1000.0000 |          - |          - |   5030552 B |
| LinqAggregateInterpolation | .NET 6.0 | 10000         | 82,579.240 μs | 1,136.0779 μs | 1,062.6879 μs | 82,519.400 μs |   29 | 125000.0000 | 44000.0000 | 43000.0000 | 500314952 B |
| LinqAggregate              | .NET 8.0 | 10000         | 82,875.557 μs |   939.9437 μs |   833.2356 μs | 82,631.700 μs |   29 | 125000.0000 | 44000.0000 | 43000.0000 | 500314856 B |
| LinqAggregateInterpolation | .NET 8.0 | 10000         | 83,009.293 μs | 1,157.8793 μs | 1,026.4298 μs | 82,934.750 μs |   29 | 125000.0000 | 44000.0000 | 43000.0000 | 500314856 B |
| LinqAggregate              | .NET 6.0 | 10000         | 83,699.619 μs | 1,510.2472 μs | 1,483.2646 μs | 83,961.500 μs |   29 | 125000.0000 | 44000.0000 | 43000.0000 | 500314952 B |
