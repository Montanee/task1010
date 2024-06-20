using System;

class Program
{
    static void Main()
    {
        // Создаем массив строк
        string[] array = { "apple", "banana", "orange", "pear", "grape" };

        // Запрашиваем у пользователя новую строку
        Console.WriteLine("Введите новую строку:");
        string newString = Console.ReadLine();

        // Проверяем, содержится ли введенная строка в массиве
        bool found = false;
        foreach (string str in array)
        {
            if (str == newString)
            {
                found = true;
                break;
            }
        }

        // Выводим соответствующее сообщение
        if (found)
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }
    }
}
