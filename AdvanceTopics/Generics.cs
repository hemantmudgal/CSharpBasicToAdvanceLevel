
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
 * So for every new type we have to create new class of that type which is not productive
 * way for doing things that's why generics came into picture.
 *
 * For solving this problem we can Replace any type with object type because object
 * is parent of any other class in C#.
 *
 * But this can create perfomance penalty becuase if use this class to store value types
 * it has to boxed in the object type first. So this will cause extra boxing and unboxing
 * which can create a performance penalty on our project. And for reference type upcasting
 * and downcasting happens each time so that's why we can't use this technique.
 *
 *
 * But in generic we can create class once and we can use it at multiple time and mutliple
 * places and it doesn't have perfomance penalty.
 */