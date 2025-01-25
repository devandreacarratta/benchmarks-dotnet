```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4751/23H2/2023Update/SunValley3)
Apple Silicon, 4 CPU, 4 logical and 4 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 6.0.36 (6.0.3624.51421), Arm64 RyuJIT AdvSIMD [AttachedDebugger]
  Job-MVMOVR : .NET 9.0.1 (9.0.124.61010), Arm64 RyuJIT AdvSIMD
  Job-KUKZGB : .NET 8.0.12 (8.0.1224.60305), Arm64 RyuJIT AdvSIMD

InvocationCount=1  UnrollFactor=1  

```
| Method         | Runtime  | ItemsToAdd | Mean        | Error     | StdDev    | Rank | Allocated  |
|--------------- |--------- |----------- |------------:|----------:|----------:|-----:|-----------:|
| OrderByRandom  | .NET 9.0 | 1000       |    204.9 μs |   4.09 μs |  11.52 μs |    1 |   16.34 KB |
| OrderByRandom  | .NET 8.0 | 1000       |    213.1 μs |   4.58 μs |  13.42 μs |    1 |   16.31 KB |
| OrderByNewGuid | .NET 8.0 | 1000       |    331.2 μs |   6.56 μs |   8.52 μs |    2 |   28.02 KB |
| OrderByNewGuid | .NET 9.0 | 1000       |    342.8 μs |   6.77 μs |  13.82 μs |    2 |   28.05 KB |
| OrderByRandom  | .NET 9.0 | 10000      |  2,563.3 μs |  49.46 μs |  66.03 μs |    3 |  156.97 KB |
| OrderByRandom  | .NET 8.0 | 10000      |  2,600.1 μs |  50.77 μs |  58.47 μs |    3 |  156.94 KB |
| OrderByNewGuid | .NET 9.0 | 10000      |  3,937.4 μs |  74.24 μs |  82.52 μs |    4 |  274.14 KB |
| OrderByNewGuid | .NET 8.0 | 10000      |  3,966.7 μs |  78.93 μs |  99.83 μs |    4 |  274.11 KB |
| OrderByRandom  | .NET 8.0 | 100000     |  7,685.2 μs | 134.02 μs | 125.36 μs |    5 | 1563.19 KB |
| OrderByRandom  | .NET 9.0 | 100000     |  8,796.6 μs | 152.39 μs | 142.54 μs |    6 | 1563.22 KB |
| OrderByNewGuid | .NET 9.0 | 100000     | 15,044.2 μs | 143.17 μs | 126.91 μs |    7 | 2735.08 KB |
| OrderByNewGuid | .NET 8.0 | 100000     | 16,232.3 μs | 193.29 μs | 180.80 μs |    8 | 2735.05 KB |
