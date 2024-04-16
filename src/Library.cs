using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


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

    public IEnumerable<Book> GetAllBooks(int page, int pageSize)
    {
        return books.OrderBy(book => book.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize);
    }

    public IEnumerable<User> GetAllUsers(int page, int pageSize)
    {
        return users.OrderBy(user => user.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize);
    }
    public Book? FindBookByTitle(string name)
    {
        Book? findBook = books.FirstOrDefault(book => book.Title.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (findBook == null)
        {
            throw new KeyNotFoundException($"Book '{name}' not found.");
        }
        else
        {
            Console.WriteLine($"Book found: '{name}'");
            return findBook;
        }
    }
    public User? FindUserByName(string name)
    {
        User? findUser = users.FirstOrDefault(user => user.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (findUser == null)
        {
            throw new KeyNotFoundException($"User '{name}' not found.");
        }
        else
        {
            Console.WriteLine($"User found: '{name}'");
            return findUser;
        }
    }

    public void DeleteBook(Guid Id)
    {
        Book? findBook = books.FirstOrDefault(book => book.Id == Id);
        if (findBook == null)
        {
            throw new KeyNotFoundException($"there is no book with this ID");
        }
        else
        {

            Console.WriteLine($"Book was deleted successfully");
            books.Remove(findBook);


        }
    }
    public void DeleteUser(Guid Id)
    {
        User? findUser = users.FirstOrDefault(user => user.Id == Id);
        if (findUser == null)
        {
            throw new KeyNotFoundException($"there is no user with this ID");
        }
        else
        {

            Console.WriteLine($"user was deleted successfully");
            users.Remove(findUser);


        }
    }


}
