
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
            this.mapeadoRemotoConnectButton = new System.Windows.Forms.Button();
            this.mapeadoRemotoIpTextBox = new System.Windows.Forms.TextBox();
            this.mapeadoRemotoRadioButton = new System.Windows.Forms.RadioButton();
            this.mapeadoLocalRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.conClientRadioButton = new System.Windows.Forms.RadioButton();
            this.conServerRadioButton = new System.Windows.Forms.RadioButton();
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
            this.mapeadoClienteGroupBox.Controls.Add(this.mapeadoRemotoConnectButton);
            this.mapeadoClienteGroupBox.Controls.Add(this.mapeadoRemotoIpTextBox);
            this.mapeadoClienteGroupBox.Controls.Add(this.mapeadoRemotoRadioButton);
            this.mapeadoClienteGroupBox.Controls.Add(this.mapeadoLocalRadioButton);
            this.mapeadoClienteGroupBox.Location = new System.Drawing.Point(284, 26);
            this.mapeadoClienteGroupBox.Name = "mapeadoClienteGroupBox";
            this.mapeadoClienteGroupBox.Size = new System.Drawing.Size(386, 129);
            this.mapeadoClienteGroupBox.TabIndex = 0;
            this.mapeadoClienteGroupBox.TabStop = false;
            this.mapeadoClienteGroupBox.Text = "Mapeado de cliente";
            // 
            // mapeadoRemotoConnectButton
            // 
            this.mapeadoRemotoConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mapeadoRemotoConnectButton.Location = new System.Drawing.Point(273, 38);
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
            this.mapeadoRemotoIpTextBox.Location = new System.Drawing.Point(140, 38);
            this.mapeadoRemotoIpTextBox.Name = "mapeadoRemotoIpTextBox";
            this.mapeadoRemotoIpTextBox.Size = new System.Drawing.Size(118, 26);
            this.mapeadoRemotoIpTextBox.TabIndex = 2;
            this.mapeadoRemotoIpTextBox.Text = "10.67.1.57";
            // 
            // mapeadoRemotoRadioButton
            // 
            this.mapeadoRemotoRadioButton.AutoSize = true;
            this.mapeadoRemotoRadioButton.Location = new System.Drawing.Point(29, 40);
            this.mapeadoRemotoRadioButton.Name = "mapeadoRemotoRadioButton";
            this.mapeadoRemotoRadioButton.Size = new System.Drawing.Size(91, 24);
            this.mapeadoRemotoRadioButton.TabIndex = 1;
            this.mapeadoRemotoRadioButton.TabStop = true;
            this.mapeadoRemotoRadioButton.Text = "Remoto";
            this.mapeadoRemotoRadioButton.UseVisualStyleBackColor = true;
            this.mapeadoRemotoRadioButton.CheckedChanged += new System.EventHandler(this.conServerRadioButton_CheckedChanged);
            // 
            // mapeadoLocalRadioButton
            // 
            this.mapeadoLocalRadioButton.AutoSize = true;
            this.mapeadoLocalRadioButton.Location = new System.Drawing.Point(29, 80);
            this.mapeadoLocalRadioButton.Name = "mapeadoLocalRadioButton";
            this.mapeadoLocalRadioButton.Size = new System.Drawing.Size(72, 24);
            this.mapeadoLocalRadioButton.TabIndex = 0;
            this.mapeadoLocalRadioButton.TabStop = true;
            this.mapeadoLocalRadioButton.Text = "Local";
            this.mapeadoLocalRadioButton.UseVisualStyleBackColor = true;
            this.mapeadoLocalRadioButton.CheckedChanged += new System.EventHandler(this.conServerRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.conClientRadioButton);
            this.groupBox2.Controls.Add(this.conServerRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(34, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modo de Conexión";
            // 
            // conClientRadioButton
            // 
            this.conClientRadioButton.AutoSize = true;
            this.conClientRadioButton.Location = new System.Drawing.Point(25, 80);
            this.conClientRadioButton.Name = "conClientRadioButton";
            this.conClientRadioButton.Size = new System.Drawing.Size(83, 24);
            this.conClientRadioButton.TabIndex = 1;
            this.conClientRadioButton.TabStop = true;
            this.conClientRadioButton.Tag = "dddssdadaddsasda";
            this.conClientRadioButton.Text = "Cliente";
            this.conClientRadioButton.UseVisualStyleBackColor = true;
            this.conClientRadioButton.CheckedChanged += new System.EventHandler(this.conServerRadioButton_CheckedChanged);
            // 
            // conServerRadioButton
            // 
            this.conServerRadioButton.AutoSize = true;
            this.conServerRadioButton.Location = new System.Drawing.Point(25, 40);
            this.conServerRadioButton.Name = "conServerRadioButton";
            this.conServerRadioButton.Size = new System.Drawing.Size(80, 24);
            this.conServerRadioButton.TabIndex = 0;
            this.conServerRadioButton.TabStop = true;
            this.conServerRadioButton.Text = "Server";
            this.conServerRadioButton.UseVisualStyleBackColor = true;
            this.conServerRadioButton.CheckedChanged += new System.EventHandler(this.conServerRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 281);
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
        private System.Windows.Forms.RadioButton mapeadoRemotoRadioButton;
        private System.Windows.Forms.RadioButton mapeadoLocalRadioButton;
        private System.Windows.Forms.Button mapeadoRemotoConnectButton;
        private System.Windows.Forms.TextBox mapeadoRemotoIpTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton conClientRadioButton;
        private System.Windows.Forms.RadioButton conServerRadioButton;
    }
}

