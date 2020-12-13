namespace RemoteController
{
    public class ServerMapperConnection : MapperConfiguration
    {
        public override string Name => ConnectionType.Server.ToString();

        public override ConnectionType ConnectionType => ConnectionType.Server;
    }
}
