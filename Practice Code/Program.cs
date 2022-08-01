using System;

namespace Practice_Code
{
    class Program
    {
        static void Main(string[] args)
        {
        
        string UserOperation;
        bool UserOpLoop = true;
        string Num1Str;
        string Num2Str;
        int Num1;
        int Num2;
        
        
        //Take user input on operation use
        Console.WriteLine("Welcome to the calculator. Please enter if you would like to +,-,*,/");

        while(UserOpLoop) { 
        
        UserOperation = Console.ReadLine();
        
        if ((UserOperation == "+") || (UserOperation == "-" || UserOperation == "*" || UserOperation == "/"))
        {
            UserOpLoop = false;
            Console.WriteLine("Great chioce! My favorate operation.");
        }
        else 
        {
            Console.WriteLine("Please only input an operation. +,-,*, or /. Enter again:");
        }
        }

        //Take User Input on numbers
        Console.WriteLine("Now I want you to input the first number of your operation.");
        Num1Str = Console.ReadLine();
        while(!Int32.TryParse(Num1Str, out Num1))
        {
        Console.WriteLine("Please only input a number. Try again:");
        Num1Str = Console.ReadLine();
        }

        //2nd number
        Console.WriteLine("Now input the second number:");
        Num2Str = Console.ReadLine();
        while(!Int32.TryParse(Num2Str, out Num2))
        {
        Console.WriteLine("Please only input a number. Try again:");
        Num2Str = Console.ReadLine();
        }
        
        if (UserOperation == "+")
        {

        }

    }
}
}