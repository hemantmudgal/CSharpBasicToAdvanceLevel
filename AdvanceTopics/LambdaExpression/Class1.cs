using System;

public class Program
{
    // args => expression

    public int Square(int number)
    {
        return number * number;
    }

    static void Main(string[] args)
    {
        Func<int, int> square = number => number * number;
        square(5);
    }
}
