namespace ChatApp
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
            this.textLocalIP = new System.Windows.Forms.TextBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textSendtoIP = new System.Windows.Forms.TextBox();
            this.textSendToPort = new System.Windows.Forms.TextBox();
            this.listRecieved = new System.Windows.Forms.ListBox();
            this.textMessageToSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupLocal = new System.Windows.Forms.GroupBox();
            this.groupRemote = new System.Windows.Forms.GroupBox();
            this.buttonConectToJasper = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EncriptionKey = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupLocal.SuspendLayout();
            this.groupRemote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EncriptionKey)).BeginInit();
            this.SuspendLayout();
            // 
            // textLocalIP
            // 
            this.textLocalIP.Location = new System.Drawing.Point(6, 19);
            this.textLocalIP.Name = "textLocalIP";
            this.textLocalIP.Size = new System.Drawing.Size(77, 20);
            this.textLocalIP.TabIndex = 0;
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(89, 19);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(37, 20);
            this.textLocalPort.TabIndex = 1;
            this.textLocalPort.Text = "33";
            // 
            // textSendtoIP
            // 
            this.textSendtoIP.Location = new System.Drawing.Point(6, 19);
            this.textSendtoIP.Name = "textSendtoIP";
            this.textSendtoIP.Size = new System.Drawing.Size(77, 20);
            this.textSendtoIP.TabIndex = 2;
            // 
            // textSendToPort
            // 
            this.textSendToPort.Location = new System.Drawing.Point(89, 19);
            this.textSendToPort.Name = "textSendToPort";
            this.textSendToPort.Size = new System.Drawing.Size(37, 20);
            this.textSendToPort.TabIndex = 3;
            this.textSendToPort.Text = "33";
            // 
            // listRecieved
            // 
            this.listRecieved.FormattingEnabled = true;
            this.listRecieved.Location = new System.Drawing.Point(12, 12);
            this.listRecieved.Name = "listRecieved";
            this.listRecieved.Size = new System.Drawing.Size(264, 368);
            this.listRecieved.TabIndex = 4;
            // 
            // textMessageToSend
            // 
            this.textMessageToSend.AcceptsReturn = true;
            this.textMessageToSend.ForeColor = System.Drawing.Color.Navy;
            this.textMessageToSend.Location = new System.Drawing.Point(12, 393);
            this.textMessageToSend.Name = "textMessageToSend";
            this.textMessageToSend.Size = new System.Drawing.Size(203, 20);
            this.textMessageToSend.TabIndex = 5;
            this.textMessageToSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(221, 392);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(55, 20);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(282, 128);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(132, 23);
            this.buttonConnect.TabIndex = 7;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupLocal
            // 
            this.groupLocal.Controls.Add(this.textLocalIP);
            this.groupLocal.Controls.Add(this.textLocalPort);
            this.groupLocal.Location = new System.Drawing.Point(282, 12);
            this.groupLocal.Name = "groupLocal";
            this.groupLocal.Size = new System.Drawing.Size(132, 52);
            this.groupLocal.TabIndex = 8;
            this.groupLocal.TabStop = false;
            this.groupLocal.Text = "Local";
            // 
            // groupRemote
            // 
            this.groupRemote.Controls.Add(this.textSendtoIP);
            this.groupRemote.Controls.Add(this.textSendToPort);
            this.groupRemote.Location = new System.Drawing.Point(282, 70);
            this.groupRemote.Name = "groupRemote";
            this.groupRemote.Size = new System.Drawing.Size(132, 52);
            this.groupRemote.TabIndex = 9;
            this.groupRemote.TabStop = false;
            this.groupRemote.Text = "Friend";
            // 
            // buttonConectToJasper
            // 
            this.buttonConectToJasper.Location = new System.Drawing.Point(282, 157);
            this.buttonConectToJasper.Name = "buttonConectToJasper";
            this.buttonConectToJasper.Size = new System.Drawing.Size(63, 23);
            this.buttonConectToJasper.TabIndex = 10;
            this.buttonConectToJasper.Text = "Jasper";
            this.buttonConectToJasper.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Contact2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EncriptionKey
            // 
            this.EncriptionKey.Location = new System.Drawing.Point(288, 226);
            this.EncriptionKey.Name = "EncriptionKey";
            this.EncriptionKey.Size = new System.Drawing.Size(131, 20);
            this.EncriptionKey.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Encryption #";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(282, 392);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(39, 20);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 425);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EncriptionKey);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonConectToJasper);
            this.Controls.Add(this.groupRemote);
            this.Controls.Add(this.groupLocal);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textMessageToSend);
            this.Controls.Add(this.listRecieved);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Jasper\'sCh@App";
            this.groupLocal.ResumeLayout(false);
            this.groupLocal.PerformLayout();
            this.groupRemote.ResumeLayout(false);
            this.groupRemote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EncriptionKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLocalIP;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textSendtoIP;
        private System.Windows.Forms.TextBox textSendToPort;
        private System.Windows.Forms.ListBox listRecieved;
        private System.Windows.Forms.TextBox textMessageToSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupLocal;
        private System.Windows.Forms.GroupBox groupRemote;
        private System.Windows.Forms.Button buttonConectToJasper;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown EncriptionKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
    }
}

