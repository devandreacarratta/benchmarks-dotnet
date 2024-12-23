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
| Method               | Runtime  | ItemsToAdd | Mean          | Error       | StdDev      | Median        | Rank | Gen0      | Gen1      | Gen2      | Allocated |
|--------------------- |--------- |----------- |--------------:|------------:|------------:|--------------:|-----:|----------:|----------:|----------:|----------:|
| IEnumerableWithYield | .NET 6.0 | 10         |      1.171 μs |   0.0273 μs |   0.0705 μs |      1.200 μs |    1 |         - |         - |         - |     680 B |
| IEnumerableWithYield | .NET 9.0 | 10         |      1.710 μs |   0.0752 μs |   0.2169 μs |      1.700 μs |    2 |         - |         - |         - |     152 B |
| IEnumerableWithYield | .NET 6.0 | 100        |      1.736 μs |   0.0384 μs |   0.0776 μs |      1.700 μs |    2 |         - |         - |         - |     680 B |
| IEnumerableWithYield | .NET 8.0 | 10         |      1.761 μs |   0.0678 μs |   0.1977 μs |      1.700 μs |    2 |         - |         - |         - |     440 B |
| IEnumerableWithList  | .NET 6.0 | 10         |      2.110 μs |   0.1028 μs |   0.2883 μs |      2.000 μs |    3 |         - |         - |         - |     864 B |
| IEnumerableWithList  | .NET 6.0 | 100        |      2.731 μs |   0.0575 μs |   0.0480 μs |      2.700 μs |    4 |         - |         - |         - |    1832 B |
| IEnumerableWithList  | .NET 9.0 | 10         |      2.967 μs |   0.0804 μs |   0.2345 μs |      2.950 μs |    4 |         - |         - |         - |     288 B |
| IEnumerableWithList  | .NET 8.0 | 10         |      3.121 μs |   0.0693 μs |   0.1989 μs |      3.100 μs |    4 |         - |         - |         - |     624 B |
| IEnumerableWithYield | .NET 9.0 | 100        |      4.725 μs |   0.0992 μs |   0.2157 μs |      4.700 μs |    5 |         - |         - |         - |     152 B |
| IEnumerableWithYield | .NET 8.0 | 100        |      5.420 μs |   0.2310 μs |   0.6738 μs |      5.200 μs |    6 |         - |         - |         - |     440 B |
| IEnumerableWithYield | .NET 6.0 | 1000       |      6.393 μs |   0.1125 μs |   0.0997 μs |      6.400 μs |    7 |         - |         - |         - |     680 B |
| IEnumerableWithList  | .NET 9.0 | 100        |      6.610 μs |   0.1341 μs |   0.2384 μs |      6.600 μs |    7 |         - |         - |         - |    1592 B |
| IEnumerableWithList  | .NET 8.0 | 100        |      7.261 μs |   0.2290 μs |   0.6532 μs |      7.100 μs |    7 |         - |         - |         - |    1592 B |
| IEnumerableWithList  | .NET 6.0 | 1000       |     17.060 μs |   1.9054 μs |   5.5279 μs |     17.000 μs |    8 |         - |         - |         - |    9072 B |
| IEnumerableWithYield | .NET 8.0 | 1000       |     40.440 μs |   0.9129 μs |   2.6192 μs |     39.600 μs |    9 |         - |         - |         - |     440 B |
| IEnumerableWithYield | .NET 9.0 | 1000       |     43.402 μs |   1.8794 μs |   5.4526 μs |     40.700 μs |    9 |         - |         - |         - |     152 B |
| IEnumerableWithList  | .NET 9.0 | 1000       |     46.827 μs |   0.9304 μs |   1.8366 μs |     46.200 μs |   10 |         - |         - |         - |    8544 B |
| IEnumerableWithList  | .NET 8.0 | 1000       |     49.448 μs |   1.9376 μs |   5.5903 μs |     46.150 μs |   10 |         - |         - |         - |    8496 B |
| IEnumerableWithYield | .NET 6.0 | 10000      |     52.514 μs |   0.0748 μs |   0.0663 μs |     52.500 μs |   10 |         - |         - |         - |     680 B |
| IEnumerableWithYield | .NET 9.0 | 10000      |     67.621 μs |   1.1573 μs |   1.0260 μs |     67.900 μs |   11 |         - |         - |         - |     440 B |
| IEnumerableWithYield | .NET 8.0 | 10000      |     68.107 μs |   0.8539 μs |   0.7570 μs |     68.000 μs |   11 |         - |         - |         - |     440 B |
| IEnumerableWithList  | .NET 9.0 | 10000      |     88.313 μs |   1.7310 μs |   3.5747 μs |     87.850 μs |   12 |         - |         - |         - |  131808 B |
| IEnumerableWithList  | .NET 6.0 | 10000      |     93.711 μs |   1.7843 μs |   1.9832 μs |     93.500 μs |   12 |         - |         - |         - |  132048 B |
| IEnumerableWithList  | .NET 8.0 | 10000      |     97.153 μs |   1.7463 μs |   2.6137 μs |     97.100 μs |   12 |         - |         - |         - |  131808 B |
| IEnumerableWithYield | .NET 8.0 | 100000     |    288.600 μs |   4.4733 μs |   3.7354 μs |    287.000 μs |   13 |         - |         - |         - |     104 B |
| IEnumerableWithYield | .NET 9.0 | 100000     |    312.871 μs |   1.5020 μs |   1.3315 μs |    312.900 μs |   14 |         - |         - |         - |     440 B |
| IEnumerableWithYield | .NET 6.0 | 100000     |    516.529 μs |   1.2048 μs |   1.0680 μs |    515.900 μs |   15 |         - |         - |         - |     680 B |
| IEnumerableWithList  | .NET 9.0 | 100000     |    777.984 μs |  23.1979 μs |  63.1115 μs |    759.700 μs |   16 |         - |         - |         - | 1049096 B |
| IEnumerableWithList  | .NET 8.0 | 100000     |    874.398 μs |  17.4896 μs |  40.5349 μs |    873.050 μs |   17 |         - |         - |         - | 1049384 B |
| IEnumerableWithList  | .NET 6.0 | 100000     |  1,150.907 μs |  20.0879 μs |  18.7902 μs |  1,155.400 μs |   18 |         - |         - |         - | 1049624 B |
| IEnumerableWithYield | .NET 8.0 | 1000000    |  2,467.000 μs |  36.3753 μs |  32.2457 μs |  2,457.000 μs |   19 |         - |         - |         - |     440 B |
| IEnumerableWithYield | .NET 9.0 | 1000000    |  2,773.871 μs |  52.6763 μs |  54.0946 μs |  2,778.300 μs |   20 |         - |         - |         - |     440 B |
| IEnumerableWithYield | .NET 6.0 | 1000000    |  5,100.621 μs |  94.4639 μs |  83.7398 μs |  5,122.200 μs |   21 |         - |         - |         - |     680 B |
| IEnumerableWithList  | .NET 9.0 | 1000000    |  7,216.828 μs | 135.0754 μs | 281.9527 μs |  7,242.100 μs |   22 | 1000.0000 | 1000.0000 | 1000.0000 | 8389488 B |
| IEnumerableWithList  | .NET 8.0 | 1000000    |  8,323.911 μs | 165.6081 μs | 281.2152 μs |  8,324.100 μs |   23 | 1000.0000 | 1000.0000 | 1000.0000 | 8389824 B |
| IEnumerableWithList  | .NET 6.0 | 1000000    | 11,663.507 μs | 209.7885 μs | 196.2363 μs | 11,692.800 μs |   24 | 1000.0000 | 1000.0000 | 1000.0000 | 8390064 B |
