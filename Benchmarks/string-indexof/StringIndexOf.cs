namespace BenchmarksDotnet.Benchmarks;

public class StringIndexOf
{    
    public const string FIXED_STRING_VALUE = "hello world";
 
    public string StringItem { get; set; } = "d";

    public char CharItem { get; set; } = 'd';   

    [Benchmark]
    public void StartWithString()
    {
        _ = FIXED_STRING_VALUE.IndexOf(StringItem);
    }

    [Benchmark]
    public void StartWithChar()
    {
        _ = FIXED_STRING_VALUE.IndexOf(CharItem);
    }
}

