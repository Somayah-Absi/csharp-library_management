using System;
internal class Print
{
    public static void Main()
    {
        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));

        Console.WriteLine($"{book1.Title}---{book1.CreatedDate}-----{book1.Id}");

        var user9 = new User("Ian");

        var library = new Library();

        library.AddBook(book1);

        library.FindItemByName("The Great Gatsby");
    }

}
