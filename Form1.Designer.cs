namespace CriptoChat
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
<<<<<<< HEAD
			this.Server_GroupBox = new System.Windows.Forms.GroupBox();
			this.GroupBox_Mode = new System.Windows.Forms.GroupBox();
			this.RadioButton_Mode_OFB = new System.Windows.Forms.RadioButton();
			this.RadioButton_Mode_CBC = new System.Windows.Forms.RadioButton();
			this.GroupBox_Method = new System.Windows.Forms.GroupBox();
			this.RadioButton_DES = new System.Windows.Forms.RadioButton();
			this.RadioButtom_AES = new System.Windows.Forms.RadioButton();
			this.Btn_Disconnect = new System.Windows.Forms.Button();
			this.Btn_Connect = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.GroupBox_Message = new System.Windows.Forms.GroupBox();
			this.Btn_Send = new System.Windows.Forms.Button();
			this.Btn_Encrypt = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.Server_GroupBox.SuspendLayout();
			this.GroupBox_Mode.SuspendLayout();
			this.GroupBox_Method.SuspendLayout();
			this.GroupBox_Message.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Server_GroupBox
			// 
			this.Server_GroupBox.Controls.Add(this.button1);
			this.Server_GroupBox.Controls.Add(this.GroupBox_Mode);
			this.Server_GroupBox.Controls.Add(this.GroupBox_Method);
			this.Server_GroupBox.Controls.Add(this.Btn_Disconnect);
			this.Server_GroupBox.Controls.Add(this.Btn_Connect);
			this.Server_GroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.Server_GroupBox.Location = new System.Drawing.Point(0, 0);
			this.Server_GroupBox.Name = "Server_GroupBox";
			this.Server_GroupBox.Size = new System.Drawing.Size(571, 122);
			this.Server_GroupBox.TabIndex = 3;
			this.Server_GroupBox.TabStop = false;
			this.Server_GroupBox.Text = "Server";
			this.Server_GroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// GroupBox_Mode
			// 
			this.GroupBox_Mode.Controls.Add(this.RadioButton_Mode_OFB);
			this.GroupBox_Mode.Controls.Add(this.RadioButton_Mode_CBC);
			this.GroupBox_Mode.Location = new System.Drawing.Point(442, 34);
			this.GroupBox_Mode.Name = "GroupBox_Mode";
			this.GroupBox_Mode.Size = new System.Drawing.Size(117, 86);
			this.GroupBox_Mode.TabIndex = 5;
			this.GroupBox_Mode.TabStop = false;
			this.GroupBox_Mode.Text = "Mode";
			// 
			// RadioButton_Mode_OFB
			// 
			this.RadioButton_Mode_OFB.AutoSize = true;
			this.RadioButton_Mode_OFB.Dock = System.Windows.Forms.DockStyle.Right;
			this.RadioButton_Mode_OFB.Location = new System.Drawing.Point(68, 16);
			this.RadioButton_Mode_OFB.Name = "RadioButton_Mode_OFB";
			this.RadioButton_Mode_OFB.Size = new System.Drawing.Size(46, 67);
			this.RadioButton_Mode_OFB.TabIndex = 1;
			this.RadioButton_Mode_OFB.TabStop = true;
			this.RadioButton_Mode_OFB.Text = "OFB";
			this.RadioButton_Mode_OFB.UseVisualStyleBackColor = true;
			this.RadioButton_Mode_OFB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// RadioButton_Mode_CBC
			// 
			this.RadioButton_Mode_CBC.AutoSize = true;
			this.RadioButton_Mode_CBC.Dock = System.Windows.Forms.DockStyle.Left;
			this.RadioButton_Mode_CBC.Location = new System.Drawing.Point(3, 16);
			this.RadioButton_Mode_CBC.Name = "RadioButton_Mode_CBC";
			this.RadioButton_Mode_CBC.Size = new System.Drawing.Size(46, 67);
			this.RadioButton_Mode_CBC.TabIndex = 0;
			this.RadioButton_Mode_CBC.TabStop = true;
			this.RadioButton_Mode_CBC.Text = "CBC";
			this.RadioButton_Mode_CBC.UseVisualStyleBackColor = true;
			// 
			// GroupBox_Method
			// 
			this.GroupBox_Method.Controls.Add(this.RadioButton_DES);
			this.GroupBox_Method.Controls.Add(this.RadioButtom_AES);
			this.GroupBox_Method.Location = new System.Drawing.Point(266, 34);
			this.GroupBox_Method.Name = "GroupBox_Method";
			this.GroupBox_Method.Size = new System.Drawing.Size(121, 86);
			this.GroupBox_Method.TabIndex = 4;
			this.GroupBox_Method.TabStop = false;
			this.GroupBox_Method.Text = "Method";
			// 
			// RadioButton_DES
			// 
			this.RadioButton_DES.AutoSize = true;
			this.RadioButton_DES.Dock = System.Windows.Forms.DockStyle.Right;
			this.RadioButton_DES.Location = new System.Drawing.Point(71, 16);
			this.RadioButton_DES.Name = "RadioButton_DES";
			this.RadioButton_DES.Size = new System.Drawing.Size(47, 67);
			this.RadioButton_DES.TabIndex = 3;
			this.RadioButton_DES.TabStop = true;
			this.RadioButton_DES.Text = "DES";
			this.RadioButton_DES.UseVisualStyleBackColor = true;
			// 
			// RadioButtom_AES
			// 
			this.RadioButtom_AES.AutoSize = true;
			this.RadioButtom_AES.Dock = System.Windows.Forms.DockStyle.Left;
			this.RadioButtom_AES.Location = new System.Drawing.Point(3, 16);
			this.RadioButtom_AES.Name = "RadioButtom_AES";
			this.RadioButtom_AES.Size = new System.Drawing.Size(46, 67);
			this.RadioButtom_AES.TabIndex = 2;
			this.RadioButtom_AES.TabStop = true;
			this.RadioButtom_AES.Text = "AES";
			this.RadioButtom_AES.UseVisualStyleBackColor = true;
			// 
			// Btn_Disconnect
			// 
			this.Btn_Disconnect.Location = new System.Drawing.Point(138, 55);
			this.Btn_Disconnect.Name = "Btn_Disconnect";
			this.Btn_Disconnect.Size = new System.Drawing.Size(75, 23);
			this.Btn_Disconnect.TabIndex = 1;
			this.Btn_Disconnect.Text = "Disconnect";
			this.Btn_Disconnect.UseVisualStyleBackColor = true;
			// 
			// Btn_Connect
			// 
			this.Btn_Connect.Location = new System.Drawing.Point(46, 55);
			this.Btn_Connect.Name = "Btn_Connect";
			this.Btn_Connect.Size = new System.Drawing.Size(75, 23);
			this.Btn_Connect.TabIndex = 0;
			this.Btn_Connect.Text = "Connect";
			this.Btn_Connect.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 122);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(571, 456);
			this.richTextBox1.TabIndex = 4;
			this.richTextBox1.Text = "";
			// 
			// GroupBox_Message
			// 
			this.GroupBox_Message.Controls.Add(this.Btn_Send);
			this.GroupBox_Message.Controls.Add(this.Btn_Encrypt);
			this.GroupBox_Message.Controls.Add(this.groupBox2);
			this.GroupBox_Message.Controls.Add(this.groupBox1);
			this.GroupBox_Message.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.GroupBox_Message.Location = new System.Drawing.Point(0, 466);
			this.GroupBox_Message.Name = "GroupBox_Message";
			this.GroupBox_Message.Size = new System.Drawing.Size(571, 112);
			this.GroupBox_Message.TabIndex = 5;
			this.GroupBox_Message.TabStop = false;
			// 
			// Btn_Send
			// 
			this.Btn_Send.Location = new System.Drawing.Point(495, 55);
			this.Btn_Send.Name = "Btn_Send";
			this.Btn_Send.Size = new System.Drawing.Size(75, 23);
			this.Btn_Send.TabIndex = 3;
			this.Btn_Send.Text = "Send";
			this.Btn_Send.UseVisualStyleBackColor = true;
			// 
			// Btn_Encrypt
			// 
			this.Btn_Encrypt.Location = new System.Drawing.Point(413, 55);
			this.Btn_Encrypt.Name = "Btn_Encrypt";
			this.Btn_Encrypt.Size = new System.Drawing.Size(75, 23);
			this.Btn_Encrypt.TabIndex = 2;
			this.Btn_Encrypt.Text = "Encrypt";
			this.Btn_Encrypt.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.richTextBox3);
			this.groupBox2.Location = new System.Drawing.Point(206, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 100);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// richTextBox3
			// 
			this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox3.Location = new System.Drawing.Point(3, 16);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(194, 81);
			this.richTextBox3.TabIndex = 0;
			this.richTextBox3.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.richTextBox2);
			this.groupBox1.Location = new System.Drawing.Point(0, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox2.Location = new System.Drawing.Point(3, 16);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(194, 81);
			this.richTextBox2.TabIndex = 0;
			this.richTextBox2.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(99, 93);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "safa";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 578);
			this.Controls.Add(this.GroupBox_Message);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.Server_GroupBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Server_GroupBox.ResumeLayout(false);
			this.GroupBox_Mode.ResumeLayout(false);
			this.GroupBox_Mode.PerformLayout();
			this.GroupBox_Method.ResumeLayout(false);
			this.GroupBox_Method.PerformLayout();
			this.GroupBox_Message.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
