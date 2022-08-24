using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ScrapCode
{
    class Program
    {
    static void Main(string[] args)
    {
    int[] theArray = { 3, 1, 3, 5, 7, 9 };
    List<int> SortedList = theArray.ToList();
    SortedList.Sort();
    int total = 0;
    for(int i=0; i < (SortedList.Count-1); i++)
    {
        int diff = Math.Abs(SortedList[i]-SortedList[i+1]);
        Console.WriteLine(SortedList[i]+" "+SortedList[i+1]);
        total += diff;
        Console.WriteLine(total);
        
    }
    Console.WriteLine(SortedList.IndexOf(3));

    
    
    }   
    } 
}  

