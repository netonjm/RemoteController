using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RemoteController.Client
{

    public partial class Form1 : Form
    {
        //ITimerWrapper timer = new Timer();
        const int DefaultDelayTooltips = 1000;

        Configuration configuration;
        MapperConfiguration mapperConfiguration => configuration.Connection;

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
            this.configuration = new Configuration();
            configuration.ConnectionChanged += Configuration_ConnectionChanged;

            configuration.Connection = new ClientMapperConfiguration()
            {
                IpAddress = "10.67.1.57",
                Port = 8089,
                JoyButtons = joyButtons
            };
         
            HasInit = true;
        }

        private void Configuration_ConnectionChanged(object sender, EventArgs ev)
        {
            if (configuration.Connection is ClientMapperConfiguration)
                RefreshClientConfiguration();
            else if (configuration.Connection is ServerMapperConnection)
                RefreshServerConfiguration();
            else
                RefreshStandaloneConfiguration();

            RefreshStates();
        }

        void RefreshStandaloneConfiguration()
        {

        }

        void RefreshServerConfiguration()
        {

        }

        void RefreshClientConfiguration ()
        {

            //Initial values
            ClientMapperConfiguration clientMapperConfiguration = null;

            if (configuration.Connection is ClientMapperConfiguration clientConfiguration)
                clientMapperConfiguration = clientConfiguration;
            mapeadoRemotoIpTextBox.Text = clientMapperConfiguration.IpAddress.ToString();

            var deviceService = new SlimDXDeviceService();

            var clientMapperService = new ClientMapperService(clientMapperConfiguration, new WinFormsTimer(), deviceService);

            if (mapperConfiguration is ClientMapperConfiguration clientMapper)
            {
                mapeadoRemotoIpTextBox.Text = clientMapper.IpAddress;
            }

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
            mapeadoRemotoConnectButton.Click += (s, e) => clientMapperService.Start();

            clientMapperService.Initialize();
        }

        void RefreshStates ()
        {
            mapeadoClienteGroupBox.Enabled = !conServerRadioButton.Checked;

            if (mapperConfiguration is ClientMapperConfiguration clientMapper)
            {
                mapeadoRemotoIpTextBox.Text = clientMapper.IpAddress;
                conServerRadioButton.Checked = false;
                conClientRadioButton.Checked = true;
                conStandaloneRadioButton.Checked = false;
                mapeadoRemotoIpTextBox.Enabled = mapeadoRemotoConnectButton.Enabled = true;
            }
            else if (mapperConfiguration is ServerMapperConnection)
            {
                conServerRadioButton.Checked = true;
                conClientRadioButton.Checked = false;
                conStandaloneRadioButton.Checked = false;

                mapeadoRemotoIpTextBox.Enabled = mapeadoRemotoConnectButton.Enabled = false;
            }
            else if (mapperConfiguration is StandaloneMapperConnection)
            {
                conServerRadioButton.Checked = false;
                conClientRadioButton.Checked = false;
                conStandaloneRadioButton.Checked = true;

                mapeadoRemotoIpTextBox.Enabled = mapeadoRemotoConnectButton.Enabled = false;
            }
        }

        //protected override void SetVisibleCore(bool value)
        //{
        //    base.SetVisibleCore(false);
        //}

     
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        private void conServerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!conServerRadioButton.Checked)
                return;
            configuration.Connection = new ServerMapperConnection()
            {
                IpAddress = "10.67.1.57",
                Port = 8089,
            };
        }

        private void conStandaloneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!conStandaloneRadioButton.Checked)
                return;
            configuration.Connection = new StandaloneMapperConnection();
        }

        private void conClientRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!conClientRadioButton.Checked)
                return;
            configuration.Connection = new ClientMapperConfiguration()
            {
                IpAddress = "10.67.1.57",
                Port = 8089,
            };
        }
    }
}
