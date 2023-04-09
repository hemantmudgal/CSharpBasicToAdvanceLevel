public class List
{
    public void Add(void number)
    {
        throw new NotImplementException();
    }

    public int this[int index]
    {
        get{ throw new NotImplementedException()};
    }
}

public class BookList
{
    public void Add(Book book)
    {
        throw new NotImplementedException();
    }

    public Book this[int index]
    {
        get { throw new NotImplemetedException(); }
    }
}


public class Book
{
    public string BookName { get; set; }
}

public class GenericList<T>
{

    public void Add(T data)
    {
        throw new NoImplementedException();
    }

    public T this[int index]
    {
        get{ throw new NoImplementedException();}
    }
}