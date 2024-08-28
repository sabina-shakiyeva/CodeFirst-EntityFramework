namespace CodeFirst.Entities;

public class Operation:BaseEntity
{
    public int StudentId { get; set; }
    public Student Student { get; set; }

    public int BookId { get; set; }
    public Book Book { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
