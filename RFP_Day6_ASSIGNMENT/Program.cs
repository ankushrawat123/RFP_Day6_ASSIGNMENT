// See https://aka.ms/new-console-template for more information
using RFP_Day6_ASSIGNMENT;

int Option;
Console.WriteLine("Enter \n 1 for FIBONACCI SERIES PROGRAM \n 2 for PERFECT NUMBER PROGRAM \n 3 for PRIME NUMBER PROGRAM \n 4 for REVERSE NUMBER PROGRAM\n 5 for STOPWATCH PROGRAM\n 6 for VENDING MACHINE PROGRAM");
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
    case 3:
        int Count = 0;
        Console.WriteLine("\nWelcome to Program for Prime Factors ...........................");
        Console.WriteLine("Enter any number to check whether entered value is prime or not and What are the prime Factors if number is not prime number");
        int Num2 = Convert.ToInt32(Console.ReadLine());
        PrimeNumber obj3 = new PrimeNumber();
        obj3.PrimeNunberMethod(Num2, Count);
        break;
    case 4:
        int Rev = 0;
        Console.WriteLine(" \n Welcome to Reverse Number Program ............................");
        Console.WriteLine("Enter any number to get it's Reverse");
        int Num3 = Convert.ToInt32(Console.ReadLine());
        ReverseNumber obj4 = new ReverseNumber();
        obj4.Reverse(Num3, Rev);
        break;
    case 5:
        Console.WriteLine(" \n Welcome to STOPWATCH Program ...........................");
        StopWatch obj5 = new StopWatch();
        obj5.stopWatchMethod();
        break;
    case 6:
        Console.WriteLine(" \n Welcome to VENDING MACHINE PrograM ..................................");
        Console.WriteLine("1, 2, 5, 10, 50, 100, 500 and 1000 Rs Notes can be returned by Vending Machine.");
        Console.WriteLine("Enter the Change amount that you want ");
        int V = Convert.ToInt32(Console.ReadLine());
        int[] Notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
        int m = Notes.Length;
        VendingMachine obj6 = new VendingMachine();
        Console.WriteLine("Minimum Notes required is " + obj6.minNotes(Notes, m, V));
        break;
    
}

