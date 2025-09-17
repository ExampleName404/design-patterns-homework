public class Book
{
    public string Name { get; set; } // Имя книги
    public string Author { get; set; } // Автор
    public string ISBN { get; set; } // Индетификатор. Нужен метод для генерации
    public int Quantity { get; set; } // Количество книг


    public Book(string name, string author, int quantity)
    {
        this.Name = name;
        this.Author = author;
        this.ISBN = IsbnGenerator.SimpleGenerate(); // Простой генератор индетификаторa
        this.Quantity = quantity;
    }

    public void ShowAttributes()
    {
        Console.WriteLine($"Name {Name}, Author {Author}, ISBN {ISBN}, Quantity {Quantity}");
    }
}