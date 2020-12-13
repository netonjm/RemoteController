using SlimDX.DirectInput;
using System;

namespace RemoteController.Client
{
    public class SlimDXDeviceService : IDeviceService
    {
        public bool IsLastFailure => SlimDX.Result.Last.IsFailure;
        Joystick gamepad;
        JoystickState state = new JoystickState();

        public bool TryCreateDevice(out Exception exception)
        {
            // make sure that DirectInput has been initialized
            DirectInput dinput = new DirectInput();

            // search for devices
            foreach (DeviceInstance device in dinput.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly))
            {
                // create the device
                try
                {
                    gamepad = new Joystick(dinput, device.InstanceGuid);
                    //gamepad.SetCooperativeLevel(this, CooperativeLevel.Exclusive | CooperativeLevel.Foreground);
                    if (gamepad.Acquire().IsFailure)
                    {
                        exception = new Exception("Adquire() is failing to initialize.");
                        //notifyIcon1.ShowBalloonTip(1000, "Joystick", $"Adquire() is failing to initialize.", ToolTipIcon.Error);
                        //notifyIcon1.Icon = RemoteController.Client.Properties.Resources.high_priority;
                        //notifyIcon1.Text = "GameProxy (Disconnected)";
                        return false;
                    }

                    break;
                }
                catch (DirectInputException ex)
                {
                    Console.WriteLine(ex);
                }
            }

            if (gamepad == null)
            {
                exception = new Exception($"There are no joysticks attached to the system.");
                //notifyIcon1.ShowBalloonTip(1000, "No USB Joystick", $"There are no joysticks attached to the system.", ToolTipIcon.Error);
                //notifyIcon1.Icon = RemoteController.Client.Properties.Resources.high_priority;
                //notifyIcon1.Text = "GameProxy (No USB controller)";
                return false;
            }
            exception = null;
            return true;
        }

        public void ReleaseDevice()
        {
            if (gamepad != null)
            {
                gamepad.Unacquire();
                gamepad.Dispose();
            }
            gamepad = null;
        }

        public bool[] GetButtonsStates(int device)
        {
            if (gamepad.Poll().IsFailure || SlimDX.Result.Last.IsFailure)
                return new bool[0];

            state = gamepad.GetCurrentState();
            var buttons = state.GetButtons();
            return buttons;
        }
    }
}
