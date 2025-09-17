public class Reader
{
    public string? Name { get; set; } // Имя

    /* как в лабке */
    private static int _counter = 0;
    public int Id { get; set; } // Индетификатор

    // Почти такой же конструктор как и в лаб
    public Reader(string name)
    {
        _counter++;
        this.Name = Name;
        this.Id = _counter;
    }
}