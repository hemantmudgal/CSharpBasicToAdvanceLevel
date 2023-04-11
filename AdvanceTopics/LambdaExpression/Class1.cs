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
        Func<int, int> square = number => number * number; // This delegate takes input as integer and return integer value.
        square(5); // we can call Func Delegate by passing the reuired argument in paranthesis.
    }
}
