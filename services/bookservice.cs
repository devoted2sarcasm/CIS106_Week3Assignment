using Books.models;

namespace Books.services {
    public class BookService {
        public static void addBook(List<Book> library, Book newBook) {
            library.Add(newBook);
        }
        public static void addBook(List<Book> library) {
            Book newBook = new Book();
            Console.WriteLine("Enter the title of the book: ");
            newBook.Title = Console.ReadLine();
            Console.WriteLine("Enter the author of the book: ");
            newBook.Author = Console.ReadLine();
            newBook.setGenre(newBook);
            newBook.assignId(newBook);
            library.Add(newBook);

        }
        
        public static void displayBooks(List<Book> library) {
            foreach (Book book in library) {
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Genre: " + book.BookGenre);
                Console.WriteLine("ID: " + book.Id);
                Console.WriteLine("--------------------");
            }
        }

        public static void lookup(List<Book> library) {
            Console.WriteLine("Enter a book Id: ");
            string id = Console.ReadLine();
            foreach (Book book in library) {
                if (book.Id == id) {
                    Console.WriteLine("Title: " + book.Title);
                    Console.WriteLine("Author: " + book.Author);
                    Console.WriteLine("Genre: " + book.BookGenre);
                    Console.WriteLine("ID: " + book.Id);
                }
            }
        }

        public static void removeBook(List<Book> library) {
            Console.WriteLine("Enter a book Id: ");
            string id = Console.ReadLine();
            foreach (Book book in library) {
                if (book.Id == id) {
                    library.Remove(book);
                    Console.WriteLine($"{book.Title} has been removed from the library.");
                }
            }
        }
    }

}