using System;

class Program
{
    static void Square(int a, int b)
    {
        a = a * a;
        b = b * b;
        Console.WriteLine(a + " " + b);
        //a = a + 1;
        //b++; (b = b +1)
        //a = a * a;
        //b *= b; (b = b * b)
        //Console.WriteLine(a + " " + b);
    }

    static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;
        Console.ReadLine(num1);
        Console.ReadLine(num2);
        Console.WriteLine(num1 + " " + num2);
        Square(num1, num2);
        Console.WriteLine(num1 + " " + num2);
        Console.WriteLine("¨Press enter key to exit");
        Console.ReadLine();
    }
}