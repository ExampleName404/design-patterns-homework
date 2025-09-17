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