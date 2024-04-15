using System;
public class Book : LibraryData
{
    public string Title { get; }

    public Book(string title,DateTime? createdDate = null) : base(createdDate)
    {
        Title = title;
    }
}
