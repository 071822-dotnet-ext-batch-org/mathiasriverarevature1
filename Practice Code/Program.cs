using System;

namespace Practice_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = {"dog","tiger","dolphin", "alligator","polar bear"};

            for (int i = 0; i < animals.Length;i++)
           {
                for (int j = 0; j < animals[i].Length; j++)
                {
                    if (animals[i][j] == 'l')
                    {
                        Console.WriteLine(animals[i] + "");
                    }
                }
            }
            

    }
}
}