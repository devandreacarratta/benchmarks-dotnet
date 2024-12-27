```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5247/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2 [AttachedDebugger]
  Job-UBNFOY : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT AVX2
  Job-EKEEND : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  Job-FUYQNI : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL


```
| Method          | Runtime  | Mean       | Error     | StdDev    | Median     | Rank | Allocated |
|---------------- |--------- |-----------:|----------:|----------:|-----------:|-----:|----------:|
| StartWithChar   | .NET 6.0 |  0.0012 ns | 0.0043 ns | 0.0036 ns |  0.0000 ns |    1 |         - |
| StartWithChar   | .NET 8.0 |  0.0016 ns | 0.0043 ns | 0.0046 ns |  0.0000 ns |    1 |         - |
| StartWithChar   | .NET 9.0 |  0.0033 ns | 0.0091 ns | 0.0081 ns |  0.0000 ns |    1 |         - |
| StartWithString | .NET 9.0 | 14.8733 ns | 0.1632 ns | 0.1447 ns | 14.8602 ns |    2 |         - |
| StartWithString | .NET 8.0 | 16.5548 ns | 0.3520 ns | 0.9516 ns | 16.1306 ns |    3 |         - |
| StartWithString | .NET 6.0 | 22.5515 ns | 0.4060 ns | 0.3390 ns | 22.4104 ns |    4 |         - |
