// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Formats.Asn1;

class Program
{

    static void Main(string[] args)
    {
        int a = 45;
        Console.WriteLine(a);
        double b = 55.5;
        Console.WriteLine(b);
        long l = 4411000000000055;
        Console.WriteLine(l);
        float f = 4.5f;
        Console.WriteLine(f);
        a = (int)b;
        Console.WriteLine(a);
        float c = (float)b;
        Console.WriteLine(c);

        //checked{
        //int i = (int)l;  
        //}
        //Console.WriteLine(i);
        int ab = (int)Math.Round(b);
        Console.WriteLine(ab);


        string hl = "Hello, World!";
        Console.WriteLine(hl);
        hl = hl + "!" + "!";
        Console.WriteLine(hl);

        int strL = hl.Length;
        Console.WriteLine(strL);

        Console.WriteLine(hl.Substring(0, 5));
        string wo = hl.Substring(7, 6);
        Console.WriteLine(wo);

        char ach = hl[0];
        Console.WriteLine(ach);
        char bch = 'b';
        Console.WriteLine(bch);
        string? n = null;
        Console.WriteLine(n);

        Console.WriteLine("Write a number: ");
        string cons = Console.ReadLine();
        Console.WriteLine(cons);

        int cons_int = int.Parse(cons); // Статический метод - потоу, что вызывается из переменной
        cons_int = cons_int +1;
        string cons_int_str = cons_int.ToString(); // Динамический метод - потоу, что вызывается из переменной
        Console.WriteLine(cons_int_str);



        //Console.WriteLine(cons_int + 1);


        //Console.WriteLine("Hello, World!");
    }

}