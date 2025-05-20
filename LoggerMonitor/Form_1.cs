//using JetBrains.ReSharper.TestRunner.Abstractions.Extensions;
//using NuGet;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;


namespace LoggerMonitor
{
    public partial class Form1 : Form
    {
        public Stream raceFileStr = null;
        raceFileClass rFile;
        raceFileClass monFile;
        Settings1 sets = new Settings1();
        int monNbr = 0;
        float seconds = 0.0f;
        private bool loggerMonitorStarted = false;
        private string loggerName = "";
        private NetworkStream nwStream;
        private TcpClient client;
        private int readErrorCount = 0;
        private bool logging = false;
        private StreamWriter logFile;
        private const string loggerNameStr = "loggerName.set";
        private bool voltageView = false;

        private const int NoDataSleepMs = 500;
        private uint linesRead = 0;

        public Form1()
        {
            InitializeComponent();
            var asmName = Assembly.GetExecutingAssembly().GetName();
            this.Text = $"{asmName.Name}, Version {asmName.Version} Copyright  © S.Molin, 2025.";

            sets.Init();
            int port = sets.port;

            var loggerNameFile = new TextFile();
            try
            {
                loggerNameFile.Open(loggerNameStr);
                var len = loggerNameFile.ReadOneLine();
                if (len > 1)
                {
                    var name = loggerNameFile.line;
                    loggerNameTextBox.Text = name;
                }
            }
            catch (FileNotFoundException)
            {

            }
            finally
            {
                loggerNameFile.Close();
                loggerNameFile.Dispose();
            }

            int tIndex = sets.first_temp_sensor_index;
            analogGauge1.CapText = formCapText(tIndex, 0);
            tIndex++;
            analogGauge2.CapText = formCapText(tIndex, 0);
            tIndex++;
            analogGauge3.CapText = formCapText(tIndex, 0);
            tIndex++;
            analogGauge4.CapText = formCapText(tIndex, 0);
            tIndex++;
            analogGauge5.CapText = formCapText(tIndex, 0);
            tIndex++;
            analogGauge6.CapText = formCapText(tIndex, 0);
            tIndex++;
            analogGauge7.CapText = formCapText(tIndex, 0);
            tIndex++;
            analogGauge8.CapText = formCapText(tIndex, 0);

            int aIndex = sets.first_analog_index;
            addGauge1.CapText = sets.analog1.getName(aIndex);
            addGauge1.MaxValue = sets.analog1.getMaxVal(aIndex);
            addGauge1.MinValue = sets.analog1.getMinVal(aIndex);
            addGauge1.ScaleLinesMajorStepValue = (addGauge1.MaxValue - addGauge1.MinValue) / 5;

            aIndex++;
            addGauge2.CapText = sets.analog1.getName(aIndex);
            addGauge2.MaxValue = sets.analog1.getMaxVal(aIndex);
            addGauge2.MinValue = sets.analog1.getMinVal(aIndex);
            addGauge2.ScaleLinesMajorStepValue = (addGauge2.MaxValue - addGauge2.MinValue) / 5;

            aIndex++;
            addGauge3.CapText = sets.analog1.getName(aIndex);
            addGauge3.MaxValue = sets.analog1.getMaxVal(aIndex);
            addGauge3.MinValue = sets.analog1.getMinVal(aIndex);
            addGauge3.ScaleLinesMajorStepValue = (addGauge3.MaxValue - addGauge3.MinValue) / 5;

            aIndex++;
            addGauge4.CapText = sets.analog1.getName(aIndex);
            addGauge4.MaxValue = sets.analog1.getMaxVal(aIndex);
            addGauge4.MinValue = sets.analog1.getMinVal(aIndex);
            addGauge4.ScaleLinesMajorStepValue = (addGauge4.MaxValue - addGauge4.MinValue) / 5;

            aIndex++;
            addGauge5.CapText = sets.analog1.getName(aIndex);
            addGauge5.MaxValue = sets.analog1.getMaxVal(aIndex);
            addGauge5.MinValue = sets.analog1.getMinVal(aIndex);
            addGauge5.ScaleLinesMajorStepValue = (addGauge5.MaxValue - addGauge5.MinValue) / 5;

            aIndex++;
            addGauge6.CapText = sets.analog1.getName(aIndex);
            addGauge6.MaxValue = sets.analog1.getMaxVal(aIndex);
            addGauge6.MinValue = sets.analog1.getMinVal(aIndex);
            addGauge6.ScaleLinesMajorStepValue = (addGauge6.MaxValue - addGauge6.MinValue) / 5;

            aIndex++;
            addGauge7.CapText = sets.analog1.getName(aIndex);
            addGauge7.MaxValue = sets.analog1.getMaxVal(aIndex);
            addGauge7.MinValue = sets.analog1.getMinVal(aIndex);
            addGauge7.ScaleLinesMajorStepValue = (addGauge7.MaxValue - addGauge7.MinValue) / 5;

            aIndex++;
            addGauge8.CapText = sets.analog1.getName(aIndex);
            addGauge8.MaxValue = sets.analog1.getMaxVal(aIndex);
            addGauge8.MinValue = sets.analog1.getMinVal(aIndex);
            addGauge8.ScaleLinesMajorStepValue = (addGauge8.MaxValue - addGauge8.MinValue) / 5;

            numericUpDown1.Value = 1.0m;

            logTextBox.AppendText("Monitor started. ");
        }