=======
            this.Server_GroupBox = new System.Windows.Forms.GroupBox();
            this.GroupBox_Mode = new System.Windows.Forms.GroupBox();
            this.RadioButton_Mode_OFB = new System.Windows.Forms.RadioButton();
            this.RadioButton_Mode_CBC = new System.Windows.Forms.RadioButton();
            this.GroupBox_Method = new System.Windows.Forms.GroupBox();
            this.RadioButton_DES = new System.Windows.Forms.RadioButton();
            this.RadioButtom_AES = new System.Windows.Forms.RadioButton();
            this.Btn_Disconnect = new System.Windows.Forms.Button();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GroupBox_Message = new System.Windows.Forms.GroupBox();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Btn_Encrypt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Server_GroupBox.SuspendLayout();
            this.GroupBox_Mode.SuspendLayout();
            this.GroupBox_Method.SuspendLayout();
            this.GroupBox_Message.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Server_GroupBox
            // 
            this.Server_GroupBox.Controls.Add(this.GroupBox_Mode);
            this.Server_GroupBox.Controls.Add(this.GroupBox_Method);
            this.Server_GroupBox.Controls.Add(this.Btn_Disconnect);
            this.Server_GroupBox.Controls.Add(this.Btn_Connect);
            this.Server_GroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Server_GroupBox.Location = new System.Drawing.Point(0, 0);
            this.Server_GroupBox.Name = "Server_GroupBox";
            this.Server_GroupBox.Size = new System.Drawing.Size(571, 122);
            this.Server_GroupBox.TabIndex = 3;
            this.Server_GroupBox.TabStop = false;
            this.Server_GroupBox.Text = "Server";
            this.Server_GroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GroupBox_Mode
            // 
            this.GroupBox_Mode.Controls.Add(this.RadioButton_Mode_OFB);
            this.GroupBox_Mode.Controls.Add(this.RadioButton_Mode_CBC);
            this.GroupBox_Mode.Location = new System.Drawing.Point(442, 34);
            this.GroupBox_Mode.Name = "GroupBox_Mode";
            this.GroupBox_Mode.Size = new System.Drawing.Size(117, 86);
            this.GroupBox_Mode.TabIndex = 5;
            this.GroupBox_Mode.TabStop = false;
            this.GroupBox_Mode.Text = "Mode";
            // 
            // RadioButton_Mode_OFB
            // 
            this.RadioButton_Mode_OFB.AutoSize = true;
            this.RadioButton_Mode_OFB.Dock = System.Windows.Forms.DockStyle.Right;
            this.RadioButton_Mode_OFB.Location = new System.Drawing.Point(68, 16);
            this.RadioButton_Mode_OFB.Name = "RadioButton_Mode_OFB";
            this.RadioButton_Mode_OFB.Size = new System.Drawing.Size(46, 67);
            this.RadioButton_Mode_OFB.TabIndex = 1;
            this.RadioButton_Mode_OFB.TabStop = true;
            this.RadioButton_Mode_OFB.Text = "OFB";
            this.RadioButton_Mode_OFB.UseVisualStyleBackColor = true;
            this.RadioButton_Mode_OFB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RadioButton_Mode_CBC
            // 
            this.RadioButton_Mode_CBC.AutoSize = true;
            this.RadioButton_Mode_CBC.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButton_Mode_CBC.Location = new System.Drawing.Point(3, 16);
            this.RadioButton_Mode_CBC.Name = "RadioButton_Mode_CBC";
            this.RadioButton_Mode_CBC.Size = new System.Drawing.Size(46, 67);
            this.RadioButton_Mode_CBC.TabIndex = 0;
            this.RadioButton_Mode_CBC.TabStop = true;
            this.RadioButton_Mode_CBC.Text = "CBC";
            this.RadioButton_Mode_CBC.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Method
            // 
            this.GroupBox_Method.Controls.Add(this.RadioButton_DES);
            this.GroupBox_Method.Controls.Add(this.RadioButtom_AES);
            this.GroupBox_Method.Location = new System.Drawing.Point(266, 34);
            this.GroupBox_Method.Name = "GroupBox_Method";
            this.GroupBox_Method.Size = new System.Drawing.Size(121, 86);
            this.GroupBox_Method.TabIndex = 4;
            this.GroupBox_Method.TabStop = false;
            this.GroupBox_Method.Text = "Method";
            // 
            // RadioButton_DES
            // 
            this.RadioButton_DES.AutoSize = true;
            this.RadioButton_DES.Dock = System.Windows.Forms.DockStyle.Right;
            this.RadioButton_DES.Location = new System.Drawing.Point(71, 16);
            this.RadioButton_DES.Name = "RadioButton_DES";
            this.RadioButton_DES.Size = new System.Drawing.Size(47, 67);
            this.RadioButton_DES.TabIndex = 3;
            this.RadioButton_DES.TabStop = true;
            this.RadioButton_DES.Text = "DES";
            this.RadioButton_DES.UseVisualStyleBackColor = true;
            // 
            // RadioButtom_AES
            // 
            this.RadioButtom_AES.AutoSize = true;
            this.RadioButtom_AES.Dock = System.Windows.Forms.DockStyle.Left;
            this.RadioButtom_AES.Location = new System.Drawing.Point(3, 16);
            this.RadioButtom_AES.Name = "RadioButtom_AES";
            this.RadioButtom_AES.Size = new System.Drawing.Size(46, 67);
            this.RadioButtom_AES.TabIndex = 2;
            this.RadioButtom_AES.TabStop = true;
            this.RadioButtom_AES.Text = "AES";
            this.RadioButtom_AES.UseVisualStyleBackColor = true;
            // 
            // Btn_Disconnect
            // 
            this.Btn_Disconnect.Location = new System.Drawing.Point(138, 55);
            this.Btn_Disconnect.Name = "Btn_Disconnect";
            this.Btn_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Btn_Disconnect.TabIndex = 1;
            this.Btn_Disconnect.Text = "Disconnect";
            this.Btn_Disconnect.UseVisualStyleBackColor = true;
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(46, 55);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.Btn_Connect.TabIndex = 0;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 122);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(571, 456);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // GroupBox_Message
            // 
            this.GroupBox_Message.Controls.Add(this.Btn_Send);
            this.GroupBox_Message.Controls.Add(this.Btn_Encrypt);
            this.GroupBox_Message.Controls.Add(this.groupBox2);
            this.GroupBox_Message.Controls.Add(this.groupBox1);
            this.GroupBox_Message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox_Message.Location = new System.Drawing.Point(0, 466);
            this.GroupBox_Message.Name = "GroupBox_Message";
            this.GroupBox_Message.Size = new System.Drawing.Size(571, 112);
            this.GroupBox_Message.TabIndex = 5;
            this.GroupBox_Message.TabStop = false;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Location = new System.Drawing.Point(495, 55);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(75, 23);
            this.Btn_Send.TabIndex = 3;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            // 
            // Btn_Encrypt
            // 
            this.Btn_Encrypt.Location = new System.Drawing.Point(413, 55);
            this.Btn_Encrypt.Name = "Btn_Encrypt";
            this.Btn_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.Btn_Encrypt.TabIndex = 2;
            this.Btn_Encrypt.Text = "Encrypt";
            this.Btn_Encrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox3);
            this.groupBox2.Location = new System.Drawing.Point(206, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encrypted Chat";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Location = new System.Drawing.Point(3, 16);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(194, 81);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 16);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(194, 81);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 578);
            this.Controls.Add(this.GroupBox_Message);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Server_GroupBox);
            this.Name = "Form1";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Server_GroupBox.ResumeLayout(false);
            this.GroupBox_Mode.ResumeLayout(false);
            this.GroupBox_Mode.PerformLayout();
            this.GroupBox_Method.ResumeLayout(false);
            this.GroupBox_Method.PerformLayout();
            this.GroupBox_Message.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
>>>>>>> 099d2c6a0572d80dfd47aaf9be68f68a9b752588

        }

        #endregion

        private System.Windows.Forms.GroupBox Server_GroupBox;
        private System.Windows.Forms.GroupBox GroupBox_Mode;
        private System.Windows.Forms.RadioButton RadioButton_Mode_OFB;
        private System.Windows.Forms.RadioButton RadioButton_Mode_CBC;
        private System.Windows.Forms.GroupBox GroupBox_Method;
        private System.Windows.Forms.RadioButton RadioButton_DES;
        private System.Windows.Forms.RadioButton RadioButtom_AES;
        private System.Windows.Forms.Button Btn_Disconnect;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox GroupBox_Message;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.Button Btn_Encrypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Button button1;
	}
}

