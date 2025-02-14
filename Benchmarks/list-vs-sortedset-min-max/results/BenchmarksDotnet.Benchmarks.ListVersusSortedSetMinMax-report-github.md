```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-QBPARD : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-JEZIMU : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-SLZKTL : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

```
| Method               | Runtime  | ItemsToAdd | Mean         | Error      | StdDev      | Median       | P95          | Rank | Allocated |
|--------------------- |--------- |----------- |-------------:|-----------:|------------:|-------------:|-------------:|-----:|----------:|
| MixItemFromList      | .NET 9.0 | 10         |     1.023 μs |  0.0496 μs |   0.1462 μs |     1.000 μs |     1.300 μs |    1 |     400 B |
| MixItemFromList      | .NET 8.0 | 10         |     1.081 μs |  0.0516 μs |   0.1522 μs |     1.000 μs |     1.400 μs |    1 |      64 B |
| MaxItemFromList      | .NET 9.0 | 100        |     1.092 μs |  0.0487 μs |   0.1412 μs |     1.000 μs |     1.400 μs |    1 |      64 B |
| MaxItemFromList      | .NET 8.0 | 100        |     1.137 μs |  0.0286 μs |   0.0727 μs |     1.100 μs |     1.300 μs |    1 |      64 B |
| MixItemFromList      | .NET 9.0 | 100        |     1.186 μs |  0.0578 μs |   0.1696 μs |     1.100 μs |     1.500 μs |    1 |     112 B |
| MaxItemFromList      | .NET 8.0 | 10         |     1.188 μs |  0.0468 μs |   0.1364 μs |     1.100 μs |     1.415 μs |    1 |      64 B |
| MaxItemFromList      | .NET 9.0 | 10         |     1.203 μs |  0.1037 μs |   0.3009 μs |     1.200 μs |     1.700 μs |    1 |     400 B |
| MixItemFromList      | .NET 8.0 | 100        |     1.211 μs |  0.0699 μs |   0.2029 μs |     1.150 μs |     1.570 μs |    1 |     400 B |
| MixItemFromList      | .NET 6.0 | 10         |     1.636 μs |  0.0609 μs |   0.1687 μs |     1.700 μs |     1.900 μs |    2 |     680 B |
| MaxItemFromList      | .NET 6.0 | 10         |     1.651 μs |  0.0580 μs |   0.1646 μs |     1.600 μs |     1.940 μs |    2 |     680 B |
| MaxItemFromList      | .NET 9.0 | 1000       |     2.179 μs |  0.0478 μs |   0.0686 μs |     2.200 μs |     2.300 μs |    3 |     400 B |
| MixItemFromList      | .NET 6.0 | 100        |     2.203 μs |  0.1182 μs |   0.3315 μs |     2.200 μs |     2.700 μs |    3 |     680 B |
| MaxItemFromList      | .NET 6.0 | 100        |     2.303 μs |  0.0601 μs |   0.1704 μs |     2.350 μs |     2.550 μs |    3 |     680 B |
| MaxItemFromList      | .NET 8.0 | 1000       |     2.355 μs |  0.0441 μs |   0.0760 μs |     2.350 μs |     2.500 μs |    3 |     400 B |
| MixItemFromList      | .NET 9.0 | 1000       |     2.543 μs |  0.1370 μs |   0.3975 μs |     2.350 μs |     3.250 μs |    3 |     400 B |
| MixItemFromList      | .NET 8.0 | 1000       |     2.801 μs |  0.1352 μs |   0.3965 μs |     2.800 μs |     3.400 μs |    3 |     400 B |
| MaxItemFromSortedSet | .NET 6.0 | 10         |     2.903 μs |  0.0830 μs |   0.2287 μs |     2.800 μs |     3.300 μs |    3 |     808 B |
| MinItemFromSortedSet | .NET 6.0 | 10         |     3.066 μs |  0.1954 μs |   0.5480 μs |     2.900 μs |     4.350 μs |    3 |     808 B |
| MinItemFromSortedSet | .NET 9.0 | 10         |     4.047 μs |  0.1058 μs |   0.2985 μs |     3.950 μs |     4.650 μs |    4 |     552 B |
| MaxItemFromSortedSet | .NET 9.0 | 10         |     4.136 μs |  0.0934 μs |   0.2725 μs |     4.100 μs |     4.700 μs |    4 |     552 B |
| MaxItemFromSortedSet | .NET 8.0 | 10         |     4.212 μs |  0.1117 μs |   0.3205 μs |     4.200 μs |     4.800 μs |    4 |     552 B |
| MinItemFromSortedSet | .NET 8.0 | 10         |     4.574 μs |  0.1672 μs |   0.4770 μs |     4.400 μs |     5.535 μs |    5 |     216 B |
| MaxItemFromSortedSet | .NET 6.0 | 100        |     5.518 μs |  0.1124 μs |   0.1999 μs |     5.500 μs |     5.805 μs |    6 |     856 B |
| MinItemFromSortedSet | .NET 6.0 | 100        |     7.398 μs |  0.8031 μs |   2.2783 μs |     6.100 μs |    11.420 μs |    6 |     856 B |
| MixItemFromList      | .NET 6.0 | 1000       |     8.600 μs |  0.1756 μs |   0.1803 μs |     8.600 μs |     8.840 μs |    7 |     680 B |
| MaxItemFromList      | .NET 6.0 | 1000       |     8.783 μs |  0.1069 μs |   0.0835 μs |     8.800 μs |     8.890 μs |    7 |     680 B |
| MaxItemFromSortedSet | .NET 9.0 | 100        |    12.184 μs |  0.2460 μs |   0.2734 μs |    12.100 μs |    12.610 μs |    8 |     312 B |
| MinItemFromSortedSet | .NET 9.0 | 100        |    12.535 μs |  0.2203 μs |   0.2262 μs |    12.500 μs |    12.920 μs |    8 |     264 B |
| MaxItemFromSortedSet | .NET 8.0 | 100        |    12.720 μs |  0.2532 μs |   0.4693 μs |    12.650 μs |    13.640 μs |    8 |     600 B |
| MixItemFromList      | .NET 9.0 | 10000      |    12.752 μs |  0.8355 μs |   2.3838 μs |    12.100 μs |    18.300 μs |    8 |     400 B |
| MinItemFromSortedSet | .NET 8.0 | 100        |    12.943 μs |  0.1941 μs |   0.3740 μs |    12.900 μs |    13.600 μs |    8 |     600 B |
| MaxItemFromList      | .NET 9.0 | 10000      |    12.985 μs |  0.7860 μs |   2.2425 μs |    12.650 μs |    17.235 μs |    8 |     400 B |
| MaxItemFromList      | .NET 8.0 | 10000      |    13.240 μs |  0.7391 μs |   2.1207 μs |    12.800 μs |    17.830 μs |    8 |     400 B |
| MixItemFromList      | .NET 8.0 | 10000      |    14.183 μs |  1.0644 μs |   3.0710 μs |    13.950 μs |    19.750 μs |    8 |     400 B |
| MaxItemFromSortedSet | .NET 6.0 | 1000       |    29.858 μs |  0.4282 μs |   0.3343 μs |    29.800 μs |    30.345 μs |    9 |     904 B |
| MinItemFromSortedSet | .NET 6.0 | 1000       |    30.000 μs |  0.5434 μs |   0.4243 μs |    30.000 μs |    30.545 μs |    9 |     904 B |
| MixItemFromList      | .NET 9.0 | 100000     |    41.647 μs |  3.7993 μs |  11.1426 μs |    46.800 μs |    57.590 μs |   10 |      64 B |
| MixItemFromList      | .NET 8.0 | 100000     |    44.119 μs |  3.9584 μs |  11.5469 μs |    49.100 μs |    59.985 μs |   10 |     400 B |
| MaxItemFromList      | .NET 9.0 | 100000     |    49.962 μs |  0.9574 μs |   1.6769 μs |    50.000 μs |    52.820 μs |   10 |     112 B |
| MaxItemFromList      | .NET 8.0 | 100000     |    58.093 μs |  0.7618 μs |   0.6754 μs |    58.200 μs |    58.905 μs |   11 |     400 B |
| MixItemFromList      | .NET 6.0 | 10000      |    70.694 μs |  1.3978 μs |   1.3728 μs |    69.750 μs |    72.500 μs |   12 |     680 B |
| MaxItemFromList      | .NET 6.0 | 10000      |    72.469 μs |  0.1235 μs |   0.1032 μs |    72.500 μs |    72.640 μs |   12 |     680 B |
| MinItemFromSortedSet | .NET 9.0 | 1000       |   100.210 μs |  1.9852 μs |   5.2646 μs |    99.200 μs |   113.470 μs |   13 |     648 B |
| MinItemFromSortedSet | .NET 8.0 | 1000       |   101.974 μs |  2.0374 μs |   5.7465 μs |   100.450 μs |   115.490 μs |   13 |     648 B |
| MaxItemFromSortedSet | .NET 8.0 | 1000       |   102.947 μs |  2.3105 μs |   6.3637 μs |   100.800 μs |   117.225 μs |   13 |     648 B |
| MaxItemFromSortedSet | .NET 9.0 | 1000       |   104.969 μs |  1.3185 μs |   1.1010 μs |   104.800 μs |   106.480 μs |   13 |     360 B |
| MinItemFromSortedSet | .NET 8.0 | 10000      |   182.622 μs | 44.1572 μs | 116.3278 μs |   146.900 μs |   582.200 μs |   14 |     712 B |
| MaxItemFromSortedSet | .NET 6.0 | 10000      |   235.508 μs |  8.9604 μs |  25.4193 μs |   225.100 μs |   280.940 μs |   15 |     968 B |
| MinItemFromSortedSet | .NET 9.0 | 10000      |   246.507 μs | 56.6223 μs | 161.5465 μs |   156.800 μs |   577.815 μs |   16 |     424 B |
| MinItemFromSortedSet | .NET 6.0 | 10000      |   274.713 μs |  3.9738 μs |   3.7171 μs |   273.100 μs |   281.100 μs |   17 |     968 B |
| MaxItemFromSortedSet | .NET 9.0 | 10000      |   589.480 μs |  9.4100 μs |   8.8021 μs |   587.600 μs |   603.940 μs |   18 |     712 B |
| MaxItemFromSortedSet | .NET 8.0 | 10000      |   617.932 μs | 12.1819 μs |  19.6715 μs |   620.500 μs |   647.815 μs |   18 |     712 B |
| MaxItemFromList      | .NET 6.0 | 100000     |   729.667 μs | 14.5337 μs |  30.9724 μs |   726.800 μs |   787.740 μs |   19 |     680 B |
| MixItemFromList      | .NET 6.0 | 100000     |   738.333 μs | 15.6952 μs |  44.2687 μs |   730.300 μs |   817.055 μs |   19 |     680 B |
| MinItemFromSortedSet | .NET 9.0 | 100000     | 1,102.879 μs | 21.5054 μs |  42.4496 μs | 1,097.700 μs | 1,156.760 μs |   20 |     424 B |
| MaxItemFromSortedSet | .NET 9.0 | 100000     | 1,109.279 μs | 22.0688 μs |  40.9059 μs | 1,113.000 μs | 1,188.060 μs |   20 |     472 B |
| MaxItemFromSortedSet | .NET 8.0 | 100000     | 1,110.679 μs | 14.2220 μs |  12.6075 μs | 1,106.950 μs | 1,130.340 μs |   20 |     760 B |
| MinItemFromSortedSet | .NET 8.0 | 100000     | 1,111.246 μs | 22.1324 μs |  44.7085 μs | 1,104.550 μs | 1,182.950 μs |   20 |     760 B |
| MaxItemFromSortedSet | .NET 6.0 | 100000     | 2,215.319 μs | 43.9164 μs |  80.3037 μs | 2,212.750 μs | 2,353.055 μs |   21 |    1016 B |
| MinItemFromSortedSet | .NET 6.0 | 100000     | 2,284.387 μs | 44.3684 μs |  69.0763 μs | 2,285.850 μs | 2,410.965 μs |   21 |    1016 B |
