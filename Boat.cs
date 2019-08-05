using System;

namespace ConceptsExample
{
    /// <summary>
    /// Base class for all Boats.  Inherits from abstract class Vehicle, implements IBoat interface
    /// </summary>
    public class Boat : Vehicle
    {
        /// <summary>
        /// Overriding Start behavior
        /// </summary>
        public override void Start()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Overriding Stop behavior
        /// </summary>
        public override void Stop()
        {
            throw new NotImplementedException();
        }

        public override void GetFuel()
        {
            throw new NotImplementedException();
        }
    }
}
