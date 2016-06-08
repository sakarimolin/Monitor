using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;


namespace CompMonitor10
{
    public partial class Form1 : Form
    {
        public  Stream raceFileStr = null;
        raceFileClass rFile;
        raceFileClass monFile;
        Settings1 sets = new Settings1();
        int monNbr = 0;
        float seconds = 0.0f;

        public Form1()
        {
            InitializeComponent();
            sets.Init();
            int port = sets.port;

            OnOff1_label.Text = sets.OnOffs.getName(0);
            OnOff2_label.Text = sets.OnOffs.getName(1);
            OnOff3_label.Text = sets.OnOffs.getName(2);

            int tIndex = sets.first_temp_sensor_index;
            aGauge5.CapText = formCapText(tIndex, 0);
            tIndex++;
            aGauge6.CapText = formCapText(tIndex, 0);
            tIndex++;
            aGauge7.CapText = formCapText(tIndex, 0);
            tIndex++;
            aGauge8.CapText = formCapText(tIndex, 0);
            tIndex++;
            aGauge9.CapText = formCapText(tIndex, 0);
            tIndex++;
            aGauge10.CapText = formCapText(tIndex, 0);
            tIndex++;
            aGauge11.CapText = formCapText(tIndex, 0);
            tIndex++;
            aGauge12.CapText = formCapText(tIndex, 0);

            addGauge1.CapText = sets.analog1.getName(8);
            addGauge2.CapText = sets.analog1.getName(9);
            addGauge3.CapText = sets.analog1.getName(10);
            addGauge4.CapText = sets.analog1.getName(11);
            addGauge5.CapText = sets.analog1.getName(12);
            addGauge6.CapText = sets.analog1.getName(13);
            addGauge7.CapText = sets.analog1.getName(14);
            addGauge8.CapText = sets.analog1.getName(15);

            addGauge1.MaxValue = sets.analog1.getMaxVal(8);
            addGauge1.MinValue = sets.analog1.getMinVal(8);
            addGauge1.ScaleLinesMajorStepValue = (addGauge1.MaxValue - addGauge1.MinValue) / 5;

            addGauge2.MaxValue = sets.analog1.getMaxVal(9);
            addGauge2.MinValue = sets.analog1.getMinVal(9);
            addGauge2.ScaleLinesMajorStepValue = (addGauge2.MaxValue - addGauge2.MinValue) / 6;

            addGauge3.MaxValue = sets.analog1.getMaxVal(10);
            addGauge3.MinValue = sets.analog1.getMinVal(10);
            addGauge3.ScaleLinesMajorStepValue = (addGauge3.MaxValue - addGauge3.MinValue) / 5;

            addGauge4.MaxValue = sets.analog1.getMaxVal(11);
            addGauge4.MinValue = sets.analog1.getMinVal(11);
            addGauge4.ScaleLinesMajorStepValue = (addGauge4.MaxValue - addGauge4.MinValue) / 5;

            addGauge5.MaxValue = sets.analog1.getMaxVal(12);
            addGauge5.MinValue = sets.analog1.getMinVal(12);
            addGauge5.ScaleLinesMajorStepValue = (addGauge5.MaxValue - addGauge5.MinValue) / 5;

            addGauge6.MaxValue = sets.analog1.getMaxVal(13);
            addGauge6.MinValue = sets.analog1.getMinVal(13);
            addGauge6.ScaleLinesMajorStepValue = (addGauge6.MaxValue - addGauge6.MinValue) / 4;

            addGauge7.MaxValue = sets.analog1.getMaxVal(14);
            addGauge7.MinValue = sets.analog1.getMinVal(14);
            addGauge7.ScaleLinesMajorStepValue = (addGauge7.MaxValue - addGauge7.MinValue) / 5;

            addGauge8.MaxValue = sets.analog1.getMaxVal(15);
            addGauge8.MinValue = sets.analog1.getMinVal(15);
            addGauge8.ScaleLinesMajorStepValue = (addGauge8.MaxValue - addGauge8.MinValue) / 3;

            numericUpDown1.Value = 1.0m;

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
            if (status == true)
            {
                status = startSession();
                int sesSta = readComAll();
                if(status == false)
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
            if (status == true )
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
            if (monFile != null)
                monFile.CloseW();
            readComTimer.Stop();
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("ZE");
                serialPort1.Close();
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            StopMonitor_button_Click(sender, e);
            if (this.rFile != null)
                rFile.Close();
            Close();
        }

        private void ComPort_button_Click(object sender, EventArgs e)
        {
            Form2 ComSets = new Form2();
            int comPortIndex = 0;
            string comPort;
            DialogResult result;
            ComSets.ComPort_InitPortSpeed(sets.port_speed);
            ComSets.ComPort_InitPortNbr(sets.port - 1);

            result = ComSets.ShowDialog();
            if( result == DialogResult.OK ) {
                comPortIndex = ComSets.ComPort_ReadPortNbr();
                sets.port = comPortIndex + 1;
                comPort = ComSets.comPort;
                sets.port_speed = ComSets.ComPort_ReadPortSpeed();
            }
        }

        private void LogComp_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented." );
        }

