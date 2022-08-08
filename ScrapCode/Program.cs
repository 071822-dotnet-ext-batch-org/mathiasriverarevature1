using System;
using System.Collections.Generic;
using System.Globalization;


namespace ScrapCode
{
    class Program
    {
        static void Main(string[] args)
        {
          //leap year determination variables
          int year = 1700;
          // int feb = 0;
          // //determine whether the calander is julian or gregorian and if Feb is 28 or 29
          // if (year < 1918 && year%4 == 0)
          //     {
          //         feb = 29;
          //     }
          // else if (year >= 1918 && year%4 ==0 && year%100 != 0)
          //     {
          //         feb = 29;
          //     }
          // else if (year >= 1918 && year%400==0)
          //     {
          //         feb = 29;
          //     }
          // else 
              // {
              //     feb = 28;
              // }
        DateTime myGDT = new DateTime(year, 1, 1, new GregorianCalendar());
        myGDT = DateTime.AddDays(myGDT, 256);
        DateTime myJDT = new DateTime(year, 1, 1, new JulianCalendar());
        myJDT = DateTime.AddDays(myJDT, 256);


        Console.WriteLine(myGDT);
        Console.WriteLine(myJDT);

        
        
        }
    }
}
