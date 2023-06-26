// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static int globalVariabl; 
    static int globalVariabl2; 
    static void DoWork()
    {
        globalVariabl = 10;
    }
    static int DoWork2()
    {
        return 12;
    }
    void M1() {
		int i = 0;
		{
			int i = 1;
		}
	}
    void M2(int i) 
    {
		int i = 0;
	}
    void M3() {
		// Фигурными скобками можно группировать операторы (правда почти никогда этого делать не стоит)
    // и каждая пара фигурных скобок создает свою область видимости.
		{
			int i = 0;
		}
		{
			int i = 1;
		}
	}
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello, World!");
           
        Console.WriteLine(globalVariabl);
        DoWork();
        Console.WriteLine(globalVariabl);
        
        int localVariabl2 = 0;
        localVariabl2 = DoWork2();
        Console.WriteLine(localVariabl2);




    }


}
