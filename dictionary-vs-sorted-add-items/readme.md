```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Xeon W-2123 CPU 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL [AttachedDebugger]
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL


```
| Method                | ItemsToAdd | Mean | Error |
|---------------------- |----------- |-----:|------:|
| **AddToDictionary**       | **1**          |   **NA** |    **NA** |
| AddToSortedDictionary | 1          |   NA |    NA |
| **AddToDictionary**       | **10**         |   **NA** |    **NA** |
| AddToSortedDictionary | 10         |   NA |    NA |
| **AddToDictionary**       | **100**        |   **NA** |    **NA** |
| AddToSortedDictionary | 100        |   NA |    NA |
| **AddToDictionary**       | **1000**       |   **NA** |    **NA** |
| AddToSortedDictionary | 1000       |   NA |    NA |
| **AddToDictionary**       | **10000**      |   **NA** |    **NA** |
| AddToSortedDictionary | 10000      |   NA |    NA |

Benchmarks with issues:
  DictionaryVersusSortedAddItems.AddToDictionary: DefaultJob [ItemsToAdd=1]
  DictionaryVersusSortedAddItems.AddToSortedDictionary: DefaultJob [ItemsToAdd=1]
  DictionaryVersusSortedAddItems.AddToDictionary: DefaultJob [ItemsToAdd=10]
  DictionaryVersusSortedAddItems.AddToSortedDictionary: DefaultJob [ItemsToAdd=10]
  DictionaryVersusSortedAddItems.AddToDictionary: DefaultJob [ItemsToAdd=100]
  DictionaryVersusSortedAddItems.AddToSortedDictionary: DefaultJob [ItemsToAdd=100]
  DictionaryVersusSortedAddItems.AddToDictionary: DefaultJob [ItemsToAdd=1000]
  DictionaryVersusSortedAddItems.AddToSortedDictionary: DefaultJob [ItemsToAdd=1000]
  DictionaryVersusSortedAddItems.AddToDictionary: DefaultJob [ItemsToAdd=10000]
  DictionaryVersusSortedAddItems.AddToSortedDictionary: DefaultJob [ItemsToAdd=10000]
