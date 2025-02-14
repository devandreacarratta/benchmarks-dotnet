```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-NTGRTK : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
  Job-DZAVPW : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-OBFGSV : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL

InvocationCount=1  UnrollFactor=1  

```
| Method             | Runtime  | NumberOfItems | Mean          | Error       | StdDev        | Median        | Rank | Allocated  |
|------------------- |--------- |-------------- |--------------:|------------:|--------------:|--------------:|-----:|-----------:|
| AddWithCapacity    | .NET 6.0 | 1000          |      6.132 μs |   0.5692 μs |     1.6604 μs |      5.050 μs |    1 |      640 B |
| AddWithoutCapacity | .NET 6.0 | 1000          |      7.907 μs |   0.1609 μs |     0.3022 μs |      7.900 μs |    2 |    17208 B |
| AddWithCapacity    | .NET 9.0 | 1000          |     18.551 μs |   0.6065 μs |     1.6704 μs |     18.000 μs |    3 |      400 B |
| AddWithoutCapacity | .NET 9.0 | 1000          |     20.139 μs |   0.4478 μs |     1.2335 μs |     19.800 μs |    4 |    16968 B |
| AddWithoutCapacity | .NET 8.0 | 1000          |     20.232 μs |   0.4095 μs |     1.0931 μs |     20.050 μs |    4 |    16968 B |
| AddWithCapacity    | .NET 8.0 | 1000          |     20.740 μs |   1.6689 μs |     4.6524 μs |     18.600 μs |    4 |       64 B |
| AddWithCapacity    | .NET 6.0 | 10000         |     44.795 μs |   0.8955 μs |     1.9467 μs |     45.100 μs |    5 |      640 B |
| AddWithCapacity    | .NET 8.0 | 10000         |     49.684 μs |   0.9949 μs |     2.2658 μs |     49.300 μs |    6 |      400 B |
| AddWithCapacity    | .NET 9.0 | 10000         |     58.993 μs |   2.6738 μs |     7.4092 μs |     55.400 μs |    7 |       64 B |
| AddWithoutCapacity | .NET 9.0 | 10000         |     63.546 μs |   1.2545 μs |     1.6312 μs |     63.350 μs |    7 |   262536 B |
| AddWithoutCapacity | .NET 6.0 | 10000         |     66.685 μs |   1.3141 μs |     1.8422 μs |     65.700 μs |    7 |   263064 B |
| AddWithoutCapacity | .NET 8.0 | 10000         |     66.714 μs |   1.1323 μs |     1.0037 μs |     66.750 μs |    7 |   262536 B |
| AddWithCapacity    | .NET 8.0 | 100000        |    376.587 μs |   7.3942 μs |     9.6146 μs |    379.350 μs |    8 |      400 B |
| AddWithCapacity    | .NET 9.0 | 100000        |    389.833 μs |  22.3753 μs |    65.6229 μs |    400.500 μs |    8 |      400 B |
| AddWithoutCapacity | .NET 9.0 | 100000        |    821.974 μs | 106.0765 μs |   312.7689 μs |    795.950 μs |    9 |  2097568 B |
| AddWithoutCapacity | .NET 8.0 | 100000        |    828.246 μs | 103.2437 μs |   302.7960 μs |    801.400 μs |    9 |  2097568 B |
| AddWithCapacity    | .NET 6.0 | 100000        |    901.060 μs |  16.7750 μs |    25.1081 μs |    900.250 μs |    9 |      640 B |
| AddWithoutCapacity | .NET 6.0 | 100000        |  1,373.810 μs | 100.4396 μs |   296.1486 μs |  1,491.200 μs |   10 |  2098144 B |
| AddWithCapacity    | .NET 9.0 | 1000000       |  3,497.070 μs | 159.3967 μs |   462.4386 μs |  3,606.500 μs |   11 |       64 B |
| AddWithCapacity    | .NET 8.0 | 1000000       |  3,748.924 μs | 180.0189 μs |   516.5080 μs |  3,898.000 μs |   11 |      400 B |
| AddWithoutCapacity | .NET 9.0 | 1000000       |  8,812.480 μs | 505.0484 μs | 1,465.2370 μs |  8,422.600 μs |   12 | 16777704 B |
| AddWithCapacity    | .NET 6.0 | 1000000       |  9,537.500 μs | 183.9725 μs |   196.8485 μs |  9,471.850 μs |   12 |      640 B |
| AddWithoutCapacity | .NET 8.0 | 1000000       |  9,616.679 μs | 626.4614 μs | 1,847.1358 μs |  9,920.550 μs |   12 | 16778040 B |
| AddWithoutCapacity | .NET 6.0 | 1000000       | 13,917.755 μs | 901.0565 μs | 2,656.7856 μs | 14,623.200 μs |   13 | 16778280 B |
