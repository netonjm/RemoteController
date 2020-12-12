using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using WebSocketSharp.Server;

namespace KeyRead
{
    public partial class Form1 : Form
    {
        KeyService keyService;

        const int Port = 8089;

        void RefreshName() => notifyIcon1.Text = string.Format("GameProxy - {0}", keyService.CurrentGame.DisplayName);

        public Form1()
        {
            InitializeComponent();

            keyService = new KeyService();

            keyService.GameChanged += (s, e) =>
            {
                notifyIcon1.ShowBalloonTip(1000, "Game", $"The game was changed to: { keyService.CurrentGame.DisplayName}", ToolTipIcon.Info);
                RefreshName();
            };
            keyService.CurrentGame = new VRVPPlayerGame();

            var wssv = new WebSocketServer(System.Net.IPAddress.Parse ("10.67.1.57"), Port);
            wssv.AddWebSocketService("/Laputa", () => {
                var behaviour = new KeyPressedSocketBehaviour(keyService);
                return behaviour;
            });
            wssv.Start();
        }

        //protected override void SetVisibleCore(bool value)
        //{
        //    base.SetVisibleCore(false);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //p = Process.Start("notepad.exe");
            p = new Process();
            p.StartInfo.FileName = System.IO.Path.GetFileName(keyService.CurrentGame.ExecutableFilePath);
            p.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(keyService.CurrentGame.ExecutableFilePath);
            p.Start();
            p.WaitForInputIdle();

            StartButton.Enabled = true;
            DerechaButton.Enabled = true;
            IzquierdaButton.Enabled = true;
            CreditoButton.Enabled = true;
        }

        Process p;
      
        private void button2_Click(object sender, EventArgs e)
        {
            keyService.SendKey(KeyEvent.Down, Keys.D5);
            keyService.SendKey(KeyEvent.Up, Keys.D5);
        }

        private void btnGame1_Click(object sender, EventArgs e)
        {
            keyService.CurrentGame = new VPPlayerGame();
        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            keyService.CurrentGame = new VRVPPlayerGame();
        }
    }
}
