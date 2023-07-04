// See https://aka.ms/new-console-template for more information
//BP1-1-2-1 Ошибки компиляции.mp4
//BP1-1-2-2 Ошибки выполнения программы.mp4

using System;

class Program
{
    private static string GetMinX(int a, int b, int c)
{
    if (a == 0 && b == 0)
        {
            return 0.ToString();
        }
    else if (a == 0)
        {
            return "Impossible";
        }
    else
        {
            return (-b / (2.0 * a)).ToString();
        }
}
    static int Divide(int a)
    {
        return 100/a;
    }
    static void Main (string[] args) 
    {
        // int b = 0;
        // Console.WriteLine("Write a namber:");
        // try
        // {
        //     b = int.Parse(Console.ReadLine());
        // }
        // catch 
        // {
        //     Console.WriteLine("String is not correct format!!!");
        //     return;
        // }

        // if (b == 0)
        //     Console.WriteLine("namber is zero!!!");
        // else
        //     Console.WriteLine(Divide(b));

        Console.WriteLine(GetMinX(1, 2, 3));
        Console.WriteLine(GetMinX(0, 3, 2));
        Console.WriteLine(GetMinX(1, -2, -3));
        Console.WriteLine(GetMinX(5, 2, 1));
        Console.WriteLine(GetMinX(4, 3, 2));
        Console.WriteLine(GetMinX(0, 4, 5));
        
        // // А в этих случаях решение существует:
        Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
        Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
    }

}
