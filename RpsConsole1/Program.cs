using System;

namespace RpsConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
           //a sentence is called a string
            Console.WriteLine("Hello World!");

            //when there are two methods in the same name(method signature)
            //but different parameters, it is called method ocerloading
            Console.WriteLine(43);

            //variables are used to hold data
            //each variable is declared and given a data type
            //the type cannot be changed without a certain qualification being met
            //conventionally, variables are 'writtenInCamelCase'
            /** camel case - starts lower, new words start upper, no spaces EX. writtenInCamelCase
                Pascal case - no spaces, starts upper, all other words cap EX. WrittenInPascalCase
            **/
                string mystring = "Mark said he is kewl"; //called an empty string
                int myint = 44;
                Console.WriteLine(mystring);

                string myString2;
                myString2 = "this is a value"; // strings are immutable
                string mystring2 = "this is a very big value"; //realocates heap location of memory
                Console.WriteLine(mystring2);


                Console.WriteLine(myString2.GetType());
                Console.WriteLine(myint.GetType());

                long myLong = 2147483548;

                int myInt1 = 1+2;
                Console.WriteLine(myInt1);

                Console.WriteLine(myInt1 - myLong);
                Console.WriteLine(100/10);
                Console.WriteLine(Math.Pow(100,2));
                Console.WriteLine(100*2);

                //String interpolation
                Console.WriteLine($"The division is => {101/10}"); //101/10 = 10 remainder 1 = 10.1
                Console.WriteLine($"The modulus is => {100%6}");

                int myint2 = 10;
                Console.WriteLine(myint2++);//++ is an incrementor. it will increment the integer by 1
                Console.WriteLine(myint2);//++ is an incrementor. it will increment the integer by 1
                Console.WriteLine(++myint2);//++ is an incrementor. it will increment the integer by 1

                Console.WriteLine(myint2--);//++ is an incrementor. it will increment the integer by 1
                Console.WriteLine(myint2);//++ is an incrementor. it will increment the integer by 1
                Console.WriteLine(--myint2);//++ is an incrementor. it will increment the integer by 1

                int a,b,c; // you can declare multiple ints 
                a = 7;
                b=a;
                c=b++;
                b=a+b*c;
                a=(int)Math.Sqrt(b*b+c*c);

                //Flow control
                //this is an if statement
                int x,y,z;
                x=5;
                y=5;
                z=7;

                if(y>x)
                {
                    Console.WriteLine("y is greater than x");
                }
                else if (y>x)
                {
                    Console.WriteLine("y is greater than x");
                }
                else {
                    Console.WriteLine("y and x are equal");
                }

                // a ternary operator acts like a if statement
                z = x >= 100 ? y : z / 10;
                // same as this if statement
                if(x>= 100){//is x greater than or equal to 10, if yes then do this
                    z=y;
                }
                else{
                    z=z/10; // z is reassigned to the post-expression value
                }
                Console.WriteLine($"z is {z}");


                //arrays
                //in a computer, a string is actually a consecutive group of char memory locations
                char[] myCharArr = new char[]{'M'/**element 0*/,'a','r','k','y'/**element 4*/};
                Console.WriteLine($"the element 1 value is => {myCharArr[1].GetType()} the 4th element is {myCharArr[3]}");

                try
                {
                    Console.WriteLine($"the element 1 value is =>{myCharArr[7]}");
                    Console.WriteLine($"z is {z}. This will not run"); 
                }
                
                catch(IndexOutOfRangeException ex) //
                {
                Console.WriteLine($"The out of range exception was thrown. The dealio is {ex.Message}");
                }
                catch(Exception ex){//ex is the exception values entered by the system. name is irrelevent ex. ex->tim
                Console.WriteLine($"The out of range exception was thrown. The dealio is {ex.Message}");

                }
                Console.WriteLine($"The exception was caught.");

                //for-loop will iterate over each element of an array. you can do something at each element
                for(int i=0; i < myCharArr.Length; i++)
                {
                    //Console.WriteLine($"The element value is {myCharArr[i]}");//the line terminator is '\n'
                    Console.Write($"{myCharArr[i]}");
                
                }

                //the foreach loop will automatically break out of the loop at the end of the array
                foreach(char x1 in myCharArr){
                   // Console.Write($"{myCharArr[w]}");
                    Console.Write($"{x1}");
                }

                //While-loop will keep iterating until false
                int w = 113;
                while (w>100){
                    Console.Write($"Mark");
                    w--;
                }

                //a do-while will keep iterating until the comparison is false. It will iterate at least once
                do
                {
                    Console.Write($"Mark on a dowhile.");
                    w++;
                } while (w<113);
                Console.WriteLine();

                //string s = "String literal";
                //char 1 = s[s.Length -1];

                





                


        }
    }
}
