namespace ConceptsExample
{
    /// <summary>
    /// This class that cannot be instantiated, only inherited.  Also cannot provide an implementation for behavior.
    /// All vehicles can be started and stopped
    /// </summary>
    public abstract class Vehicle
    {
        public abstract void Start();
        public abstract void Stop();
        public abstract void GetFuel();
    }
}
