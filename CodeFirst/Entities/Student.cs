﻿namespace CodeFirst.Entities;

public class Student:BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SchoolNumber { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDay { get; set; }
    public string PhoneNumber { get; set; }

    public ICollection<Operation> Operations { get; set; } = new List<Operation>();
}
public enum Gender
{
    Male,
    Female
}
