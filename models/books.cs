using System;
/// <summary>
/// creates the book class with the properties of title, author, genre, and id
/// </summary>
namespace Books.models {
    public class Book {
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre BookGenre { get; set; }
        public string Id { get; set; }

        public enum Genre {
            HOR = 1,
            FIC = 2,
            NON = 3,
            SCI = 4,
            FAN = 5,
            BIO = 6,

        }
// constructor for the book class
        public Book() {
            this.Title = "Unknown";
            this.Author = "Unknown";
            this.BookGenre = Genre.NON;
            this.Id = "0";
        }
        //constructor for the book class with parameters
        public Book(string title, string author, Genre genre, string id) {
            this.Title = title;
            this.Author = author;
            this.BookGenre = genre;
            this.Id = id;
        }
        /// <summary>
        /// used when adding a new book to the list for the user to select a genre
        /// </summary>
        /// <param name="newBook">Placeholder for the book being currently entered</param>
        public void setGenre(Book newBook) {
            Console.WriteLine("Enter the genre of the book: \n" +
                "1. Horror\n" +
                "2. Fiction\n" +
                "3. Non-Fiction\n" +
                "4. Science Fiction\n" +
                "5. Fantasy\n" +
                "6. Biography\n");
            //user input for the genre
            string choice = Console.ReadLine();
            //switch statement to assign the genre to the book
            do {
                switch (choice) {
                    case "1":
                        newBook.BookGenre = Genre.HOR;
                        break;
                    case "2":
                        newBook.BookGenre = Genre.FIC;
                        break;
                    case "3":
                        newBook.BookGenre = Genre.NON;
                        break;
                    case "4":
                        newBook.BookGenre = Genre.SCI;
                        break;
                    case "5":
                        newBook.BookGenre = Genre.FAN;
                        break;
                    case "6":
                        newBook.BookGenre = Genre.BIO;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 6: ");
                        continue;
                }
                break;
            } while (true);
        } 


/// <summary>
/// Assigns an id for the book, need to check against the list of books to make sure it is unique
/// </summary>
/// <param name="newBook">Placeholder for the book being added</param>
        public void assignId(Book newBook, List<Book> library) {
            //user input for the id
            Console.WriteLine("Enter the id for the book: ");
            string id = Console.ReadLine();
            //checks to see if the id is valid
            if (IsValidId(id)) {
                //checks to see if the id is unique
                if (IsUnique(id, library)) {
                    newBook.Id = id;
                } else {
                    Console.WriteLine("That id is already in use. Please enter a unique id: ");
                    assignId(newBook, library);
                }
            } else {
                Console.WriteLine("Invalid id. Please enter a valid id: ");
                assignId(newBook, library);
            }

        }
/// <summary>
/// Just making sure the id entered by user is not null or blank or whitespace.
/// </summary>
/// <param name="input">User input</param>
/// <returns>True if the id is not blank</returns>
        private bool IsValidId(string input) {
            return !string.IsNullOrWhiteSpace(input);
        }

    }

}