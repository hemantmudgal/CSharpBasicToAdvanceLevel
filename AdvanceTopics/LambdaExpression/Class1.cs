using System;

public class Program
{
    // args => expression
    // () => ... No arguments
    // x => ... for one argument
    // (x,y,z) => ... for multiple arguments surrond them with paranthesis

    //public int Square(int number)
    //{
    //    return number * number;
    //}

    static void Main(string[] args)
    {
        Func<int, int> square = number => number * number; // This delegate takes input as integer and return integer value.
        int output1 = square(5); // we can call Func Delegate by passing the reuired argument in paranthesis.
        //int output2 = Square(5);


        /*
        lambda expression can access all variables which is define on that scope where expression has to be wirtten.
        */
        const int factor = 5;
        Func<int, int> multiplier = n => n * factor;
        console.WriteLine(10); //output 50 on consle
    }
}
