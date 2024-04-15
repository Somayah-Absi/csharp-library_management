using System;
internal class Program
{


    public abstract class Information
{
        public Guid Id;
        public DateTime CreatedDate;

    public Information()
    {
        Id = Guid.NewGuid();
        CreatedDate = DateTime.Now;
    }
}

// Book class
public class Book : Information
{
    public string Title { get; }

    public Book(string title) : base()
    {
        Title = title;
    }
}

// User class
public class User : Information
{
    public string Name { get; }

    public User(string name) : base()
    {
        Name = name;
    }
}


    public static void Main()
    {
    }
}