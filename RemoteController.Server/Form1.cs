using RemoteController;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using WebSocketSharp.Server;

namespace RemoteController.Server
{
    public partial class Form1 : Form
    {
        IGameService gameService;

        const int Port = 8089;

        void RefreshName() => notifyIcon1.Text = string.Format("GameProxy - {0}", gameService.CurrentGame.DisplayName);

        private IPAddress GetIPAddress()
        {
            string strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            return  addr[addr.Length - 1];
        }

        public Form1()
        {
            InitializeComponent();

            gameService = new WinFormsGameService();

            gameService.GameChanged += (s, e) =>
            {
                notifyIcon1.ShowBalloonTip(1000, "Game", $"The game was changed to: { gameService.CurrentGame.DisplayName}", ToolTipIcon.Info);
                RefreshName();
            };
            gameService.CurrentGame = new VRVPPlayerGame();

            var ipAddress = GetIPAddress();
            var wssv = new WebSocketServer(ipAddress, Port);
            wssv.AddWebSocketService("/Laputa", () => {
                var behaviour = new KeyPressedSocketBehaviour(gameService);
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
            gameService.StartCurrentGame();
        
            StartButton.Enabled = true;
            DerechaButton.Enabled = true;
            IzquierdaButton.Enabled = true;
            CreditoButton.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameService.SendKey(KeyEvent.Down, RemoteController.Keys.D5);
            gameService.SendKey(KeyEvent.Up, RemoteController.Keys.D5);
        }

        private void btnGame1_Click(object sender, EventArgs e)
        {
            gameService.CurrentGame = new VPPlayerGame();
        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            gameService.CurrentGame = new VRVPPlayerGame();
        }
    }
}
