using System;
using System.Collections.Generic;

namespace ScrapCode
{
    class Program
    {
            Dictionary<string, int> myData = new Dictionary<string, int>();
            myData.Add("Dog", 1);
            myData.Add("Cat", 1);
            
            Console.WriteLine(myData["1"]);
    }
}
