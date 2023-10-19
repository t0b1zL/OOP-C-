using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static List<Tuple<string, string, int, string>> datingAgencyDatabase = new List<Tuple<string, string, int, string>>();
    static List<Tuple<string, string>> archive = new List<Tuple<string, string>>();

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.OutputEncoding = System.Text.Encoding.Default;
        while (true)
        {
            Console.WriteLine("Виберіть завдання:");
            Console.WriteLine("1. Завдання 1");
            Console.WriteLine("2. Завдання 2");
            Console.WriteLine("3. Завдання 3");
            Console.WriteLine("4. Завдання 4");
            Console.WriteLine("5. Вихід");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Ви вибрали завдання 1");
                    int[] array = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };

                    int indexOfFirstZero = Array.IndexOf(array, 0);

                    int minAbsoluteValue = int.MaxValue;
                    foreach (int number in array)
                    {
                        int absoluteValue = Math.Abs(number);
                        if (absoluteValue < minAbsoluteValue)
                        {
                            minAbsoluteValue = absoluteValue;
                        }
                    }
                    int sumAfterFirstZero = 0;
                    if (indexOfFirstZero >= 0 && indexOfFirstZero < array.Length - 1)
                    {
                        for (int i = indexOfFirstZero + 1; i < array.Length; i++)
                        {
                            sumAfterFirstZero += Math.Abs(array[i]);
                        }
                    }
                    int[] transformedArray = new int[array.Length];
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            transformedArray[i / 2] = array[i];
                        }
                        else
                        {
                            transformedArray[transformedArray.Length / 2 + i / 2] = array[i];
                        }
                    }

                    Console.WriteLine($"Мінімальний за модулем елемент: {minAbsoluteValue}");
                    Console.WriteLine($"Сума модулів елементів після першого нульового елемента: {sumAfterFirstZero}");
                    Console.WriteLine("Перетворений масив:");
                    Console.WriteLine(string.Join(", ", transformedArray));
                    break;
                case "2":
                    Console.WriteLine("Ви вибрали завдання 2");
                    int rows, cols;

                    Console.Write("Введіть кількість рядків: ");
                    if (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
                    {
                        Console.WriteLine("Некоректне значення для кількості рядків.");
                        return;
                    }

                    Console.Write("Введіть кількість стовпців: ");
                    if (!int.TryParse(Console.ReadLine(), out cols) || cols <= 0)
                    {
                        Console.WriteLine("Некоректне значення для кількості стовпців.");
                        return;
                    }

                    int[,] matrix = new int[rows, cols];

                    Console.WriteLine("Введіть елементи матриці:");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write($"matrix[{i}][{j}] = ");
                            if (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                            {
                                Console.WriteLine("Некоректне значення для елемента матриці.");
                                return;
                            }
                        }
                    }

                    Console.Write("Ви хочете зсувати вправо (R) чи вниз (D)? ");
                    char mode = Console.ReadLine().ToUpper()[0];

                    Console.Write("Введіть кількість позицій для зсуву: ");
                    if (!int.TryParse(Console.ReadLine(), out int shiftPositions) || shiftPositions < 0)
                    {
                        Console.WriteLine("Некоректне значення для кількості позицій для зсуву.");
                        return;
                    }

                    if (mode == 'R')
                    {
                        ShiftRight(matrix, shiftPositions);
                    }
                    else if (mode == 'D')
                    {
                        ShiftDown(matrix, shiftPositions);
                    }
                    else
                    {
                        Console.WriteLine("Невірний режим. Виберіть 'R' або 'D'.");
                        return;
                    }

                    Console.WriteLine("Результат зсуву:");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "3":
                    Console.WriteLine("Ви вибрали завдання 3");
                    Console.WriteLine("Введіть текстовий рядок:");
                    string inputText = Console.ReadLine();

                    int wordsStartingWithVowelsCount = CountWordsStartingWithVowels(inputText);

                    Console.WriteLine($"Кількість слів, які починаються з голосної літери: {wordsStartingWithVowelsCount}");

                    string[] wordsWithOddConsonants = GetWordsWithOddConsonants(inputText);
                    Console.WriteLine("Слова, які містять непарну кількість приголосних літер:");
                    foreach (var word in wordsWithOddConsonants)
                    {
                        Console.WriteLine(word);
                    }

                    string textWithoutNumbers = RemoveNumbers(inputText);
                    Console.WriteLine("Текст без чисел:");
                    Console.WriteLine(textWithoutNumbers);
                    break;
                case "4":
                    Console.WriteLine("Ви вибрали завдання 4");
                    while (true)
                    {
                        Console.WriteLine("Виберіть дію:");
                        Console.WriteLine("1. Реєстрація нового клієнта");
                        Console.WriteLine("2. Пошук іншого клієнта для знайомства");
                        Console.WriteLine("3. Виходити з програми");
                        string innerChoice = Console.ReadLine();

                        switch (innerChoice)
                        {
                            case "1":
                                RegisterNewClient();
                                break;
                            case "2":
                                FindMatch();
                                break;
                            case "3":
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                                break;
                        }
                    }
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }

    static void ShiftRight(int[,] matrix, int positions)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = cols - 1; j >= positions; j--)
            {
                matrix[i, j] = matrix[i, j - positions];
            }

            for (int j = 0; j < positions; j++)
            {
                matrix[i, j] = 0;
            }
        }
    }

    static void ShiftDown(int[,] matrix, int positions)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = rows - 1; i >= positions; i--)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = matrix[i - positions, j];
            }
        }

        for (int i = 0; i < positions; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = 0;
            }
        }
    }

    static int CountWordsStartingWithVowels(string text)
    {
        string[] words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string vowels = "AEIOUaeiou";
        return words.Count(word => vowels.Contains(word[0]));
    }

    static string[] GetWordsWithOddConsonants(string text)
    {
        string[] words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string consonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
        return words.Where(word => word.Count(c => consonants.Contains(c)) % 2 != 0).ToArray();
    }

    static string RemoveNumbers(string text)
    {
        return Regex.Replace(text, @"\d", "");
    }

    static void RegisterNewClient()
    {
        Console.WriteLine("Введіть ім'я:");
        string name = Console.ReadLine();

        Console.WriteLine("Введіть стать:");
        string gender = Console.ReadLine();

        Console.WriteLine("Введіть вік:");
        if (!int.TryParse(Console.ReadLine(), out int age))
        {
            Console.WriteLine("Невірний формат віку. Реєстрація скасована.");
            return;
        }

        Console.WriteLine("Введіть опис:");
        string description = Console.ReadLine();

        Tuple<string, string, int, string> clientData = new Tuple<string, string, int, string>(name, gender, age, description);
        datingAgencyDatabase.Add(clientData);
        Console.WriteLine("Клієнт успішно зареєстрований!");
    }

    static void FindMatch()
    {
        Console.WriteLine("Введіть свій ідентифікаційний номер:");
        int id = int.Parse(Console.ReadLine());

        if (id >= 0 && id < datingAgencyDatabase.Count)
        {
            Tuple<string, string, int, string> clientData = datingAgencyDatabase[id];

            Console.WriteLine($"Знайдено відповідний клієнт: {clientData.Item1}");
            Console.WriteLine("Бажаєте зустрітися з цим клієнтом? (Так/Ні)");
            string response = Console.ReadLine();

            if (response.ToLower() == "так")
            {
                Console.WriteLine("Зустріч організована! Перший контакт відбудеться в агентстві.");
                datingAgencyDatabase.RemoveAt(id);
                archive.Add(new Tuple<string, string>(clientData.Item1, clientData.Item2));
            }
            else
            {
                Console.WriteLine("Дякую за ваш вибір.");
            }
        }
        else
        {
            Console.WriteLine("Клієнта з таким ідентифікаційним номером не знайдено.");
        }
    }
}