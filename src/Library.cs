using System;
using System.Collections.Generic; 
using System.Linq; 

public class Library
{
    private List<Book> books;
    private List<User> users;

    public Library()
    {
        books = new List<Book>();
        users = new List<User>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public Book? FindItemByName(string name)
    {
        Book? findItem = books.FirstOrDefault(book => book.Title.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (findItem == null)
        {
            throw new KeyNotFoundException($"Book '{name}' not found.");
        }
        else
        {
            Console.WriteLine($"Book found: '{name}'");
            return findItem;
        }
    }

}
