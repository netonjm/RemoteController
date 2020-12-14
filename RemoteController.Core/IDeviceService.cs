using System;
using System.Collections.Generic;

namespace RemoteController
{
    public interface IDeviceService
    {
        bool TryCreateDevice(out Exception exception);
        void ReleaseDevice();
        bool[] GetButtonsStates(int device);
    }
}