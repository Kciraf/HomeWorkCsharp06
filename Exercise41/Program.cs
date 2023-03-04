// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] InputArray(string text)
{
    System.Console.WriteLine(text);
    return  Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}

int CountPositive(int[] arr)
{
    int result = -1;            // "-" На случай ошибки счета
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) result++;
    }
    return result++;        // добавляем 1 для компенсации приобъявлении
}

int[] numbers = InputArray("Введите числа целые числа через пробел: ");

System.Console.WriteLine("Введено положительных чисел: " + CountPositive(numbers));
