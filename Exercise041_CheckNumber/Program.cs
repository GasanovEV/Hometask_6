/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.*/


/*Определение параметров массива*/
int arraySize = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода");
int minValue = GetNumberFromUser("Введите нижний предел массива: ", "Ошибка ввода");
int maxValue = GetNumberFromUser("Введите верхний предел массива: ", "Ошибка ввода");

/*вызов метода генерации нового массива */
int[] array = GetArray(arraySize, minValue, maxValue);

/*Вызов метода , подсчитывающего количество положительных чисел в массиве*/
int PositiveNumbers = GetPositiveNumbers(array);




Console.WriteLine($"В сгенерированный массиве: [{string.Join(", ", array)}] -> {PositiveNumbers}  положительных чисел");

/*Генерация масива с задаными параметрами*/
int[] GetArray(int size, int minValue, int maxValue)
{
    if (minValue > maxValue)
    {
        throw new ArgumentException("Минимальное значение не может быть больше максимального значения.");
    }

    Random random = new Random();
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }

    return array;
}
/*Считывание введенного числа и передача его в переменную, при введении
 не целочисленного значения выводится сообщение об ошибке*/
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

/*Метод подсчитывает количество положительных чисел*/
int GetPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}