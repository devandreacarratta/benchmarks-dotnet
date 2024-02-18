```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL


```
| Method      | _stringComparison    | Mean       | Error     | StdDev    |
|------------ |--------------------- |-----------:|----------:|----------:|
| **StringEqual** | **CurrentCulture**       | **140.957 ns** | **2.8580 ns** | **3.5099 ns** |
| **StringEqual** | **Curre(...)eCase [24]** | **134.711 ns** | **1.5863 ns** | **1.4062 ns** |
| **StringEqual** | **InvariantCulture**     | **140.895 ns** | **2.5486 ns** | **3.9678 ns** |
| **StringEqual** | **Invar(...)eCase [26]** | **132.683 ns** | **1.5960 ns** | **1.4148 ns** |
| **StringEqual** | **Ordinal**              |   **4.328 ns** | **0.0109 ns** | **0.0091 ns** |
| **StringEqual** | **OrdinalIgnoreCase**    |   **7.790 ns** | **0.0360 ns** | **0.0319 ns** |
