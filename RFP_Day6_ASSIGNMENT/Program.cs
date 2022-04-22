// See https://aka.ms/new-console-template for more information
using RFP_Day6_ASSIGNMENT;

int Option;
Console.WriteLine("Enter \n 1 for FIBONACCI SERIES PROGRAM \n 2 for PERFECT NUMBER PROGRAM ");
Option = Convert.ToInt32(Console.ReadLine());
switch (Option)
{
    case 1:
        Console.WriteLine("\n Welcome to Program for Fibonacci ................................");
        Console.WriteLine("Enter any number till that you want Fibonacci series");
        int Input = Convert.ToInt32(Console.ReadLine());
        Fibonacci obj1 = new Fibonacci();
        obj1.fibonacciMethod(Input);
        break;

    case 2:
        Console.WriteLine(" \n Welcome to PERFECT NUMBER Program .............................................");
        int Factor = 0;
        Console.WriteLine("Enter any number to check whether it's a perfect number or not");
        int Num = Convert.ToInt32(Console.ReadLine());
        PerfectNum obj2 = new PerfectNum();
        obj2.perfectNumMethod(Factor, Num);
        break;
}

