public class Library
{
    // Атрибуты
    private List<Book> books = new List<Book>();
    private List<Reader> readers = new List<Reader>();

    // Методы
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public void RemoveReader(Reader reader)
    {
        readers.Remove(reader);
    }

    public void RegisterReader(Reader reader)
    {
        readers.Add(reader);
    }

    public bool IssueBook(Book book, Reader reader)
    {
        if (books.Contains(book) && book.Quantity > 0 && readers.Contains(reader))
        {
            book.Quantity--;
            // Можно добавить логику учёта выданных книг
            return true;
        }
        return false;
    }

    public bool ReturnBook(Book book, Reader reader)
    {
        if (books.Contains(book) && readers.Contains(reader))
        {
            book.Quantity++;
            // Можно добавить логику учёта возврата
            return true;
        }
        return false;
    }
}