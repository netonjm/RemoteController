using System;

namespace RemoteController
{
    public abstract class MapperService : IDisposable
    {
        public virtual void Dispose()
        {
        }

        public abstract void Initialize();

        public abstract void Start();
    }
}
