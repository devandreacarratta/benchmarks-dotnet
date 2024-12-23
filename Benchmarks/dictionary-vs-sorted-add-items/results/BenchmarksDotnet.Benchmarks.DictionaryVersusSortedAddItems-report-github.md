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
| AddToDictionary       | .NET 6.0 | 10         |     1.812 μs |   0.0529 μs |   0.1536 μs |     1.800 μs |    1 |    1336 B |
| AddToSortedDictionary | .NET 6.0 | 10         |     2.432 μs |   0.0730 μs |   0.2105 μs |     2.400 μs |    2 |    1120 B |
| AddToDictionary       | .NET 9.0 | 10         |     2.529 μs |   0.0802 μs |   0.2327 μs |     2.500 μs |    2 |    1096 B |
| AddToDictionary       | .NET 8.0 | 10         |     2.843 μs |   0.0959 μs |   0.2784 μs |     2.800 μs |    3 |    1096 B |
| AddToSortedDictionary | .NET 9.0 | 10         |     4.253 μs |   0.0900 μs |   0.2121 μs |     4.200 μs |    4 |     592 B |
| AddToDictionary       | .NET 9.0 | 100        |     4.362 μs |   0.1234 μs |   0.3581 μs |     4.300 μs |    4 |    7712 B |
| AddToDictionary       | .NET 6.0 | 100        |     4.439 μs |   0.3436 μs |   1.0078 μs |     4.900 μs |    4 |    7952 B |
| AddToSortedDictionary | .NET 8.0 | 10         |     4.559 μs |   0.1116 μs |   0.3130 μs |     4.600 μs |    4 |    1120 B |
| AddToDictionary       | .NET 8.0 | 100        |     4.597 μs |   0.1345 μs |   0.3815 μs |     4.500 μs |    4 |    7712 B |
| AddToSortedDictionary | .NET 6.0 | 100        |    17.280 μs |   0.3341 μs |   0.3847 μs |    17.200 μs |    5 |    5440 B |
| AddToDictionary       | .NET 6.0 | 1000       |    18.151 μs |   0.3623 μs |   0.5953 μs |    18.000 μs |    5 |   73728 B |
| AddToDictionary       | .NET 8.0 | 1000       |    25.041 μs |   0.5049 μs |   1.4076 μs |    24.800 μs |    6 |   73488 B |
| AddToDictionary       | .NET 9.0 | 1000       |    25.413 μs |   0.5938 μs |   1.7038 μs |    24.950 μs |    6 |   73488 B |
| AddToSortedDictionary | .NET 8.0 | 100        |    44.436 μs |   0.8733 μs |   1.2525 μs |    44.400 μs |    7 |    7600 B |
| AddToSortedDictionary | .NET 9.0 | 100        |    44.937 μs |   0.8892 μs |   1.2466 μs |    44.400 μs |    7 |    5200 B |
| AddToDictionary       | .NET 9.0 | 10000      |   199.171 μs |   2.0878 μs |   1.8507 μs |   199.000 μs |    8 |  673384 B |
| AddToDictionary       | .NET 8.0 | 10000      |   204.894 μs |   4.0865 μs |   8.2549 μs |   201.800 μs |    8 |  673384 B |
| AddToDictionary       | .NET 6.0 | 10000      |   205.814 μs |   3.9797 μs |   9.7623 μs |   201.400 μs |    8 |  673624 B |
| AddToSortedDictionary | .NET 6.0 | 1000       |   219.008 μs |   3.4844 μs |   2.9096 μs |   217.800 μs |    9 |   48640 B |
| AddToSortedDictionary | .NET 8.0 | 1000       |   563.158 μs |   5.1782 μs |   4.0428 μs |   563.850 μs |   10 |   72376 B |
| AddToSortedDictionary | .NET 9.0 | 1000       |   572.957 μs |   7.7399 μs |   6.8612 μs |   570.450 μs |   10 |   48112 B |
| AddToSortedDictionary | .NET 6.0 | 10000      | 2,300.974 μs | 218.0011 μs | 628.9830 μs | 1,909.850 μs |   11 |  480640 B |
| AddToSortedDictionary | .NET 8.0 | 10000      | 6,733.393 μs |  91.3417 μs |  80.9720 μs | 6,741.500 μs |   12 |  504376 B |
| AddToSortedDictionary | .NET 9.0 | 10000      | 6,915.979 μs | 119.2186 μs | 105.6842 μs | 6,944.650 μs |   12 |  480400 B |
