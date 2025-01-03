```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-SLYGXL : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-PXLHCR : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-ZLKGYE : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2


```
| Method      | Runtime  | StringComparisonItem | FirstItem   | SecondItem  | Mean       | Error     | StdDev     | Median     | Rank | Allocated |
|------------ |--------- |--------------------- |------------ |------------ |-----------:|----------:|-----------:|-----------:|-----:|----------:|
| StringEqual | .NET 9.0 | Ordinal              | Hello World | Hello World |   1.058 ns | 0.0381 ns |  0.0297 ns |   1.052 ns |    1 |         - |
| StringEqual | .NET 9.0 | InvariantCulture     | Hello World | Hello World |   1.070 ns | 0.0197 ns |  0.0165 ns |   1.068 ns |    1 |         - |
| StringEqual | .NET 9.0 | Invar(...)eCase [26] | Hello World | Hello World |   1.078 ns | 0.0233 ns |  0.0182 ns |   1.076 ns |    1 |         - |
| StringEqual | .NET 9.0 | OrdinalIgnoreCase    | Hello World | Hello World |   1.093 ns | 0.0182 ns |  0.0152 ns |   1.088 ns |    1 |         - |
| StringEqual | .NET 8.0 | Curre(...)eCase [24] | Hello World | Hello World |   1.108 ns | 0.0176 ns |  0.0138 ns |   1.111 ns |    1 |         - |
| StringEqual | .NET 8.0 | InvariantCulture     | Hello World | Hello World |   1.116 ns | 0.0179 ns |  0.0140 ns |   1.110 ns |    1 |         - |
| StringEqual | .NET 8.0 | CurrentCulture       | Hello World | Hello World |   1.124 ns | 0.0269 ns |  0.0238 ns |   1.120 ns |    1 |         - |
| StringEqual | .NET 8.0 | Ordinal              | Hello World | Hello World |   1.130 ns | 0.0552 ns |  0.0614 ns |   1.102 ns |    1 |         - |
| StringEqual | .NET 8.0 | OrdinalIgnoreCase    | Hello World | Hello World |   1.142 ns | 0.0469 ns |  0.0416 ns |   1.130 ns |    1 |         - |
| StringEqual | .NET 8.0 | Invar(...)eCase [26] | Hello World | Hello World |   1.227 ns | 0.0552 ns |  0.1222 ns |   1.189 ns |    1 |         - |
| StringEqual | .NET 6.0 | InvariantCulture     | Hello World | Hello World |   1.599 ns | 0.0191 ns |  0.0159 ns |   1.598 ns |    2 |         - |
| StringEqual | .NET 9.0 | Curre(...)eCase [24] | Hello World | Hello World |   1.605 ns | 0.0149 ns |  0.0124 ns |   1.605 ns |    2 |         - |
| StringEqual | .NET 9.0 | CurrentCulture       | Hello World | Hello World |   1.611 ns | 0.0556 ns |  0.0546 ns |   1.594 ns |    2 |         - |
| StringEqual | .NET 6.0 | Curre(...)eCase [24] | Hello World | Hello World |   1.617 ns | 0.0167 ns |  0.0130 ns |   1.618 ns |    2 |         - |
| StringEqual | .NET 6.0 | Invar(...)eCase [26] | Hello World | Hello World |   1.626 ns | 0.0408 ns |  0.0341 ns |   1.609 ns |    2 |         - |
| StringEqual | .NET 6.0 | OrdinalIgnoreCase    | Hello World | Hello World |   1.629 ns | 0.0546 ns |  0.0511 ns |   1.614 ns |    2 |         - |
| StringEqual | .NET 6.0 | CurrentCulture       | Hello World | Hello World |   1.668 ns | 0.0641 ns |  0.0788 ns |   1.639 ns |    2 |         - |
| StringEqual | .NET 6.0 | Ordinal              | Hello World | Hello World |   2.336 ns | 0.0378 ns |  0.0315 ns |   2.323 ns |    3 |         - |
| StringEqual | .NET 9.0 | Ordinal              | Hello World | HELLO WORLD |   3.894 ns | 0.0324 ns |  0.0253 ns |   3.892 ns |    4 |         - |
| StringEqual | .NET 9.0 | Ordinal              | hello world | Hello World |   3.898 ns | 0.1052 ns |  0.0984 ns |   3.872 ns |    4 |         - |
| StringEqual | .NET 9.0 | Ordinal              | hello world | HELLO WORLD |   3.953 ns | 0.0906 ns |  0.0803 ns |   3.955 ns |    4 |         - |
| StringEqual | .NET 8.0 | Ordinal              | Hello World | HELLO WORLD |   4.502 ns | 0.0596 ns |  0.0498 ns |   4.500 ns |    5 |         - |
| StringEqual | .NET 8.0 | Ordinal              | hello world | Hello World |   4.524 ns | 0.0468 ns |  0.0366 ns |   4.521 ns |    5 |         - |
| StringEqual | .NET 8.0 | Ordinal              | hello world | HELLO WORLD |   4.555 ns | 0.1213 ns |  0.1075 ns |   4.512 ns |    5 |         - |
| StringEqual | .NET 6.0 | Ordinal              | Hello World | HELLO WORLD |   5.250 ns | 0.1308 ns |  0.1159 ns |   5.244 ns |    6 |         - |
| StringEqual | .NET 6.0 | Ordinal              | hello world | HELLO WORLD |   5.270 ns | 0.0986 ns |  0.0874 ns |   5.233 ns |    6 |         - |
| StringEqual | .NET 6.0 | Ordinal              | hello world | Hello World |   5.333 ns | 0.0402 ns |  0.0336 ns |   5.340 ns |    6 |         - |
| StringEqual | .NET 9.0 | OrdinalIgnoreCase    | hello world | HELLO WORLD |   6.373 ns | 0.0521 ns |  0.0406 ns |   6.371 ns |    7 |         - |
| StringEqual | .NET 9.0 | OrdinalIgnoreCase    | hello world | Hello World |   6.471 ns | 0.1094 ns |  0.0970 ns |   6.437 ns |    7 |         - |
| StringEqual | .NET 9.0 | OrdinalIgnoreCase    | Hello World | HELLO WORLD |   6.482 ns | 0.1347 ns |  0.1383 ns |   6.435 ns |    7 |         - |
| StringEqual | .NET 8.0 | OrdinalIgnoreCase    | hello world | Hello World |   8.280 ns | 0.1128 ns |  0.0942 ns |   8.247 ns |    8 |         - |
| StringEqual | .NET 8.0 | OrdinalIgnoreCase    | Hello World | HELLO WORLD |   9.141 ns | 0.1653 ns |  0.1466 ns |   9.099 ns |    9 |         - |
| StringEqual | .NET 8.0 | OrdinalIgnoreCase    | hello world | HELLO WORLD |   9.185 ns | 0.2172 ns |  0.2231 ns |   9.054 ns |    9 |         - |
| StringEqual | .NET 6.0 | OrdinalIgnoreCase    | hello world | Hello World |  10.475 ns | 0.2381 ns |  0.2646 ns |  10.470 ns |   10 |         - |
| StringEqual | .NET 6.0 | OrdinalIgnoreCase    | hello world | HELLO WORLD |  10.669 ns | 0.0914 ns |  0.0763 ns |  10.675 ns |   10 |         - |
| StringEqual | .NET 6.0 | OrdinalIgnoreCase    | Hello World | HELLO WORLD |  10.728 ns | 0.2229 ns |  0.1861 ns |  10.656 ns |   10 |         - |
| StringEqual | .NET 9.0 | Curre(...)eCase [24] | hello world | Hello World | 134.098 ns | 1.0972 ns |  0.8566 ns | 133.991 ns |   11 |         - |
| StringEqual | .NET 8.0 | Invar(...)eCase [26] | hello world | HELLO WORLD | 134.119 ns | 0.8556 ns |  0.7585 ns | 134.104 ns |   11 |         - |
| StringEqual | .NET 8.0 | Invar(...)eCase [26] | hello world | Hello World | 135.122 ns | 2.1535 ns |  1.7983 ns | 134.679 ns |   11 |         - |
| StringEqual | .NET 9.0 | Invar(...)eCase [26] | hello world | Hello World | 136.244 ns | 2.6400 ns |  2.4695 ns | 135.133 ns |   11 |         - |
| StringEqual | .NET 9.0 | Curre(...)eCase [24] | hello world | HELLO WORLD | 136.527 ns | 2.3396 ns |  4.5633 ns | 134.360 ns |   11 |         - |
| StringEqual | .NET 9.0 | Invar(...)eCase [26] | Hello World | HELLO WORLD | 136.769 ns | 2.0742 ns |  1.7320 ns | 136.098 ns |   11 |         - |
| StringEqual | .NET 9.0 | Invar(...)eCase [26] | hello world | HELLO WORLD | 137.153 ns | 2.7517 ns |  3.4800 ns | 135.254 ns |   11 |         - |
| StringEqual | .NET 8.0 | Invar(...)eCase [26] | Hello World | HELLO WORLD | 137.695 ns | 2.0641 ns |  1.8297 ns | 137.226 ns |   11 |         - |
| StringEqual | .NET 9.0 | InvariantCulture     | hello world | HELLO WORLD | 139.691 ns | 1.0028 ns |  0.7829 ns | 139.741 ns |   11 |         - |
| StringEqual | .NET 6.0 | Invar(...)eCase [26] | hello world | HELLO WORLD | 139.833 ns | 0.9489 ns |  0.7408 ns | 139.635 ns |   11 |         - |
| StringEqual | .NET 8.0 | Curre(...)eCase [24] | hello world | HELLO WORLD | 139.936 ns | 2.6429 ns |  5.0284 ns | 137.957 ns |   11 |         - |
| StringEqual | .NET 6.0 | Invar(...)eCase [26] | hello world | Hello World | 140.401 ns | 1.9056 ns |  1.6892 ns | 140.064 ns |   11 |         - |
| StringEqual | .NET 8.0 | Curre(...)eCase [24] | hello world | Hello World | 141.892 ns | 2.8562 ns |  6.8981 ns | 139.905 ns |   11 |         - |
| StringEqual | .NET 6.0 | Invar(...)eCase [26] | Hello World | HELLO WORLD | 142.565 ns | 2.8686 ns |  2.6833 ns | 142.044 ns |   11 |         - |
| StringEqual | .NET 9.0 | CurrentCulture       | hello world | HELLO WORLD | 142.688 ns | 1.6840 ns |  1.4062 ns | 142.456 ns |   11 |         - |
| StringEqual | .NET 8.0 | CurrentCulture       | hello world | Hello World | 142.916 ns | 1.0392 ns |  0.8678 ns | 142.893 ns |   11 |         - |
| StringEqual | .NET 8.0 | InvariantCulture     | hello world | HELLO WORLD | 142.997 ns | 2.5545 ns |  4.2679 ns | 140.881 ns |   11 |         - |
| StringEqual | .NET 9.0 | CurrentCulture       | hello world | Hello World | 143.308 ns | 1.6796 ns |  2.1840 ns | 142.571 ns |   11 |         - |
| StringEqual | .NET 9.0 | InvariantCulture     | Hello World | HELLO WORLD | 143.318 ns | 1.2739 ns |  1.0637 ns | 143.199 ns |   11 |         - |
| StringEqual | .NET 8.0 | CurrentCulture       | Hello World | HELLO WORLD | 144.535 ns | 1.1807 ns |  0.9859 ns | 144.501 ns |   11 |         - |
| StringEqual | .NET 9.0 | InvariantCulture     | hello world | Hello World | 144.806 ns | 2.8362 ns |  6.4018 ns | 141.402 ns |   11 |         - |
| StringEqual | .NET 8.0 | InvariantCulture     | Hello World | HELLO WORLD | 145.080 ns | 2.4418 ns |  2.2840 ns | 144.242 ns |   11 |         - |
| StringEqual | .NET 8.0 | InvariantCulture     | hello world | Hello World | 145.307 ns | 2.9317 ns |  6.4963 ns | 142.337 ns |   11 |         - |
| StringEqual | .NET 9.0 | CurrentCulture       | Hello World | HELLO WORLD | 145.758 ns | 2.7885 ns |  3.9992 ns | 144.479 ns |   11 |         - |
| StringEqual | .NET 9.0 | Curre(...)eCase [24] | Hello World | HELLO WORLD | 145.953 ns | 4.6363 ns | 13.5242 ns | 138.539 ns |   11 |         - |
| StringEqual | .NET 8.0 | CurrentCulture       | hello world | HELLO WORLD | 146.776 ns | 2.8991 ns |  5.0008 ns | 144.361 ns |   11 |         - |
| StringEqual | .NET 6.0 | InvariantCulture     | Hello World | HELLO WORLD | 148.597 ns | 1.4552 ns |  1.2151 ns | 148.317 ns |   11 |         - |
| StringEqual | .NET 6.0 | InvariantCulture     | hello world | Hello World | 148.874 ns | 3.0034 ns |  4.2103 ns | 147.744 ns |   11 |         - |
| StringEqual | .NET 6.0 | Curre(...)eCase [24] | hello world | HELLO WORLD | 150.462 ns | 1.2392 ns |  1.0348 ns | 150.154 ns |   11 |         - |
| StringEqual | .NET 6.0 | InvariantCulture     | hello world | HELLO WORLD | 151.301 ns | 3.0215 ns |  7.2972 ns | 147.293 ns |   11 |         - |
| StringEqual | .NET 6.0 | CurrentCulture       | hello world | HELLO WORLD | 155.038 ns | 2.4381 ns |  2.0360 ns | 154.566 ns |   11 |         - |
| StringEqual | .NET 6.0 | Curre(...)eCase [24] | hello world | Hello World | 156.186 ns | 3.0294 ns |  3.7203 ns | 154.419 ns |   11 |         - |
| StringEqual | .NET 6.0 | CurrentCulture       | hello world | Hello World | 157.081 ns | 1.0514 ns |  0.8780 ns | 156.873 ns |   11 |         - |
| StringEqual | .NET 8.0 | Curre(...)eCase [24] | Hello World | HELLO WORLD | 159.185 ns | 5.3893 ns | 15.8904 ns | 161.941 ns |   11 |         - |
| StringEqual | .NET 6.0 | Curre(...)eCase [24] | Hello World | HELLO WORLD | 170.254 ns | 5.8273 ns | 17.1820 ns | 165.285 ns |   11 |         - |
| StringEqual | .NET 6.0 | CurrentCulture       | Hello World | HELLO WORLD | 171.700 ns | 5.5757 ns | 16.4401 ns | 161.353 ns |   11 |         - |
