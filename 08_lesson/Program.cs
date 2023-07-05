// See https://aka.ms/new-console-template for more information
//BP1-1-2-3 Отладка.mp4
//
using System;

class Program
{
    static double GetDescriminant(double a, double b, double c) 
    {
        return b * b - 4 * a * c;
    }

    static double GetFirstRoot(double a, double b, double c) 
    {
        double descriminant = GetDescriminant(a, b, c);
        double squareRoot = Math.Sqrt(descriminant);
        return (- b - squareRoot) / ( 2 *a);

    }
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        double result = GetFirstRoot(1, 1, 1);
        Console.WriteLine(result);
    }
}

