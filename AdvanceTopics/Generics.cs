
/*
 * What problem Generic came to solve:
 *
 *	In .NET version 1 we didn't have generics
 *
 */
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

/*
* But if we want to store books this class wouldn't work
* For storing books this class shouls looks like:
*/

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

/*
 * So for every new type we have to create
 * new class of that type which is not productive
 * way for doing things that's why generics
 * came into picture.
 */