        private bool IPv4ConnectToClient(List<IPAddress> ipAddr, Int32 port)
        {
            var ipv4Found = false;
            for (int i = 0; i < 2; i++) // try twice find IPv4 connection
            {
                foreach (var ip in ipAddr)
                {
                    var addrString = ip.ToString();
                    logTextBox.AppendText($" - Connect with IPv4 to {loggerName} addr: {addrString} ");
                    client = new TcpClient(AddressFamily.InterNetwork);
                    client.ReceiveTimeout = 1500;
                    client.SendTimeout = 1500;

                    var ipEndPoint = new IPEndPoint(ip, port);
                    try
                    {
                        client.Connect(ipEndPoint);
                        ipv4Found = true;
                        break;
                    }
                    catch (Exception ex)
                    {
                        logTextBox.AppendText(" thrown exception: " + ex.Message);
                        ipv4Found = false;
                    }
                }
                if (ipv4Found)
                    break;
                System.Threading.Thread.Sleep(1000);
            }
            return ipv4Found;
        }

        private bool IPv6ConnectToClient(List<IPAddress> ipAddr, Int32 port)
        {
            var ipv6Found = false;
            foreach (var ip in ipAddr)
            {
                var addrString = ip.ToString();
                if (ip.AddressFamily == AddressFamily.InterNetworkV6)
                {
                    ipv6Found = true;
                    logTextBox.AppendText($" - Connect with IPv6 to {loggerName} addr: {addrString} ");
                    client = new TcpClient(AddressFamily.InterNetworkV6);
                    client.ReceiveTimeout = 1500;
                    client.SendTimeout = 1500;
                }
                else
                    continue;

                var ipEndPoint = new IPEndPoint(ip, port);
                try
                {
                    client.Connect(ipEndPoint);
                    break;
                }
                catch (Exception ex)
                {
                    logTextBox.AppendText(" thrown exception: " + ex.Message);
                    if (ip == ipAddr.Last())
                        throw;
                }
            }
            return ipv6Found;
        }

        private void StartLoggerButtonClick(object sender, EventArgs e)
        {
            StartLoggerButton.Enabled = false;
            string message = "Hello -> Logger";
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer 
                // connected to the same address as specified by the server, port combination.
                Int32 port = 22222;

                var ip = Dns.GetHostAddresses(loggerName);
                logTextBox.AppendText($"1st Found {ip.Length} IP addresses. ");

                var ipv4Addresses = ip.Where(i => i.AddressFamily == AddressFamily.InterNetwork).Select(i => i).ToList();
                var ipv6Addresses = ip.Where(i => i.AddressFamily == AddressFamily.InterNetworkV6).Select(i => i).ToList();

                var ipv6Found = false;
                var ipv4Found = IPv4ConnectToClient(ipv4Addresses, port);
                if (!ipv4Found)
                    ipv6Found = IPv6ConnectToClient(ipv6Addresses, port);

                if (!ipv4Found && !ipv6Found)
                {
                    MessageBox.Show("No IP-connection to Logger found");
                    return;
                }

                LingerOption lingerOption = new LingerOption(false, 0);
                client.LingerState = lingerOption;

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                nwStream = client.GetStream();
                nwStream.ReadTimeout = 3000;
                nwStream.WriteTimeout = 2000;

                // Send the message to the connected TcpServer. 
                try
                {
                    nwStream.Write(data, 0, data.Length);
                }
                catch (Exception e2)
                {
                    logTextBox.AppendText(" Exception in 1st Socket Write: " + e2.Message);
                }

                // Receive the TcpServer.response.

                // Buffer to store the response bytes.
                data = new Byte[256];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                var trials = 10;
                while (--trials > 0)
                {
                    if (!nwStream.DataAvailable)
                        System.Threading.Thread.Sleep(500);
                    else
                        break;
                }

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = 0;
                try
                {
                    bytes = nwStream.Read(data, 0, data.Length);
                }
                catch (Exception e1)
                {
                    logTextBox.AppendText(" Exception in Socket Read: " + e1.Message);
                }
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                logTextBox.AppendText(" Received: " + responseData);

                if (bytes > 0)
                {
                    if (responseData.Contains("Hello <- Master"))
                    {
                        // Start updating the view
                        loggerMonitorStarted = SendLoggerDataRequest("HeaderRequest");
                    }
                }

                if (loggerMonitorStarted == false)
                {
                    // Close everything.
                    nwStream.Close();
                    MessageBox.Show("Connection to Logger failed");
                    client.Close();
                }
                else
                {
                    monFile = new raceFileClass();
                    monFile.OpenW("Monitor." + System.Convert.ToString(monNbr));
                    monNbr++;
                    initLoggerTimer.Start();
                }
            }
            catch (ArgumentNullException e1)
            {
                MessageBox.Show("ArgumentNullException: " + e1.Message);
            }
            catch (SocketException e2)
            {
                logTextBox.AppendText("SocketException: " + e2.Message);
            }
        }

