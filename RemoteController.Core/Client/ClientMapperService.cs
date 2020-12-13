using System;
using System.Collections.Generic;
using WebSocketSharp;

namespace RemoteController
{
    public class ClientMapperService : MapperService
    {
        public bool IsConnected { get; set; }

        List<JoyButton> joyButtons = new List<JoyButton>();
    
        WebSocket ws;

        public event EventHandler DeviceCreated;
        public event EventHandler Connecting;
        public event EventHandler Connected;

        public int Port { get; set; }
        public string IpAddress { get; set; }

        public string Device { get; set; } = "Laputa";

        ITimer timer;

        IDeviceService deviceService;

        public ClientMapperService(ClientMapperConfiguration configuration, ITimer timer, IDeviceService deviceService)
        {
            this.deviceService = deviceService;
            this.timer = timer;
            IpAddress = configuration.IpAddress;
            Port = configuration.Port;

            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var buttons = deviceService.GetButtonsStates(0);
            if (buttons.Length == 0)
                return;

            for (int i = 0; i < joyButtons.Count; i++)
            {
                joyButtons[i].IsPressed = buttons[i];
            }
        }

        public override void Initialize ()
        {
            LastException = null;

            //Device creation
            if (!deviceService.TryCreateDevice(out Exception ex))
                return;

            DeviceCreated?.Invoke(this, EventArgs.Empty);

            ws = new WebSocket($"ws://{IpAddress}:{Port}/{Device}");
            ws.OnMessage += (sender, e) =>
            {
                if (e.Data == "PONG")
                {
                    Connected?.Invoke(this, EventArgs.Empty);

                    Console.WriteLine("SERVER CONNECTED SUCCESSFULL");
                    IsConnected = true;
                }
                else
                    Console.WriteLine($"{Device} says: " + e.Data);
            };

            foreach (var item in joyButtons)
                item.Pressed += Item_Pressed;

            timer.Interval = 1000 / 12;
            timer.Start();
        }

        private void Item_Pressed(object sender, EventArgs e)
        {
            var button = (JoyButton)sender;
            var pressedStr = (button.IsPressed ? KeyEvent.Down : KeyEvent.Up).ToString();
            ws.Send(pressedStr + "|" + button.Key.ToString());
        }

        public Exception LastException { get; set; }

        public override void Start ()
        {
            IsConnected = false;

            LastException = null;
            Connecting?.Invoke(this, EventArgs.Empty);
            //prueba de conexión
            try
            {
                ws.Connect();
                ws.Send("PING");
            }
            catch (Exception ex)
            {
                LastException = ex;
                Console.WriteLine("SERVER CONNECTION FAILED");
            }
        }

        public void Stop ()
        {
            foreach (var item in joyButtons)
                item.Pressed -= Item_Pressed;

            try
            {
                ws.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

            timer.Stop();
        }
        
        public override void Dispose()
        {
            timer.Tick -= Timer_Tick;
            Stop();
            deviceService.ReleaseDevice();
        }
    }
}
