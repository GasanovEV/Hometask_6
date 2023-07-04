double k1, b1, k2, b2;

k1 = GetNumberFromUser("Введите значение k1: ", "Ошибка ввода");
b1 = GetNumberFromUser("Введите значение b1: ", "Ошибка ввода");
k2 = GetNumberFromUser("Введите значение k2: ", "Ошибка ввода");
b2 = GetNumberFromUser("Введите значение b2: ", "Ошибка ввода");

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны и не имеют точки пересечения.");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения: ({x}, {y})");

}

double GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (double.TryParse(Console.ReadLine(), out double userNumber))
        {
            return userNumber;
        }
        else
        {
            Console.WriteLine(errorMessage);
        }
    }
}