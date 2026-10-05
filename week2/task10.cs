using System;
using System.Collections.Generic;

class Book
{
    int Bookid;
    string Title;
    string Author;

    public Book(int Bookid, string Title, string Author)
    {
        this.Bookid = Bookid;
        this.Title = Title;
        this.Author = Author;
    }
    public void Display()
    {
        Console.WriteLine("Book ID:" + Bookid);
        Console.WriteLine("Title:" + Title);
        Console.WriteLine("Author" + Author);
        Console.WriteLine();
    }
    public int GetBookid()
    {
        return Bookid;
    }
    static void Main(string[] args)
    {
        List<Book> Books = new List<Book>();
        Books.Add(new Book(1, "The Alchemist", "Paulo Coelho"));
        Books.Add(new Book(2, "Harry Potter", "J.K. Rowling"));

        Console.WriteLine("All Books:");
        foreach (Book book in Books)
        {
            book.Display();
        }
        Books.Add(new Book(3, "Atomic Habits", "James Clear"));
        foreach (Book book in Books)
        {
            book.Display();
        }
        int id = 2;
        for (int i = 0; i < Books.Count; i++)
        {
            if (Books[i].GetBookid() == id)
            {
                Books.RemoveAt(i);
                break;
            }
        }
        Console.WriteLine("After Removing Book:");
        foreach (Book book in Books)
        {
            book.Display();
        }
    }
}

