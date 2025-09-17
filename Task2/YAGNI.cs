public class Task2_Yagni // YAGNI (You Aren't Gonna Need It):
{
    

}

public class User
{ 
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public void SaveToDatabase()
    {
        // Код для сохранения пользователя в базу данных
    }
} // нинаю вроде так

public class FileReader
{
    public string ReadFile(string filePath)
    {
        return "file content";
    }
} // удалили буферы не буферы

public class ReportGenerator
{
    public void GeneratePdfReport()
    {
        // Генерация отчета
    }
} // один метод все, никто ничего не просил значит не нужно