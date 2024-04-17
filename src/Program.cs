using System;
internal class Print
{
    public static void Main()
    {
        // Program.cs - You can also change these sample codes to adapt to your design
        var user1 = new User("Alice", new DateTime(2023, 1, 1));
        var user2 = new User("Bob", new DateTime(2023, 2, 1));
        var user3 = new User("Charlie", new DateTime(2023, 3, 1));
        var user4 = new User("David", new DateTime(2023, 4, 1));
        var user5 = new User("Eve", new DateTime(2024, 5, 1));
        var user6 = new User("Fiona", new DateTime(2024, 6, 1));
        var user7 = new User("George", new DateTime(2024, 7, 1));
        var user8 = new User("Hannah", new DateTime(2024, 8, 1));
        var user9 = new User("Ian");
        var user10 = new User("Julia");

        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
        var book2 = new Book("1984", new DateTime(2023, 2, 1));
        var book3 = new Book("To Kill a Mockingbird", new DateTime(2023, 3, 1));
        var book4 = new Book("The Catcher in the Rye", new DateTime(2023, 4, 1));
        var book5 = new Book("Pride and Prejudice", new DateTime(2023, 5, 1));
        var book6 = new Book("Wuthering Heights", new DateTime(2023, 6, 1));
        var book7 = new Book("Jane Eyre", new DateTime(2023, 7, 1));
        var book8 = new Book("Brave New World", new DateTime(2023, 8, 1));
        var book9 = new Book("Moby-Dick", new DateTime(2023, 9, 1));
        var book10 = new Book("War and Peace", new DateTime(2023, 10, 1));
        var book11 = new Book("Hamlet", new DateTime(2023, 11, 1));
        var book12 = new Book("Great Expectations", new DateTime(2023, 12, 1));
        var book13 = new Book("Ulysses", new DateTime(2024, 1, 1));
        var book14 = new Book("The Odyssey", new DateTime(2024, 2, 1));
        var book15 = new Book("The Divine Comedy", new DateTime(2024, 3, 1));
        var book16 = new Book("Crime and Punishment", new DateTime(2024, 4, 1));
        var book17 = new Book("The Brothers Karamazov", new DateTime(2024, 5, 1));
        var book18 = new Book("Don Quixote", new DateTime(2024, 6, 1));
        var book19 = new Book("The Iliad");
        var book20 = new Book("Anna Karenina");

        var emailService = new EmailNotificationService();
        var smsService = new SMSNotificationService();

        var libraryWithEmail = new Library(emailService);
        var libraryWithSMS = new Library(smsService);


        // Demonstrate adding/removing books/users in each library and observe notifications



        //add books to library with email notifications
        //-------------------------------------------------------------
        libraryWithEmail.AddBook(book1);
        libraryWithEmail.AddBook(book2);
        libraryWithEmail.AddBook(book3);
        libraryWithEmail.AddBook(book4);
        libraryWithEmail.AddBook(book5);
        libraryWithEmail.AddBook(book6);
        libraryWithEmail.AddBook(book7);
        libraryWithEmail.AddBook(book8);
        libraryWithEmail.AddBook(book9);
        libraryWithEmail.AddBook(book10);

        //add Users to library with email notifications
        //-------------------------------------------------------------

        libraryWithEmail.AddUser(user6);
        libraryWithEmail.AddUser(user7);
        libraryWithEmail.AddUser(user8);
        libraryWithEmail.AddUser(user9);
        libraryWithEmail.AddUser(user9);
        libraryWithEmail.AddUser(user10);

        //add books to library with SMS notifications
        //-------------------------------------------------------------
        libraryWithSMS.AddBook(book11);
        libraryWithSMS.AddBook(book12);
        libraryWithSMS.AddBook(book13);
        libraryWithSMS.AddBook(book14);
        libraryWithSMS.AddBook(book15);
        libraryWithSMS.AddBook(book16);
        libraryWithSMS.AddBook(book17);
        libraryWithSMS.AddBook(book18);
        libraryWithSMS.AddBook(book19);
        libraryWithSMS.AddBook(book20);
        //add users to library with SMS notifications
        //--------------------------------------------------------------

        libraryWithSMS.AddUser(user1);
        libraryWithSMS.AddUser(user1);
        libraryWithSMS.AddUser(user2);
        libraryWithSMS.AddUser(user3);
        libraryWithSMS.AddUser(user4);
        libraryWithSMS.AddUser(user5);

        //test delete book and user by ID


        Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        libraryWithEmail.DeleteBook(book1.Id);
        libraryWithEmail.DeleteUser(user9.Id);


        //    test find user  and book methods
        Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        libraryWithEmail.FindUserByName("Ian");
        libraryWithEmail.FindUserByName("Hannah");
        libraryWithEmail.FindBookByTitle("The Great Gatsby");


        //test getAllBooks method
        var allBook = libraryWithSMS.GetAllBooks(2, 5);
        foreach (var all in allBook)
        {
            Console.WriteLine("________________________________________________________");
            Console.WriteLine($"Title: {all.Title} \n \n  Created Date: {all.CreatedDate}");

        }
        Console.WriteLine("\n \n***************************************************************************************************");


        //test getAllUsers method
        var allUsers = libraryWithSMS.GetAllUsers(1, 5);
        foreach (var all in allUsers)
        {
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"Title: {all.Name} || Created Date: {all.CreatedDate}");

        }

    }

}
