using System;

namespace RemoteController
{
    public class Configuration
    {
        public event EventHandler ConnectionChanged;

        MapperConfiguration connection;
        public MapperConfiguration Connection {
            get => connection;
            set
            {
                if (connection == value)
                    return;
                connection = value;
                ConnectionChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
