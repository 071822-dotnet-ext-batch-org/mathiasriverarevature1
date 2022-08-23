
using System.Collections;
using System.Globalization;
using System;



class Program
{
    public static void Main(string[] args)
    {
        List<int> a = new List<int>();  
        a.Add(5);
        a.Add(4);    
        a.Add(4);    
        a.Add(2);  
        a.Add(2);    
        a.Add(4);    
        a.Add(5);    
  
       int maxCount = 0;//counter that will be given to answer
        a.Sort();//sort list a for calculations

            for (int i = 0; i < a.Count; i++)//commence iteration 
            {
                int currentCount = 1;//assign beginning of sublist to 1
                if (i > 0)//ensure value is more than 1
                    if (a[i] == a[i-1])//if two consecutive values are equal, then then difference is zero and therefore should be included in a sublist
                        continue;//continutes to next loop if succeeds

                for (int j = i+1; j < a.Count; j++)//iterates parallel list one step ahead of i
                {
                    if (Math.Abs(a[j]-a[i]) <=1)//checks if the abs difference is less than or equal to one and if so it adds to counter
                        currentCount++;
                    else
                        break;//breaks loop when sublist conditions are broken
                }

                if (currentCount > maxCount)//updates max count compared to current loop's count    
                {   
                    maxCount = currentCount;
                }
            }
            Console.WriteLine(maxCount);   
    }
}
