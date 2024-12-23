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
| Method   | Runtime  | ItemsToAdd | Mean           | Error        | StdDev       | Median         | Rank | Allocated |
|--------- |--------- |----------- |---------------:|-------------:|-------------:|---------------:|-----:|----------:|
| ListSort | .NET 6.0 | 10         |       795.0 ns |     19.42 ns |     22.36 ns |       800.0 ns |    1 |     640 B |
| LinqSort | .NET 9.0 | 10         |     1,097.9 ns |    102.69 ns |    294.63 ns |     1,100.0 ns |    2 |     208 B |
| LinqSort | .NET 9.0 | 100        |     1,098.0 ns |     75.76 ns |    223.37 ns |     1,050.0 ns |    2 |     496 B |
| LinqSort | .NET 6.0 | 10         |     1,100.0 ns |     43.19 ns |    121.11 ns |     1,100.0 ns |    2 |     696 B |
| LinqSort | .NET 8.0 | 100        |     1,149.0 ns |     72.05 ns |    210.18 ns |     1,200.0 ns |    2 |     456 B |
| LinqSort | .NET 8.0 | 1000       |     1,159.0 ns |     63.60 ns |    187.54 ns |     1,150.0 ns |    2 |     456 B |
| LinqSort | .NET 6.0 | 10000      |     1,166.7 ns |     27.17 ns |     64.05 ns |     1,200.0 ns |    2 |     696 B |
| LinqSort | .NET 6.0 | 1000       |     1,195.9 ns |     58.64 ns |    170.12 ns |     1,200.0 ns |    2 |     696 B |
| LinqSort | .NET 6.0 | 100        |     1,198.0 ns |     41.33 ns |    121.20 ns |     1,200.0 ns |    2 |     696 B |
| LinqSort | .NET 9.0 | 1000       |     1,242.0 ns |     82.68 ns |    243.78 ns |     1,200.0 ns |    2 |     208 B |
| LinqSort | .NET 9.0 | 10000      |     1,254.2 ns |     72.16 ns |    208.21 ns |     1,300.0 ns |    2 |     496 B |
| LinqSort | .NET 8.0 | 10         |     1,264.9 ns |     71.59 ns |    207.69 ns |     1,200.0 ns |    2 |     456 B |
| LinqSort | .NET 8.0 | 10000      |     1,476.8 ns |    118.08 ns |    338.79 ns |     1,400.0 ns |    2 |     456 B |
| ListSort | .NET 9.0 | 10         |     1,551.6 ns |     76.14 ns |    216.00 ns |     1,500.0 ns |    2 |     112 B |
| ListSort | .NET 8.0 | 10         |     1,684.5 ns |     69.18 ns |    200.70 ns |     1,700.0 ns |    2 |     400 B |
| ListSort | .NET 6.0 | 100        |     6,807.1 ns |    461.34 ns |  1,353.02 ns |     6,600.0 ns |    3 |     640 B |
| ListSort | .NET 9.0 | 100        |    17,835.6 ns |    577.49 ns |  1,609.82 ns |    18,300.0 ns |    4 |     400 B |
| ListSort | .NET 8.0 | 100        |    17,873.5 ns |    599.32 ns |  1,599.70 ns |    18,200.0 ns |    4 |     400 B |
| ListSort | .NET 6.0 | 1000       |    67,966.7 ns |  1,360.53 ns |  1,907.27 ns |    67,500.0 ns |    5 |     640 B |
| ListSort | .NET 8.0 | 1000       |   213,025.6 ns |  4,256.28 ns | 11,579.54 ns |   208,400.0 ns |    6 |     400 B |
| ListSort | .NET 9.0 | 1000       |   213,097.5 ns |  4,145.42 ns | 10,920.70 ns |   210,400.0 ns |    6 |     400 B |
| ListSort | .NET 6.0 | 10000      | 1,043,031.8 ns | 20,415.69 ns | 25,072.30 ns | 1,039,350.0 ns |    7 |     640 B |
| ListSort | .NET 9.0 | 10000      | 2,304,441.7 ns | 46,028.56 ns | 59,850.14 ns | 2,296,650.0 ns |    8 |     112 B |
| ListSort | .NET 8.0 | 10000      | 2,317,666.7 ns | 45,246.50 ns | 53,862.75 ns | 2,311,500.0 ns |    8 |     400 B |
