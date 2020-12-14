
namespace RemoteController.Client
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mapeadoClienteGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mapeadoRemotoConnectButton = new System.Windows.Forms.Button();
            this.mapeadoRemotoIpTextBox = new System.Windows.Forms.TextBox();
            this.conStandaloneRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.conClientRadioButton = new System.Windows.Forms.RadioButton();
            this.conServerRadioButton = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mapeadoClienteGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // mapeadoClienteGroupBox
            // 
            this.mapeadoClienteGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapeadoClienteGroupBox.Controls.Add(this.label1);
            this.mapeadoClienteGroupBox.Controls.Add(this.mapeadoRemotoConnectButton);
            this.mapeadoClienteGroupBox.Controls.Add(this.mapeadoRemotoIpTextBox);
            this.mapeadoClienteGroupBox.Location = new System.Drawing.Point(284, 26);
            this.mapeadoClienteGroupBox.Name = "mapeadoClienteGroupBox";
            this.mapeadoClienteGroupBox.Size = new System.Drawing.Size(386, 163);
            this.mapeadoClienteGroupBox.TabIndex = 0;
            this.mapeadoClienteGroupBox.TabStop = false;
            this.mapeadoClienteGroupBox.Text = "Opciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dirección IP";
            // 
            // mapeadoRemotoConnectButton
            // 
            this.mapeadoRemotoConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mapeadoRemotoConnectButton.Location = new System.Drawing.Point(267, 30);
            this.mapeadoRemotoConnectButton.Name = "mapeadoRemotoConnectButton";
            this.mapeadoRemotoConnectButton.Size = new System.Drawing.Size(94, 38);
            this.mapeadoRemotoConnectButton.TabIndex = 3;
            this.mapeadoRemotoConnectButton.Text = "Connectar";
            this.mapeadoRemotoConnectButton.UseVisualStyleBackColor = true;
            // 
            // mapeadoRemotoIpTextBox
            // 
            this.mapeadoRemotoIpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapeadoRemotoIpTextBox.Location = new System.Drawing.Point(132, 36);
            this.mapeadoRemotoIpTextBox.Name = "mapeadoRemotoIpTextBox";
            this.mapeadoRemotoIpTextBox.Size = new System.Drawing.Size(118, 26);
            this.mapeadoRemotoIpTextBox.TabIndex = 2;
            this.mapeadoRemotoIpTextBox.Text = "10.67.1.57";
            // 
            // conStandaloneRadioButton
            // 
            this.conStandaloneRadioButton.AutoSize = true;
            this.conStandaloneRadioButton.Location = new System.Drawing.Point(21, 38);
            this.conStandaloneRadioButton.Name = "conStandaloneRadioButton";
            this.conStandaloneRadioButton.Size = new System.Drawing.Size(116, 24);
            this.conStandaloneRadioButton.TabIndex = 0;
            this.conStandaloneRadioButton.TabStop = true;
            this.conStandaloneRadioButton.Text = "Standalone";
            this.toolTip1.SetToolTip(this.conStandaloneRadioButton, "Permite mapear localmente dispositivos a teclado");
            this.conStandaloneRadioButton.UseVisualStyleBackColor = true;
            this.conStandaloneRadioButton.CheckedChanged += new System.EventHandler(this.conStandaloneRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.conClientRadioButton);
            this.groupBox2.Controls.Add(this.conServerRadioButton);
            this.groupBox2.Controls.Add(this.conStandaloneRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(34, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modo de Conexión";
            // 
            // conClientRadioButton
            // 
            this.conClientRadioButton.AutoSize = true;
            this.conClientRadioButton.Location = new System.Drawing.Point(21, 117);
            this.conClientRadioButton.Name = "conClientRadioButton";
            this.conClientRadioButton.Size = new System.Drawing.Size(83, 24);
            this.conClientRadioButton.TabIndex = 1;
            this.conClientRadioButton.TabStop = true;
            this.conClientRadioButton.Tag = "dddssdadaddsasda";
            this.conClientRadioButton.Text = "Cliente";
            this.toolTip1.SetToolTip(this.conClientRadioButton, "Reenvia pulsaciones de teclas a servidor remoto");
            this.conClientRadioButton.UseVisualStyleBackColor = true;
            this.conClientRadioButton.CheckedChanged += new System.EventHandler(this.conClientRadioButton_CheckedChanged);
            // 
            // conServerRadioButton
            // 
            this.conServerRadioButton.AutoSize = true;
            this.conServerRadioButton.Location = new System.Drawing.Point(21, 77);
            this.conServerRadioButton.Name = "conServerRadioButton";
            this.conServerRadioButton.Size = new System.Drawing.Size(80, 24);
            this.conServerRadioButton.TabIndex = 0;
            this.conServerRadioButton.TabStop = true;
            this.conServerRadioButton.Text = "Server";
            this.toolTip1.SetToolTip(this.conServerRadioButton, "Acepta conexiones de clientes para el mapeo de teclas");
            this.conServerRadioButton.UseVisualStyleBackColor = true;
            this.conServerRadioButton.CheckedChanged += new System.EventHandler(this.conServerRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 214);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mapeadoClienteGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simple Device Mapper";
            this.mapeadoClienteGroupBox.ResumeLayout(false);
            this.mapeadoClienteGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox mapeadoClienteGroupBox;
        private System.Windows.Forms.RadioButton conStandaloneRadioButton;
        private System.Windows.Forms.Button mapeadoRemotoConnectButton;
        private System.Windows.Forms.TextBox mapeadoRemotoIpTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton conClientRadioButton;
        private System.Windows.Forms.RadioButton conServerRadioButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}

