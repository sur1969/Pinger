namespace Pinger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtPingTarget0 = new TextBox();
            txtPingTarget3 = new TextBox();
            txtPingTarget2 = new TextBox();
            txtPingTarget1 = new TextBox();
            lblPingTarget3Response = new Label();
            lblPingTarget2Response = new Label();
            lblPingTarget1Response = new Label();
            groupBox2 = new GroupBox();
            txtFileLocation = new TextBox();
            label4 = new Label();
            txtPingWaitMs = new TextBox();
            txtTestIntervalSecs = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnStart = new Button();
            btnStop = new Button();
            listBoxLog = new ListBox();
            lblPingTarget0Response = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPingTarget0);
            groupBox1.Controls.Add(txtPingTarget3);
            groupBox1.Controls.Add(txtPingTarget2);
            groupBox1.Controls.Add(txtPingTarget1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 149);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ping Targets";
            // 
            // txtPingTarget0
            // 
            txtPingTarget0.Location = new Point(6, 25);
            txtPingTarget0.Name = "txtPingTarget0";
            txtPingTarget0.PlaceholderText = "Ping Target 1";
            txtPingTarget0.Size = new Size(538, 23);
            txtPingTarget0.TabIndex = 3;
            // 
            // txtPingTarget3
            // 
            txtPingTarget3.Location = new Point(6, 112);
            txtPingTarget3.Name = "txtPingTarget3";
            txtPingTarget3.PlaceholderText = "Ping Target 3";
            txtPingTarget3.Size = new Size(538, 23);
            txtPingTarget3.TabIndex = 2;
            txtPingTarget3.Text = "Cloudflare 1.1.1.1";
            // 
            // txtPingTarget2
            // 
            txtPingTarget2.Location = new Point(6, 83);
            txtPingTarget2.Name = "txtPingTarget2";
            txtPingTarget2.PlaceholderText = "Ping Target 2";
            txtPingTarget2.Size = new Size(538, 23);
            txtPingTarget2.TabIndex = 1;
            txtPingTarget2.Text = "Level3 4.2.2.2";
            // 
            // txtPingTarget1
            // 
            txtPingTarget1.Location = new Point(6, 54);
            txtPingTarget1.Name = "txtPingTarget1";
            txtPingTarget1.PlaceholderText = "Ping Target 1";
            txtPingTarget1.Size = new Size(538, 23);
            txtPingTarget1.TabIndex = 0;
            txtPingTarget1.Text = "Google 8.8.8.8";
            // 
            // lblPingTarget3Response
            // 
            lblPingTarget3Response.AutoSize = true;
            lblPingTarget3Response.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPingTarget3Response.ForeColor = Color.DarkGreen;
            lblPingTarget3Response.Location = new Point(572, 136);
            lblPingTarget3Response.Name = "lblPingTarget3Response";
            lblPingTarget3Response.Size = new Size(118, 15);
            lblPingTarget3Response.TabIndex = 10;
            lblPingTarget3Response.Text = "Response Time (ms)";
            // 
            // lblPingTarget2Response
            // 
            lblPingTarget2Response.AutoSize = true;
            lblPingTarget2Response.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPingTarget2Response.ForeColor = Color.DarkGreen;
            lblPingTarget2Response.Location = new Point(572, 107);
            lblPingTarget2Response.Name = "lblPingTarget2Response";
            lblPingTarget2Response.Size = new Size(118, 15);
            lblPingTarget2Response.TabIndex = 9;
            lblPingTarget2Response.Text = "Response Time (ms)";
            // 
            // lblPingTarget1Response
            // 
            lblPingTarget1Response.AutoSize = true;
            lblPingTarget1Response.FlatStyle = FlatStyle.Flat;
            lblPingTarget1Response.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPingTarget1Response.ForeColor = Color.DarkGreen;
            lblPingTarget1Response.Location = new Point(572, 78);
            lblPingTarget1Response.Name = "lblPingTarget1Response";
            lblPingTarget1Response.Size = new Size(118, 15);
            lblPingTarget1Response.TabIndex = 8;
            lblPingTarget1Response.Text = "Response Time (ms)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtFileLocation);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPingWaitMs);
            groupBox2.Controls.Add(txtTestIntervalSecs);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(711, 116);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Settings";
            // 
            // txtFileLocation
            // 
            txtFileLocation.Location = new Point(229, 79);
            txtFileLocation.Name = "txtFileLocation";
            txtFileLocation.Size = new Size(476, 23);
            txtFileLocation.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 82);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 6;
            label4.Text = "Log File Location";
            // 
            // txtPingWaitMs
            // 
            txtPingWaitMs.Location = new Point(229, 50);
            txtPingWaitMs.Name = "txtPingWaitMs";
            txtPingWaitMs.Size = new Size(100, 23);
            txtPingWaitMs.TabIndex = 5;
            txtPingWaitMs.Text = "200";
            // 
            // txtTestIntervalSecs
            // 
            txtTestIntervalSecs.Location = new Point(229, 21);
            txtTestIntervalSecs.Name = "txtTestIntervalSecs";
            txtTestIntervalSecs.Size = new Size(100, 23);
            txtTestIntervalSecs.TabIndex = 3;
            txtTestIntervalSecs.Text = "5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 53);
            label3.Name = "label3";
            label3.Size = new Size(208, 15);
            label3.TabIndex = 2;
            label3.Text = "Wait For Ping Response (milliseconds)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 24);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Test Interval (seconds)";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LawnGreen;
            btnStart.Location = new Point(10, 298);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Red;
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(10, 298);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 3;
            btnStop.Text = "STOP";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // listBoxLog
            // 
            listBoxLog.FormattingEnabled = true;
            listBoxLog.ItemHeight = 15;
            listBoxLog.Location = new Point(12, 327);
            listBoxLog.Name = "listBoxLog";
            listBoxLog.Size = new Size(711, 109);
            listBoxLog.TabIndex = 4;
            // 
            // lblPingTarget0Response
            // 
            lblPingTarget0Response.AutoSize = true;
            lblPingTarget0Response.FlatStyle = FlatStyle.Flat;
            lblPingTarget0Response.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPingTarget0Response.ForeColor = Color.DarkGreen;
            lblPingTarget0Response.Location = new Point(572, 49);
            lblPingTarget0Response.Name = "lblPingTarget0Response";
            lblPingTarget0Response.Size = new Size(118, 15);
            lblPingTarget0Response.TabIndex = 11;
            lblPingTarget0Response.Text = "Response Time (ms)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 447);
            Controls.Add(lblPingTarget0Response);
            Controls.Add(lblPingTarget3Response);
            Controls.Add(listBoxLog);
            Controls.Add(lblPingTarget2Response);
            Controls.Add(btnStop);
            Controls.Add(lblPingTarget1Response);
            Controls.Add(btnStart);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Pinger";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPingTarget3;
        private TextBox txtPingTarget2;
        private TextBox txtPingTarget1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtPingWaitMs;
        private TextBox txtTestIntervalSecs;
        private Label label3;
        private Button btnStart;
        private Button btnStop;
        private TextBox txtFileLocation;
        private Label label4;
        private ListBox listBoxLog;
        private Label lblPingTarget1Response;
        private Label lblPingTarget3Response;
        private Label lblPingTarget2Response;
        private TextBox txtPingTarget0;
        private Label lblPingTarget0Response;
    }
}
