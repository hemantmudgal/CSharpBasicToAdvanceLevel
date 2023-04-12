using System;

public class Program
{
    static void Main(string[] args)
    {
        string post = "This is supposed to be very long blog post";
        var shortenedPost = post.Shorten(5);
        Console.WriteLine(shortenedPost);
    }
}