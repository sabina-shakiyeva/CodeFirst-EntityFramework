﻿namespace CodeFirst.Entities;

public class Author:BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public ICollection<Book> Books { get; set; } = new List<Book>();
}
