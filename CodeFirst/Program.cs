using CodeFirst.Context;
using CodeFirst.Entities;

namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Library3DbContext context = new Library3DbContext())
            {
                var authors = new List<Author>
                {
                    new Author { FirstName = "John", LastName = "Doe" },
                    new Author { FirstName = "Jane", LastName = "Smith" },
                    new Author { FirstName = "Emily", LastName = "Johnson" },
                    new Author { FirstName = "Michael", LastName = "Williams" },
                    new Author { FirstName = "David", LastName = "Brown" },
                    new Author { FirstName = "Sarah", LastName = "Jones" }
                };
                context.Authors.AddRange(authors);

              
                var bookTypes = new List<BookType>
                {
                    new BookType { Name = "Science Fiction" },
                    new BookType { Name = "Fantasy" },
                    new BookType { Name = "Mystery" },
                    new BookType { Name = "Biography" },
                    new BookType { Name = "History" },
                    new BookType { Name = "Romance" }
                };
                context.BookTypes.AddRange(bookTypes);

                
                var books = new List<Book>
                {
                    new Book { Name = "Book 1", PageCount = 200, Author = authors[0], BookType = bookTypes[0] },
                    new Book { Name = "Book 2", PageCount = 150, Author = authors[1], BookType = bookTypes[1] },
                    new Book { Name = "Book 3", PageCount = 300, Author = authors[2], BookType = bookTypes[2] },
                    new Book { Name = "Book 4", PageCount = 250, Author = authors[3], BookType = bookTypes[3] },
                    new Book { Name = "Book 5", PageCount = 180, Author = authors[4], BookType = bookTypes[4] },
                    new Book { Name = "Book 6", PageCount = 220, Author = authors[5], BookType = bookTypes[5] }
                };
                context.Books.AddRange(books);

               
                var students = new List<Student>
                {
                    new Student { FirstName = "Alice", LastName = "Green", SchoolNumber = "123", Gender = Gender.Female, BirthDay = new DateTime(2000, 1, 1), PhoneNumber = "1234567890" },
                    new Student { FirstName = "Bob", LastName = "Blue", SchoolNumber = "124", Gender = Gender.Male, BirthDay = new DateTime(2001, 2, 2), PhoneNumber = "0987654321" },
                    new Student { FirstName = "Charlie", LastName = "Yellow", SchoolNumber = "125", Gender = Gender.Male, BirthDay = new DateTime(2002, 3, 3), PhoneNumber = "1112223334" },
                    new Student { FirstName = "Daisy", LastName = "Purple", SchoolNumber = "126", Gender = Gender.Female, BirthDay = new DateTime(2003, 4, 4), PhoneNumber = "5556667778" },
                    new Student { FirstName = "Eve", LastName = "Orange", SchoolNumber = "127", Gender = Gender.Female, BirthDay = new DateTime(2004, 5, 5), PhoneNumber = "9998887776" },
                    new Student { FirstName = "Frank", LastName = "Black", SchoolNumber = "128", Gender = Gender.Male, BirthDay = new DateTime(2005, 6, 6), PhoneNumber = "4443332221" }
                };
                context.Students.AddRange(students);

             
                var operations = new List<Operation>
                {
                    new Operation { Student = students[0], Book = books[0], StartDate = DateTime.UtcNow },
                    new Operation { Student = students[1], Book = books[1], StartDate = DateTime.UtcNow },
                    new Operation { Student = students[2], Book = books[2], StartDate = DateTime.UtcNow },
                    new Operation { Student = students[3], Book = books[3], StartDate = DateTime.UtcNow },
                    new Operation { Student = students[4], Book = books[4], StartDate = DateTime.UtcNow },
                    new Operation { Student = students[5], Book = books[5], StartDate = DateTime.UtcNow }
                };
                context.Operations.AddRange(operations);

             
                context.SaveChanges();
            }
        }
    }
}
    

