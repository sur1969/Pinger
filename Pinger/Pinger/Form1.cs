using System.Net;
using System.Net.NetworkInformation;

namespace Pinger
{
    public partial class Form1 : Form
    {
        private bool _isPingFail = false;
        System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

            string? defaultGateway = NetworkInterface.GetAllNetworkInterfaces()
                                                     .Where(n => n.OperationalStatus == OperationalStatus.Up)
                                                     .SelectMany(n => n.GetIPProperties().GatewayAddresses)
                                                     .FirstOrDefault()?.Address.ToString();
            txtPingTarget0.Text = "Local Internet " + defaultGateway;

            txtPingTarget0.ReadOnly = true;

            txtFileLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Pinger.txt";

            btnStart.Visible = true;
            btnStop.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (PingTargets.Count == 0)
            {
                MessageBox.Show("Invalid 'Ping Targets'. Format must be empty or '<name> <ip>'");
                return;
            }

            if (TestIntervalSecs <= 0)
            {
                MessageBox.Show("Invalid 'Test Interval'. Must be greater than 0");
                return;
            }

            if (PingWaitMs <= 100)
            {
                MessageBox.Show("Invalid 'Wait For Ping Response'. Must be greater than 100");
                return;
            }

            if (string.IsNullOrWhiteSpace(FileLocation) || !Directory.Exists(Path.GetDirectoryName(FileLocation)))
            {
                MessageBox.Show("Invalid 'Log File Location'. Must be a valid file path");
                return;
            }

            try
            {
                File.AppendAllText(FileLocation, "");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Invalid 'Log File Location'. Unauthorized Access. Run as Administrator if you want to use this location.", "ERROR!");
                return;
            }

            LogRecord("Started");

            Pinger();

            btnStart.Visible = false;
            btnStop.Visible = true;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _timer.Stop();

            LogRecord("Stopped");

            btnStart.Visible = true;
            btnStop.Visible = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
        }

        private Dictionary<string, string> LocalPingTargets
        {
            get
            {
                try
                {
                    Dictionary<string, string> pingTargets = [];

                    if (!string.IsNullOrWhiteSpace(txtPingTarget0.Text))
                    {
                        string pingTarget = txtPingTarget0.Text.Split(' ').Last();
                        if (IPAddress.TryParse(pingTarget, out _)) pingTargets.Add("0", pingTarget);
                    }

                    return pingTargets;
                }
                catch
                {
                    return [];
                }
            }
        }

        private Dictionary<string, string> PingTargets
        {
            get
            {
                try
                {
                    Dictionary<string, string> pingTargets = [];

                    if (!string.IsNullOrWhiteSpace(txtPingTarget1.Text))
                    {
                        string pingTarget = txtPingTarget1.Text.Split(' ').Last();
                        if (IPAddress.TryParse(pingTarget, out _)) pingTargets.Add("1", pingTarget);
                    }

                    if (!string.IsNullOrWhiteSpace(txtPingTarget2.Text))
                    {
                        string pingTarget = txtPingTarget2.Text.Split(' ').Last();
                        if (IPAddress.TryParse(pingTarget, out _)) pingTargets.Add("2", pingTarget);
                    }

                    if (!string.IsNullOrWhiteSpace(txtPingTarget3.Text))
                    {
                        string pingTarget = txtPingTarget3.Text.Split(' ').Last();
                        if (IPAddress.TryParse(pingTarget, out _)) pingTargets.Add("3", pingTarget);
                    }

                    return pingTargets;
                }
                catch
                {
                    return [];
                }
            }
        }

        private int TestIntervalSecs => int.TryParse(txtTestIntervalSecs.Text, out int result) ? result : 0;
        private int PingWaitMs => int.TryParse(txtPingWaitMs.Text, out int result) ? result : 0;
        private string FileLocation => txtFileLocation.Text;

        private void LogRecord(string message)
        {
            message = $"{DateTime.Now} - {message}";

            listBoxLog.Items.Add(message);
            listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;

            File.AppendAllText(FileLocation, message + Environment.NewLine);
        }

        #region Pinger

        private void Pinger()
        {
            _timer.Interval = TestIntervalSecs * 1000;
            _timer.Tick += (sender, e) => PingAllTargets(LocalPingTargets);
            _timer.Tick += (sender, e) => PingAllTargets(PingTargets);
            _timer.Start();
        }

        private void PingAllTargets(Dictionary<string, string> pingTargets)
        {
            Ping ping = new();

            int failCount = 0;

            foreach (var pingTarget in pingTargets)
            {
                string pingResponse;

                try
                {
                    PingReply reply = ping.Send(pingTarget.Value, PingWaitMs);

                    if (reply.Status != IPStatus.Success) failCount++;

                    pingResponse = $"Response Time {reply.RoundtripTime}ms";
                }
                catch (Exception)
                {
                    failCount++;
                    pingResponse = $"Response Time FAILED";
                }

                DisplayPingResponse(pingTarget.Key, pingResponse);
            }

            bool isPingFail = failCount == pingTargets.Count;

            LogPing(isPingFail);
        }

        private void DisplayPingResponse(string pingTarget, string pingResponse)
        {
            switch (pingTarget)
            {
                case "0": DisplayPingResponse(lblPingTarget0Response, pingResponse); break;
                case "1": DisplayPingResponse(lblPingTarget1Response, pingResponse); break;
                case "2": DisplayPingResponse(lblPingTarget2Response, pingResponse); break;
                case "3": DisplayPingResponse(lblPingTarget3Response, pingResponse); break;
            }
        }

        private void DisplayPingResponse(Label label, string pingResponse)
        {
            label.Text = pingResponse;
            label.BackColor = Color.MistyRose;
            Task.Delay(1000).ContinueWith(t => label.BackColor = SystemColors.Control);
        }

        private void LogPing(bool isPingFail)
        {
            bool recordLog = _isPingFail != isPingFail;

            if (recordLog)
            {
                _isPingFail = isPingFail;

                string message = isPingFail ? "LOST INTERNET" : "We have Internet again";
                LogRecord(message);
            }
        }

        #endregion
    }
}