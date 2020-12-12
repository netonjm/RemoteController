using SlimDX.DirectInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WebSocketSharp;

namespace RemoteController.Client
{
 
    public partial class Form1 : Form
    {
        const int Port = 8089;
        const string IpAddress = "10.67.1.57";

        List<JoyButton> joyButtons = new List<JoyButton>();
        Joystick gamepad;
        JoystickState state = new JoystickState();

        Timer timer = new Timer();

        WebSocket ws;

        public Form1()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(TimerEventProcessor);

            Visible = false;

            notifyIcon1.Visible = true;
            notifyIcon1.Text = "GameProxy";
            notifyIcon1.ShowBalloonTip(1000, "Connection", $"Trying to connect to {IpAddress}:{Port}", ToolTipIcon.Info);

            CreateDevice();

            ws = new WebSocket($"ws://{IpAddress}:{Port}/Laputa");
            ws.OnMessage += (sender, e) =>
            {
                if (e.Data == "PONG")
                {
                    
                    Console.WriteLine("SERVER CONNECTED SUCCESSFULL");
                    notifyIcon1.ShowBalloonTip(1000, "Connection", $"Connection to {IpAddress}:{Port} successfull.", ToolTipIcon.Info);
                    notifyIcon1.Icon = RemoteController.Client.Properties.Resources.electronics;
                    notifyIcon1.Text = "GameProxy (Connected)";
                }
                else
                    Console.WriteLine("Laputa says: " + e.Data);
            };

            joyButtons.Add(new JoyButton(ws, 0, Keys.N)); //
            joyButtons.Add(new JoyButton(ws, 1, Keys.I)); //sacar bola
            joyButtons.Add(new JoyButton(ws, 2, Keys.Space));
            joyButtons.Add(new JoyButton(ws, 3, Keys.M));

            joyButtons.Add(new JoyButton(ws, 4, Keys.U)); //left
            joyButtons.Add(new JoyButton(ws, 5, Keys.P)); //right

            joyButtons.Add(new JoyButton(ws, 6, Keys.D1)); //start
            joyButtons.Add(new JoyButton(ws, 7, Keys.D6)); //coin
         
            //trying to connect
            try
            {
                ws.Connect();
                ws.Send("PING");
            }
            catch (Exception)
            {
                Console.WriteLine("SERVER CONNECTION FAILED");
                notifyIcon1.ShowBalloonTip(1000, "Connection", $"Connection to {IpAddress}:{Port} failed.", ToolTipIcon.Error);
                notifyIcon1.Icon = RemoteController.Client.Properties.Resources.high_priority;
                notifyIcon1.Text = "GameProxy (Not Connected)";
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(false);
        }

        bool CreateDevice()
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
                        notifyIcon1.ShowBalloonTip(1000, "Joystick", $"Adquire() is failing to initialize.", ToolTipIcon.Error);
                        notifyIcon1.Icon = RemoteController.Client.Properties.Resources.high_priority;
                        notifyIcon1.Text = "GameProxy (Disconnected)";
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
                notifyIcon1.ShowBalloonTip(1000, "No USB Joystick", $"There are no joysticks attached to the system.", ToolTipIcon.Error);
                notifyIcon1.Icon = RemoteController.Client.Properties.Resources.high_priority;
                notifyIcon1.Text = "GameProxy (No USB controller)";
                return false;
            }

            timer.Interval = 1000 / 12;
            timer.Start();
            return true;
        }

        private void TimerEventProcessor(object sender, EventArgs e)
        {
            ReadImmediateData();
        }

        void ReadImmediateData()
        {
            if (gamepad.Poll().IsFailure)
                return;
            if (SlimDX.Result.Last.IsFailure)
                return;

            state = gamepad.GetCurrentState();

            var buttons = state.GetButtons();
            for (int i = 0; i < joyButtons.Count; i++)
            {
                joyButtons[i].Pressed = buttons[i];
            }
        }

        void ReleaseDevice()
        {
            //timer.Stop();

            if (gamepad != null)
            {
                gamepad.Unacquire();
                gamepad.Dispose();
            }
            gamepad = null;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            ReleaseDevice();
            base.OnClosing(e);
        }
    }
}
