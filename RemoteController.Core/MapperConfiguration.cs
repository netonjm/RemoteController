namespace RemoteController
{
    public abstract class MapperConfiguration
    {
        public abstract ConnectionType ConnectionType { get; }
        public abstract string Name { get; }
    }
}
