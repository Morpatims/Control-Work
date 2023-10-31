using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива, разделяя их пробелами:");
        string[] inputArray = Console.ReadLine().Split();

        string[] newArray = new string[inputArray.Length];
        int newIndex = 0;

        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                newArray[newIndex] = item;
                newIndex++;
            }
        }

        string[] finalArray = new string[newIndex];
        
        Array.Copy(newArray, finalArray, newIndex);

        Console.WriteLine("Итоговый массив:");
        foreach (string item in finalArray)
        {
            Console.WriteLine(item);
        }
    }
}
