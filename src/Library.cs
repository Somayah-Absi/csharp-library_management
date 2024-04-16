using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


public class Library
{
    private INotificationService notificationService;
    private List<Book> books;
    private List<User> users;
   
    public Library(INotificationService service)
    {
        notificationService = service;
        books = new List<Book>();
        users = new List<User>();
    }

    public void AddBook(Book book)
    {
        try
        {
            books.Add(book);
            notificationService.SendNotificationOnSuccess(" add book ", book.Title);
        }
        catch (Exception ex) { notificationService.SendNotificationOnFailure(" Add Book", book.Title, ex.Message); }
    }

    public void AddUser(User user)
    {
        try
        {
            users.Add(user);
            notificationService.SendNotificationOnSuccess("Adding User ",user.Name);
        }
        catch (Exception ex)
        {
            notificationService.SendNotificationOnFailure("Adding User ", user.Name, ex.Message);
        }
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
           Console.WriteLine($"book '{name}' not found.");
        return null; 
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
             Console.WriteLine($"User '{name}' not found.");
        return null; 
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
            Console.WriteLine("                                                there is no book with this ID");
            notificationService.SendNotificationOnFailure("Deleting Book :",Id.ToString(),"not found");
        }
        else
        {

            Console.WriteLine("                                                 Book was deleted successfully");
            books.Remove(findBook); 
            notificationService.SendNotificationOnSuccess("Deleting Book :",findBook.Title);


        }
    }
    public void DeleteUser(Guid Id)
    {
        User? findUser = users.FirstOrDefault(user => user.Id == Id);
        if (findUser == null)
        {
            Console.WriteLine("                                                  there is no user with this ID");
            notificationService.SendNotificationOnFailure("Deleting User :",Id.ToString(),"not found");
        }
        else
        {

            Console.WriteLine("                                                   user was deleted successfully");
            users.Remove(findUser);
            notificationService.SendNotificationOnSuccess("Deleting User : ",findUser.Name);


        }
    }


}
