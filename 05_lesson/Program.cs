// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    /// <summary>
    /// Вычисляет округленное частное двух аргументв
    /// </summary>
    /// <param name="a">Делимое</param>
    /// <param name="b">Делитель</param>
    /// <returns>Округленное частное</returns>
    public static int DivideAndRound(double a, double b)
    {
        return (int)Math.Round(a / b);
    }
    public static void WriteNamber(int a)
    {
        Console.WriteLine("a is int");
        Console.WriteLine(a);
    }
    public static void WriteNamber(double a)
    {
        Console.WriteLine("a is double");
        Console.WriteLine(a);
    }
    static void Main(string[] args)
    {
        double g = 4;
        double h = 3;
        Console.WriteLine();
        int c = DivideAndRound(g, h);
        Console.WriteLine(c);

        int a = 2;
        WriteNamber(a);

        double b = 3;
        WriteNamber(b);


        WriteNamber((double)a);
    }

}
