using System.Collections.Generic;

namespace RemoteController
{
    public class ClientMapperConfiguration : MapperConfiguration
    {
        public int Port { get; set; } = 8089;
        public string IpAddress { get; set; }
        public override string Name => ConnectionType.Client.ToString();

        public override ConnectionType ConnectionType => ConnectionType.Client;

        public List<JoyButton> JoyButtons { get; set; }

        public ClientConnectionType ClientConnectionType { get; set; }
    }
}
