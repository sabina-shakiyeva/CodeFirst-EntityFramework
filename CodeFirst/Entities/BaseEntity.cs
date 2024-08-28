namespace CodeFirst.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public DataStatus Status { get; set; }=DataStatus.Inserted;
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? ModifiedDate { get; set; }
}

public enum DataStatus
{
    Inserted,
    Updated,
    Deleted
}