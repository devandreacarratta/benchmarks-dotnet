```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-XQDGVE : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-IXLBGF : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT AVX2


```
| Method      | Runtime  | StringComparisonItem | FirstItem   | SecondItem  | Mean       | Error     | StdDev    | Median     | Rank | Allocated |
|------------ |--------- |--------------------- |------------ |------------ |-----------:|----------:|----------:|-----------:|-----:|----------:|
| StringEqual | .NET 8.0 | CurrentCulture       | Hello World | Hello World |   1.559 ns | 0.0092 ns | 0.0081 ns |   1.557 ns |    1 |         - |
| StringEqual | .NET 8.0 | Invar(...)eCase [26] | Hello World | Hello World |   1.578 ns | 0.0087 ns | 0.0081 ns |   1.577 ns |    1 |         - |
| StringEqual | .NET 8.0 | InvariantCulture     | Hello World | Hello World |   1.583 ns | 0.0112 ns | 0.0105 ns |   1.581 ns |    1 |         - |
| StringEqual | .NET 8.0 | OrdinalIgnoreCase    | Hello World | Hello World |   1.584 ns | 0.0088 ns | 0.0082 ns |   1.581 ns |    1 |         - |
| StringEqual | .NET 8.0 | Ordinal              | Hello World | Hello World |   1.585 ns | 0.0116 ns | 0.0109 ns |   1.586 ns |    1 |         - |
| StringEqual | .NET 8.0 | Curre(...)eCase [24] | Hello World | Hello World |   1.589 ns | 0.0135 ns | 0.0120 ns |   1.584 ns |    1 |         - |
| StringEqual | .NET 6.0 | OrdinalIgnoreCase    | Hello World | Hello World |   2.048 ns | 0.0096 ns | 0.0085 ns |   2.050 ns |    2 |         - |
| StringEqual | .NET 6.0 | Curre(...)eCase [24] | Hello World | Hello World |   2.053 ns | 0.0147 ns | 0.0137 ns |   2.049 ns |    2 |         - |
| StringEqual | .NET 6.0 | CurrentCulture       | Hello World | Hello World |   2.054 ns | 0.0106 ns | 0.0088 ns |   2.054 ns |    2 |         - |
| StringEqual | .NET 6.0 | Ordinal              | Hello World | Hello World |   2.054 ns | 0.0116 ns | 0.0108 ns |   2.052 ns |    2 |         - |
| StringEqual | .NET 6.0 | InvariantCulture     | Hello World | Hello World |   2.057 ns | 0.0102 ns | 0.0091 ns |   2.058 ns |    2 |         - |
| StringEqual | .NET 6.0 | Invar(...)eCase [26] | Hello World | Hello World |   2.057 ns | 0.0108 ns | 0.0101 ns |   2.056 ns |    2 |         - |
| StringEqual | .NET 8.0 | Ordinal              | hello world | Hello World |   4.344 ns | 0.0228 ns | 0.0213 ns |   4.350 ns |    3 |         - |
| StringEqual | .NET 8.0 | Ordinal              | hello world | HELLO WORLD |   4.352 ns | 0.0249 ns | 0.0221 ns |   4.353 ns |    3 |         - |
| StringEqual | .NET 8.0 | Ordinal              | Hello World | HELLO WORLD |   4.361 ns | 0.0316 ns | 0.0295 ns |   4.357 ns |    3 |         - |
| StringEqual | .NET 6.0 | Ordinal              | hello world | HELLO WORLD |   5.342 ns | 0.0217 ns | 0.0181 ns |   5.344 ns |    4 |         - |
| StringEqual | .NET 6.0 | Ordinal              | Hello World | HELLO WORLD |   5.351 ns | 0.0316 ns | 0.0296 ns |   5.351 ns |    4 |         - |
| StringEqual | .NET 6.0 | Ordinal              | hello world | Hello World |   5.367 ns | 0.0300 ns | 0.0281 ns |   5.363 ns |    4 |         - |
| StringEqual | .NET 8.0 | OrdinalIgnoreCase    | hello world | Hello World |   7.637 ns | 0.0269 ns | 0.0224 ns |   7.635 ns |    5 |         - |
| StringEqual | .NET 8.0 | OrdinalIgnoreCase    | Hello World | HELLO WORLD |   8.716 ns | 0.0408 ns | 0.0361 ns |   8.708 ns |    6 |         - |
| StringEqual | .NET 8.0 | OrdinalIgnoreCase    | hello world | HELLO WORLD |   8.741 ns | 0.0431 ns | 0.0382 ns |   8.736 ns |    6 |         - |
| StringEqual | .NET 6.0 | OrdinalIgnoreCase    | hello world | Hello World |   9.117 ns | 0.0277 ns | 0.0259 ns |   9.120 ns |    7 |         - |
| StringEqual | .NET 6.0 | OrdinalIgnoreCase    | Hello World | HELLO WORLD |   9.613 ns | 0.0447 ns | 0.0418 ns |   9.597 ns |    8 |         - |
| StringEqual | .NET 6.0 | OrdinalIgnoreCase    | hello world | HELLO WORLD |   9.634 ns | 0.0534 ns | 0.0473 ns |   9.628 ns |    8 |         - |
| StringEqual | .NET 8.0 | Invar(...)eCase [26] | hello world | HELLO WORLD | 131.046 ns | 0.9199 ns | 0.8154 ns | 130.980 ns |    9 |         - |
| StringEqual | .NET 8.0 | Invar(...)eCase [26] | hello world | Hello World | 131.088 ns | 0.5056 ns | 0.4482 ns | 131.022 ns |    9 |         - |
| StringEqual | .NET 8.0 | Curre(...)eCase [24] | hello world | HELLO WORLD | 132.740 ns | 0.6560 ns | 0.6136 ns | 132.630 ns |    9 |         - |
| StringEqual | .NET 8.0 | Invar(...)eCase [26] | Hello World | HELLO WORLD | 133.539 ns | 0.5404 ns | 0.4512 ns | 133.436 ns |    9 |         - |
| StringEqual | .NET 8.0 | Curre(...)eCase [24] | Hello World | HELLO WORLD | 134.098 ns | 0.6036 ns | 0.5351 ns | 134.038 ns |    9 |         - |
| StringEqual | .NET 8.0 | Curre(...)eCase [24] | hello world | Hello World | 134.327 ns | 1.1502 ns | 1.0196 ns | 133.973 ns |    9 |         - |
| StringEqual | .NET 6.0 | Invar(...)eCase [26] | hello world | HELLO WORLD | 134.607 ns | 0.6288 ns | 0.5882 ns | 134.689 ns |    9 |         - |
| StringEqual | .NET 8.0 | InvariantCulture     | hello world | Hello World | 139.169 ns | 0.5354 ns | 0.5008 ns | 139.112 ns |   10 |         - |
| StringEqual | .NET 6.0 | Invar(...)eCase [26] | hello world | Hello World | 139.208 ns | 0.6411 ns | 0.5683 ns | 139.145 ns |   10 |         - |
| StringEqual | .NET 8.0 | InvariantCulture     | hello world | HELLO WORLD | 139.239 ns | 0.5916 ns | 0.5244 ns | 139.081 ns |   10 |         - |
| StringEqual | .NET 6.0 | Invar(...)eCase [26] | Hello World | HELLO WORLD | 139.630 ns | 0.8087 ns | 0.7169 ns | 139.463 ns |   10 |         - |
| StringEqual | .NET 8.0 | CurrentCulture       | hello world | HELLO WORLD | 141.535 ns | 0.8134 ns | 0.6351 ns | 141.587 ns |   11 |         - |
| StringEqual | .NET 8.0 | CurrentCulture       | Hello World | HELLO WORLD | 141.552 ns | 0.4873 ns | 0.4069 ns | 141.415 ns |   11 |         - |
| StringEqual | .NET 8.0 | InvariantCulture     | Hello World | HELLO WORLD | 141.668 ns | 0.7840 ns | 0.6547 ns | 141.957 ns |   11 |         - |
| StringEqual | .NET 6.0 | InvariantCulture     | hello world | Hello World | 142.637 ns | 1.0566 ns | 0.8823 ns | 142.664 ns |   11 |         - |
| StringEqual | .NET 6.0 | InvariantCulture     | hello world | HELLO WORLD | 144.129 ns | 2.8654 ns | 4.5449 ns | 141.479 ns |   11 |         - |
| StringEqual | .NET 6.0 | Curre(...)eCase [24] | hello world | Hello World | 144.179 ns | 0.5999 ns | 0.5611 ns | 144.108 ns |   11 |         - |
| StringEqual | .NET 6.0 | InvariantCulture     | Hello World | HELLO WORLD | 144.231 ns | 0.7373 ns | 0.6536 ns | 144.312 ns |   11 |         - |
| StringEqual | .NET 6.0 | Curre(...)eCase [24] | Hello World | HELLO WORLD | 145.208 ns | 0.7892 ns | 0.6590 ns | 145.294 ns |   11 |         - |
| StringEqual | .NET 6.0 | Curre(...)eCase [24] | hello world | HELLO WORLD | 146.963 ns | 2.8593 ns | 3.0594 ns | 145.571 ns |   11 |         - |
| StringEqual | .NET 8.0 | CurrentCulture       | hello world | Hello World | 149.146 ns | 2.8396 ns | 3.0383 ns | 150.527 ns |   11 |         - |
| StringEqual | .NET 6.0 | CurrentCulture       | hello world | Hello World | 149.950 ns | 0.5888 ns | 0.5219 ns | 149.790 ns |   11 |         - |
| StringEqual | .NET 6.0 | CurrentCulture       | hello world | HELLO WORLD | 151.535 ns | 0.5701 ns | 0.4761 ns | 151.573 ns |   11 |         - |
| StringEqual | .NET 6.0 | CurrentCulture       | Hello World | HELLO WORLD | 155.379 ns | 0.8733 ns | 0.8168 ns | 155.482 ns |   12 |         - |
