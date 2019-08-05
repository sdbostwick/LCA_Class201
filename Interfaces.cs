using static ConceptsExample.Enums;

namespace ConceptsExample
{
    // Interfaces enforce consistent properties and behavior
    public interface IAutomobile
    {
        AutomobileTypes Type { get; set; }
        int NumberOfWheels { get; set; }
        int NumberOfCylinders { get; set; }
        Colors Color { get; set; }
    }

    public interface IBoat
    {
        BoatTypes Type { get; set; }
        bool IsCovered { get; set; }
        int NumberOfEngines { get; set; }
        Colors Color { get; set; }
    }

    public interface IPlane
    {
        PlaneTypes Type { get; set; }
        int NumberOfEngines { get; set; }
        Colors Color { get; set; }
    }

    public interface INonMotorized
    {
        NonMotorizedTypes Type { get; set; }
        int NumberOfAnimals { get; set; }
    }
}
