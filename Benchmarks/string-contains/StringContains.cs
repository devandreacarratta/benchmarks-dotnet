namespace BenchmarksDotnet.Benchmarks;

public class StringContains
{    
    public const string FIXED_STRING_VALUE = "hello world";
 
    public string StringItem { get; set; } = "d";

    public char CharItem { get; set; } = 'd';   

    [Benchmark]
    public void ContainString()
    {
        _ = FIXED_STRING_VALUE.Contains(StringItem);
    }

    [Benchmark]
    public void ContainChar()
    {
        _ = FIXED_STRING_VALUE.Contains(CharItem);
    }
}

