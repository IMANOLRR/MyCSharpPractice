using System;

public class Book
{
    private string title;
    private string author;
    private bool isBorrowed;

    public Book()
    {
        title = "Unknown";
        author = "Unknown";
        isBorrowed = false;
    }

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
        isBorrowed = false;
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public void Borrow()
    {
        if (!isBorrowed)
        {
            isBorrowed = true;
            Console.WriteLine("The book has been borrowed.");
        }
        else
        {
            Console.WriteLine("The book is already borrowed.");
        }
    }

    public void Return()
    {
        if (isBorrowed)
        {
            isBorrowed = false;
            Console.WriteLine("The book has been returned.");
        }
        else
        {
            Console.WriteLine("The book was not borrowed.");
        }
    }

    public override string ToString()
    {
        return $"Title: {title}, Author: {author}, Borrowed: {isBorrowed}";
    }

    public static void Main(string[] args)
    {
        Book book1 = new Book("Game of Thrones", "George R.R. Martin");
        Console.WriteLine(book1.ToString());

        book1.Borrow();
        Console.WriteLine(book1.ToString());

        book1.Return();
        Console.WriteLine(book1.ToString());
    }
}
