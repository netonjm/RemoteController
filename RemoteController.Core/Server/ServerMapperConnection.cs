namespace RemoteController
{
    public class ServerMapperConnection : MapperConfiguration
    {
        public int Port { get; set; }
        public string IpAddress { get; set; }

        public override string Name => ConnectionType.Server.ToString();

        public override ConnectionType ConnectionType => ConnectionType.Server;
    }

    public class StandaloneMapperConnection : MapperConfiguration
    {
        public override string Name => ConnectionType.Standalone.ToString();

        public override ConnectionType ConnectionType => ConnectionType.Standalone;
    }
}
