namespace CodeFirst.Entities;

public class BookType:BaseEntity
{
    public string Name { get; set; }

    public ICollection<Book> Books { get; set; } = new List<Book>();
}
