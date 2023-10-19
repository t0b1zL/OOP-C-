using System;

static class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Default;

        object s, t, a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12;

        Console.Write("Введіть s: ");
        s = double.Parse(Console.ReadLine());

        Console.Write("Введіть t: ");
        t = double.Parse(Console.ReadLine());

        Console.Write("Введіть a0: ");
        a0 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a1: ");
        a1 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a2: ");
        a2 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a3: ");
        a3 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a4: ");
        a4 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a5: ");
        a5 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a6: ");
        a6 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a7: ");
        a7 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a8: ");
        a8 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a9: ");
        a9 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a10: ");
        a10 = double.Parse(Console.ReadLine());
         
        Console.Write("Введіть a11: ");
        a11 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a12: ");
        a12 = double.Parse(Console.ReadLine());

        object x = 1.0;
        object y = t;
        object z = (double)s - (double)t;
        object p = (double)x * ((double)a12 * Math.Pow((double)x, 12) + (double)a11 * Math.Pow((double)x, 11) + (double)a10 * Math.Pow((double)x, 10) + (double)a9 * Math.Pow((double)x, 9) + (double)a8 * Math.Pow((double)x, 8) + (double)a7 * Math.Pow((double)x, 7) + (double)a6 * Math.Pow((double)x, 6) + (double)a5 * Math.Pow((double)x, 5) + (double)a4 * Math.Pow((double)x, 4) + (double)a3 * Math.Pow((double)x, 3) + (double)a2 * Math.Pow((double)x, 2) + (double)a1 * (double)x + (double)a0); // p(1)
        object result = (double)p - (double)y + Math.Pow((double)p, 2) * (double)z - Math.Pow((double)p, 3) * 1.0;
        
        Console.WriteLine($"Результат виразу: {result}");
    }
}


/*using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        
        double s, t, a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12;

        Console.Write("Введіть s: ");
        s = double.Parse(Console.ReadLine());

        Console.Write("Введіть t: ");
        t = double.Parse(Console.ReadLine());

        Console.Write("Введіть a0: ");
        a0 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a1: ");
        a1 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a2: ");
        a2 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a3: ");
        a3 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a4: ");
        a4 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a5: ");
        a5 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a6: ");
        a6 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a7: ");
        a7 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a8: ");
        a8 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a9: ");
        a9 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a10: ");
        a10 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a11: ");
        a11 = double.Parse(Console.ReadLine());

        Console.Write("Введіть a12: ");
        a12 = double.Parse(Console.ReadLine());

        // Обчислення виразу
        double x = 1.0; // p(1)
        double y = t; // p(t)
        double z = s - t; // s - t
        double p = x * (a12 * Math.Pow(x, 12) + a11 * Math.Pow(x, 11) + a10 * Math.Pow(x, 10) + a9 * Math.Pow(x, 9) + a8 * Math.Pow(x, 8) + a7 * Math.Pow(x, 7) + a6 * Math.Pow(x, 6) + a5 * Math.Pow(x, 5) + a4 * Math.Pow(x, 4) + a3 * Math.Pow(x, 3) + a2 * Math.Pow(x, 2) + a1 * x + a0); // p(1)
        double result = p - y + Math.Pow(p, 2) * z - Math.Pow(p, 3) * 1.0; // Обчислення виразу

        // Виведення результату
        Console.WriteLine($"Результат виразу: {result}");
    }
}
*/
