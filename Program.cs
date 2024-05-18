using System;

class Program
{
    static void Main()
    {
        //Вводим строки с клавиатуры:
        Console.WriteLine("Введите строки через пробел:");
        string input = Console.ReadLine();
        string[] initialArray = input.Split(' ');

        // Считаем количество строк, длина которых меньше или равна 3 символам
        int count = 0;
        foreach (string str in initialArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужного размера
        string[] resultArray = new string[count];

        // Заполняем новый массив строками, удовлетворяющими условию
        int index = 0;
        foreach (string str in initialArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        // Выводим результат
        Console.WriteLine("[" + string.Join(", ", initialArray) + "] → [" + string.Join(", ", resultArray) + "]");
    }
}