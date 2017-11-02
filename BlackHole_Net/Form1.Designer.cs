namespace BlackHole_Net
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
            this.BT_PING = new System.Windows.Forms.Button();
            this.BT_auto_config = new System.Windows.Forms.Button();
            this.TB_IP = new System.Windows.Forms.TextBox();
            this.TB_PING = new System.Windows.Forms.TextBox();
            this.TB_ERROR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_LAUNCH = new System.Windows.Forms.Button();
            this.Con_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BT_PING
            // 
            this.BT_PING.Location = new System.Drawing.Point(28, 153);
            this.BT_PING.Name = "BT_PING";
            this.BT_PING.Size = new System.Drawing.Size(117, 23);
            this.BT_PING.TabIndex = 0;
            this.BT_PING.Text = "Ping gateway";
            this.BT_PING.UseVisualStyleBackColor = true;
            this.BT_PING.Click += new System.EventHandler(this.BT_PING_Click);
            // 
            // BT_auto_config
            // 
            this.BT_auto_config.Location = new System.Drawing.Point(28, 195);
            this.BT_auto_config.Name = "BT_auto_config";
            this.BT_auto_config.Size = new System.Drawing.Size(117, 23);
            this.BT_auto_config.TabIndex = 1;
            this.BT_auto_config.Text = "Auto configer ping";
            this.BT_auto_config.UseVisualStyleBackColor = true;
            this.BT_auto_config.Click += new System.EventHandler(this.BT_auto_config_Click);
            // 
            // TB_IP
            // 
            this.TB_IP.Location = new System.Drawing.Point(28, 44);
            this.TB_IP.Name = "TB_IP";
            this.TB_IP.Size = new System.Drawing.Size(117, 20);
            this.TB_IP.TabIndex = 3;
            // 
            // TB_PING
            // 
            this.TB_PING.BackColor = System.Drawing.Color.Black;
            this.TB_PING.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TB_PING.ForeColor = System.Drawing.Color.Lime;
            this.TB_PING.Location = new System.Drawing.Point(318, 28);
            this.TB_PING.Multiline = true;
            this.TB_PING.Name = "TB_PING";
            this.TB_PING.ReadOnly = true;
            this.TB_PING.Size = new System.Drawing.Size(366, 127);
            this.TB_PING.TabIndex = 4;
            this.TB_PING.TextChanged += new System.EventHandler(this.TB_PING_TextChanged);
            // 
            // TB_ERROR
            // 
            this.TB_ERROR.BackColor = System.Drawing.Color.Black;
            this.TB_ERROR.ForeColor = System.Drawing.Color.Red;
            this.TB_ERROR.Location = new System.Drawing.Point(318, 195);
            this.TB_ERROR.Multiline = true;
            this.TB_ERROR.Name = "TB_ERROR";
            this.TB_ERROR.Size = new System.Drawing.Size(366, 143);
            this.TB_ERROR.TabIndex = 5;
            this.TB_ERROR.TextChanged += new System.EventHandler(this.TB_ERROR_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Network reply";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gateway IP-address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Error box";
            // 
            // BT_LAUNCH
            // 
            this.BT_LAUNCH.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BT_LAUNCH.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.BT_LAUNCH.ForeColor = System.Drawing.Color.Red;
            this.BT_LAUNCH.Location = new System.Drawing.Point(28, 112);
            this.BT_LAUNCH.Name = "BT_LAUNCH";
            this.BT_LAUNCH.Size = new System.Drawing.Size(117, 23);
            this.BT_LAUNCH.TabIndex = 9;
            this.BT_LAUNCH.Text = "Launch loris";
            this.BT_LAUNCH.UseVisualStyleBackColor = false;
            this.BT_LAUNCH.Click += new System.EventHandler(this.BT_LAUNCH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 408);
            this.Controls.Add(this.BT_LAUNCH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_ERROR);
            this.Controls.Add(this.TB_PING);
            this.Controls.Add(this.TB_IP);
            this.Controls.Add(this.BT_auto_config);
            this.Controls.Add(this.BT_PING);
            this.Name = "Form1";
            this.Text = "BlackHole_Net";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_PING;
        private System.Windows.Forms.Button BT_auto_config;
        private System.Windows.Forms.TextBox TB_IP;
        private System.Windows.Forms.TextBox TB_PING;
        private System.Windows.Forms.TextBox TB_ERROR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_LAUNCH;
        private System.Windows.Forms.Timer Con_timer;
    }
}

