using System;

public abstract class LibraryData
{
    public Guid Id;
    public DateTime CreatedDate;

    public LibraryData(DateTime? createdDate = null)
    {
        Id = Guid.NewGuid();
        CreatedDate = createdDate ?? DateTime.Now;
    }
}
