using System;
internal class Print
{
    public static void Main()
    {
        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));

        Console.WriteLine($"{book1.Title}---{book1.CreatedDate}-----{book1.Id}");
        var user8 = new User("Hannah", new DateTime(2024, 8, 1));
        var user9 = new User("Ian");

        var library = new Library();
        library.AddUser(user8);
        library.AddBook(book1);
        library.AddUser(user9);
        Guid bookIdToDelete = book1.Id;
        Guid userIdToDelete = user9.Id;
        library.FindUserByName("Hannah");
        library.FindBookByTitle("The Great Gatsby");
        library.DeleteBook(bookIdToDelete);
        library.DeleteUser(userIdToDelete);
        library.FindUserByName("Ian");


    }

}
