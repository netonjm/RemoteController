namespace RemoteController.Server
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LaunchButton = new System.Windows.Forms.Button();
            this.DerechaButton = new System.Windows.Forms.Button();
            this.IzquierdaButton = new System.Windows.Forms.Button();
            this.CreditoButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnGame1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGame2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LaunchButton
            // 
            this.LaunchButton.Location = new System.Drawing.Point(59, 47);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(75, 23);
            this.LaunchButton.TabIndex = 0;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DerechaButton
            // 
            this.DerechaButton.Enabled = false;
            this.DerechaButton.Location = new System.Drawing.Point(158, 47);
            this.DerechaButton.Name = "DerechaButton";
            this.DerechaButton.Size = new System.Drawing.Size(75, 23);
            this.DerechaButton.TabIndex = 1;
            this.DerechaButton.Text = "Derecha";
            this.DerechaButton.UseVisualStyleBackColor = true;
            this.DerechaButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // IzquierdaButton
            // 
            this.IzquierdaButton.Enabled = false;
            this.IzquierdaButton.Location = new System.Drawing.Point(239, 47);
            this.IzquierdaButton.Name = "IzquierdaButton";
            this.IzquierdaButton.Size = new System.Drawing.Size(75, 23);
            this.IzquierdaButton.TabIndex = 2;
            this.IzquierdaButton.Text = "Izquierda";
            this.IzquierdaButton.UseVisualStyleBackColor = true;
            // 
            // CreditoButton
            // 
            this.CreditoButton.Enabled = false;
            this.CreditoButton.Location = new System.Drawing.Point(158, 85);
            this.CreditoButton.Name = "CreditoButton";
            this.CreditoButton.Size = new System.Drawing.Size(75, 23);
            this.CreditoButton.TabIndex = 3;
            this.CreditoButton.Text = "Credito";
            this.CreditoButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(239, 85);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Credito";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 121);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 317);
            this.textBox1.TabIndex = 5;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnGame1
            // 
            this.btnGame1.Location = new System.Drawing.Point(18, 19);
            this.btnGame1.Name = "btnGame1";
            this.btnGame1.Size = new System.Drawing.Size(75, 23);
            this.btnGame1.TabIndex = 6;
            this.btnGame1.Text = "VPinball";
            this.btnGame1.UseVisualStyleBackColor = true;
            this.btnGame1.Click += new System.EventHandler(this.btnGame1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGame2);
            this.groupBox1.Controls.Add(this.btnGame1);
            this.groupBox1.Location = new System.Drawing.Point(462, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Games";
            // 
            // btnGame2
            // 
            this.btnGame2.Location = new System.Drawing.Point(18, 48);
            this.btnGame2.Name = "btnGame2";
            this.btnGame2.Size = new System.Drawing.Size(75, 23);
            this.btnGame2.TabIndex = 7;
            this.btnGame2.Text = "VR-VPinball";
            this.btnGame2.UseVisualStyleBackColor = true;
            this.btnGame2.Click += new System.EventHandler(this.btnGame2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CreditoButton);
            this.Controls.Add(this.IzquierdaButton);
            this.Controls.Add(this.DerechaButton);
            this.Controls.Add(this.LaunchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Button DerechaButton;
        private System.Windows.Forms.Button IzquierdaButton;
        private System.Windows.Forms.Button CreditoButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnGame1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGame2;
    }
}

