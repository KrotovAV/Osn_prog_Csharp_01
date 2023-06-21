// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        int a = 2;
        int b = 3;
        int c = (a + b) * 2;
        Console.WriteLine(c);
        int d = b % a; // остаток от деления
        Console.WriteLine(d);
        int cc = b / a;
        Console.WriteLine(cc);
        double cd = b / a;
        Console.WriteLine(cd);
        double cs = (double)b / a;
        Console.WriteLine(cs);

        double angle = 3.1456;
        Console.WriteLine(Math.Sin(angle));

        double sdf = Math.Pow(a, b);
        Console.WriteLine(sdf);

        var ab = a * b;
        Console.WriteLine(ab);

        a += 2;
        Console.WriteLine(a);

        a -= 4;
		// То же самое, что a=a-4, аналогично с другими операциями.

		a++;
		//Оператор инкремента
		//То же самое, что a=a+1

		a--;
		//Оператор декремента
		//То же самое, что a=a-1

		++a;
		//То же самое, что a=a+1, но с одним отличием:

		a = 5;
		Console.WriteLine(a++);
		// выведет 5

		a = 5;
		Console.WriteLine(++a);
		// выведет 6
    }
}
