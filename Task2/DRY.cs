
public class Task2_Dry // Don repeat yourself
{
    public void Log(string message, string level)
    {
        Console.WriteLine($"{level}: {message}");
    }
    // Пример использования:
    // Log("Ошибка подключения", "ERROR");
    // Log("Внимание!", "WARNING");
    // Log("Информация", "INFO");
    // DRY (Don't Repeat Yourself): те объеденили 3 метода
}

public static class Config
{
    public static string ConnectionString = "Server=myServer;Database=myDb;User Id=myUser;Password=myPass;";
}

public class DatabaseService
{
    public void Connect()
    {
        string connectionString = Config.ConnectionString;
        // Логика подключения к базе данных
    }
}

public class LoggingService
{
    public void Log(string message)
    {
        string connectionString = Config.ConnectionString;
        // Логика записи лога в базу данных
    }
}

/* Убрали дублирование + подключение вынесли отдельно*/