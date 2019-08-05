using System;

namespace ConceptsExample
{
    /// <summary>
    /// Base class for all automobiles.  Inherits methods from abstract class Vehicle and provides a base implementation of the methods.
    /// All vehicles have a maker/manufacturer, model, and style
    /// </summary>
    public class Automobile : Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Style { get; set; }

        public Automobile(string make, string model, string style)
        {
            this.Make = make;
            this.Model = model;
            this.Style = style;
        }

        // Implementation of the abstract Start() method
        public override void Start()
        {
            Console.WriteLine("Starting from base class...");
        }

        // Implementation of the abstract Stop() method
        public override void Stop()
        {
            Console.WriteLine("Stopping from base class...");
        }

        public override void GetFuel()
        {
            Console.WriteLine("\tGetting cheap fuel from the base class...");
        }
    }
}
