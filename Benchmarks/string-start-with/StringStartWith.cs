namespace BenchmarksDotnet.Benchmarks;

public class StringStartWith
{    
    public const string FIXED_STRING_VALUE = "hello world";
 
    public string StringItem { get; set; } = "h";

    public char CharItem { get; set; } = 'h';   

    [Benchmark]
    public void StartWithString()
    {
        _ = FIXED_STRING_VALUE.StartsWith(StringItem);
    }

    [Benchmark]
    public void StartWithChar()
    {
        _ = FIXED_STRING_VALUE.StartsWith(CharItem);
    }
}

