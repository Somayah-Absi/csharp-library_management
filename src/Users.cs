using System;
public class User : LibraryData
{
    public string Name { get; }

    public User(string name, DateTime? createdDate = null) : base(createdDate)
    {
        Name = name;
    }
}