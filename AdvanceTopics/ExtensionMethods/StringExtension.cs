using System;

class StringExtension
{
    public static string Shorten(this String str, int numberOfWords)
    {
        if (numberOfWords < 0) Console.WriteLine("Number of words should be greater than or equal to zero");

        if (numberOfWords == 0) return "";

        var words = str.split(' ');

        if (words.Length < words) return str;

        return str.Join(" ", words.Take(numberOfWords));
    }
}