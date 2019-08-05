namespace ConceptsExample
{
    // enums provide a standardized way to control available options
    // if the option you want to use is not listed, then it is not a valid selection
    public class Enums
    {
        public enum Colors
        {
            White,
            Black,
            Red,
            Blue,
            Camo
        }

        public enum VehicleTypes
        {
            Automobile,
            Boat,
            Plane,
            NonMotorized
        }

        public enum AutomobileTypes
        {
            PassengerCar,
            Truck,
            SUV,
            Motorcycle,
            Tank
        }

        public enum BoatTypes
        {
            Cruiser,
            Cigarette,
            Yacht,
            Tug
        }

        public enum PlaneTypes
        {
            Cessna,
            Jumbo,
            Cargo,
            Military
        }

        public enum NonMotorizedTypes
        {
            HorseDrawn,
            DogSled,
            Rickshaw
        }
    }
}
