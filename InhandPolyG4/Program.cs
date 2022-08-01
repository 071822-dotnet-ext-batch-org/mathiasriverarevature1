using System;

namespace InhandPolyG4
{
    class Program
    {
        static void Main(string[] args)
        {            
            string Color = "Black";
            string Make = "Toyota";
            Cars newcar = new Cars(Color, Make); //create instance of Cars
            newcar.CarColor();
            newcar.CarMake();

            Coupe newCoupe = new Coupe(Color, Make);
            newCoupe.NumDoors = 2;
            newCoupe.CoupeDesc();
            
        }
    }
}
