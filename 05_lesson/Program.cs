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
    public static double GetSquare(double a)
    {
        return a * a;
    }

    public static void Print (double a) 
    {
        Console.WriteLine(a);
    }

    public static void Print (int a) 
    {
        Console.WriteLine(a);
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

    private static string GetGreetingMessage(string name, double salary) 
    {
        return "Hello, " +  name + ", your salary is " + Math.Round(salary, 0) + ".";
    }
    private static string GetLastHalf(string stri) 
    {
        stri = stri.Substring(stri.Length/2, stri.Length/2);
        return stri.Replace(" ", "");
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

       
        string name = "Nik";
        double salary = 12.56;
        string str = GetGreetingMessage(name, salary);
        Console.WriteLine(str);

        Print(GetSquare(42));

        string strl = "123 45678 91";
        Console.WriteLine(GetLastHalf(strl));

    }

}
