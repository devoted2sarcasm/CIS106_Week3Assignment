namespace Books.models {
    public class Book {
        public string Title { get; set; }
        public string Author { get; set; }
        public enum Genre {
            HOR = "Horror",
            FIC = "Fiction",
            NON = "Non-Fiction",
            SCI = "Science Fiction",
            FAN = "Fantasy",
            BIO = "Biography",

        }
        public string Id { get; set; }

        public Book(string title, string author, Genre genre, string id) {
            Title = title;
            Author = author;
            Genre = genre;
            Id = id;
        }
        public string getGenre(Book newBook) {
            Console.WriteLine("Enter the genre of the book: \n" +
                "1. Horror\n" +
                "2. Fiction\n" +
                "3. Non-Fiction\n" +
                "4. Science Fiction\n" +
                "5. Fantasy\n" +
                "6. Biography\n" +
                "Enter the number of the genre: ");
            newBook.Genre = Console.ReadLine();
            do {
                switch (newBook.Genre) {
                    case "1":
                        newBook.Genre = Genre.HOR;
                        break;
                    case "2":
                        newBook.Genre = Genre.FIC;
                        break;
                    case "3":
                        newBook.Genre = Genre.NON;
                        break;
                    case "4":
                        newBook.Genre = Genre.SCI;
                        break;
                    case "5":
                        newBook.Genre = Genre.FAN;
                        break;
                    case "6":
                        newBook.Genre = Genre.BIO;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 6: ");
                        newBook.Genre = Console.ReadLine();
                        break;
                }
            } while (newBook.Genre != Genre.HOR || newBook.Genre != Genre.FIC || newBook.Genre != Genre.NON || newBook.Genre != Genre.SCI || newBook.Genre != Genre.FAN || newBook.Genre != Genre.BIO);
        }

        public string assignId(Book newBook) {
            Console.WriteLine("Enter the ID of the book: ");
            newBook.Id = Console.ReadLine();
        }
    }

}