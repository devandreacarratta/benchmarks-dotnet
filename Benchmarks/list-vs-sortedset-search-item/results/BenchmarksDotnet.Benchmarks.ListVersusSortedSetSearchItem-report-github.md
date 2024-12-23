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
| Method                    | Runtime  | ItemsToAdd | Mean           | Error         | StdDev        | Median         | Rank | Allocated |
|-------------------------- |--------- |----------- |---------------:|--------------:|--------------:|---------------:|-----:|----------:|
| ContainsItemFromSortedSet | .NET 6.0 | 10         |       157.0 ns |      23.25 ns |      68.54 ns |       100.0 ns |    1 |     640 B |
| ContainsItemFromSortedSet | .NET 6.0 | 100        |       167.0 ns |      21.53 ns |      62.45 ns |       200.0 ns |    1 |     640 B |
| ContainsItemFromList      | .NET 6.0 | 10         |       242.0 ns |      21.65 ns |      63.85 ns |       200.0 ns |    2 |     640 B |
| ContainsItemFromList      | .NET 6.0 | 100        |       291.9 ns |      32.19 ns |      94.41 ns |       300.0 ns |    2 |     640 B |
| ContainsItemFromList      | .NET 9.0 | 100        |       320.2 ns |      43.56 ns |     127.76 ns |       300.0 ns |    2 |     400 B |
| ContainsItemFromSortedSet | .NET 6.0 | 1000       |       333.7 ns |      29.47 ns |      84.56 ns |       300.0 ns |    2 |     640 B |
| ContainsItemFromList      | .NET 9.0 | 10         |       337.8 ns |      25.35 ns |      73.94 ns |       300.0 ns |    2 |     400 B |
| ContainsItemFromList      | .NET 8.0 | 10         |       351.5 ns |      26.38 ns |      76.53 ns |       300.0 ns |    2 |     400 B |
| ContainsItemFromList      | .NET 9.0 | 1000       |       411.1 ns |      40.40 ns |     112.62 ns |       400.0 ns |    3 |     400 B |
| ContainsItemFromList      | .NET 8.0 | 100        |       419.6 ns |      24.19 ns |      70.18 ns |       400.0 ns |    3 |     400 B |
| ContainsItemFromSortedSet | .NET 8.0 | 10         |       428.9 ns |      36.57 ns |     101.94 ns |       400.0 ns |    3 |     400 B |
| ContainsItemFromList      | .NET 6.0 | 1000       |       435.2 ns |      37.73 ns |     105.80 ns |       500.0 ns |    3 |     640 B |
| ContainsItemFromSortedSet | .NET 9.0 | 100        |       455.7 ns |      26.89 ns |      74.06 ns |       500.0 ns |    3 |     400 B |
| ContainsItemFromSortedSet | .NET 8.0 | 100        |       541.9 ns |      31.75 ns |      90.08 ns |       500.0 ns |    3 |     400 B |
| ContainsItemFromList      | .NET 8.0 | 1000       |       553.8 ns |      65.03 ns |     184.48 ns |       500.0 ns |    3 |     400 B |
| ContainsItemFromSortedSet | .NET 9.0 | 10         |       566.0 ns |      49.97 ns |     144.98 ns |       600.0 ns |    3 |     400 B |
| ContainsItemFromSortedSet | .NET 6.0 | 10000      |       594.7 ns |      85.58 ns |     245.54 ns |       500.0 ns |    3 |     640 B |
| ContainsItemFromSortedSet | .NET 9.0 | 1000       |       716.3 ns |      55.20 ns |     155.68 ns |       700.0 ns |    4 |     112 B |
| ContainsItemFromSortedSet | .NET 8.0 | 1000       |       730.6 ns |      54.46 ns |     158.87 ns |       700.0 ns |    4 |     400 B |
| ExistsItemFromList        | .NET 9.0 | 100        |       975.8 ns |      60.31 ns |     173.03 ns |       900.0 ns |    5 |     464 B |
| ExistsItemFromList        | .NET 9.0 | 10         |     1,035.7 ns |      64.42 ns |     187.91 ns |     1,000.0 ns |    5 |     464 B |
| ExistsItemFromList        | .NET 6.0 | 10         |     1,114.1 ns |      47.47 ns |     133.90 ns |     1,100.0 ns |    5 |     704 B |
| ExistsItemFromList        | .NET 6.0 | 100        |     1,114.3 ns |      39.99 ns |     116.65 ns |     1,100.0 ns |    5 |     704 B |
| ExistsItemFromList        | .NET 8.0 | 10         |     1,178.7 ns |      61.01 ns |     174.05 ns |     1,200.0 ns |    5 |     464 B |
| ExistsItemFromList        | .NET 8.0 | 100        |     1,189.1 ns |      56.23 ns |     158.60 ns |     1,200.0 ns |    5 |     464 B |
| ContainsItemFromSortedSet | .NET 8.0 | 10000      |     1,203.4 ns |     122.31 ns |     338.93 ns |     1,100.0 ns |    5 |     400 B |
| ContainsItemFromSortedSet | .NET 9.0 | 10000      |     1,422.0 ns |     140.63 ns |     394.35 ns |     1,300.0 ns |    5 |     400 B |
| ContainsItemFromSortedSet | .NET 6.0 | 100000     |     1,432.7 ns |     153.61 ns |     448.08 ns |     1,300.0 ns |    5 |     640 B |
| AnyItemFromList           | .NET 9.0 | 10         |     1,551.0 ns |      91.99 ns |     268.35 ns |     1,500.0 ns |    5 |     176 B |
| AnyItemFromList           | .NET 6.0 | 10         |     1,598.9 ns |      55.08 ns |     152.62 ns |     1,600.0 ns |    5 |     744 B |
| AnyItemFromList           | .NET 8.0 | 10         |     1,852.1 ns |     100.07 ns |     288.73 ns |     1,850.0 ns |    6 |     504 B |
| AnyItemFromList           | .NET 6.0 | 100        |     1,921.9 ns |     100.98 ns |     291.35 ns |     1,900.0 ns |    6 |     744 B |
| ContainsItemFromSortedSet | .NET 9.0 | 100000     |     2,224.2 ns |     605.69 ns |   1,776.38 ns |     2,700.0 ns |    7 |     112 B |
| ExistsItemFromList        | .NET 6.0 | 1000       |     2,284.6 ns |     237.21 ns |     665.15 ns |     2,200.0 ns |    7 |     704 B |
| ExistsItemFromList        | .NET 9.0 | 1000       |     2,333.7 ns |     294.49 ns |     844.96 ns |     2,300.0 ns |    7 |     464 B |
| AnyItemFromList           | .NET 9.0 | 100        |     2,362.6 ns |     218.79 ns |     641.68 ns |     2,400.0 ns |    7 |     464 B |
| ExistsItemFromList        | .NET 8.0 | 1000       |     2,405.4 ns |     271.77 ns |     766.52 ns |     2,350.0 ns |    7 |     464 B |
| ContainsItemFromSortedSet | .NET 8.0 | 100000     |     2,500.0 ns |     565.05 ns |   1,657.20 ns |     3,000.0 ns |    7 |     400 B |
| ContainsItemFromList      | .NET 8.0 | 10000      |     2,631.6 ns |     387.32 ns |   1,111.28 ns |     2,500.0 ns |    7 |      64 B |
| AnyItemFromSortedSet      | .NET 6.0 | 10         |     2,640.2 ns |      75.23 ns |     218.26 ns |     2,600.0 ns |    7 |     872 B |
| AnyItemFromSortedSet      | .NET 9.0 | 10         |     3,774.2 ns |     150.84 ns |     437.63 ns |     3,800.0 ns |    8 |     328 B |
| AnyItemFromSortedSet      | .NET 6.0 | 100        |     3,994.9 ns |     301.90 ns |     885.41 ns |     3,900.0 ns |    8 |     920 B |
| ContainsItemFromList      | .NET 6.0 | 10000      |     4,061.6 ns |     714.72 ns |   2,096.14 ns |     3,700.0 ns |    8 |     640 B |
| AnyItemFromSortedSet      | .NET 8.0 | 10         |     4,207.6 ns |     259.54 ns |     732.04 ns |     4,100.0 ns |    8 |     616 B |
| ContainsItemFromList      | .NET 9.0 | 10000      |     4,821.6 ns |   1,237.36 ns |   3,589.81 ns |     3,600.0 ns |    8 |     400 B |
| AnyItemFromList           | .NET 8.0 | 100        |     5,190.9 ns |     688.65 ns |   2,019.70 ns |     5,300.0 ns |    9 |     168 B |
| AnyItemFromList           | .NET 6.0 | 1000       |     6,641.4 ns |   1,169.41 ns |   3,317.43 ns |     6,150.0 ns |    9 |     744 B |
| AnyItemFromSortedSet      | .NET 9.0 | 100        |     8,843.0 ns |   1,179.49 ns |   3,477.76 ns |     8,600.0 ns |   10 |     376 B |
| AnyItemFromSortedSet      | .NET 8.0 | 100        |     9,692.6 ns |   1,266.80 ns |   3,614.26 ns |     9,300.0 ns |   10 |     664 B |
| ExistsItemFromList        | .NET 9.0 | 10000      |    12,026.4 ns |   2,153.04 ns |   6,037.36 ns |    11,800.0 ns |   10 |     128 B |
| ExistsItemFromList        | .NET 6.0 | 10000      |    12,297.0 ns |   2,185.16 ns |   6,408.71 ns |    12,100.0 ns |   10 |     704 B |
| ExistsItemFromList        | .NET 8.0 | 10000      |    12,461.2 ns |   2,404.72 ns |   6,501.30 ns |    12,700.0 ns |   10 |     464 B |
| AnyItemFromList           | .NET 9.0 | 1000       |    13,757.6 ns |   2,325.98 ns |   6,821.70 ns |    13,800.0 ns |   10 |     464 B |
| AnyItemFromSortedSet      | .NET 6.0 | 1000       |    19,874.7 ns |   3,362.05 ns |   9,860.31 ns |    19,600.0 ns |   11 |     968 B |
| AnyItemFromList           | .NET 8.0 | 1000       |    25,032.0 ns |   5,012.08 ns |  14,778.23 ns |    22,650.0 ns |   12 |     504 B |
| ContainsItemFromList      | .NET 6.0 | 100000     |    26,969.7 ns |   4,589.29 ns |  13,459.59 ns |    28,700.0 ns |   12 |     640 B |
| ContainsItemFromList      | .NET 8.0 | 100000     |    27,106.2 ns |   5,368.87 ns |  15,490.41 ns |    26,350.0 ns |   12 |      64 B |
| AnyItemFromList           | .NET 9.0 | 10000      |    28,602.2 ns |   2,594.53 ns |   7,360.26 ns |    29,700.0 ns |   12 |     464 B |
| ContainsItemFromList      | .NET 9.0 | 100000     |    28,774.2 ns |   6,090.07 ns |  17,668.40 ns |    25,600.0 ns |   12 |      64 B |
| AnyItemFromList           | .NET 6.0 | 10000      |    47,271.7 ns |   9,761.26 ns |  28,628.08 ns |    48,100.0 ns |   13 |     744 B |
| AnyItemFromList           | .NET 8.0 | 10000      |    64,865.3 ns |   4,932.84 ns |  14,389.34 ns |    66,900.0 ns |   14 |     504 B |
| AnyItemFromSortedSet      | .NET 8.0 | 1000       |    66,143.4 ns |  11,678.17 ns |  34,250.04 ns |    64,800.0 ns |   14 |     712 B |
| AnyItemFromSortedSet      | .NET 9.0 | 1000       |    66,236.0 ns |  11,336.57 ns |  33,426.13 ns |    70,250.0 ns |   14 |     712 B |
| AnyItemFromList           | .NET 9.0 | 100000     |    70,063.6 ns |  11,170.60 ns |  32,761.44 ns |    66,400.0 ns |   14 |     128 B |
| ExistsItemFromList        | .NET 6.0 | 100000     |    97,752.5 ns |  19,937.13 ns |  58,472.17 ns |   104,000.0 ns |   15 |     704 B |
| ExistsItemFromList        | .NET 8.0 | 100000     |   104,831.3 ns |  33,221.97 ns |  88,676.17 ns |    80,300.0 ns |   15 |     464 B |
| AnyItemFromSortedSet      | .NET 9.0 | 10000      |   111,162.7 ns |  15,814.64 ns |  42,212.49 ns |   105,200.0 ns |   16 |     488 B |
| AnyItemFromSortedSet      | .NET 6.0 | 10000      |   135,396.0 ns |  24,550.64 ns |  72,388.11 ns |   131,550.0 ns |   16 |    1032 B |
| AnyItemFromSortedSet      | .NET 8.0 | 10000      |   148,389.8 ns |  37,112.59 ns | 102,218.85 ns |   118,800.0 ns |   16 |     440 B |
| ExistsItemFromList        | .NET 9.0 | 100000     |   161,319.0 ns |  90,989.57 ns | 244,437.59 ns |    69,300.0 ns |   17 |     128 B |
| AnyItemFromList           | .NET 8.0 | 100000     |   178,133.3 ns |  38,431.74 ns | 112,713.65 ns |   153,900.0 ns |   18 |     504 B |
| AnyItemFromList           | .NET 6.0 | 100000     |   410,536.0 ns |  86,469.83 ns | 254,958.25 ns |   401,200.0 ns |   19 |     744 B |
| AnyItemFromSortedSet      | .NET 9.0 | 100000     |   557,244.4 ns |  97,012.30 ns | 284,520.30 ns |   533,400.0 ns |   20 |     488 B |
| AnyItemFromSortedSet      | .NET 8.0 | 100000     |   596,312.1 ns | 116,330.62 ns | 341,177.58 ns |   636,100.0 ns |   20 |     488 B |
| AnyItemFromSortedSet      | .NET 6.0 | 100000     | 1,341,013.0 ns | 237,192.44 ns | 699,367.30 ns | 1,456,250.0 ns |   21 |    1080 B |
