```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-OBFGSV : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-NTGRTK : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
  Job-DZAVPW : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL

InvocationCount=1  UnrollFactor=1  

```
| Method                  | Runtime  | NumberOfItems | Mean         | Error      | StdDev     | Median       | Rank | Allocated |
|------------------------ |--------- |-------------- |-------------:|-----------:|-----------:|-------------:|-----:|----------:|
| AddRangeWithCapacity    | .NET 8.0 | 1000          |     1.181 μs |  0.0572 μs |  0.1676 μs |     1.100 μs |    1 |     400 B |
| AddRangeWithCapacity    | .NET 6.0 | 1000          |     1.283 μs |  0.0835 μs |  0.2450 μs |     1.200 μs |    1 |     640 B |
| AddRangeWithCapacity    | .NET 9.0 | 1000          |     1.355 μs |  0.1024 μs |  0.2988 μs |     1.300 μs |    1 |     112 B |
| AddRangeWithoutCapacity | .NET 6.0 | 1000          |     1.995 μs |  0.0741 μs |  0.2103 μs |     1.900 μs |    2 |    8664 B |
| AddRangeWithoutCapacity | .NET 9.0 | 1000          |     2.380 μs |  0.0838 μs |  0.2364 μs |     2.350 μs |    3 |    8136 B |
| AddRangeWithoutCapacity | .NET 8.0 | 1000          |     2.409 μs |  0.0554 μs |  0.1554 μs |     2.400 μs |    3 |    8424 B |
| AddRangeWithCapacity    | .NET 8.0 | 10000         |     6.276 μs |  0.1312 μs |  0.2229 μs |     6.300 μs |    4 |     400 B |
| AddRangeWithCapacity    | .NET 6.0 | 10000         |     6.353 μs |  0.1269 μs |  0.1187 μs |     6.300 μs |    4 |     640 B |
| AddRangeWithCapacity    | .NET 9.0 | 10000         |     8.483 μs |  0.7037 μs |  2.0303 μs |     7.650 μs |    5 |     112 B |
| AddRangeWithoutCapacity | .NET 6.0 | 10000         |    11.897 μs |  0.2432 μs |  0.3927 μs |    11.800 μs |    6 |   80664 B |
| AddRangeWithoutCapacity | .NET 8.0 | 10000         |    12.033 μs |  0.2274 μs |  0.1775 μs |    12.050 μs |    6 |   80424 B |
| AddRangeWithoutCapacity | .NET 9.0 | 10000         |    13.068 μs |  0.4777 μs |  1.3396 μs |    12.800 μs |    6 |   80136 B |
| AddRangeWithCapacity    | .NET 6.0 | 100000        |   109.629 μs |  2.1899 μs |  4.2712 μs |   108.950 μs |    7 |     640 B |
| AddRangeWithCapacity    | .NET 8.0 | 100000        |   110.820 μs |  2.1405 μs |  3.8598 μs |   110.800 μs |    7 |     400 B |
| AddRangeWithCapacity    | .NET 9.0 | 100000        |   115.138 μs |  3.1317 μs |  9.1847 μs |   112.450 μs |    7 |     400 B |
| AddRangeWithoutCapacity | .NET 9.0 | 100000        |   120.643 μs |  2.3822 μs |  2.1118 μs |   120.950 μs |    7 |  800088 B |
| AddRangeWithoutCapacity | .NET 8.0 | 100000        |   121.689 μs |  3.0747 μs |  8.8219 μs |   117.800 μs |    7 |  800424 B |
| AddRangeWithoutCapacity | .NET 6.0 | 100000        |   121.906 μs |  2.3229 μs |  3.6165 μs |   121.100 μs |    7 |  800664 B |
| AddRangeWithCapacity    | .NET 6.0 | 1000000       | 1,111.280 μs | 22.1580 μs | 20.7266 μs | 1,105.600 μs |    8 |     640 B |
| AddRangeWithCapacity    | .NET 8.0 | 1000000       | 1,112.694 μs | 17.8301 μs | 19.0780 μs | 1,110.500 μs |    8 |     400 B |
| AddRangeWithCapacity    | .NET 9.0 | 1000000       | 1,120.138 μs | 20.9333 μs | 20.5593 μs | 1,118.900 μs |    8 |     400 B |
| AddRangeWithoutCapacity | .NET 9.0 | 1000000       | 1,325.600 μs | 23.9842 μs | 20.0279 μs | 1,319.000 μs |    9 | 8000088 B |
| AddRangeWithoutCapacity | .NET 6.0 | 1000000       | 1,328.773 μs | 24.5500 μs | 40.3363 μs | 1,326.550 μs |    9 | 8000664 B |
| AddRangeWithoutCapacity | .NET 8.0 | 1000000       | 1,351.015 μs | 26.3542 μs | 41.8006 μs | 1,340.700 μs |    9 | 8000424 B |
