using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RemoteController.Client
{

    public partial class Form1 : Form
    {
        ClientMapperService clientMapperService;

        //ITimerWrapper timer = new Timer();
        const int DefaultDelayTooltips = 1000;

        Configuration configuration;
        MapperConfiguration mapperConfiguration;

        public string ApplicationName { get; set; } = "Simple Device Mapper";
        public string ApplicationVersion { get; set; } = "0.2";

        bool HasInit = false;

        public Form1()
        {
            InitializeComponent();
            //timer.Tick += new EventHandler(TimerEventProcessor);

            Visible = true;
            Text = ApplicationName + " v" + ApplicationVersion;
            notifyIcon1.Visible = true;
            notifyIcon1.Text = ApplicationName;

            var joyButtons = new System.Collections.Generic.List<JoyButton>();
            //TODO: mapear a configuracion .json
            joyButtons.Add(new JoyButton(0, Keys.N)); //
            joyButtons.Add(new JoyButton(1, Keys.I)); //bola
            joyButtons.Add(new JoyButton(2, Keys.Space));
            joyButtons.Add(new JoyButton(3, Keys.M));

            joyButtons.Add(new JoyButton(4, Keys.U)); //left
            joyButtons.Add(new JoyButton(5, Keys.P)); //right

            joyButtons.Add(new JoyButton(6, Keys.D1)); //start
            joyButtons.Add(new JoyButton(7, Keys.D6)); //coin

            //lectura de json
            this.configuration = new Configuration()
            {
                Connection = new ClientMapperConfiguration() { 
                    IpAddress = "10.67.1.57", Port = 8089, JoyButtons = joyButtons, ClientConnectionType = ClientConnectionType.Remote }
            };

            mapperConfiguration = this.configuration.Connection;

            //Initial values
            ClientMapperConfiguration clientMapperConfiguration = null;

            if (configuration.Connection is ClientMapperConfiguration clientConfiguration)
                clientMapperConfiguration = clientConfiguration;
            mapeadoRemotoIpTextBox.Text = clientMapperConfiguration.IpAddress.ToString();

            var deviceService = new SlimDXDeviceService();

            clientMapperService = new ClientMapperService(clientMapperConfiguration, new WinFormsTimer (), deviceService);
            clientMapperService.Connected += (s, e) =>
            {
                if (clientMapperService.LastException != null)
                {
                    notifyIcon1.ShowBalloonTip(DefaultDelayTooltips, "Connection", $"Connection to {clientMapperService.IpAddress}:{clientMapperService.Port} failed.", ToolTipIcon.Error);
                    notifyIcon1.Icon = Properties.Resources.high_priority;
                    notifyIcon1.Text = $"{clientMapperService.IpAddress} (Not Connected)";
                }
                else
                {
                    notifyIcon1.ShowBalloonTip(DefaultDelayTooltips, "Connection", $"Connection to {clientMapperService.IpAddress}:{clientMapperService.Port} successfull.", ToolTipIcon.Info);
                    notifyIcon1.Icon = Properties.Resources.electronics;
                    notifyIcon1.Text = $"{clientMapperService.IpAddress} (Connected)";
                }
            };

            clientMapperService.Connecting += (s, e) =>
             {
                 notifyIcon1.ShowBalloonTip(1000, "Connection", $"Trying to connect to {clientMapperService.IpAddress}:{clientMapperService.Port}", ToolTipIcon.Info);
             };

            mapeadoRemotoIpTextBox.TextChanged += (s, e) =>
            {
                if (mapperConfiguration is ClientMapperConfiguration c)
                    c.IpAddress = mapeadoRemotoIpTextBox.Text;
            };

            clientMapperService.Initialize();

            //states recovering

            if (mapperConfiguration is ClientMapperConfiguration clientMapper)
            {
                if (clientMapper.ClientConnectionType == ClientConnectionType.Remote)
                { 
                    mapeadoLocalRadioButton.Checked = true;
                }

                mapeadoRemotoIpTextBox.Text = clientMapper.IpAddress;
                conServerRadioButton.Checked = false;
                conClientRadioButton.Checked = true;
            }
            else
            {
                conServerRadioButton.Checked = true;
                conClientRadioButton.Checked = false;
            }
          
            RefreshStates();

            //prueba de conexión
            mapeadoRemotoConnectButton.Click += (s, e) => clientMapperService.Start();

            HasInit = true;
        }

        void RefreshStates ()
        {
            mapeadoClienteGroupBox.Enabled = !conServerRadioButton.Checked;
            mapeadoRemotoIpTextBox.Enabled = mapeadoRemotoConnectButton.Enabled = mapeadoRemotoRadioButton.Checked;
        }

        //protected override void SetVisibleCore(bool value)
        //{
        //    base.SetVisibleCore(false);
        //}

     
        protected override void OnClosing(CancelEventArgs e)
        {
            clientMapperService.Dispose();
            base.OnClosing(e);
        }

        private void conServerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HasInit)
                RefreshStates();
        }
    }
}
