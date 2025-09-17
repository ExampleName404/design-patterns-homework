public class IsbnGenerator
{
    public static string SimpleGenerate()
    {
        var random = new Random();
        string isbn = "987"; // дефолт префикс для книг как я понял

        for (int i = 0; i < 9; i++)
        {
            isbn += random.Next(0, 10).ToString();
        }
        // контрольная цифра
        isbn += random.Next(0, 10).ToString();
        return isbn;
    }
}