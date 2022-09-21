using System;
internal class Program
{
    private static void Main(string[] args)
    {
        
        List<string> listOfStrings = new List<String> {"apple", "aardvarkZ", "babble", "zebra", "coockoo", "cudAle", "oops", "opera", "yellow"};
        string letter = "Z";
       //listOfStrings.Sort();
       List<string> sortedList = new List<string>{};

        for(int i=0; i<listOfStrings.Count; i++)
        {
            
            if(listOfStrings[i].Contains(letter, StringComparison.OrdinalIgnoreCase)==true)
            {
                sortedList.Add(listOfStrings[i]);
            }
        }
        for(int i=0; i<sortedList.Count; i++)
        {
            Console.WriteLine(sortedList[i]);
        }
        Console.WriteLine(sortedList.Count);

    }
}