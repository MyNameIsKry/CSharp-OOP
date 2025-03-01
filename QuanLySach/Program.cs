namespace QuanLySach {
    public enum BookStatus {
            Available,
            Borrowed,
            NotFound
    }

    public class Book {
        public string BookId { get; private set; }
        public string BookTitle { get; private set; }
        public string BookAuthor { get; private set; }
        public int PublishYear { get; private set; }
        public BookStatus Status { get; set; }


        public Book(string bookId, string bookTitle, string bookAuthor, int publishYear, BookStatus status) {
            BookId = bookId;
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            PublishYear = publishYear;
            Status = status;
        }
    }
    

    class User {
        public string UserId { get; private set; }
        public string UserName { get; private set; } 
        public List<Book> BorrowedBooks { get; private set; } 

        public User(string userId, string userName) {
            UserId = userId;
            UserName = userName;
            BorrowedBooks = new List<Book>();
        }
    }

    public class BookManagement: Book {
        protected List<Book> Books = new List<Book>();

        public BookManagement(
            string bookId, 
            string bookTitle, 
            string bookAuthor, 
            int publishYear, 
            BookStatus status
        ): base(bookId, bookTitle, bookAuthor, publishYear, status) {

        }

        public void AddBook() {
            Console.Write("Nhập số lượng sách muốn nhập: ");
            int bookAmountInput = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < bookAmountInput; i++) {
                Console.Write("Nhập id sách: ");
                string bookId = Console.ReadLine()!;
                Console.Write("Nhập tên sách: ");
                string bookTitle = Console.ReadLine()!;
                Console.Write("Nhập tên tác giả: ");
                string bookAuthor = Console.ReadLine()!;
                Console.Write("Nhập năm xuất bản: ");
                int publishYear = int.Parse(Console.ReadLine()!);
                new Book(bookId, bookTitle, bookAuthor, publishYear, BookStatus.Available);
            }
        }

        public void BookList() {
            foreach(Book book in Books) {
            Console.WriteLine($"ID: {book.BookId}, Title: {book.BookTitle}, " +
                    $"Author: {book.BookAuthor}, Status: {book.Status}");
            }
        }

        public BookStatus CheckBookStatus() {
            string bookId = Console.ReadLine()!;
            foreach(Book book in Books) {
                if (book.BookId == bookId)
                    return book.Status;
                return BookStatus.NotFound;
            }
            return BookStatus.NotFound;
        }
    }                   
}