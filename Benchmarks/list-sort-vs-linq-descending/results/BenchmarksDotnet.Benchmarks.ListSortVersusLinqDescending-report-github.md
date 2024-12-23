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
| ListSort | .NET 6.0 | 10         |       851.8 ns |     23.95 ns |     64.76 ns |       800.0 ns |    1 |     640 B |
| LinqSort | .NET 9.0 | 100        |       919.0 ns |     28.95 ns |     75.24 ns |       900.0 ns |    1 |     496 B |
| LinqSort | .NET 9.0 | 10         |     1,059.2 ns |     58.00 ns |    169.19 ns |     1,000.0 ns |    1 |     496 B |
| LinqSort | .NET 9.0 | 1000       |     1,136.9 ns |     97.01 ns |    284.51 ns |     1,050.0 ns |    1 |     496 B |
| LinqSort | .NET 9.0 | 10000      |     1,145.8 ns |     72.34 ns |    208.71 ns |     1,100.0 ns |    1 |     208 B |
| LinqSort | .NET 8.0 | 100        |     1,183.0 ns |     74.06 ns |    218.38 ns |     1,100.0 ns |    1 |     456 B |
| LinqSort | .NET 8.0 | 10         |     1,196.8 ns |     46.44 ns |    133.25 ns |     1,200.0 ns |    1 |     456 B |
| LinqSort | .NET 6.0 | 10         |     1,206.4 ns |     51.86 ns |    147.97 ns |     1,200.0 ns |    1 |     696 B |
| LinqSort | .NET 6.0 | 1000       |     1,226.3 ns |     66.89 ns |    196.18 ns |     1,200.0 ns |    1 |     696 B |
| LinqSort | .NET 6.0 | 100        |     1,226.3 ns |     37.08 ns |    106.40 ns |     1,200.0 ns |    1 |     696 B |
| LinqSort | .NET 6.0 | 10000      |     1,258.9 ns |     41.96 ns |    116.98 ns |     1,300.0 ns |    1 |     696 B |
| LinqSort | .NET 8.0 | 10000      |     1,308.6 ns |     66.49 ns |    188.62 ns |     1,300.0 ns |    1 |     456 B |
| LinqSort | .NET 8.0 | 1000       |     1,367.7 ns |    102.01 ns |    294.33 ns |     1,300.0 ns |    1 |     456 B |
| ListSort | .NET 9.0 | 10         |     1,794.8 ns |     62.68 ns |    180.86 ns |     1,800.0 ns |    2 |     400 B |
| ListSort | .NET 8.0 | 10         |     2,065.6 ns |     78.12 ns |    225.40 ns |     2,050.0 ns |    3 |     400 B |
| ListSort | .NET 6.0 | 100        |     5,242.9 ns |    107.75 ns |    177.04 ns |     5,200.0 ns |    4 |     640 B |
| ListSort | .NET 9.0 | 100        |    18,586.5 ns |    602.45 ns |  1,669.39 ns |    19,100.0 ns |    5 |      64 B |
| ListSort | .NET 8.0 | 100        |    18,721.6 ns |    506.64 ns |  1,453.66 ns |    18,950.0 ns |    5 |     400 B |
| ListSort | .NET 6.0 | 1000       |    67,750.0 ns |  1,225.99 ns |  1,086.81 ns |    67,500.0 ns |    6 |     640 B |
| ListSort | .NET 8.0 | 1000       |   217,845.2 ns |  4,153.83 ns | 10,344.47 ns |   214,700.0 ns |    7 |     400 B |
| ListSort | .NET 9.0 | 1000       |   235,057.8 ns |  5,498.53 ns | 15,327.71 ns |   234,950.0 ns |    8 |      64 B |
| ListSort | .NET 6.0 | 10000      |   896,350.0 ns | 15,639.00 ns | 21,406.84 ns |   893,950.0 ns |    9 |     640 B |
| ListSort | .NET 9.0 | 10000      | 2,285,613.5 ns | 45,467.17 ns | 77,206.72 ns | 2,280,700.0 ns |   10 |     400 B |
| ListSort | .NET 8.0 | 10000      | 2,297,317.4 ns | 45,721.22 ns | 57,822.70 ns | 2,296,600.0 ns |   10 |     400 B |
