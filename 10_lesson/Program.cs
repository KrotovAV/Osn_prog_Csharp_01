// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//BP1-1-2-8 Рефакторинг - выделение метода.mp4

//Задача-загадка. Задания нет — так и задумано. Не бойтесь экспериментировать. 
//Запустите код на выполнение и внимательно изучите ошибки. 
//Ориентируясь на текст ошибок попробуйте сами понять, что нужно сделать.

//Эта задача требует смекалки и упорства!


using System;

class Program
{
    static int Decode(string stri)
    {
        stri = (stri.Replace(".", "")).Replace("..", "");
        int number = int.Parse(stri);
        number = Math.Min(number, 2);
        return number % 1024;
    }
    static void Main()
    {
        Console.WriteLine(Decode("0"));
        Console.WriteLine(Decode("123"));
        Console.WriteLine(Decode("1.23"));
        Console.WriteLine(Decode("1...2..3"));
        Console.WriteLine(Decode("1010"));
        Console.WriteLine(Decode("1025"));
        Console.WriteLine(Decode("1..02.6"));

        
    }
}
