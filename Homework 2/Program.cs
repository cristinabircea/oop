using System;
using LibrarySystem;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance using the first constructor
        Book book1 = new Book("Pride and Prejudice", "Jane Austen");

        // Create an instance using the overloaded constructor
        Book book2 = new Book(To Kill a Mockingbird", "Harper Lee", 281);

        // Check out book1 and return book2
        book1.CheckOut();
        book2.ReturnBook();

        // Print the details of both books
        Console.WriteLine(book1);
        Console.WriteLine(book2);
    }
}