        private void StartMonitor_button_Click(object sender, EventArgs e)
        {
            bool status = true;
            initComPort();
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not open serial port connection. Original error: " + ex.Message);
                status = false;
            }
            logTextBox.AppendText($"Serial port {serialPort1.PortName} opened. ");
            if (status == true)
            {
                status = startSession();
                int sesSta = readComAll();
                if (status == false)
                    MessageBox.Show("Error: Could not start terminal connection.");
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine("ZE");
                    serialPort1.Close();
                }
                MessageBox.Show("Error: Could not open terminal connection.");
            }
            if (status == true)
                status = sendMonitorCommand();

            if (status == true)
            {
                monFile = new raceFileClass();
                monFile.OpenW("Monitor." + System.Convert.ToString(monNbr));
                monNbr++;
                readComTimer.Start();
            }
        }

        private void StopMonitor_button_Click(object sender, EventArgs e)
        {
            StartLoggerButton.Enabled = true;
            if (monFile != null)
            {
                monFile.CloseW();
            }
            readComTimer.Stop();
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("ZE");
                serialPort1.Close();
            }

            if (initLoggerTimer != null)
                initLoggerTimer.Stop();
            if (readLoggerTimer != null)
                readLoggerTimer.Stop();

            if (loggerMonitorStarted == true)
            {
                SendLoggerDataRequest("Stop -> Logger");
                logTextBox.AppendText("Stop -> Logger sent. ");
                for (int i = 0; i < 3; i++)
                {
                    if (nwStream.CanRead)
                    {
                        string responseData = ReadLoggerData();
                        if (responseData.Contains("Stopping <- Master"))
                        {
                            logTextBox.AppendText("Stopping <- Master received. ");
                            break;
                        }
                        System.Threading.Thread.Sleep(NoDataSleepMs);
                    }
                }
                // Close everything.
                nwStream.Close();
                client.Close();
                loggerMonitorStarted = false;
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            StopMonitor_button_Click(sender, e);
            if (this.rFile != null)
                rFile.Close();
            if (logFile != null)
            {
                logFile.Close();
                logFile.Dispose();
                logFile = null;
            }
            Close();
        }

        private void LogComp_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet.");
        }

        private void Sensor_button_Click(object sender, EventArgs e)
        {
            AnalogSettingsForm aSets = new AnalogSettingsForm();
            DialogResult result;


            result = aSets.ShowDialog();
            if (result == DialogResult.OK)
            {
            }
        }

        private void Simulate_button_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path1 = openFileDialog1.FileName;

                try
                {
                    if ((raceFileStr = openFileDialog1.OpenFile()) != null)
                    {
                        // Insert code to read the stream here.
                        string fName = Convert.ToString(openFileDialog1.FileName);
                        raceFileStr.Close();
                        rFile = new raceFileClass();
                        //rFile.Open(openFileDialog1.FileName);
                        rFile.Open(fName);
                        int count = rFile.ReadOneLine();
                        if (count > 10)
                            count = rFile.ParseLine();
                        int time = rFile.ms;
                        if (time == 0 || time > 1000)
                            time = 50;
                        updateScreenTimer.Interval = time;
                        updateScreenTimer.Enabled = true;
                        updateScreenTimer.Start();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            }
        }

        private void updateScreenTimer_Tick(object sender, EventArgs e)
        {
            int count = rFile.ReadOneLine();
            if (count > 10)
                count = rFile.ParseLine();
            int time = rFile.ms;
            if (time == 0 || time > 1000)
                time = 50;
            decimal dTime = time / numericUpDown1.Value;
            time = System.Convert.ToInt32(dTime);

            seconds = (float)(rFile.ms2 - 1000) / 1000.0f;
            string s = seconds.ToString();
            secsLabel.Text = s;
            updateScreenTimer.Interval = time;
            if (count > 10)
            {    // file end not reached yet
                updateScreenTimer.Start();
                updateGauges(rFile);
            }
            else
                updateScreenTimer.Enabled = false;

        }

        private void readComTimer_Tick(object sender, EventArgs e)
        {
            string rLine;
            bool status1;

            rLine = readMonLine();
            if (rLine.Length > 10) // some valid data
            {
                monFile.wLine = rLine;  // store to disk
                monFile.WriteOneLine();

                monFile.line = rLine;
                int count1 = monFile.ParseLine();
                if (count1 > 10)
                {
                    updateGauges(monFile);
                }
            }
            status1 = sendMonitorCommand();
            readComTimer.Start();
        }

        private void initComPort()
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Close();
            string name = "COM" + System.Convert.ToString(sets.port);
            serialPort1.PortName = name;
            if (sets.port_speed == 2)
                serialPort1.BaudRate = 38400;
            else
                serialPort1.BaudRate = 9600;

            serialPort1.WriteTimeout = 500;
            serialPort1.WriteBufferSize = 10;
            serialPort1.ReadTimeout = 1;
            serialPort1.Parity = System.IO.Ports.Parity.Even;
            serialPort1.StopBits = System.IO.Ports.StopBits.Two;

            serialPort1.NewLine = "\r";
        }

        private bool startSession()
        {
            int sesState = 0;  // 1 = Starting..., 2 = illegal passw, 3 = wellcome to ...
            bool status2 = false;

            serialPort1.ReadTimeout = 1;
            try
            {
                serialPort1.WriteLine("\n");
                for (int trials = 1; trials < 6 && status2 == false; trials++)
                {
                    sesState = readComAll();
                    if (sesState >= 3)
                    {
                        status2 = true;
                        break;
                    }
                    serialPort1.WriteLine("CHEVYS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not write or read serial port connection (StartSession). Original error: " + ex.Message);
                return false;
            }
            return status2;
        }

        private int readComAll()
        {   // this reads max 10 lines from COM port, if there is lines to be read
            string rLine;
            int stat1 = 0;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    rLine = serialPort1.ReadLine();
                    if (rLine.Contains("STARTING"))
                        stat1 = 1;
                    if (rLine.Contains("ILLEGAL"))
                        stat1 = 2;
                    if (rLine.Contains("WELLCOME"))
                        stat1 = 3;
                    if (rLine.Contains(":MAN"))
                        stat1 = 4;
                    if (rLine.Contains(":CLU"))
                        stat1 = 5;
                    if (rLine.Contains(":RACE"))
                        stat1 = 6;
                }
                catch (TimeoutException)
                {
                }
            }
            return stat1;
        }

        private string readMonLine()
        {   // this reads max 5 lines from COM port, if there is lines to be read
            // and returns the line containing monitor data
            string rLine, retLine = "";
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    rLine = serialPort1.ReadLine();
                    if (rLine.Contains("ZXO") || rLine.Contains(":") || rLine.Contains("***"))
                        // skip it
                        retLine = "";
                    else if (rLine.Length > 10)
                        retLine = rLine;
                }
                catch (TimeoutException)
                {
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read serial port connection (in readMonLine). Original error: " + ex.Message);
                }
            }
            return retLine;
        }

        private bool sendMonitorCommand()
        {
            try
            {
                serialPort1.WriteLine("ZXO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not write serial port connection (SendMonitorCommand). Original error: " + ex.Message);
                return false;
            }
            return true;
        }

        private string formCapText(int index, int value)
        {   // name from settings + current value after it.
            string reString = sets.analog1.getName(index) + ": " + value.ToString();
            return reString;
        }

        private int displayAnalogValueInt(AGauge anaGauge, raceFileClass rF, int analogNumber, int digitalValue, int meterValue, float multiplier)
        {   // this calculates one measured analog value pointed by index i.e. analogNumber
            int rotator = rF.AnalogRotator;
            float flValue = ((rF.Analog[analogNumber] >> rotator) - digitalValue) * multiplier + (float)meterValue;
            var intValue = 0;
            if (!float.IsNaN(flValue))
            {
                intValue = System.Convert.ToInt32(flValue);
            }
            anaGauge.Value = intValue;
            anaGauge.CapText = formCapText(analogNumber, intValue);
            return intValue;
        }

        private float calcFloatAnalogValue(AGauge anaGauge, raceFileClass rF, int analogNumber, int digitalValue, int meterValue, float multiplier)
        {
            float flValue = (float)(rF.Analog[analogNumber] - digitalValue) * multiplier + (float)meterValue;
            return flValue;
        }

        private void updateGauges(raceFileClass raceFile)
        {
            string vText;
            int value;
            float fValue;

            rpmGauge1.Value = raceFile.RPM[0];
            vText = raceFile.RPM[0].ToString();
            gauge1_label.Text = vText;

            fValue = (float)raceFile.RPM[1] * (float)sets.speedPerShaftRPM;
            rpmGauge2.Value = fValue;
            value = System.Convert.ToInt32(fValue);
            gauge2_label.Text = value.ToString();

            rpmGauge3.Value = raceFile.RPM[2];
            rpmGauge4.Value = raceFile.RPM[3];

            UpdateOnOffs(raceFile);

            float multip = (float)(sets.temp_2 - sets.temp_1) / (float)(sets.analog_value_2 - sets.analog_value_1);

            int tmpIndex = sets.first_temp_sensor_index;
            value = displayAnalogValueInt(analogGauge1, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);
            tmpIndex++;
            value = displayAnalogValueInt(analogGauge2, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);
            tmpIndex++;
            value = displayAnalogValueInt(analogGauge3, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);
            tmpIndex++;
            value = displayAnalogValueInt(analogGauge4, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);
            tmpIndex++;
            value = displayAnalogValueInt(analogGauge5, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);
            tmpIndex++;
            value = displayAnalogValueInt(analogGauge6, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);
            tmpIndex++;
            value = displayAnalogValueInt(analogGauge7, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);
            tmpIndex++;
            value = displayAnalogValueInt(analogGauge8, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);

            float[] volt = new float[8];
            int aIndex = 0;
            for (int i = 0; i < 8; i++)
            {
                volt[i] = raceFile.Analog[sets.first_analog_index + i] * 5.0F / 0x20000;
            }
            float[] val = new float[8];
            for (int i = 0; i < 8; i++)
            {
                aIndex = sets.first_analog_index + i;
                val[i] = (float)(volt[i] - sets.analog1.getVolt2(aIndex))
                            / sets.analog1.getMultip(aIndex) + sets.analog1.getVal2(aIndex);
            }
            addGauge1.Value = val[0];
            addGauge2.Value = val[1];
            addGauge3.Value = val[2];
            addGauge4.Value = val[3];
            addGauge5.Value = val[4];
            addGauge6.Value = val[5];
            addGauge7.Value = val[6];
            addGauge8.Value = val[7];
        }

        private void UpdateOnOffNames(raceFileClass raceFile)
        {
            OnOffButton1.Text = raceFile.OnOffName[0];
            OnOffButton2.Text = raceFile.OnOffName[1];
            OnOffButton3.Text = raceFile.OnOffName[2];
            OnOffButton4.Text = raceFile.OnOffName[3];
        }

        private void UpdateOnOffs(raceFileClass raceFile)
        {
            if (raceFile.onOff[0] == true)
            {
                if (sets.OnOffs.getState(0) == true)
                    OnOffButton1.BackColor = System.Drawing.Color.LightGreen;
                else
                    OnOffButton1.BackColor = System.Drawing.Color.LightSlateGray;
            }
            else
            {
                if (sets.OnOffs.getState(0) == true)
                    OnOffButton1.BackColor = System.Drawing.Color.LightSlateGray;
                else
                    OnOffButton1.BackColor = System.Drawing.Color.LightGreen;
            }

            if (raceFile.onOff[1] == true)
            {
                if (sets.OnOffs.getState(1) == true)
                    OnOffButton2.BackColor = System.Drawing.Color.LightGreen;
                else
                    OnOffButton2.BackColor = System.Drawing.Color.LightSlateGray;
            }
            else
            {
                if (sets.OnOffs.getState(1) == true)
                    OnOffButton2.BackColor = System.Drawing.Color.LightSlateGray;
                else
                    OnOffButton2.BackColor = System.Drawing.Color.LightGreen;
            }

            if (raceFile.onOff[2] == true)
            {
                if (sets.OnOffs.getState(2) == true)
                    OnOffButton3.BackColor = System.Drawing.Color.LightGreen;
                else
                    OnOffButton3.BackColor = System.Drawing.Color.LightSlateGray;
            }
            else
            {
                if (sets.OnOffs.getState(2) == true)
                    OnOffButton3.BackColor = System.Drawing.Color.LightSlateGray;
                else
                    OnOffButton3.BackColor = System.Drawing.Color.LightGreen;
            }

            if (raceFile.onOff[3] == true)
            {
                if (sets.OnOffs.getState(3) == true)
                    OnOffButton4.BackColor = System.Drawing.Color.LightGreen;
                else
                    OnOffButton4.BackColor = System.Drawing.Color.LightSlateGray;
            }
            else
            {
                if (sets.OnOffs.getState(3) == true)
                    OnOffButton4.BackColor = System.Drawing.Color.LightSlateGray;
                else
                    OnOffButton4.BackColor = System.Drawing.Color.LightGreen;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (monFile != null)
            {
                monFile.CloseW();
                monFile.Dispose();
            }
            if (this.rFile != null)
                rFile.Close();
            if (logFile != null)
            {
                logFile.Flush();
                logFile.Close();
                logFile.Dispose();
                logFile = null;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown1.Value;
            // scroll downwards, jump logarithmic way
            if (numericUpDown1.Value == 1.9m)
                numericUpDown1.Value = 1m;
            if (numericUpDown1.Value == 0.9m)
                numericUpDown1.Value = 0.5m;

            // scroll upwards, jump logarithmic way
            if (numericUpDown1.Value == 0.6m)
                numericUpDown1.Value = 1m;
            if (numericUpDown1.Value == 1.1m)
                numericUpDown1.Value = 2m;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void loggerNameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void loggerNameTextBox_Leave(object sender, EventArgs e)
        {
            var loggerNameFile = new TextFile();
            loggerName = loggerNameTextBox.Text;
            loggerNameFile.OpenW(loggerNameStr);
            loggerNameFile.wLine = loggerName;
            loggerNameFile.WriteOneLine();
            loggerNameFile.Close();
            loggerNameFile.Dispose();
        }

        private void initLoggerTimer_Tick(object sender, EventArgs e)
        {
            string rLine;

            rLine = ReadLoggerData();
            if (rLine.Contains("HeaderItems"))
            {
                logTextBox.AppendText(" Received HeaderItems.");
                UpdateGaugeSettings(rLine);
            }
            else if (rLine.Contains("HeaderValues"))
            {
                logTextBox.AppendText(" Received HeaderValues.");
                UpdateGaugeLimits(rLine);
                initLoggerTimer.Stop();
            }
            else
            {
                logTextBox.AppendText($"Received response:'{rLine}'");
            }
            if (logFile != null)
            {
                logFile.WriteLine(rLine);
            }
        }

        private void readLoggerTimer_Tick(object sender, EventArgs e)
        {
            string rLine;
            var voltagesRead = false;
            rLine = ReadLoggerData();
            if (rLine.Length < 10)
            {
                rLine += ReadLoggerData();
            }
            linesRead++;
            readLoggerTimer.Start();
            if (rLine.Contains("DataValues"))
            {
                readErrorCount = 0;
                monFile.wLine = rLine;  // store to disk
                if (linesRead % 20 == 0)
                    monFile.WriteOneLine();

                monFile.line = rLine;
                int count1 = monFile.ParseLoggerLine();
                if (count1 > 10 & !voltageView) // don't update gauges here, if voltage view selected
                {
                    UpdateLoggerGauges(monFile, count1);
                }
                if (logFile != null)
                {
                    logFile.WriteLine(rLine);
                }
            }
            else if (rLine.Contains("VoltageValues"))
            {
                voltagesRead = true;
                readErrorCount = 0;
                monFile.wLine = rLine;  // store to disk
                monFile.WriteOneLine();

                monFile.line = rLine;
                int count1 = monFile.ParseLoggerVoltages();
                if (count1 > 10)
                {
                    UpdateLoggerGauges(monFile, count1);
                }
                if (logFile != null)
                {
                    logFile.WriteLine(rLine);
                }
            }
            else
            {
                readErrorCount++;
                logTextBox.AppendText($" Got wrong response:'{rLine}'");
                if (rLine.Length < 5)
                    System.Threading.Thread.Sleep(NoDataSleepMs);
            }
            if (readErrorCount > 5)
            {
                StopMonitor_button_Click(this, EventArgs.Empty);
                if (readLoggerTimer != null)
                    readLoggerTimer.Stop();
                if (initLoggerTimer != null)
                    initLoggerTimer.Stop();
                MessageBox.Show($"Reading Logger failed {readErrorCount} times. Closing connection...");
            }
            else
            {
                System.Threading.Thread.Sleep(30);

                if (voltageView & !voltagesRead)
                    loggerMonitorStarted = SendLoggerDataRequest("VoltageRequest");
                else
                    loggerMonitorStarted = SendLoggerDataRequest("DataRequest");
            }
            if (loggerMonitorStarted & readErrorCount > 0)
                readErrorCount--;
        }

        private void UpdateLoggerGauges(raceFileClass raceFile, int itemCount)
        {
            string vText;

            rpmGauge1.Value = raceFile.RPM[0];
            Byte[] name = System.Text.Encoding.ASCII.GetBytes(raceFile.RPMLimit[0].name);
            vText = System.Text.Encoding.ASCII.GetString(name);
            rpmGauge1.CapText = vText;
            gauge1_label.Text = rpmGauge1.Value.ToString();

            rpmGauge2.Value = raceFile.RPM[1];
            name = System.Text.Encoding.ASCII.GetBytes(raceFile.RPMLimit[1].name);
            vText = System.Text.Encoding.ASCII.GetString(name);
            rpmGauge2.CapText = vText;
            gauge2_label.Text = rpmGauge2.Value.ToString();

            rpmGauge3.Value = raceFile.RPM[2];
            rpmGauge4.Value = raceFile.RPM[3];

            UpdateOnOffs(raceFile);

            analogGauge1.Value = (float)raceFile.AnalogDouble[0];
            analogGauge2.Value = (float)raceFile.AnalogDouble[1];
            analogGauge3.Value = (float)raceFile.AnalogDouble[2];
            analogGauge4.Value = (float)raceFile.AnalogDouble[3];
            analogGauge5.Value = (float)raceFile.AnalogDouble[4];
            analogGauge6.Value = (float)raceFile.AnalogDouble[5];
            analogGauge7.Value = (float)raceFile.AnalogDouble[6];
            analogGauge8.Value = (float)raceFile.AnalogDouble[7];

            if (voltageView)
            {
                analogGauge1.CapText = formLoggerCapVoltageText(0);
                analogGauge2.CapText = formLoggerCapVoltageText(1);
                analogGauge3.CapText = formLoggerCapVoltageText(2);
                analogGauge4.CapText = formLoggerCapVoltageText(3);
                analogGauge5.CapText = formLoggerCapVoltageText(4);
                analogGauge6.CapText = formLoggerCapVoltageText(5);
                analogGauge7.CapText = formLoggerCapVoltageText(6);
                analogGauge8.CapText = formLoggerCapVoltageText(7);
            }
            else
            {
                analogGauge1.CapText = formLoggerCapText(0);
                analogGauge2.CapText = formLoggerCapText(1);
                analogGauge3.CapText = formLoggerCapText(2);
                analogGauge4.CapText = formLoggerCapText(3);
                analogGauge5.CapText = formLoggerCapText(4);
                analogGauge6.CapText = formLoggerCapText(5);
                analogGauge7.CapText = formLoggerCapText(6);
                analogGauge8.CapText = formLoggerCapText(7);
            }

            int firstAddIndex = (int)addGaugesUpDown.Value - 1;
            addGauge1.Value = (float)raceFile.AnalogDouble[firstAddIndex];
            addGauge2.Value = (float)raceFile.AnalogDouble[firstAddIndex + 1];
            addGauge3.Value = (float)raceFile.AnalogDouble[firstAddIndex + 2];
            addGauge4.Value = (float)raceFile.AnalogDouble[firstAddIndex + 3];
            addGauge5.Value = (float)raceFile.AnalogDouble[firstAddIndex + 4];
            addGauge6.Value = (float)raceFile.AnalogDouble[firstAddIndex + 5];
            addGauge7.Value = (float)raceFile.AnalogDouble[firstAddIndex + 6];
            addGauge8.Value = (float)raceFile.AnalogDouble[firstAddIndex + 7];

            if (voltageView)
            {
                addGauge1.CapText = formLoggerCapVoltageText(firstAddIndex);
                addGauge2.CapText = formLoggerCapVoltageText(firstAddIndex + 1);
                addGauge3.CapText = formLoggerCapVoltageText(firstAddIndex + 2);
                addGauge4.CapText = formLoggerCapVoltageText(firstAddIndex + 3);
                addGauge5.CapText = formLoggerCapVoltageText(firstAddIndex + 4);
                addGauge6.CapText = formLoggerCapVoltageText(firstAddIndex + 5);
                addGauge7.CapText = formLoggerCapVoltageText(firstAddIndex + 6);
                addGauge8.CapText = formLoggerCapVoltageText(firstAddIndex + 7);
            }
            else
            {
                addGauge1.CapText = formLoggerCapText(firstAddIndex);
                addGauge2.CapText = formLoggerCapText(firstAddIndex + 1);
                addGauge3.CapText = formLoggerCapText(firstAddIndex + 2);
                addGauge4.CapText = formLoggerCapText(firstAddIndex + 3);
                addGauge5.CapText = formLoggerCapText(firstAddIndex + 4);
                addGauge6.CapText = formLoggerCapText(firstAddIndex + 5);
                addGauge7.CapText = formLoggerCapText(firstAddIndex + 6);
                addGauge8.CapText = formLoggerCapText(firstAddIndex + 7);
            }
        }

        private string formLoggerCapText(int index)
        {   // name + current value after it.
            //Byte[] name = System.Text.Encoding.ASCII.GetBytes(monFile.AnalogLimit[index].name)            
            //string reString = System.Text.Encoding.ASCII.GetString(name) + ": " + monFile.AnalogDouble[index].ToString("F1");
            string reString = $"{monFile.AnalogLimit[index].name} : {monFile.AnalogDouble[index]:F1}";
            return reString;
        }

        private string formLoggerCapVoltageText(int index)
        {   // name + current voltage after it.
            //Byte[] name = System.Text.Encoding.ASCII.GetBytes(monFile.AnalogLimit[index].name);
            string reString = $"{monFile.AnalogLimit[index].name} : {monFile.AnalogVoltage[index]:F3} V";
            return reString;
        }

        private bool SendLoggerDataRequest(string request)
        {
            bool status = false;
            byte[] wBuffer = new byte[40];
            wBuffer = System.Text.Encoding.ASCII.GetBytes(request);
            try
            {
                nwStream.Write(wBuffer, 0, wBuffer.Length);
                status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in sending data request to Logger. Original error: " + ex.Message);
            }
            return status;
        }

        private void HandleReadError(string text)
        {
            readErrorCount++;
            logTextBox.AppendText("Read error: nr=" + readErrorCount.ToString() + " " + text);
            if (readErrorCount == 10)
            {
                if (initLoggerTimer != null)
                    initLoggerTimer.Stop();
                if (readLoggerTimer != null)
                    readLoggerTimer.Stop();
                MessageBox.Show("Reading data from Logger failed. Closing connection...");
            }
            if (readErrorCount == 5)
                MessageBox.Show("Exception in reading data from Logger.\n Original error: " + text);
        }

        private string ReadLoggerData()
        {
            // Buffer to store the response bytes.
            Byte[] data = new Byte[500];

            // String to store the response ASCII representation.
            String responseData = String.Empty;

            nwStream.ReadTimeout = 500;

            // Read the TcpServer response bytes.
            try
            {
                var dataAvailable = false;
                for (int trials = 0; trials < 10; trials++)
                {
                    dataAvailable = nwStream.DataAvailable;
                    if (dataAvailable)
                        break;
                    else
                        Thread.Sleep(100);
                };
                if (dataAvailable)
                {
                    Int32 bytes = nwStream.Read(data, 0, data.Length);
                    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                }
                else
                {
                    HandleReadError("No data.");
                }
            }
            catch (Exception exc)
            {
                HandleReadError(exc.Message);
            }
            return responseData;
        }

        private void UpdateGaugeSettings(string settings)
        {
            var items = settings.Split(';');

            if (items[0].Contains("HeaderItems"))
            {
                if (items.Count() >= (1 + 4 + 4 + 16))
                {
                    var i = 0;
                    for (i = 0; i < 4; i++)
                    {
                        monFile.RPMLimit[i].name = items[i + 1];
                    }
                    for (i = 0; i < 4; i++)
                    {
                        monFile.OnOffName[i] = items[i + 5];
                    }
                    for (i = 0; i < items.Count() - 9; i++)
                    {
                        monFile.AnalogLimit[i].name = items[i + 9];
                    }
                    //updateGauges(monFile);
                    UpdateOnOffNames(monFile);

                    var status = SendLoggerDataRequest("HeaderLimitsRequest");
                    initLoggerTimer.Start();
                }
            }
        }

        private void UpdateGaugeLimits(string limits)
        {
            var items = limits.Split(';');

            if (items[0].Contains("HeaderValues") && items.Count() >= (1 + 8 + 32))
            {
                var i = 0;
                for (i = 0; i < 4; i++)
                {
                    var min = (float)Convert.ToDouble(items[2 * i + 1], CultureInfo.InvariantCulture);
                    var max = (float)Convert.ToDouble(items[2 * i + 2], CultureInfo.InvariantCulture);
                    if (min < 10000)
                        min = 0;
                    if (max > 20000)
                        max = 10000;
                    if (min == max)
                        max = min + 10000;
                    monFile.RPMLimit[i].min = min;
                    monFile.RPMLimit[i].max = max;
                }
                int firstAddIndex = (int)addGaugesUpDown.Value - 1;
                var analogCount = (items.Count() - 9) / 2;
                for (i = 0; i < analogCount; i++)
                {
                    var min = Convert.ToDouble(items[2 * i + 9], CultureInfo.InvariantCulture);
                    var max = Convert.ToDouble(items[2 * i + 10], CultureInfo.InvariantCulture);
                    if (min < -1000)
                        min = 0.0;
                    if (max > 50000)
                        max = 1000.0;
                    if (min == max)
                        max = min + 100.0;
                    if (max == 1)
                        max = 2.0;
                    if (max < min)
                    {
                        var m = max;
                        max = min;
                        min = m;
                    }

                    monFile.AnalogLimit[i].min = min;
                    monFile.AnalogLimit[i].max = max;

                    var majorStep = (max - min) / 5;
                    majorStep = Math.Round(majorStep, 2);
                    majorStep = Math.Abs(majorStep);

                    max = Math.Round(max, 2);   // why ??
                    if (i < 8)
                    {
                        UpdateAnalogGaugeLimitsToScreen(i, min, max, majorStep);
                    }
                    if (i >= firstAddIndex)
                    {
                        UpdateAddGaugeLimitsToScreen(i, min, max, majorStep);
                    }
                }
                updateGauges(monFile);
            }
            var status = SendLoggerDataRequest("DataRequest");
            readLoggerTimer.Start();
        }

        private void UpdateAnalogGaugeLimitsToScreen(int gaugeIndex, double min, double max, double majorStep)
        {
            switch (gaugeIndex)
            {
                case 0:
                    analogGauge1.MaxValue = (float)max;
                    analogGauge1.MinValue = (float)min;
                    analogGauge1.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
                case 01:
                    analogGauge2.MaxValue = (float)max;
                    analogGauge2.MinValue = (float)min;
                    analogGauge2.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
                case 02:
                    analogGauge3.MaxValue = (float)max;
                    analogGauge3.MinValue = (float)min;
                    analogGauge3.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
                case 03:
                    analogGauge4.MaxValue = (float)max;
                    analogGauge4.MinValue = (float)min;
                    analogGauge4.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
                case 04:
                    analogGauge5.MaxValue = (float)max;
                    analogGauge5.MinValue = (float)min;
                    analogGauge5.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
                case 05:
                    analogGauge6.MaxValue = (float)max;
                    analogGauge6.MinValue = (float)min;
                    analogGauge6.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
                case 06:
                    analogGauge7.MaxValue = (float)max;
                    analogGauge7.MinValue = (float)min;
                    analogGauge7.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
                case 07:
                    analogGauge8.MaxValue = (float)max;
                    analogGauge8.MinValue = (float)min;
                    analogGauge8.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
            }
        }

        private void UpdateAddGaugeLimitsToScreen(int gaugeIndex, double min, double max, double majorStep)
        {
            int firstAddIndex = (int)addGaugesUpDown.Value - 1;
            switch (gaugeIndex)
            {
                case 08:
                    addGauge1.MaxValue = (float)max;
                    addGauge1.MinValue = (float)min;
                    addGauge1.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
                case 09:
                    addGauge2.MaxValue = ((float)max);
                    addGauge2.MinValue = ((float)min);
                    addGauge2.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
                case 10:
                    addGauge3.MaxValue = (float)max;
                    addGauge3.MinValue = (float)min;
                    addGauge3.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
                case 11:
                    addGauge4.MaxValue = (float)max;
                    addGauge4.MinValue = (float)min;
                    addGauge4.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
                case 12:
                    addGauge5.MaxValue = (float)max;
                    addGauge5.MinValue = (float)min;
                    addGauge5.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
                case 13:
                    addGauge6.MaxValue = (float)max;
                    addGauge6.MinValue = (float)min;
                    addGauge6.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
                case 14:
                    addGauge7.MaxValue = (float)max;
                    addGauge7.MinValue = (float)min;
                    addGauge7.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
                case 15:
                    addGauge8.MaxValue = (float)max;
                    addGauge8.MinValue = (float)min;
                    addGauge8.ScaleLinesMajorStepValue = (float)majorStep;
                    break;
            }
        }

        private void logDataButton_Click(object sender, EventArgs e)
        {
            if (logging)
            {
                logging = false;
                //logDataButton.BackColor = System.Drawing.SystemColors.Control;
                logDataButton.BackColor = System.Drawing.Color.MistyRose;
                logFile.Close();
                logFile.Dispose();
                logFile = null;
            }
            else
            {
                logging = true;
                logDataButton.BackColor = System.Drawing.Color.LightGreen;
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                path = path + "\\LoggerMonitor.log";
                var logFileStream = new FileStream(path, FileMode.Create);
                logFile = new StreamWriter(logFileStream);
                logFile.WriteLine("Monitor log started: " + System.DateTime.Now.ToLongTimeString());
            }
        }

        private void toggleVoltageButton_Click(object sender, EventArgs e)
        {
            if (voltageView)
            {
                voltageView = false;
                toggleValueButton.BackColor = System.Drawing.Color.MistyRose;
            }
            else
            {
                voltageView = true;
                toggleValueButton.BackColor = System.Drawing.Color.LightGreen;
            }
        }

        private void addGaugesUpDown_ValueChanged(object sender, EventArgs e)
        {
            int firstAddIndex = (int)addGaugesUpDown.Value - 1;
            //var analogCount = (items.Count() - 9) / 2;
            for (int i = 0; i < 8; i++)
            {
                var min = 0.0;
                var max = 100.0;
                if (monFile != null)
                {
                    min = monFile.AnalogLimit[firstAddIndex + i].min;
                    max = monFile.AnalogLimit[firstAddIndex + i].max;
                }

                var majorStep = (max - min) / 5;
                majorStep = Math.Round(majorStep, 2);
                majorStep = Math.Abs(majorStep);

                max = Math.Round(max, 2);

                //if (i >= firstAddIndex && i < firstAddIndex - 8)
                {
                    UpdateAddGaugeLimitsToScreen(i + 8, min, max, majorStep);
                }
            }
        }
    }
}