        private void Sensor_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.");
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
                    if ((raceFileStr = openFileDialog1.OpenFile( )) != null)
                    {
                        // Insert code to read the stream here.
                        raceFileStr.Close();
                        rFile = new raceFileClass();
                        rFile.Open( openFileDialog1.FileName );
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

            seconds = (float)(rFile.ms2 - 1000)/1000.0f;
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
            string name = "COM" + System.Convert.ToString( sets.port );
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
//            string  rLine;
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
                catch (TimeoutException )
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
                catch (TimeoutException )
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

            float flValue = (float)( rF.Analog[analogNumber] - digitalValue) * multiplier + (float)meterValue;
            int intValue = System.Convert.ToInt32(flValue);
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

            aGauge1.Value = raceFile.RPM[0];
            vText = raceFile.RPM[0].ToString();
            gauge1_label.Text = vText;

            fValue = (float)raceFile.RPM[1] * (float)sets.speedPerShaftRPM;
            aGauge2.Value = fValue;
            value = System.Convert.ToInt32(fValue);
            gauge2_label.Text = value.ToString();

            aGauge3.Value = raceFile.RPM[2];
            aGauge4.Value = raceFile.RPM[3];


            if(raceFile.onOff[0] == true)
                if (sets.OnOffs.getState(0) == true)
                    OnOff1_progressBar.Value = 100;
                else
                    OnOff1_progressBar.Value = 0;
            else
                if (sets.OnOffs.getState(0) == true)
                    OnOff1_progressBar.Value = 0;
                else
                    OnOff1_progressBar.Value = 100;

            if (raceFile.onOff[1] == true)
                if (sets.OnOffs.getState(1) == true)
                    OnOff2_progressBar.Value = 100;
                else
                    OnOff2_progressBar.Value = 0;
            else
                if (sets.OnOffs.getState(1) == true)
                    OnOff2_progressBar.Value = 0;
                else
                    OnOff2_progressBar.Value = 100;

            if (raceFile.onOff[2] == true)
                if (sets.OnOffs.getState(2) == true)
                    OnOff3_progressBar.Value = 100;
                else
                    OnOff3_progressBar.Value = 0;
            else
                if (sets.OnOffs.getState(2) == true)
                    OnOff3_progressBar.Value = 0;
                else
                    OnOff3_progressBar.Value = 100;

            float multip = (float)(sets.temp_2 - sets.temp_1) / (float)(sets.analog_value_2 - sets.analog_value_1);

            int tmpIndex = sets.first_temp_sensor_index;
            value = displayAnalogValueInt(aGauge5, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);
            tmpIndex++;
            value = displayAnalogValueInt(aGauge6, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);
            tmpIndex++;
            value = displayAnalogValueInt(aGauge7, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);
            tmpIndex++;
            value = displayAnalogValueInt(aGauge8, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);
            tmpIndex++;
            value = displayAnalogValueInt(aGauge9, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);
            tmpIndex++;
            value = displayAnalogValueInt(aGauge10, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);
            tmpIndex++;
            value = displayAnalogValueInt(aGauge11, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);
            tmpIndex++;
            value = displayAnalogValueInt(aGauge12, raceFile, tmpIndex, sets.analog_value_2, sets.temp_2, multip);

            float [] volt = new float[8];
            int aIndex = 0;
            for (int i = 0; i < 8; i++)
            {
                volt[i] = (float)raceFile.Analog[sets.first_analog_index + i] * 5.0F / 256.0F;
            }
            float [] val = new float[8];
            for( int i = 0; i < 8; i++ ){
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (monFile != null)
                monFile.CloseW();
            if (this.rFile != null)
                rFile.Close();
            readComTimer.Stop();
            serialPort1.Close();
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



    }
}
