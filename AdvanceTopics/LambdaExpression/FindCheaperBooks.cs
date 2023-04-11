using System;

public class Class1
{
    static void Main(string[] args)
    {
        var bookRepository = new BookReposiotry();
        var cheaperBooks = bookRepository.FindAll(IsChepaerThan10Dollar);

        foreach (var cheaperBook in cheaperBooks)
        {
            Console.WriteLine(cheaperBook.Title + " => " + cheaperBook.Price);
        }
    }

    public bool IsChaperThan10Dollar(Book book)
    {
        return book.Price < 10;
    }
}
