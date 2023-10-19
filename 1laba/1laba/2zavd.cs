using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        Console.Write("Введіть кількість чисел (n): ");
        int n = int.Parse(Console.ReadLine());

        int[] sequence = new int[n];

        Console.WriteLine("Введіть послідовність чисел:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"b{i + 1}: ");
            sequence[i] = int.Parse(Console.ReadLine());
        }

        int count = 0;

        for (int i = 1; i < n; i += 2)
        {
            if (sequence[i] % 2 != 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Кількість членів з парними порядковими номерами та непарними значеннями: {count}");
    }
}