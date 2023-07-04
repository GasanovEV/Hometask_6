/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.*/

int m = GetNumberFromUser("Введите количество чисел: ", "Ошибка ввода");
int[] numbers = new int[m];

for (int i = 0; i < m; i++)
{
    numbers[i] = GetNumberFromUser($"Введите число №{i + 1}: ", "Ошибка ввода");
}

int count = 0;
for (int i = 0; i < m; i++)
{
    if (numbers[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество чисел больше 0: {count}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
        {
            return userNumber;
        }
        else
        {
            Console.WriteLine(errorMessage);
        }
    }
}