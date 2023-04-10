using System;

public class Program
{
    static void Main(string[] args)
    {
        Func<int, int> square = number => number * number;
        square(5);
    }
}
