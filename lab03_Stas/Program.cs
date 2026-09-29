using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Завдання 1");
        Console.WriteLine();

        Console.Write("Введiть число: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Введiть основу степеня: ");
        int baseNumber = int.Parse(Console.ReadLine());

        int result = 1;

        while (result < number)
        {
            result = result * baseNumber;
        }

        if (result == number)
        {
            Console.WriteLine("Число є степенем заданого числа.");
        }
        else
        {
            Console.WriteLine("Число не є степенем заданого числа.");
        }

        Console.WriteLine();
        Console.WriteLine("Завдання 2");
        Console.WriteLine();

        Console.Write("Введiть кiлькiсть елементiв масиву: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Введiть елемент " + (i + 1) + ": ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int uniqueCount = 0;

        for (int i = 0; i < n; i++)
        {
            int count = 0;

            for (int j = 0; j < n; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                }
            }

            if (count == 1)
            {
                uniqueCount++;
            }
        }

        Console.WriteLine("Кiлькiсть унікальних елементiв: " + uniqueCount);
    }
}