using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InhandPolyG4
{
    public class Coupe : Cars
    {
        public int NumDoors;


        public Coupe (string Color, string Make): base(Color, Make)
        {
        }

        public int CoupeDesc()
        {
            Console.WriteLine($"The car is a {base.Color} {base.Make} and has {this.NumDoors} doors.");
            return NumDoors;
        }
    }
}