using System.Collections.Concurrent;
using System.Collections.Generic;
using Books.models;
using Books.services;

BookService bookService = new BookService();

Book book1 = new Book("The Shining", "Stephen King", Book.Genre.HOR, "1");
Book book2 = new Book("The Great Gatsby", "F. Scott Fitzgerald", Book.Genre.FIC, "2");
Book book3 = new Book("The Art of War", "Sun Tzu", Book.Genre.NON, "3");
Book book4 = new Book("Dune", "Frank Herbert", Book.Genre.SCI, "4");
Book book5 = new Book("The Hobbit", "J.R.R. Tolkien", Book.Genre.FAN, "5");
Book book6 = new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", Book.Genre.SCI, "6");

List <Book> library = new List<Book>();

library.Add(book1);
library.Add(book2);
library.Add(book3);
library.Add(book4);
library.Add(book5);
library.Add(book6);

Console.WriteLine("Welcome to the library!");
Console.WriteLine("The current list of books looks like this: ");
BookService.displayBooks(library);

string choice = "0";

do {
    Console.WriteLine("What would you like to do? \n" + 
    "1. Add a book\n" +
    "2. Display all books\n" +
    "3. Look up a book by Id\n" +
    "4. Remove a book\n" +
    "5. Exit\n");
    choice = Console.ReadLine();
    switch (choice) {
        case "1":
            BookService.addBook(library);
            break;
        case "2":
            BookService.displayBooks(library);
            break;
        case "3":
            BookService.lookup(library);
            break;
        case "4":
            BookService.removeBook(library);
            break;
        case "5":
            Console.WriteLine("Goodbye!");
            break;
        default:
            Console.WriteLine("Invalid input. Please enter a number between 1 and 5: ");
            break;
    } 
} while (choice != "5");


