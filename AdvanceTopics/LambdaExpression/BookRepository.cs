using System;

public class BooksRepository
{
    public List<Books> GetBooks()
    {
        return new Books()
        {
            new Book() { Title = "Title1", Price = 5 },
            new Book() { Title = "Title2", Price = 7 },
            new Book() { Title = "Title3", Price = 8 }
        };
    }
}
