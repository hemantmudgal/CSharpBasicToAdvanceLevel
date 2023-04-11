using System;

public class Class1
{
    static void Main(string[] args)
    {
        var bookRepository = new BookReposiotry();

        /*
         * Here FindAll(Predicate<Book>) requires a predicate. Predicate is a type of
         * delegate which require an argument of specified type and return the bool
         * value according to the specified condition.
         */
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
