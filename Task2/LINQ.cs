public class Task2_LINQ()
{
    public void PrintPositiveNumbers(int[] numbers)
    {
        foreach (var number in numbers)
        {
            if (number > 0)
            {
                Console.WriteLine($"Number > 0: {number}");
            }
        }
    } // Вывод каждого + значения из массива

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            return 0;
        }

        return a / b;
    } // катчи патчи ваши. Trycatch это на bmx чувак катается
}