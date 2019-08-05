using System;

namespace ConceptsExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Inherited methods
            Vehicle myCar = new PassengerCar(Enums.AutomobileTypes.PassengerCar, 4, Enums.Colors.White, 6, "Acura", "CL", "2-Door");
            myCar.Start();
            myCar.GetFuel();
            myCar.Stop();

            // Class methods are only available with instantiation of the concrete class, but inherited methods are all available.
            PassengerCar car = new PassengerCar(Enums.AutomobileTypes.PassengerCar, 4, Enums.Colors.Blue, 4, "", "", "");
            car.Start();
            car.PopTrunk();
            car.GetFuel();
            car.Stop();



            Console.WriteLine();

            Vehicle myTruck = new Truck(Enums.AutomobileTypes.Truck, 6, Enums.Colors.Red, 8, "Chevy", "1500", "Half-Ton");
            myTruck.Start();
            myTruck.GetFuel();
            myTruck.Stop();

            // Vehicle myBoat

            // wait for input so the user can see the output before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
