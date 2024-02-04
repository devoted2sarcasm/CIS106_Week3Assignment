//uses the book class for some methods
using Books.models;

//creates the book service class
namespace Books.services {

    public class BookService {

        //method to add a book to the library
        public static void addBook(List<Book> library, Book newBook) {
            library.Add(newBook);
        }

        /// <summary>
        /// method to add a book to the library via user input
        /// </summary>
        /// <param name="library">using master library to add the book into</param>
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

        /// <summary>
        /// method to display all the books in the library
        /// </summary>
        /// <param name="library">master library name</param>
        public static void displayBooks(List<Book> library) {
            foreach (Book book in library) {
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Genre: " + book.BookGenre);
                Console.WriteLine("ID: " + book.Id);
                Console.WriteLine("--------------------");
            }
        }

        /// <summary>
        /// method to look up a book in the library by id
        /// </summary>
        /// <param name="library">master library to check for active id</param>
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

        /// <summary>
        /// method to remove a book from the library
        /// </summary>
        /// <param name="library">master library name</param>
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