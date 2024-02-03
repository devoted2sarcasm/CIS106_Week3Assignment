using System;

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

        public Book() {
            this.Title = "Unknown";
            this.Author = "Unknown";
            this.BookGenre = Genre.NON;
            this.Id = "0";
        }
        public Book(string title, string author, Genre genre, string id) {
            this.Title = title;
            this.Author = author;
            this.BookGenre = genre;
            this.Id = id;
        }
        public void setGenre(Book newBook) {
            Console.WriteLine("Enter the genre of the book: \n" +
                "1. Horror\n" +
                "2. Fiction\n" +
                "3. Non-Fiction\n" +
                "4. Science Fiction\n" +
                "5. Fantasy\n" +
                "6. Biography\n");
            string choice = Console.ReadLine();
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


        public void assignId(Book newBook) {
            do {
                Console.WriteLine("Enter the ID of the book: ");
                string input = Console.ReadLine();

                if (IsValidId(input))
                {
                    newBook.Id = input;
                    break; // Exit the loop if the input is valid
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a non-empty ID.");
                }
            } while (true);
        }

        private bool IsValidId(string input) {
            // You can add more validation rules as needed
            return !string.IsNullOrWhiteSpace(input);
        }

    }

}