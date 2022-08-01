using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InhandPolyG4
{
    public class Cars
    {
        public string Color; 
        public string Make;
        
        public Cars (string Color, string Make){
            this.Color = Color;
            this.Make = Make;
        }
        
        
        public string CarColor()
        {
            Console.WriteLine($"The car color is {this.Color}");
            return this.Color; 
        } 

        public string CarMake()
        {
            Console.WriteLine($"The car maker is {this.Make}");
            return this.Make; 
        } 
        
    }
}