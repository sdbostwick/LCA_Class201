using System;

namespace ConceptsExample
{
    /// <summary>
    /// Concrete class of PassengerCar.  Inherits from base class Automobile, implements IAutomobile interface
    /// </summary>
    public class PassengerCar : Automobile, IAutomobile
    {
        // Implementing IAutomobile interface 
        public Enums.AutomobileTypes Type { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfCylinders { get; set; }
        public Enums.Colors Color { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="numberOfWheels"></param>
        /// <param name="color"></param>
        /// <param name="numberOfCylinders"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="style"></param>
        public PassengerCar(Enums.AutomobileTypes type, int numberOfWheels, Enums.Colors color, int numberOfCylinders, string make, string model, string style)
            : base(make, model, style)
        {
            this.Type = type;
            this.NumberOfWheels = numberOfWheels;
            this.Color = color;
            this.NumberOfCylinders = numberOfCylinders;
        }

        // Overriding base class Start behavior
        public override void Start()
        {
            base.Start();
            Console.WriteLine("\tStarting from derived class...");
            Console.WriteLine($"\tMy {this.Type} is a {this.Make} {this.Model}, and it has a {this.NumberOfCylinders} cylinder engine, has {this.NumberOfWheels} wheels, and is {this.Color}.");
        }

        // Overriding base class Stop behavior
        public override void Stop()
        {
            //base.Stop();
            Console.WriteLine("\tStopping from derived class...");
            Console.WriteLine("\tTurning off the radio");
        }

        // Overriding base class GetFuel behavior
        public override void GetFuel()
        {
            //base.GetFuel();
            Console.WriteLine("\tFilling up the tank with Premium!");
        }

        // Class method
        public void PopTrunk()
        {
            Console.WriteLine("\tTrunk is popped.");
        }
    }
}
