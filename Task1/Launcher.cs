using System.Runtime.CompilerServices;

internal class Task1
{
    public void Start()
    {
        var library = new Library();

        // Создание книг
        var book1 = new Book("STALKER", "Vasiliy Oreshnikov", 13);
        var book2 = new Book("Metro 2033", "Dmitry Glukhovsky", 5);
        var book3 = new Book("Master and Margarita", "Mikhail Bulgakov", 2);

        // Добавление книг
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        // Проверка добавления
        book1.ShowAttributes();
        book2.ShowAttributes();
        book3.ShowAttributes();

        // Удаление книги
        library.RemoveBook(book2);

        // Создание читателей
        var reader1 = new Reader("Ivan Ivanov");
        var reader2 = new Reader("Anna Petrova");

        // Регистрация читателей
        library.RegisterReader(reader1);
        library.RegisterReader(reader2);

        // Выдача книги
        bool issued = library.IssueBook(book1, reader1);
        Console.WriteLine($"Книга выдана: {issued}, осталось экземпляров: {book1.Quantity}");

        // Возврат книги
        bool returned = library.ReturnBook(book1, reader1);
        Console.WriteLine($"Книга возвращена: {returned}, осталось экземпляров: {book1.Quantity}");

        // Удаление читателя
        library.RemoveReader(reader2);
    }
}