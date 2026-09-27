using System;

namespace VehicleInheritance
{
    // Base class: holds the state and the behaviour that every vehicle shares.
    class Vehicle
    {
        public string brand = "Ford";

        public void StartEngine()
        {
            Console.WriteLine("The " + brand + " engine is running.");
        }
    }

    // Derived class: reuses everything Vehicle offers and adds its own state.
    class Car : Vehicle
    {
        public string Model = "Mustang";
    }
}