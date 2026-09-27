using System;

namespace VehicleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            // StartEngine() and brand are declared on Vehicle, but they are reached
            // through the Car instance, and Model comes from Car itself.
            myCar.StartEngine();

            Console.WriteLine("the brand is: " + myCar.brand);
            Console.WriteLine("the model is: " + myCar.Model);
        }
    }
}