using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace LoggerMonitor
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
            this.updateScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.StartMonitor_button = new System.Windows.Forms.Button();
            this.StopMonitor_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.ComPort_button = new System.Windows.Forms.Button();
            this.LogComp_button = new System.Windows.Forms.Button();
            this.Sensor_button = new System.Windows.Forms.Button();
            this.Simulate_button = new System.Windows.Forms.Button();
            this.StartLoggerButton = new System.Windows.Forms.Button();
            this.logDataButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.readComTimer = new System.Windows.Forms.Timer(this.components);
            this.secsLabel = new System.Windows.Forms.Label();
            this.secs_heading_label = new System.Windows.Forms.Label();
            this.gauge1_label = new System.Windows.Forms.Label();
            this.gauge2_label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.speed_label = new System.Windows.Forms.Label();
            this.loggerNameLabel = new System.Windows.Forms.Label();
            this.loggerNameTextBox = new System.Windows.Forms.TextBox();
            this.readLoggerTimer = new System.Windows.Forms.Timer(this.components);
            this.initLoggerTimer = new System.Windows.Forms.Timer(this.components);
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.toggleValueButton = new System.Windows.Forms.Button();
            this.OnOffButton1 = new System.Windows.Forms.Button();
            this.OnOffButton2 = new System.Windows.Forms.Button();
            this.OnOffButton3 = new System.Windows.Forms.Button();
            this.OnOffButton4 = new System.Windows.Forms.Button();
            this.addGauge8 = new LoggerMonitor.AGauge();
            this.addGauge7 = new LoggerMonitor.AGauge();
            this.addGauge6 = new LoggerMonitor.AGauge();
            this.addGauge5 = new LoggerMonitor.AGauge();
            this.addGauge4 = new LoggerMonitor.AGauge();
            this.addGauge3 = new LoggerMonitor.AGauge();
            this.addGauge2 = new LoggerMonitor.AGauge();
            this.addGauge1 = new LoggerMonitor.AGauge();
            this.analogGauge8 = new LoggerMonitor.AGauge();
            this.analogGauge7 = new LoggerMonitor.AGauge();
            this.analogGauge6 = new LoggerMonitor.AGauge();
            this.analogGauge5 = new LoggerMonitor.AGauge();
            this.analogGauge4 = new LoggerMonitor.AGauge();
            this.analogGauge3 = new LoggerMonitor.AGauge();
            this.analogGauge2 = new LoggerMonitor.AGauge();
            this.analogGauge1 = new LoggerMonitor.AGauge();
            this.rpmGauge4 = new LoggerMonitor.AGauge();
            this.rpmGauge3 = new LoggerMonitor.AGauge();
            this.rpmGauge2 = new LoggerMonitor.AGauge();
            this.rpmGauge1 = new LoggerMonitor.AGauge();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateScreenTimer
            // 
            this.updateScreenTimer.Interval = 200;
            this.updateScreenTimer.Tick += new System.EventHandler(this.updateScreenTimer_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            this.serialPort1.DataBits = 7;
            this.serialPort1.Parity = System.IO.Ports.Parity.Even;
            this.serialPort1.StopBits = System.IO.Ports.StopBits.Two;
            // 
            // StartMonitor_button
            // 
            this.StartMonitor_button.Location = new System.Drawing.Point(986, 580);
            this.StartMonitor_button.Name = "StartMonitor_button";
            this.StartMonitor_button.Size = new System.Drawing.Size(80, 41);
            this.StartMonitor_button.TabIndex = 9;
            this.StartMonitor_button.Text = "Start COM Monitor";
            this.StartMonitor_button.UseVisualStyleBackColor = true;
            this.StartMonitor_button.Click += new System.EventHandler(this.StartMonitor_button_Click);
            // 
            // StopMonitor_button
            // 
            this.StopMonitor_button.Location = new System.Drawing.Point(986, 113);
            this.StopMonitor_button.Name = "StopMonitor_button";
            this.StopMonitor_button.Size = new System.Drawing.Size(80, 41);
            this.StopMonitor_button.TabIndex = 2;
            this.StopMonitor_button.Text = "Stop Monitor";
            this.StopMonitor_button.UseVisualStyleBackColor = true;
            this.StopMonitor_button.Click += new System.EventHandler(this.StopMonitor_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(986, 639);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(80, 41);
            this.Exit_button.TabIndex = 4;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // ComPort_button
            // 
            this.ComPort_button.Location = new System.Drawing.Point(986, 531);
            this.ComPort_button.Name = "ComPort_button";
            this.ComPort_button.Size = new System.Drawing.Size(80, 41);
            this.ComPort_button.TabIndex = 8;
            this.ComPort_button.Text = "COM Port Settings...";
            this.ComPort_button.UseVisualStyleBackColor = true;
            this.ComPort_button.Click += new System.EventHandler(this.ComPort_button_Click);
            // 
            // LogComp_button
            // 
            this.LogComp_button.Location = new System.Drawing.Point(986, 323);
            this.LogComp_button.Name = "LogComp_button";
            this.LogComp_button.Size = new System.Drawing.Size(80, 41);
            this.LogComp_button.TabIndex = 10;
            this.LogComp_button.Text = "Race Logger Settings...";
            this.LogComp_button.UseVisualStyleBackColor = true;
            this.LogComp_button.Click += new System.EventHandler(this.LogComp_button_Click);
            // 
            // Sensor_button
            // 
            this.Sensor_button.Location = new System.Drawing.Point(986, 370);
            this.Sensor_button.Name = "Sensor_button";
            this.Sensor_button.Size = new System.Drawing.Size(80, 41);
            this.Sensor_button.TabIndex = 7;
            this.Sensor_button.Text = "Sensor Settings...";
            this.Sensor_button.UseVisualStyleBackColor = true;
            this.Sensor_button.Click += new System.EventHandler(this.Sensor_button_Click);
            // 
            // Simulate_button
            // 
            this.Simulate_button.Location = new System.Drawing.Point(986, 217);
            this.Simulate_button.Name = "Simulate_button";
            this.Simulate_button.Size = new System.Drawing.Size(80, 41);
            this.Simulate_button.TabIndex = 6;
            this.Simulate_button.Text = "Simulate from File...";
            this.Simulate_button.UseVisualStyleBackColor = true;
            this.Simulate_button.Click += new System.EventHandler(this.Simulate_button_Click);
            // 
            // StartLoggerButton
            // 
            this.StartLoggerButton.Location = new System.Drawing.Point(986, 58);
            this.StartLoggerButton.Name = "StartLoggerButton";
            this.StartLoggerButton.Size = new System.Drawing.Size(80, 41);
            this.StartLoggerButton.TabIndex = 1;
            this.StartLoggerButton.Text = "Start Logger Monitor";
            this.StartLoggerButton.UseVisualStyleBackColor = true;
            this.StartLoggerButton.Click += new System.EventHandler(this.StartLoggerButtonClick);
            // 
            // logDataButton
            // 
            this.logDataButton.Location = new System.Drawing.Point(986, 475);
            this.logDataButton.Name = "logDataButton";
            this.logDataButton.Size = new System.Drawing.Size(80, 41);
            this.logDataButton.TabIndex = 45;
            this.logDataButton.Text = "Toggle Data Transfer Log";
            this.logDataButton.UseVisualStyleBackColor = true;
            this.logDataButton.Click += new System.EventHandler(this.logDataButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // readComTimer
            // 
            this.readComTimer.Tick += new System.EventHandler(this.readComTimer_Tick);
            // 
            // secsLabel
            // 
            this.secsLabel.AutoSize = true;
            this.secsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secsLabel.Location = new System.Drawing.Point(922, 219);
            this.secsLabel.Name = "secsLabel";
            this.secsLabel.Size = new System.Drawing.Size(45, 24);
            this.secsLabel.TabIndex = 54;
            this.secsLabel.Text = "0.00";
            // 
            // secs_heading_label
            // 
            this.secs_heading_label.AutoSize = true;
            this.secs_heading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secs_heading_label.Location = new System.Drawing.Point(832, 219);
            this.secs_heading_label.Name = "secs_heading_label";
            this.secs_heading_label.Size = new System.Drawing.Size(90, 24);
            this.secs_heading_label.TabIndex = 55;
            this.secs_heading_label.Text = "Seconds:";
            // 
            // gauge1_label
            // 
            this.gauge1_label.AutoSize = true;
            this.gauge1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge1_label.Location = new System.Drawing.Point(100, 178);
            this.gauge1_label.Name = "gauge1_label";
            this.gauge1_label.Size = new System.Drawing.Size(44, 17);
            this.gauge1_label.TabIndex = 56;
            this.gauge1_label.Text = "0000";
            // 
            // gauge2_label
            // 
            this.gauge2_label.AutoSize = true;
            this.gauge2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge2_label.Location = new System.Drawing.Point(355, 178);
            this.gauge2_label.Name = "gauge2_label";
            this.gauge2_label.Size = new System.Drawing.Size(35, 17);
            this.gauge2_label.TabIndex = 57;
            this.gauge2_label.Text = "000";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(1000, 291);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // speed_label
            // 
            this.speed_label.AutoSize = true;
            this.speed_label.Location = new System.Drawing.Point(970, 271);
            this.speed_label.Name = "speed_label";
            this.speed_label.Size = new System.Drawing.Size(92, 13);
            this.speed_label.TabIndex = 50;
            this.speed_label.Text = "Simulation Speed:";
            // 
            // loggerNameLabel
            // 
            this.loggerNameLabel.AutoSize = true;
            this.loggerNameLabel.Location = new System.Drawing.Point(986, 8);
            this.loggerNameLabel.Name = "loggerNameLabel";
            this.loggerNameLabel.Size = new System.Drawing.Size(69, 13);
            this.loggerNameLabel.TabIndex = 41;
            this.loggerNameLabel.Text = "Logger name";
            // 
            // loggerNameTextBox
            // 
            this.loggerNameTextBox.Location = new System.Drawing.Point(986, 24);
            this.loggerNameTextBox.MaxLength = 50;
            this.loggerNameTextBox.Name = "loggerNameTextBox";
            this.loggerNameTextBox.Size = new System.Drawing.Size(80, 20);
            this.loggerNameTextBox.TabIndex = 0;
            this.loggerNameTextBox.TextChanged += new System.EventHandler(this.loggerNameTextBox_TextChanged);
            this.loggerNameTextBox.Leave += new System.EventHandler(this.loggerNameTextBox_Leave);
            // 
            // readLoggerTimer
            // 
            this.readLoggerTimer.Interval = 150;
            this.readLoggerTimer.Tick += new System.EventHandler(this.readLoggerTimer_Tick);
            // 
            // initLoggerTimer
            // 
            this.initLoggerTimer.Interval = 500;
            this.initLoggerTimer.Tick += new System.EventHandler(this.initLoggerTimer_Tick);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(20, 666);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(935, 40);
            this.logTextBox.TabIndex = 42;
            // 
            // toggleValueButton
            // 
            this.toggleValueButton.Location = new System.Drawing.Point(986, 426);
            this.toggleValueButton.Name = "toggleValueButton";
            this.toggleValueButton.Size = new System.Drawing.Size(80, 41);
            this.toggleValueButton.TabIndex = 3;
            this.toggleValueButton.Text = "Toggle Value vs. Voltage";
            this.toggleValueButton.UseVisualStyleBackColor = true;
            this.toggleValueButton.Click += new System.EventHandler(this.toggleVoltageButton_Click);
            // 
            // OnOffButton1
            // 
            this.OnOffButton1.Location = new System.Drawing.Point(12, 207);
            this.OnOffButton1.Margin = new System.Windows.Forms.Padding(2);
            this.OnOffButton1.Name = "OnOffButton1";
            this.OnOffButton1.Size = new System.Drawing.Size(112, 41);
            this.OnOffButton1.TabIndex = 47;
            this.OnOffButton1.TabStop = false;
            this.OnOffButton1.Text = "On/Off 1";
            this.OnOffButton1.UseVisualStyleBackColor = true;
            // 
            // OnOffButton2
            // 
            this.OnOffButton2.Location = new System.Drawing.Point(147, 207);
            this.OnOffButton2.Margin = new System.Windows.Forms.Padding(2);
            this.OnOffButton2.Name = "OnOffButton2";
            this.OnOffButton2.Size = new System.Drawing.Size(112, 41);
            this.OnOffButton2.TabIndex = 48;
            this.OnOffButton2.TabStop = false;
            this.OnOffButton2.Text = "On/Off 2";
            this.OnOffButton2.UseVisualStyleBackColor = true;
            // 
            // OnOffButton3
            // 
            this.OnOffButton3.Location = new System.Drawing.Point(282, 207);
            this.OnOffButton3.Margin = new System.Windows.Forms.Padding(2);
            this.OnOffButton3.Name = "OnOffButton3";
            this.OnOffButton3.Size = new System.Drawing.Size(112, 41);
            this.OnOffButton3.TabIndex = 49;
            this.OnOffButton3.TabStop = false;
            this.OnOffButton3.Text = "On/Off 3";
            this.OnOffButton3.UseVisualStyleBackColor = true;
            // 
            // OnOffButton4
            // 
            this.OnOffButton4.Location = new System.Drawing.Point(417, 207);
            this.OnOffButton4.Margin = new System.Windows.Forms.Padding(2);
            this.OnOffButton4.Name = "OnOffButton4";
            this.OnOffButton4.Size = new System.Drawing.Size(112, 41);
            this.OnOffButton4.TabIndex = 50;
            this.OnOffButton4.TabStop = false;
            this.OnOffButton4.Text = "On/Off 4";
            this.OnOffButton4.UseVisualStyleBackColor = true;
            // 
            // addGauge8
            // 
            this.addGauge8.BaseArcColor = System.Drawing.Color.Gray;
            this.addGauge8.BaseArcRadius = 65;
            this.addGauge8.BaseArcStart = 90;
            this.addGauge8.BaseArcSweep = -180;
            this.addGauge8.BaseArcWidth = 2;
            this.addGauge8.Cap_Idx = ((byte)(1));
            this.addGauge8.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.addGauge8.CapPosition = new System.Drawing.Point(1, 1);
            this.addGauge8.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(1, 1),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.addGauge8.CapsText = new string[] {
        "",
        "Add8",
        "",
        "",
        ""};
            this.addGauge8.CapText = "Add8";
            this.addGauge8.Center = new System.Drawing.Point(10, 75);
            this.addGauge8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGauge8.Location = new System.Drawing.Point(879, 525);
            this.addGauge8.MaxValue = 100F;
            this.addGauge8.MinValue = 0F;
            this.addGauge8.Name = "addGauge8";
            this.addGauge8.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Blue;
            this.addGauge8.NeedleColor2 = System.Drawing.Color.MediumBlue;
            this.addGauge8.NeedleRadius = 60;
            this.addGauge8.NeedleType = 0;
            this.addGauge8.NeedleWidth = 2;
            this.addGauge8.Range_Idx = ((byte)(0));
            this.addGauge8.RangeColor = System.Drawing.Color.LightGreen;
            this.addGauge8.RangeEnabled = false;
            this.addGauge8.RangeEndValue = 100F;
            this.addGauge8.RangeInnerRadius = 50;
            this.addGauge8.RangeOuterRadius = 60;
            this.addGauge8.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.addGauge8.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.addGauge8.RangesEndValue = new float[] {
        100F,
        400F,
        0F,
        0F,
        0F};
            this.addGauge8.RangesInnerRadius = new int[] {
        50,
        70,
        70,
        70,
        70};
            this.addGauge8.RangesOuterRadius = new int[] {
        60,
        80,
        80,
        80,
        80};
            this.addGauge8.RangesStartValue = new float[] {
        0F,
        300F,
        0F,
        0F,
        0F};
            this.addGauge8.RangeStartValue = 0F;
            this.addGauge8.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.addGauge8.ScaleLinesInterInnerRadius = 53;
            this.addGauge8.ScaleLinesInterOuterRadius = 70;
            this.addGauge8.ScaleLinesInterWidth = 1;
            this.addGauge8.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.addGauge8.ScaleLinesMajorInnerRadius = 50;
            this.addGauge8.ScaleLinesMajorOuterRadius = 60;
            this.addGauge8.ScaleLinesMajorStepValue = 25F;
            this.addGauge8.ScaleLinesMajorWidth = 2;
            this.addGauge8.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.addGauge8.ScaleLinesMinorInnerRadius = 53;
            this.addGauge8.ScaleLinesMinorNumOf = 4;
            this.addGauge8.ScaleLinesMinorOuterRadius = 60;
            this.addGauge8.ScaleLinesMinorWidth = 1;
            this.addGauge8.ScaleNumbersColor = System.Drawing.Color.Black;
            this.addGauge8.ScaleNumbersFormat = null;
            this.addGauge8.ScaleNumbersRadius = 40;
            this.addGauge8.ScaleNumbersRotation = 0;
            this.addGauge8.ScaleNumbersStartScaleLine = 0;
            this.addGauge8.ScaleNumbersStepScaleLines = 1;
            this.addGauge8.Size = new System.Drawing.Size(94, 140);
            this.addGauge8.TabIndex = 34;
            this.addGauge8.TabStop = false;
            this.addGauge8.Text = "addGauge8";
            this.addGauge8.Value = 0F;
            // 
            // addGauge7
            // 
            this.addGauge7.BaseArcColor = System.Drawing.Color.Gray;
            this.addGauge7.BaseArcRadius = 65;
            this.addGauge7.BaseArcStart = 90;
            this.addGauge7.BaseArcSweep = 180;
            this.addGauge7.BaseArcWidth = 2;
            this.addGauge7.Cap_Idx = ((byte)(1));
            this.addGauge7.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.addGauge7.CapPosition = new System.Drawing.Point(1, 1);
            this.addGauge7.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(1, 1),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.addGauge7.CapsText = new string[] {
        "",
        "Add7",
        "",
        "",
        ""};
            this.addGauge7.CapText = "Add7";
            this.addGauge7.Center = new System.Drawing.Point(85, 75);
            this.addGauge7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGauge7.Location = new System.Drawing.Point(756, 525);
            this.addGauge7.MaxValue = 100F;
            this.addGauge7.MinValue = 0F;
            this.addGauge7.Name = "addGauge7";
            this.addGauge7.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Blue;
            this.addGauge7.NeedleColor2 = System.Drawing.Color.MediumBlue;
            this.addGauge7.NeedleRadius = 60;
            this.addGauge7.NeedleType = 0;
            this.addGauge7.NeedleWidth = 2;
            this.addGauge7.Range_Idx = ((byte)(0));
            this.addGauge7.RangeColor = System.Drawing.Color.LightGreen;
            this.addGauge7.RangeEnabled = false;
            this.addGauge7.RangeEndValue = 100F;
            this.addGauge7.RangeInnerRadius = 50;
            this.addGauge7.RangeOuterRadius = 60;
            this.addGauge7.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.addGauge7.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.addGauge7.RangesEndValue = new float[] {
        100F,
        400F,
        0F,
        0F,
        0F};
            this.addGauge7.RangesInnerRadius = new int[] {
        50,
        70,
        70,
        70,
        70};
            this.addGauge7.RangesOuterRadius = new int[] {
        60,
        80,
        80,
        80,
        80};
            this.addGauge7.RangesStartValue = new float[] {
        0F,
        300F,
        0F,
        0F,
        0F};
            this.addGauge7.RangeStartValue = 0F;
            this.addGauge7.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.addGauge7.ScaleLinesInterInnerRadius = 53;
            this.addGauge7.ScaleLinesInterOuterRadius = 70;
            this.addGauge7.ScaleLinesInterWidth = 1;
            this.addGauge7.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.addGauge7.ScaleLinesMajorInnerRadius = 50;
            this.addGauge7.ScaleLinesMajorOuterRadius = 60;
            this.addGauge7.ScaleLinesMajorStepValue = 25F;
            this.addGauge7.ScaleLinesMajorWidth = 2;
            this.addGauge7.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.addGauge7.ScaleLinesMinorInnerRadius = 53;
            this.addGauge7.ScaleLinesMinorNumOf = 4;
            this.addGauge7.ScaleLinesMinorOuterRadius = 60;
            this.addGauge7.ScaleLinesMinorWidth = 1;
            this.addGauge7.ScaleNumbersColor = System.Drawing.Color.Black;
            this.addGauge7.ScaleNumbersFormat = null;
            this.addGauge7.ScaleNumbersRadius = 40;
            this.addGauge7.ScaleNumbersRotation = 0;
            this.addGauge7.ScaleNumbersStartScaleLine = 0;
            this.addGauge7.ScaleNumbersStepScaleLines = 1;
            this.addGauge7.Size = new System.Drawing.Size(94, 140);
            this.addGauge7.TabIndex = 33;
            this.addGauge7.TabStop = false;
            this.addGauge7.Text = "addGauge7";
            this.addGauge7.Value = 0F;
            // 
            // addGauge6
            // 
            this.addGauge6.BaseArcColor = System.Drawing.Color.Gray;
            this.addGauge6.BaseArcRadius = 65;
            this.addGauge6.BaseArcStart = 90;
            this.addGauge6.BaseArcSweep = -180;
            this.addGauge6.BaseArcWidth = 2;
            this.addGauge6.Cap_Idx = ((byte)(1));
            this.addGauge6.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.addGauge6.CapPosition = new System.Drawing.Point(1, 1);
            this.addGauge6.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(1, 1),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.addGauge6.CapsText = new string[] {
        "",
        "Add6",
        "",
        "",
        ""};
            this.addGauge6.CapText = "Add6";
            this.addGauge6.Center = new System.Drawing.Point(10, 75);
            this.addGauge6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGauge6.Location = new System.Drawing.Point(633, 525);
            this.addGauge6.MaxValue = 100F;
            this.addGauge6.MinValue = 0F;
            this.addGauge6.Name = "addGauge6";
            this.addGauge6.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Blue;
            this.addGauge6.NeedleColor2 = System.Drawing.Color.MediumBlue;
            this.addGauge6.NeedleRadius = 60;
            this.addGauge6.NeedleType = 0;
            this.addGauge6.NeedleWidth = 2;
            this.addGauge6.Range_Idx = ((byte)(0));
            this.addGauge6.RangeColor = System.Drawing.Color.LightGreen;
            this.addGauge6.RangeEnabled = false;
            this.addGauge6.RangeEndValue = 100F;
            this.addGauge6.RangeInnerRadius = 50;
            this.addGauge6.RangeOuterRadius = 60;
            this.addGauge6.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.addGauge6.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.addGauge6.RangesEndValue = new float[] {
        100F,
        400F,
        0F,
        0F,
        0F};
            this.addGauge6.RangesInnerRadius = new int[] {
        50,
        70,
        70,
        70,
        70};
            this.addGauge6.RangesOuterRadius = new int[] {
        60,
        80,
        80,
        80,
        80};
            this.addGauge6.RangesStartValue = new float[] {
        0F,
        300F,
        0F,
        0F,
        0F};
            this.addGauge6.RangeStartValue = 0F;
            this.addGauge6.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.addGauge6.ScaleLinesInterInnerRadius = 53;
            this.addGauge6.ScaleLinesInterOuterRadius = 70;
            this.addGauge6.ScaleLinesInterWidth = 1;
            this.addGauge6.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.addGauge6.ScaleLinesMajorInnerRadius = 50;
            this.addGauge6.ScaleLinesMajorOuterRadius = 60;
            this.addGauge6.ScaleLinesMajorStepValue = 25F;
            this.addGauge6.ScaleLinesMajorWidth = 2;
            this.addGauge6.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.addGauge6.ScaleLinesMinorInnerRadius = 53;
            this.addGauge6.ScaleLinesMinorNumOf = 4;
            this.addGauge6.ScaleLinesMinorOuterRadius = 60;
            this.addGauge6.ScaleLinesMinorWidth = 1;
            this.addGauge6.ScaleNumbersColor = System.Drawing.Color.Black;
            this.addGauge6.ScaleNumbersFormat = null;
            this.addGauge6.ScaleNumbersRadius = 40;
            this.addGauge6.ScaleNumbersRotation = 0;
            this.addGauge6.ScaleNumbersStartScaleLine = 0;
            this.addGauge6.ScaleNumbersStepScaleLines = 1;
            this.addGauge6.Size = new System.Drawing.Size(94, 140);
            this.addGauge6.TabIndex = 32;
            this.addGauge6.TabStop = false;
            this.addGauge6.Text = "addGauge6";
            this.addGauge6.Value = 0F;
            // 
            // addGauge5
            // 
            this.addGauge5.BaseArcColor = System.Drawing.Color.Gray;
            this.addGauge5.BaseArcRadius = 65;
            this.addGauge5.BaseArcStart = 90;
            this.addGauge5.BaseArcSweep = 180;
            this.addGauge5.BaseArcWidth = 2;
            this.addGauge5.Cap_Idx = ((byte)(1));
            this.addGauge5.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.addGauge5.CapPosition = new System.Drawing.Point(1, 1);
            this.addGauge5.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(1, 1),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.addGauge5.CapsText = new string[] {
        "",
        "Add5",
        "",
        "",
        ""};
            this.addGauge5.CapText = "Add5";
            this.addGauge5.Center = new System.Drawing.Point(85, 75);
            this.addGauge5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGauge5.Location = new System.Drawing.Point(510, 525);
            this.addGauge5.MaxValue = 100F;
            this.addGauge5.MinValue = 0F;
            this.addGauge5.Name = "addGauge5";
            this.addGauge5.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Blue;
            this.addGauge5.NeedleColor2 = System.Drawing.Color.MediumBlue;
            this.addGauge5.NeedleRadius = 60;
            this.addGauge5.NeedleType = 0;
            this.addGauge5.NeedleWidth = 2;
            this.addGauge5.Range_Idx = ((byte)(0));
            this.addGauge5.RangeColor = System.Drawing.Color.LightGreen;
            this.addGauge5.RangeEnabled = false;
            this.addGauge5.RangeEndValue = 100F;
            this.addGauge5.RangeInnerRadius = 50;
            this.addGauge5.RangeOuterRadius = 60;
            this.addGauge5.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.addGauge5.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.addGauge5.RangesEndValue = new float[] {
        100F,
        400F,
        0F,
        0F,
        0F};
            this.addGauge5.RangesInnerRadius = new int[] {
        50,
        70,
        70,
        70,
        70};
            this.addGauge5.RangesOuterRadius = new int[] {
        60,
        80,
        80,
        80,
        80};
            this.addGauge5.RangesStartValue = new float[] {
        0F,
        300F,
        0F,
        0F,
        0F};
            this.addGauge5.RangeStartValue = 0F;
            this.addGauge5.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.addGauge5.ScaleLinesInterInnerRadius = 53;
            this.addGauge5.ScaleLinesInterOuterRadius = 70;
            this.addGauge5.ScaleLinesInterWidth = 1;
            this.addGauge5.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.addGauge5.ScaleLinesMajorInnerRadius = 50;
            this.addGauge5.ScaleLinesMajorOuterRadius = 60;
            this.addGauge5.ScaleLinesMajorStepValue = 25F;
            this.addGauge5.ScaleLinesMajorWidth = 2;
            this.addGauge5.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.addGauge5.ScaleLinesMinorInnerRadius = 53;
            this.addGauge5.ScaleLinesMinorNumOf = 4;
            this.addGauge5.ScaleLinesMinorOuterRadius = 60;
            this.addGauge5.ScaleLinesMinorWidth = 1;
            this.addGauge5.ScaleNumbersColor = System.Drawing.Color.Black;
            this.addGauge5.ScaleNumbersFormat = null;
            this.addGauge5.ScaleNumbersRadius = 40;
            this.addGauge5.ScaleNumbersRotation = 0;
            this.addGauge5.ScaleNumbersStartScaleLine = 0;
            this.addGauge5.ScaleNumbersStepScaleLines = 1;
            this.addGauge5.Size = new System.Drawing.Size(94, 140);
            this.addGauge5.TabIndex = 31;
            this.addGauge5.TabStop = false;
            this.addGauge5.Text = "addGauge5";
            this.addGauge5.Value = 0F;
            // 
            // addGauge4
            // 
            this.addGauge4.BaseArcColor = System.Drawing.Color.Gray;
            this.addGauge4.BaseArcRadius = 65;
            this.addGauge4.BaseArcStart = 90;
            this.addGauge4.BaseArcSweep = -180;
            this.addGauge4.BaseArcWidth = 2;
            this.addGauge4.Cap_Idx = ((byte)(1));
            this.addGauge4.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.addGauge4.CapPosition = new System.Drawing.Point(1, 1);
            this.addGauge4.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(1, 1),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.addGauge4.CapsText = new string[] {
        "",
        "Add4",
        "",
        "",
        ""};
            this.addGauge4.CapText = "Add4";
            this.addGauge4.Center = new System.Drawing.Point(15, 75);
            this.addGauge4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGauge4.Location = new System.Drawing.Point(382, 525);
            this.addGauge4.MaxValue = 100F;
            this.addGauge4.MinValue = 0F;
            this.addGauge4.Name = "addGauge4";
            this.addGauge4.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Blue;
            this.addGauge4.NeedleColor2 = System.Drawing.Color.MediumBlue;
            this.addGauge4.NeedleRadius = 60;
            this.addGauge4.NeedleType = 0;
            this.addGauge4.NeedleWidth = 2;
            this.addGauge4.Range_Idx = ((byte)(0));
            this.addGauge4.RangeColor = System.Drawing.Color.LightGreen;
            this.addGauge4.RangeEnabled = false;
            this.addGauge4.RangeEndValue = 100F;
            this.addGauge4.RangeInnerRadius = 50;
            this.addGauge4.RangeOuterRadius = 60;
            this.addGauge4.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.addGauge4.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.addGauge4.RangesEndValue = new float[] {
        100F,
        400F,
        0F,
        0F,
        0F};
            this.addGauge4.RangesInnerRadius = new int[] {
        50,
        70,
        70,
        70,
        70};
            this.addGauge4.RangesOuterRadius = new int[] {
        60,
        80,
        80,
        80,
        80};
            this.addGauge4.RangesStartValue = new float[] {
        0F,
        300F,
        0F,
        0F,
        0F};
            this.addGauge4.RangeStartValue = 0F;
            this.addGauge4.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.addGauge4.ScaleLinesInterInnerRadius = 53;
            this.addGauge4.ScaleLinesInterOuterRadius = 70;
            this.addGauge4.ScaleLinesInterWidth = 1;
            this.addGauge4.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.addGauge4.ScaleLinesMajorInnerRadius = 50;
            this.addGauge4.ScaleLinesMajorOuterRadius = 60;
            this.addGauge4.ScaleLinesMajorStepValue = 25F;
            this.addGauge4.ScaleLinesMajorWidth = 2;
            this.addGauge4.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.addGauge4.ScaleLinesMinorInnerRadius = 53;
            this.addGauge4.ScaleLinesMinorNumOf = 4;
            this.addGauge4.ScaleLinesMinorOuterRadius = 60;
            this.addGauge4.ScaleLinesMinorWidth = 1;
            this.addGauge4.ScaleNumbersColor = System.Drawing.Color.Black;
            this.addGauge4.ScaleNumbersFormat = null;
            this.addGauge4.ScaleNumbersRadius = 42;
            this.addGauge4.ScaleNumbersRotation = 0;
            this.addGauge4.ScaleNumbersStartScaleLine = 0;
            this.addGauge4.ScaleNumbersStepScaleLines = 1;
            this.addGauge4.Size = new System.Drawing.Size(100, 140);
            this.addGauge4.TabIndex = 30;
            this.addGauge4.TabStop = false;
            this.addGauge4.Text = "addGauge4";
            this.addGauge4.Value = 0F;
            // 
            // addGauge3
            // 
            this.addGauge3.BaseArcColor = System.Drawing.Color.Gray;
            this.addGauge3.BaseArcRadius = 65;
            this.addGauge3.BaseArcStart = 90;
            this.addGauge3.BaseArcSweep = 180;
            this.addGauge3.BaseArcWidth = 2;
            this.addGauge3.Cap_Idx = ((byte)(1));
            this.addGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.addGauge3.CapPosition = new System.Drawing.Point(1, 1);
            this.addGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(1, 1),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.addGauge3.CapsText = new string[] {
        "",
        "Add3",
        "",
        "",
        ""};
            this.addGauge3.CapText = "Add3";
            this.addGauge3.Center = new System.Drawing.Point(80, 75);
            this.addGauge3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGauge3.Location = new System.Drawing.Point(264, 525);
            this.addGauge3.MaxValue = 100F;
            this.addGauge3.MinValue = 0F;
            this.addGauge3.Name = "addGauge3";
            this.addGauge3.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Blue;
            this.addGauge3.NeedleColor2 = System.Drawing.Color.MediumBlue;
            this.addGauge3.NeedleRadius = 60;
            this.addGauge3.NeedleType = 0;
            this.addGauge3.NeedleWidth = 2;
            this.addGauge3.Range_Idx = ((byte)(0));
            this.addGauge3.RangeColor = System.Drawing.Color.LightGreen;
            this.addGauge3.RangeEnabled = false;
            this.addGauge3.RangeEndValue = 100F;
            this.addGauge3.RangeInnerRadius = 50;
            this.addGauge3.RangeOuterRadius = 60;
            this.addGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.addGauge3.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.addGauge3.RangesEndValue = new float[] {
        100F,
        400F,
        0F,
        0F,
        0F};
            this.addGauge3.RangesInnerRadius = new int[] {
        50,
        70,
        70,
        70,
        70};
            this.addGauge3.RangesOuterRadius = new int[] {
        60,
        80,
        80,
        80,
        80};
            this.addGauge3.RangesStartValue = new float[] {
        0F,
        300F,
        0F,
        0F,
        0F};
            this.addGauge3.RangeStartValue = 0F;
            this.addGauge3.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.addGauge3.ScaleLinesInterInnerRadius = 53;
            this.addGauge3.ScaleLinesInterOuterRadius = 70;
            this.addGauge3.ScaleLinesInterWidth = 1;
            this.addGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.addGauge3.ScaleLinesMajorInnerRadius = 50;
            this.addGauge3.ScaleLinesMajorOuterRadius = 60;
            this.addGauge3.ScaleLinesMajorStepValue = 25F;
            this.addGauge3.ScaleLinesMajorWidth = 2;
            this.addGauge3.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.addGauge3.ScaleLinesMinorInnerRadius = 53;
            this.addGauge3.ScaleLinesMinorNumOf = 4;
            this.addGauge3.ScaleLinesMinorOuterRadius = 60;
            this.addGauge3.ScaleLinesMinorWidth = 1;
            this.addGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.addGauge3.ScaleNumbersFormat = null;
            this.addGauge3.ScaleNumbersRadius = 42;
            this.addGauge3.ScaleNumbersRotation = 0;
            this.addGauge3.ScaleNumbersStartScaleLine = 0;
            this.addGauge3.ScaleNumbersStepScaleLines = 1;
            this.addGauge3.Size = new System.Drawing.Size(100, 140);
            this.addGauge3.TabIndex = 29;
            this.addGauge3.TabStop = false;
            this.addGauge3.Text = "addGauge3";
            this.addGauge3.Value = 0F;
            // 
            // addGauge2
            // 
            this.addGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.addGauge2.BaseArcRadius = 65;
            this.addGauge2.BaseArcStart = 90;
            this.addGauge2.BaseArcSweep = -180;
            this.addGauge2.BaseArcWidth = 2;
            this.addGauge2.Cap_Idx = ((byte)(1));
            this.addGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.addGauge2.CapPosition = new System.Drawing.Point(1, 1);
            this.addGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(1, 1),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.addGauge2.CapsText = new string[] {
        "",
        "Add2",
        "",
        "",
        ""};
            this.addGauge2.CapText = "Add2";
            this.addGauge2.Center = new System.Drawing.Point(10, 75);
            this.addGauge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGauge2.Location = new System.Drawing.Point(141, 525);
            this.addGauge2.MaxValue = 100F;
            this.addGauge2.MinValue = 0F;
            this.addGauge2.Name = "addGauge2";
            this.addGauge2.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Blue;
            this.addGauge2.NeedleColor2 = System.Drawing.Color.MediumBlue;
            this.addGauge2.NeedleRadius = 60;
            this.addGauge2.NeedleType = 0;
            this.addGauge2.NeedleWidth = 2;
            this.addGauge2.Range_Idx = ((byte)(0));
            this.addGauge2.RangeColor = System.Drawing.Color.LightGreen;
            this.addGauge2.RangeEnabled = false;
            this.addGauge2.RangeEndValue = 100F;
            this.addGauge2.RangeInnerRadius = 50;
            this.addGauge2.RangeOuterRadius = 60;
            this.addGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.addGauge2.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.addGauge2.RangesEndValue = new float[] {
        100F,
        400F,
        0F,
        0F,
        0F};
            this.addGauge2.RangesInnerRadius = new int[] {
        50,
        70,
        70,
        70,
        70};
            this.addGauge2.RangesOuterRadius = new int[] {
        60,
        80,
        80,
        80,
        80};
            this.addGauge2.RangesStartValue = new float[] {
        0F,
        300F,
        0F,
        0F,
        0F};
            this.addGauge2.RangeStartValue = 0F;
            this.addGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.addGauge2.ScaleLinesInterInnerRadius = 53;
            this.addGauge2.ScaleLinesInterOuterRadius = 70;
            this.addGauge2.ScaleLinesInterWidth = 1;
            this.addGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.addGauge2.ScaleLinesMajorInnerRadius = 50;
            this.addGauge2.ScaleLinesMajorOuterRadius = 60;
            this.addGauge2.ScaleLinesMajorStepValue = 25F;
            this.addGauge2.ScaleLinesMajorWidth = 2;
            this.addGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.addGauge2.ScaleLinesMinorInnerRadius = 53;
            this.addGauge2.ScaleLinesMinorNumOf = 4;
            this.addGauge2.ScaleLinesMinorOuterRadius = 60;
            this.addGauge2.ScaleLinesMinorWidth = 1;
            this.addGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.addGauge2.ScaleNumbersFormat = null;
            this.addGauge2.ScaleNumbersRadius = 40;
            this.addGauge2.ScaleNumbersRotation = 0;
            this.addGauge2.ScaleNumbersStartScaleLine = 0;
            this.addGauge2.ScaleNumbersStepScaleLines = 1;
            this.addGauge2.Size = new System.Drawing.Size(94, 140);
            this.addGauge2.TabIndex = 28;
            this.addGauge2.TabStop = false;
            this.addGauge2.Text = "addGauge2";
            this.addGauge2.Value = 0F;
            // 
            // addGauge1
            // 
            this.addGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.addGauge1.BaseArcRadius = 65;
            this.addGauge1.BaseArcStart = 90;
            this.addGauge1.BaseArcSweep = 180;
            this.addGauge1.BaseArcWidth = 2;
            this.addGauge1.Cap_Idx = ((byte)(1));
            this.addGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.addGauge1.CapPosition = new System.Drawing.Point(1, 1);
            this.addGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(1, 1),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.addGauge1.CapsText = new string[] {
        "",
        "Add1",
        "",
        "",
        ""};
            this.addGauge1.CapText = "Add1";
            this.addGauge1.Center = new System.Drawing.Point(85, 75);
            this.addGauge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGauge1.Location = new System.Drawing.Point(18, 525);
            this.addGauge1.MaxValue = 100F;
            this.addGauge1.MinValue = 0F;
            this.addGauge1.Name = "addGauge1";
            this.addGauge1.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Blue;
            this.addGauge1.NeedleColor2 = System.Drawing.Color.MediumBlue;
            this.addGauge1.NeedleRadius = 60;
            this.addGauge1.NeedleType = 0;
            this.addGauge1.NeedleWidth = 2;
            this.addGauge1.Range_Idx = ((byte)(0));
            this.addGauge1.RangeColor = System.Drawing.Color.LightGreen;
            this.addGauge1.RangeEnabled = false;
            this.addGauge1.RangeEndValue = 100F;
            this.addGauge1.RangeInnerRadius = 50;
            this.addGauge1.RangeOuterRadius = 60;
            this.addGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.addGauge1.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.addGauge1.RangesEndValue = new float[] {
        100F,
        400F,
        0F,
        0F,
        0F};
            this.addGauge1.RangesInnerRadius = new int[] {
        50,
        70,
        70,
        70,
        70};
            this.addGauge1.RangesOuterRadius = new int[] {
        60,
        80,
        80,
        80,
        80};
            this.addGauge1.RangesStartValue = new float[] {
        0F,
        300F,
        0F,
        0F,
        0F};
            this.addGauge1.RangeStartValue = 0F;
            this.addGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.addGauge1.ScaleLinesInterInnerRadius = 53;
            this.addGauge1.ScaleLinesInterOuterRadius = 70;
            this.addGauge1.ScaleLinesInterWidth = 1;
            this.addGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.addGauge1.ScaleLinesMajorInnerRadius = 50;
            this.addGauge1.ScaleLinesMajorOuterRadius = 60;
            this.addGauge1.ScaleLinesMajorStepValue = 25F;
            this.addGauge1.ScaleLinesMajorWidth = 2;
            this.addGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.addGauge1.ScaleLinesMinorInnerRadius = 53;
            this.addGauge1.ScaleLinesMinorNumOf = 4;
            this.addGauge1.ScaleLinesMinorOuterRadius = 60;
            this.addGauge1.ScaleLinesMinorWidth = 1;
            this.addGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.addGauge1.ScaleNumbersFormat = null;
            this.addGauge1.ScaleNumbersRadius = 40;
            this.addGauge1.ScaleNumbersRotation = 0;
            this.addGauge1.ScaleNumbersStartScaleLine = 0;
            this.addGauge1.ScaleNumbersStepScaleLines = 1;
            this.addGauge1.Size = new System.Drawing.Size(94, 140);
            this.addGauge1.TabIndex = 27;
            this.addGauge1.TabStop = false;
            this.addGauge1.Text = "aGauge13";
            this.addGauge1.Value = 0F;
            // 
            // analogGauge8
            // 
            this.analogGauge8.BaseArcColor = System.Drawing.Color.Gray;
            this.analogGauge8.BaseArcRadius = 105;
            this.analogGauge8.BaseArcStart = 180;
            this.analogGauge8.BaseArcSweep = 120;
            this.analogGauge8.BaseArcWidth = 2;
            this.analogGauge8.Cap_Idx = ((byte)(1));
            this.analogGauge8.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.analogGauge8.CapPosition = new System.Drawing.Point(20, 110);
            this.analogGauge8.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(20, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.analogGauge8.CapsText = new string[] {
        "",
        "Exh. Temp 8",
        "",
        "",
        ""};
            this.analogGauge8.CapText = "Exh. Temp 8";
            this.analogGauge8.Center = new System.Drawing.Point(110, 110);
            this.analogGauge8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogGauge8.Location = new System.Drawing.Point(780, 262);
            this.analogGauge8.MaxValue = 1000F;
            this.analogGauge8.MinValue = 0F;
            this.analogGauge8.Name = "analogGauge8";
            this.analogGauge8.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
            this.analogGauge8.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.analogGauge8.NeedleRadius = 95;
            this.analogGauge8.NeedleType = 0;
            this.analogGauge8.NeedleWidth = 2;
            this.analogGauge8.Range_Idx = ((byte)(2));
            this.analogGauge8.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.analogGauge8.RangeEnabled = true;
            this.analogGauge8.RangeEndValue = 1000F;
            this.analogGauge8.RangeInnerRadius = 75;
            this.analogGauge8.RangeOuterRadius = 85;
            this.analogGauge8.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.PaleTurquoise,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control};
            this.analogGauge8.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.analogGauge8.RangesEndValue = new float[] {
        250F,
        800F,
        1000F,
        1000F,
        0F};
            this.analogGauge8.RangesInnerRadius = new int[] {
        75,
        75,
        75,
        70,
        70};
            this.analogGauge8.RangesOuterRadius = new int[] {
        85,
        85,
        85,
        80,
        80};
            this.analogGauge8.RangesStartValue = new float[] {
        0F,
        251F,
        800F,
        800F,
        0F};
            this.analogGauge8.RangeStartValue = 800F;
            this.analogGauge8.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.analogGauge8.ScaleLinesInterInnerRadius = 75;
            this.analogGauge8.ScaleLinesInterOuterRadius = 82;
            this.analogGauge8.ScaleLinesInterWidth = 1;
            this.analogGauge8.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.analogGauge8.ScaleLinesMajorInnerRadius = 75;
            this.analogGauge8.ScaleLinesMajorOuterRadius = 85;
            this.analogGauge8.ScaleLinesMajorStepValue = 200F;
            this.analogGauge8.ScaleLinesMajorWidth = 2;
            this.analogGauge8.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.analogGauge8.ScaleLinesMinorInnerRadius = 75;
            this.analogGauge8.ScaleLinesMinorNumOf = 7;
            this.analogGauge8.ScaleLinesMinorOuterRadius = 80;
            this.analogGauge8.ScaleLinesMinorWidth = 1;
            this.analogGauge8.ScaleNumbersColor = System.Drawing.Color.Black;
            this.analogGauge8.ScaleNumbersFormat = null;
            this.analogGauge8.ScaleNumbersRadius = 95;
            this.analogGauge8.ScaleNumbersRotation = 90;
            this.analogGauge8.ScaleNumbersStartScaleLine = 0;
            this.analogGauge8.ScaleNumbersStepScaleLines = 1;
            this.analogGauge8.Size = new System.Drawing.Size(175, 124);
            this.analogGauge8.TabIndex = 26;
            this.analogGauge8.TabStop = false;
            this.analogGauge8.Text = "aGauge12";
            this.analogGauge8.Value = 0F;
            // 
            // analogGauge7
            // 
            this.analogGauge7.BaseArcColor = System.Drawing.Color.Gray;
            this.analogGauge7.BaseArcRadius = 105;
            this.analogGauge7.BaseArcStart = 180;
            this.analogGauge7.BaseArcSweep = 120;
            this.analogGauge7.BaseArcWidth = 2;
            this.analogGauge7.Cap_Idx = ((byte)(1));
            this.analogGauge7.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.analogGauge7.CapPosition = new System.Drawing.Point(20, 110);
            this.analogGauge7.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(20, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.analogGauge7.CapsText = new string[] {
        "",
        "Exh. Temp 7",
        "",
        "",
        ""};
            this.analogGauge7.CapText = "Exh. Temp 7";
            this.analogGauge7.Center = new System.Drawing.Point(110, 110);
            this.analogGauge7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogGauge7.Location = new System.Drawing.Point(680, 392);
            this.analogGauge7.MaxValue = 1000F;
            this.analogGauge7.MinValue = 0F;
            this.analogGauge7.Name = "analogGauge7";
            this.analogGauge7.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
            this.analogGauge7.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.analogGauge7.NeedleRadius = 95;
            this.analogGauge7.NeedleType = 0;
            this.analogGauge7.NeedleWidth = 2;
            this.analogGauge7.Range_Idx = ((byte)(2));
            this.analogGauge7.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.analogGauge7.RangeEnabled = true;
            this.analogGauge7.RangeEndValue = 1000F;
            this.analogGauge7.RangeInnerRadius = 75;
            this.analogGauge7.RangeOuterRadius = 85;
            this.analogGauge7.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.PaleTurquoise,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control};
            this.analogGauge7.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.analogGauge7.RangesEndValue = new float[] {
        250F,
        800F,
        1000F,
        1000F,
        0F};
            this.analogGauge7.RangesInnerRadius = new int[] {
        75,
        75,
        75,
        70,
        70};
            this.analogGauge7.RangesOuterRadius = new int[] {
        85,
        85,
        85,
        80,
        80};
            this.analogGauge7.RangesStartValue = new float[] {
        0F,
        251F,
        800F,
        800F,
        0F};
            this.analogGauge7.RangeStartValue = 800F;
            this.analogGauge7.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.analogGauge7.ScaleLinesInterInnerRadius = 75;
            this.analogGauge7.ScaleLinesInterOuterRadius = 82;
            this.analogGauge7.ScaleLinesInterWidth = 1;
            this.analogGauge7.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.analogGauge7.ScaleLinesMajorInnerRadius = 75;
            this.analogGauge7.ScaleLinesMajorOuterRadius = 85;
            this.analogGauge7.ScaleLinesMajorStepValue = 200F;
            this.analogGauge7.ScaleLinesMajorWidth = 2;
            this.analogGauge7.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.analogGauge7.ScaleLinesMinorInnerRadius = 75;
            this.analogGauge7.ScaleLinesMinorNumOf = 7;
            this.analogGauge7.ScaleLinesMinorOuterRadius = 80;
            this.analogGauge7.ScaleLinesMinorWidth = 1;
            this.analogGauge7.ScaleNumbersColor = System.Drawing.Color.Black;
            this.analogGauge7.ScaleNumbersFormat = null;
            this.analogGauge7.ScaleNumbersRadius = 95;
            this.analogGauge7.ScaleNumbersRotation = 90;
            this.analogGauge7.ScaleNumbersStartScaleLine = 0;
            this.analogGauge7.ScaleNumbersStepScaleLines = 1;
            this.analogGauge7.Size = new System.Drawing.Size(175, 124);
            this.analogGauge7.TabIndex = 25;
            this.analogGauge7.TabStop = false;
            this.analogGauge7.Text = "aGauge11";
            this.analogGauge7.Value = 0F;
            // 
            // analogGauge6
            // 
            this.analogGauge6.BaseArcColor = System.Drawing.Color.Gray;
            this.analogGauge6.BaseArcRadius = 105;
            this.analogGauge6.BaseArcStart = 180;
            this.analogGauge6.BaseArcSweep = 120;
            this.analogGauge6.BaseArcWidth = 2;
            this.analogGauge6.Cap_Idx = ((byte)(1));
            this.analogGauge6.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.analogGauge6.CapPosition = new System.Drawing.Point(20, 110);
            this.analogGauge6.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(20, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.analogGauge6.CapsText = new string[] {
        "",
        "Exh. Temp 6",
        "",
        "",
        ""};
            this.analogGauge6.CapText = "Exh. Temp 6";
            this.analogGauge6.Center = new System.Drawing.Point(110, 110);
            this.analogGauge6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogGauge6.Location = new System.Drawing.Point(560, 262);
            this.analogGauge6.MaxValue = 1000F;
            this.analogGauge6.MinValue = 0F;
            this.analogGauge6.Name = "analogGauge6";
            this.analogGauge6.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
            this.analogGauge6.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.analogGauge6.NeedleRadius = 95;
            this.analogGauge6.NeedleType = 0;
            this.analogGauge6.NeedleWidth = 2;
            this.analogGauge6.Range_Idx = ((byte)(2));
            this.analogGauge6.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.analogGauge6.RangeEnabled = true;
            this.analogGauge6.RangeEndValue = 1000F;
            this.analogGauge6.RangeInnerRadius = 75;
            this.analogGauge6.RangeOuterRadius = 85;
            this.analogGauge6.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.PaleTurquoise,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control};
            this.analogGauge6.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.analogGauge6.RangesEndValue = new float[] {
        250F,
        800F,
        1000F,
        1000F,
        0F};
            this.analogGauge6.RangesInnerRadius = new int[] {
        75,
        75,
        75,
        70,
        70};
            this.analogGauge6.RangesOuterRadius = new int[] {
        85,
        85,
        85,
        80,
        80};
            this.analogGauge6.RangesStartValue = new float[] {
        0F,
        251F,
        800F,
        800F,
        0F};
            this.analogGauge6.RangeStartValue = 800F;
            this.analogGauge6.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.analogGauge6.ScaleLinesInterInnerRadius = 75;
            this.analogGauge6.ScaleLinesInterOuterRadius = 82;
            this.analogGauge6.ScaleLinesInterWidth = 1;
            this.analogGauge6.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.analogGauge6.ScaleLinesMajorInnerRadius = 75;
            this.analogGauge6.ScaleLinesMajorOuterRadius = 85;
            this.analogGauge6.ScaleLinesMajorStepValue = 200F;
            this.analogGauge6.ScaleLinesMajorWidth = 2;
            this.analogGauge6.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.analogGauge6.ScaleLinesMinorInnerRadius = 75;
            this.analogGauge6.ScaleLinesMinorNumOf = 7;
            this.analogGauge6.ScaleLinesMinorOuterRadius = 80;
            this.analogGauge6.ScaleLinesMinorWidth = 1;
            this.analogGauge6.ScaleNumbersColor = System.Drawing.Color.Black;
            this.analogGauge6.ScaleNumbersFormat = null;
            this.analogGauge6.ScaleNumbersRadius = 95;
            this.analogGauge6.ScaleNumbersRotation = 90;
            this.analogGauge6.ScaleNumbersStartScaleLine = 0;
            this.analogGauge6.ScaleNumbersStepScaleLines = 1;
            this.analogGauge6.Size = new System.Drawing.Size(175, 124);
            this.analogGauge6.TabIndex = 24;
            this.analogGauge6.TabStop = false;
            this.analogGauge6.Text = "aGauge10";
            this.analogGauge6.Value = 0F;
            // 
            // analogGauge5
            // 
            this.analogGauge5.BaseArcColor = System.Drawing.Color.Gray;
            this.analogGauge5.BaseArcRadius = 105;
            this.analogGauge5.BaseArcStart = 180;
            this.analogGauge5.BaseArcSweep = 120;
            this.analogGauge5.BaseArcWidth = 2;
            this.analogGauge5.Cap_Idx = ((byte)(1));
            this.analogGauge5.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.analogGauge5.CapPosition = new System.Drawing.Point(20, 110);
            this.analogGauge5.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(20, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.analogGauge5.CapsText = new string[] {
        "",
        "Exh. Temp 5",
        "",
        "",
        ""};
            this.analogGauge5.CapText = "Exh. Temp 5";
            this.analogGauge5.Center = new System.Drawing.Point(110, 110);
            this.analogGauge5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogGauge5.Location = new System.Drawing.Point(460, 392);
            this.analogGauge5.MaxValue = 1000F;
            this.analogGauge5.MinValue = 0F;
            this.analogGauge5.Name = "analogGauge5";
            this.analogGauge5.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
            this.analogGauge5.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.analogGauge5.NeedleRadius = 95;
            this.analogGauge5.NeedleType = 0;
            this.analogGauge5.NeedleWidth = 2;
            this.analogGauge5.Range_Idx = ((byte)(2));
            this.analogGauge5.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.analogGauge5.RangeEnabled = true;
            this.analogGauge5.RangeEndValue = 1000F;
            this.analogGauge5.RangeInnerRadius = 75;
            this.analogGauge5.RangeOuterRadius = 85;
            this.analogGauge5.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.PaleTurquoise,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control};
            this.analogGauge5.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.analogGauge5.RangesEndValue = new float[] {
        250F,
        800F,
        1000F,
        1000F,
        0F};
            this.analogGauge5.RangesInnerRadius = new int[] {
        75,
        75,
        75,
        70,
        70};
            this.analogGauge5.RangesOuterRadius = new int[] {
        85,
        85,
        85,
        80,
        80};
            this.analogGauge5.RangesStartValue = new float[] {
        0F,
        251F,
        800F,
        800F,
        0F};
            this.analogGauge5.RangeStartValue = 800F;
            this.analogGauge5.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.analogGauge5.ScaleLinesInterInnerRadius = 75;
            this.analogGauge5.ScaleLinesInterOuterRadius = 82;
            this.analogGauge5.ScaleLinesInterWidth = 1;
            this.analogGauge5.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.analogGauge5.ScaleLinesMajorInnerRadius = 75;
            this.analogGauge5.ScaleLinesMajorOuterRadius = 85;
            this.analogGauge5.ScaleLinesMajorStepValue = 200F;
            this.analogGauge5.ScaleLinesMajorWidth = 2;
            this.analogGauge5.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.analogGauge5.ScaleLinesMinorInnerRadius = 75;
            this.analogGauge5.ScaleLinesMinorNumOf = 7;
            this.analogGauge5.ScaleLinesMinorOuterRadius = 80;
            this.analogGauge5.ScaleLinesMinorWidth = 1;
            this.analogGauge5.ScaleNumbersColor = System.Drawing.Color.Black;
            this.analogGauge5.ScaleNumbersFormat = null;
            this.analogGauge5.ScaleNumbersRadius = 95;
            this.analogGauge5.ScaleNumbersRotation = 90;
            this.analogGauge5.ScaleNumbersStartScaleLine = 0;
            this.analogGauge5.ScaleNumbersStepScaleLines = 1;
            this.analogGauge5.Size = new System.Drawing.Size(175, 124);
            this.analogGauge5.TabIndex = 23;
            this.analogGauge5.TabStop = false;
            this.analogGauge5.Text = "aGauge9";
            this.analogGauge5.Value = 0F;
            // 
            // analogGauge4
            // 
            this.analogGauge4.BaseArcColor = System.Drawing.Color.Gray;
            this.analogGauge4.BaseArcRadius = 105;
            this.analogGauge4.BaseArcStart = 180;
            this.analogGauge4.BaseArcSweep = 120;
            this.analogGauge4.BaseArcWidth = 2;
            this.analogGauge4.Cap_Idx = ((byte)(1));
            this.analogGauge4.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.analogGauge4.CapPosition = new System.Drawing.Point(20, 110);
            this.analogGauge4.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(20, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.analogGauge4.CapsText = new string[] {
        "",
        "Exh. Temp 4",
        "",
        "",
        ""};
            this.analogGauge4.CapText = "Exh. Temp 4";
            this.analogGauge4.Center = new System.Drawing.Point(110, 110);
            this.analogGauge4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogGauge4.Location = new System.Drawing.Point(340, 262);
            this.analogGauge4.MaxValue = 1000F;
            this.analogGauge4.MinValue = 0F;
            this.analogGauge4.Name = "analogGauge4";
            this.analogGauge4.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
            this.analogGauge4.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.analogGauge4.NeedleRadius = 95;
            this.analogGauge4.NeedleType = 0;
            this.analogGauge4.NeedleWidth = 2;
            this.analogGauge4.Range_Idx = ((byte)(2));
            this.analogGauge4.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.analogGauge4.RangeEnabled = true;
            this.analogGauge4.RangeEndValue = 1000F;
            this.analogGauge4.RangeInnerRadius = 75;
            this.analogGauge4.RangeOuterRadius = 85;
            this.analogGauge4.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.PaleTurquoise,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control};
            this.analogGauge4.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.analogGauge4.RangesEndValue = new float[] {
        250F,
        800F,
        1000F,
        1000F,
        0F};
            this.analogGauge4.RangesInnerRadius = new int[] {
        75,
        75,
        75,
        70,
        70};
            this.analogGauge4.RangesOuterRadius = new int[] {
        85,
        85,
        85,
        80,
        80};
            this.analogGauge4.RangesStartValue = new float[] {
        0F,
        251F,
        800F,
        800F,
        0F};
            this.analogGauge4.RangeStartValue = 800F;
            this.analogGauge4.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.analogGauge4.ScaleLinesInterInnerRadius = 75;
            this.analogGauge4.ScaleLinesInterOuterRadius = 82;
            this.analogGauge4.ScaleLinesInterWidth = 1;
            this.analogGauge4.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.analogGauge4.ScaleLinesMajorInnerRadius = 75;
            this.analogGauge4.ScaleLinesMajorOuterRadius = 85;
            this.analogGauge4.ScaleLinesMajorStepValue = 200F;
            this.analogGauge4.ScaleLinesMajorWidth = 2;
            this.analogGauge4.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.analogGauge4.ScaleLinesMinorInnerRadius = 75;
            this.analogGauge4.ScaleLinesMinorNumOf = 7;
            this.analogGauge4.ScaleLinesMinorOuterRadius = 80;
            this.analogGauge4.ScaleLinesMinorWidth = 1;
            this.analogGauge4.ScaleNumbersColor = System.Drawing.Color.Black;
            this.analogGauge4.ScaleNumbersFormat = null;
            this.analogGauge4.ScaleNumbersRadius = 95;
            this.analogGauge4.ScaleNumbersRotation = 90;
            this.analogGauge4.ScaleNumbersStartScaleLine = 0;
            this.analogGauge4.ScaleNumbersStepScaleLines = 1;
            this.analogGauge4.Size = new System.Drawing.Size(175, 124);
            this.analogGauge4.TabIndex = 22;
            this.analogGauge4.TabStop = false;
            this.analogGauge4.Text = "aGauge8";
            this.analogGauge4.Value = 0F;
            // 
            // analogGauge3
            // 
            this.analogGauge3.BaseArcColor = System.Drawing.Color.Gray;
            this.analogGauge3.BaseArcRadius = 105;
            this.analogGauge3.BaseArcStart = 180;
            this.analogGauge3.BaseArcSweep = 120;
            this.analogGauge3.BaseArcWidth = 2;
            this.analogGauge3.Cap_Idx = ((byte)(1));
            this.analogGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.analogGauge3.CapPosition = new System.Drawing.Point(20, 110);
            this.analogGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(20, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.analogGauge3.CapsText = new string[] {
        "",
        "Exh. Temp 3",
        "",
        "",
        ""};
            this.analogGauge3.CapText = "Exh. Temp 3";
            this.analogGauge3.Center = new System.Drawing.Point(110, 110);
            this.analogGauge3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogGauge3.Location = new System.Drawing.Point(240, 392);
            this.analogGauge3.MaxValue = 1000F;
            this.analogGauge3.MinValue = 0F;
            this.analogGauge3.Name = "analogGauge3";
            this.analogGauge3.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
            this.analogGauge3.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.analogGauge3.NeedleRadius = 95;
            this.analogGauge3.NeedleType = 0;
            this.analogGauge3.NeedleWidth = 2;
            this.analogGauge3.Range_Idx = ((byte)(2));
            this.analogGauge3.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.analogGauge3.RangeEnabled = true;
            this.analogGauge3.RangeEndValue = 1000F;
            this.analogGauge3.RangeInnerRadius = 75;
            this.analogGauge3.RangeOuterRadius = 85;
            this.analogGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.PaleTurquoise,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control};
            this.analogGauge3.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.analogGauge3.RangesEndValue = new float[] {
        250F,
        800F,
        1000F,
        1000F,
        0F};
            this.analogGauge3.RangesInnerRadius = new int[] {
        75,
        75,
        75,
        70,
        70};
            this.analogGauge3.RangesOuterRadius = new int[] {
        85,
        85,
        85,
        80,
        80};
            this.analogGauge3.RangesStartValue = new float[] {
        0F,
        251F,
        800F,
        800F,
        0F};
            this.analogGauge3.RangeStartValue = 800F;
            this.analogGauge3.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.analogGauge3.ScaleLinesInterInnerRadius = 75;
            this.analogGauge3.ScaleLinesInterOuterRadius = 82;
            this.analogGauge3.ScaleLinesInterWidth = 1;
            this.analogGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.analogGauge3.ScaleLinesMajorInnerRadius = 75;
            this.analogGauge3.ScaleLinesMajorOuterRadius = 85;
            this.analogGauge3.ScaleLinesMajorStepValue = 200F;
            this.analogGauge3.ScaleLinesMajorWidth = 2;
            this.analogGauge3.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.analogGauge3.ScaleLinesMinorInnerRadius = 75;
            this.analogGauge3.ScaleLinesMinorNumOf = 7;
            this.analogGauge3.ScaleLinesMinorOuterRadius = 80;
            this.analogGauge3.ScaleLinesMinorWidth = 1;
            this.analogGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.analogGauge3.ScaleNumbersFormat = null;
            this.analogGauge3.ScaleNumbersRadius = 95;
            this.analogGauge3.ScaleNumbersRotation = 90;
            this.analogGauge3.ScaleNumbersStartScaleLine = 0;
            this.analogGauge3.ScaleNumbersStepScaleLines = 1;
            this.analogGauge3.Size = new System.Drawing.Size(175, 124);
            this.analogGauge3.TabIndex = 21;
            this.analogGauge3.TabStop = false;
            this.analogGauge3.Text = "aGauge7";
            this.analogGauge3.Value = 0F;
            // 
            // analogGauge2
            // 
            this.analogGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.analogGauge2.BaseArcRadius = 105;
            this.analogGauge2.BaseArcStart = 180;
            this.analogGauge2.BaseArcSweep = 120;
            this.analogGauge2.BaseArcWidth = 2;
            this.analogGauge2.Cap_Idx = ((byte)(1));
            this.analogGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.analogGauge2.CapPosition = new System.Drawing.Point(20, 110);
            this.analogGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(20, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.analogGauge2.CapsText = new string[] {
        "",
        "Exh. Temp 2",
        "",
        "",
        ""};
            this.analogGauge2.CapText = "Exh. Temp 2";
            this.analogGauge2.Center = new System.Drawing.Point(110, 110);
            this.analogGauge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogGauge2.Location = new System.Drawing.Point(120, 262);
            this.analogGauge2.MaxValue = 1000F;
            this.analogGauge2.MinValue = 0F;
            this.analogGauge2.Name = "analogGauge2";
            this.analogGauge2.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
            this.analogGauge2.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.analogGauge2.NeedleRadius = 95;
            this.analogGauge2.NeedleType = 0;
            this.analogGauge2.NeedleWidth = 2;
            this.analogGauge2.Range_Idx = ((byte)(2));
            this.analogGauge2.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.analogGauge2.RangeEnabled = true;
            this.analogGauge2.RangeEndValue = 1000F;
            this.analogGauge2.RangeInnerRadius = 75;
            this.analogGauge2.RangeOuterRadius = 85;
            this.analogGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.PaleTurquoise,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control};
            this.analogGauge2.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.analogGauge2.RangesEndValue = new float[] {
        250F,
        800F,
        1000F,
        1000F,
        0F};
            this.analogGauge2.RangesInnerRadius = new int[] {
        75,
        75,
        75,
        70,
        70};
            this.analogGauge2.RangesOuterRadius = new int[] {
        85,
        85,
        85,
        80,
        80};
            this.analogGauge2.RangesStartValue = new float[] {
        0F,
        251F,
        800F,
        800F,
        0F};
            this.analogGauge2.RangeStartValue = 800F;
            this.analogGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.analogGauge2.ScaleLinesInterInnerRadius = 75;
            this.analogGauge2.ScaleLinesInterOuterRadius = 82;
            this.analogGauge2.ScaleLinesInterWidth = 1;
            this.analogGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.analogGauge2.ScaleLinesMajorInnerRadius = 75;
            this.analogGauge2.ScaleLinesMajorOuterRadius = 85;
            this.analogGauge2.ScaleLinesMajorStepValue = 200F;
            this.analogGauge2.ScaleLinesMajorWidth = 2;
            this.analogGauge2.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.analogGauge2.ScaleLinesMinorInnerRadius = 75;
            this.analogGauge2.ScaleLinesMinorNumOf = 7;
            this.analogGauge2.ScaleLinesMinorOuterRadius = 80;
            this.analogGauge2.ScaleLinesMinorWidth = 1;
            this.analogGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.analogGauge2.ScaleNumbersFormat = null;
            this.analogGauge2.ScaleNumbersRadius = 95;
            this.analogGauge2.ScaleNumbersRotation = 90;
            this.analogGauge2.ScaleNumbersStartScaleLine = 0;
            this.analogGauge2.ScaleNumbersStepScaleLines = 1;
            this.analogGauge2.Size = new System.Drawing.Size(175, 124);
            this.analogGauge2.TabIndex = 20;
            this.analogGauge2.TabStop = false;
            this.analogGauge2.Text = "aGauge6";
            this.analogGauge2.Value = 0F;
            // 
            // analogGauge1
            // 
            this.analogGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.analogGauge1.BaseArcRadius = 105;
            this.analogGauge1.BaseArcStart = 180;
            this.analogGauge1.BaseArcSweep = 120;
            this.analogGauge1.BaseArcWidth = 2;
            this.analogGauge1.Cap_Idx = ((byte)(1));
            this.analogGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.analogGauge1.CapPosition = new System.Drawing.Point(20, 110);
            this.analogGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(20, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.analogGauge1.CapsText = new string[] {
        "",
        "Exh. Temp 1",
        "",
        "",
        ""};
            this.analogGauge1.CapText = "Exh. Temp 1";
            this.analogGauge1.Center = new System.Drawing.Point(110, 110);
            this.analogGauge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogGauge1.Location = new System.Drawing.Point(20, 392);
            this.analogGauge1.MaxValue = 1000F;
            this.analogGauge1.MinValue = 0F;
            this.analogGauge1.Name = "analogGauge1";
            this.analogGauge1.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
            this.analogGauge1.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.analogGauge1.NeedleRadius = 95;
            this.analogGauge1.NeedleType = 0;
            this.analogGauge1.NeedleWidth = 2;
            this.analogGauge1.Range_Idx = ((byte)(2));
            this.analogGauge1.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.analogGauge1.RangeEnabled = true;
            this.analogGauge1.RangeEndValue = 1000F;
            this.analogGauge1.RangeInnerRadius = 75;
            this.analogGauge1.RangeOuterRadius = 85;
            this.analogGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.PaleTurquoise,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control};
            this.analogGauge1.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.analogGauge1.RangesEndValue = new float[] {
        250F,
        800F,
        1000F,
        1000F,
        0F};
            this.analogGauge1.RangesInnerRadius = new int[] {
        75,
        75,
        75,
        70,
        70};
            this.analogGauge1.RangesOuterRadius = new int[] {
        85,
        85,
        85,
        80,
        80};
            this.analogGauge1.RangesStartValue = new float[] {
        0F,
        251F,
        800F,
        800F,
        0F};
            this.analogGauge1.RangeStartValue = 800F;
            this.analogGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.analogGauge1.ScaleLinesInterInnerRadius = 75;
            this.analogGauge1.ScaleLinesInterOuterRadius = 82;
            this.analogGauge1.ScaleLinesInterWidth = 1;
            this.analogGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.analogGauge1.ScaleLinesMajorInnerRadius = 75;
            this.analogGauge1.ScaleLinesMajorOuterRadius = 85;
            this.analogGauge1.ScaleLinesMajorStepValue = 200F;
            this.analogGauge1.ScaleLinesMajorWidth = 2;
            this.analogGauge1.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.analogGauge1.ScaleLinesMinorInnerRadius = 75;
            this.analogGauge1.ScaleLinesMinorNumOf = 7;
            this.analogGauge1.ScaleLinesMinorOuterRadius = 80;
            this.analogGauge1.ScaleLinesMinorWidth = 1;
            this.analogGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.analogGauge1.ScaleNumbersFormat = null;
            this.analogGauge1.ScaleNumbersRadius = 95;
            this.analogGauge1.ScaleNumbersRotation = 90;
            this.analogGauge1.ScaleNumbersStartScaleLine = 0;
            this.analogGauge1.ScaleNumbersStepScaleLines = 1;
            this.analogGauge1.Size = new System.Drawing.Size(175, 124);
            this.analogGauge1.TabIndex = 19;
            this.analogGauge1.TabStop = false;
            this.analogGauge1.Text = "aGauge5";
            this.analogGauge1.Value = 0F;
            // 
            // rpmGauge4
            // 
            this.rpmGauge4.BaseArcColor = System.Drawing.Color.Gray;
            this.rpmGauge4.BaseArcRadius = 109;
            this.rpmGauge4.BaseArcStart = 135;
            this.rpmGauge4.BaseArcSweep = 270;
            this.rpmGauge4.BaseArcWidth = 2;
            this.rpmGauge4.Cap_Idx = ((byte)(1));
            this.rpmGauge4.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.rpmGauge4.CapPosition = new System.Drawing.Point(90, 150);
            this.rpmGauge4.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(90, 150),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.rpmGauge4.CapsText = new string[] {
        "",
        "RPM 4",
        "",
        "",
        ""};
            this.rpmGauge4.CapText = "RPM 4";
            this.rpmGauge4.Center = new System.Drawing.Point(110, 110);
            this.rpmGauge4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmGauge4.Location = new System.Drawing.Point(759, 2);
            this.rpmGauge4.MaxValue = 10000F;
            this.rpmGauge4.MinValue = 0F;
            this.rpmGauge4.Name = "rpmGauge4";
            this.rpmGauge4.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Yellow;
            this.rpmGauge4.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rpmGauge4.NeedleRadius = 95;
            this.rpmGauge4.NeedleType = 0;
            this.rpmGauge4.NeedleWidth = 2;
            this.rpmGauge4.Range_Idx = ((byte)(1));
            this.rpmGauge4.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rpmGauge4.RangeEnabled = true;
            this.rpmGauge4.RangeEndValue = 10000F;
            this.rpmGauge4.RangeInnerRadius = 75;
            this.rpmGauge4.RangeOuterRadius = 85;
            this.rpmGauge4.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.rpmGauge4.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.rpmGauge4.RangesEndValue = new float[] {
        8000F,
        10000F,
        0F,
        0F,
        0F};
            this.rpmGauge4.RangesInnerRadius = new int[] {
        75,
        75,
        75,
        70,
        70};
            this.rpmGauge4.RangesOuterRadius = new int[] {
        85,
        85,
        85,
        80,
        80};
            this.rpmGauge4.RangesStartValue = new float[] {
        0F,
        8000F,
        0F,
        0F,
        0F};
            this.rpmGauge4.RangeStartValue = 8000F;
            this.rpmGauge4.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.rpmGauge4.ScaleLinesInterInnerRadius = 80;
            this.rpmGauge4.ScaleLinesInterOuterRadius = 90;
            this.rpmGauge4.ScaleLinesInterWidth = 1;
            this.rpmGauge4.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.rpmGauge4.ScaleLinesMajorInnerRadius = 70;
            this.rpmGauge4.ScaleLinesMajorOuterRadius = 90;
            this.rpmGauge4.ScaleLinesMajorStepValue = 2000F;
            this.rpmGauge4.ScaleLinesMajorWidth = 2;
            this.rpmGauge4.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.rpmGauge4.ScaleLinesMinorInnerRadius = 85;
            this.rpmGauge4.ScaleLinesMinorNumOf = 9;
            this.rpmGauge4.ScaleLinesMinorOuterRadius = 90;
            this.rpmGauge4.ScaleLinesMinorWidth = 1;
            this.rpmGauge4.ScaleNumbersColor = System.Drawing.Color.Black;
            this.rpmGauge4.ScaleNumbersFormat = null;
            this.rpmGauge4.ScaleNumbersRadius = 100;
            this.rpmGauge4.ScaleNumbersRotation = 90;
            this.rpmGauge4.ScaleNumbersStartScaleLine = 0;
            this.rpmGauge4.ScaleNumbersStepScaleLines = 1;
            this.rpmGauge4.Size = new System.Drawing.Size(220, 195);
            this.rpmGauge4.TabIndex = 18;
            this.rpmGauge4.TabStop = false;
            this.rpmGauge4.Text = "aGauge4";
            this.rpmGauge4.Value = 0F;
            // 
            // rpmGauge3
            // 
            this.rpmGauge3.BaseArcColor = System.Drawing.Color.Gray;
            this.rpmGauge3.BaseArcRadius = 109;
            this.rpmGauge3.BaseArcStart = 135;
            this.rpmGauge3.BaseArcSweep = 270;
            this.rpmGauge3.BaseArcWidth = 2;
            this.rpmGauge3.Cap_Idx = ((byte)(1));
            this.rpmGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.rpmGauge3.CapPosition = new System.Drawing.Point(90, 150);
            this.rpmGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(90, 150),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.rpmGauge3.CapsText = new string[] {
        "",
        "RPM 3",
        "",
        "",
        ""};
            this.rpmGauge3.CapText = "RPM 3";
            this.rpmGauge3.Center = new System.Drawing.Point(110, 110);
            this.rpmGauge3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmGauge3.Location = new System.Drawing.Point(507, 2);
            this.rpmGauge3.MaxValue = 10000F;
            this.rpmGauge3.MinValue = 0F;
            this.rpmGauge3.Name = "rpmGauge3";
            this.rpmGauge3.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Yellow;
            this.rpmGauge3.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rpmGauge3.NeedleRadius = 95;
            this.rpmGauge3.NeedleType = 0;
            this.rpmGauge3.NeedleWidth = 2;
            this.rpmGauge3.Range_Idx = ((byte)(1));
            this.rpmGauge3.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rpmGauge3.RangeEnabled = true;
            this.rpmGauge3.RangeEndValue = 10000F;
            this.rpmGauge3.RangeInnerRadius = 75;
            this.rpmGauge3.RangeOuterRadius = 85;
            this.rpmGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.rpmGauge3.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.rpmGauge3.RangesEndValue = new float[] {
        8000F,
        10000F,
        0F,
        0F,
        0F};
            this.rpmGauge3.RangesInnerRadius = new int[] {
        75,
        75,
        75,
        70,
        70};
            this.rpmGauge3.RangesOuterRadius = new int[] {
        85,
        85,
        85,
        80,
        80};
            this.rpmGauge3.RangesStartValue = new float[] {
        0F,
        8000F,
        0F,
        0F,
        0F};
            this.rpmGauge3.RangeStartValue = 8000F;
            this.rpmGauge3.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.rpmGauge3.ScaleLinesInterInnerRadius = 80;
            this.rpmGauge3.ScaleLinesInterOuterRadius = 90;
            this.rpmGauge3.ScaleLinesInterWidth = 1;
            this.rpmGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.rpmGauge3.ScaleLinesMajorInnerRadius = 70;
            this.rpmGauge3.ScaleLinesMajorOuterRadius = 90;
            this.rpmGauge3.ScaleLinesMajorStepValue = 2000F;
            this.rpmGauge3.ScaleLinesMajorWidth = 2;
            this.rpmGauge3.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.rpmGauge3.ScaleLinesMinorInnerRadius = 85;
            this.rpmGauge3.ScaleLinesMinorNumOf = 9;
            this.rpmGauge3.ScaleLinesMinorOuterRadius = 90;
            this.rpmGauge3.ScaleLinesMinorWidth = 1;
            this.rpmGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.rpmGauge3.ScaleNumbersFormat = null;
            this.rpmGauge3.ScaleNumbersRadius = 100;
            this.rpmGauge3.ScaleNumbersRotation = 90;
            this.rpmGauge3.ScaleNumbersStartScaleLine = 0;
            this.rpmGauge3.ScaleNumbersStepScaleLines = 1;
            this.rpmGauge3.Size = new System.Drawing.Size(220, 195);
            this.rpmGauge3.TabIndex = 17;
            this.rpmGauge3.TabStop = false;
            this.rpmGauge3.Text = "aGauge3";
            this.rpmGauge3.Value = 0F;
            // 
            // rpmGauge2
            // 
            this.rpmGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.rpmGauge2.BaseArcRadius = 109;
            this.rpmGauge2.BaseArcStart = 135;
            this.rpmGauge2.BaseArcSweep = 270;
            this.rpmGauge2.BaseArcWidth = 2;
            this.rpmGauge2.Cap_Idx = ((byte)(1));
            this.rpmGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.rpmGauge2.CapPosition = new System.Drawing.Point(75, 150);
            this.rpmGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(75, 150),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.rpmGauge2.CapsText = new string[] {
        "",
        "Shaft RPM",
        "",
        "",
        ""};
            this.rpmGauge2.CapText = "Shaft RPM";
            this.rpmGauge2.Center = new System.Drawing.Point(110, 110);
            this.rpmGauge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmGauge2.Location = new System.Drawing.Point(255, 2);
            this.rpmGauge2.MaxValue = 10000F;
            this.rpmGauge2.MinValue = 0F;
            this.rpmGauge2.Name = "rpmGauge2";
            this.rpmGauge2.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
            this.rpmGauge2.NeedleColor2 = System.Drawing.Color.Maroon;
            this.rpmGauge2.NeedleRadius = 95;
            this.rpmGauge2.NeedleType = 0;
            this.rpmGauge2.NeedleWidth = 3;
            this.rpmGauge2.Range_Idx = ((byte)(2));
            this.rpmGauge2.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rpmGauge2.RangeEnabled = true;
            this.rpmGauge2.RangeEndValue = 10000F;
            this.rpmGauge2.RangeInnerRadius = 75;
            this.rpmGauge2.RangeOuterRadius = 85;
            this.rpmGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.PaleTurquoise,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.rpmGauge2.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.rpmGauge2.RangesEndValue = new float[] {
        6000F,
        7999F,
        10000F,
        0F,
        0F};
            this.rpmGauge2.RangesInnerRadius = new int[] {
        75,
        75,
        75,
        70,
        70};
            this.rpmGauge2.RangesOuterRadius = new int[] {
        85,
        85,
        85,
        80,
        80};
            this.rpmGauge2.RangesStartValue = new float[] {
        0F,
        6001F,
        8000F,
        0F,
        0F};
            this.rpmGauge2.RangeStartValue = 8000F;
            this.rpmGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.rpmGauge2.ScaleLinesInterInnerRadius = 80;
            this.rpmGauge2.ScaleLinesInterOuterRadius = 90;
            this.rpmGauge2.ScaleLinesInterWidth = 1;
            this.rpmGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.rpmGauge2.ScaleLinesMajorInnerRadius = 70;
            this.rpmGauge2.ScaleLinesMajorOuterRadius = 90;
            this.rpmGauge2.ScaleLinesMajorStepValue = 1000F;
            this.rpmGauge2.ScaleLinesMajorWidth = 2;
            this.rpmGauge2.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.rpmGauge2.ScaleLinesMinorInnerRadius = 85;
            this.rpmGauge2.ScaleLinesMinorNumOf = 9;
            this.rpmGauge2.ScaleLinesMinorOuterRadius = 90;
            this.rpmGauge2.ScaleLinesMinorWidth = 1;
            this.rpmGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.rpmGauge2.ScaleNumbersFormat = null;
            this.rpmGauge2.ScaleNumbersRadius = 100;
            this.rpmGauge2.ScaleNumbersRotation = 90;
            this.rpmGauge2.ScaleNumbersStartScaleLine = 0;
            this.rpmGauge2.ScaleNumbersStepScaleLines = 1;
            this.rpmGauge2.Size = new System.Drawing.Size(220, 195);
            this.rpmGauge2.TabIndex = 16;
            this.rpmGauge2.TabStop = false;
            this.rpmGauge2.Text = "aGauge2";
            this.rpmGauge2.Value = 0F;
            // 
            // rpmGauge1
            // 
            this.rpmGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.rpmGauge1.BaseArcRadius = 109;
            this.rpmGauge1.BaseArcStart = 135;
            this.rpmGauge1.BaseArcSweep = 270;
            this.rpmGauge1.BaseArcWidth = 2;
            this.rpmGauge1.Cap_Idx = ((byte)(1));
            this.rpmGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.rpmGauge1.CapPosition = new System.Drawing.Point(78, 150);
            this.rpmGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(78, 150),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.rpmGauge1.CapsText = new string[] {
        "",
        "Engine RPM",
        "",
        "",
        ""};
            this.rpmGauge1.CapText = "Engine RPM";
            this.rpmGauge1.Center = new System.Drawing.Point(110, 110);
            this.rpmGauge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmGauge1.Location = new System.Drawing.Point(3, 2);
            this.rpmGauge1.Margin = new System.Windows.Forms.Padding(2);
            this.rpmGauge1.MaxValue = 10000F;
            this.rpmGauge1.MinValue = 0F;
            this.rpmGauge1.Name = "rpmGauge1";
            this.rpmGauge1.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
            this.rpmGauge1.NeedleColor2 = System.Drawing.Color.Maroon;
            this.rpmGauge1.NeedleRadius = 95;
            this.rpmGauge1.NeedleType = 0;
            this.rpmGauge1.NeedleWidth = 3;
            this.rpmGauge1.Range_Idx = ((byte)(2));
            this.rpmGauge1.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rpmGauge1.RangeEnabled = true;
            this.rpmGauge1.RangeEndValue = 10000F;
            this.rpmGauge1.RangeInnerRadius = 75;
            this.rpmGauge1.RangeOuterRadius = 85;
            this.rpmGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.PaleTurquoise,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.rpmGauge1.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.rpmGauge1.RangesEndValue = new float[] {
        6000F,
        7999F,
        10000F,
        0F,
        0F};
            this.rpmGauge1.RangesInnerRadius = new int[] {
        75,
        75,
        75,
        70,
        70};
            this.rpmGauge1.RangesOuterRadius = new int[] {
        85,
        85,
        85,
        80,
        80};
            this.rpmGauge1.RangesStartValue = new float[] {
        0F,
        6001F,
        8000F,
        0F,
        0F};
            this.rpmGauge1.RangeStartValue = 8000F;
            this.rpmGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.rpmGauge1.ScaleLinesInterInnerRadius = 80;
            this.rpmGauge1.ScaleLinesInterOuterRadius = 90;
            this.rpmGauge1.ScaleLinesInterWidth = 1;
            this.rpmGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.rpmGauge1.ScaleLinesMajorInnerRadius = 70;
            this.rpmGauge1.ScaleLinesMajorOuterRadius = 90;
            this.rpmGauge1.ScaleLinesMajorStepValue = 1000F;
            this.rpmGauge1.ScaleLinesMajorWidth = 2;
            this.rpmGauge1.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.rpmGauge1.ScaleLinesMinorInnerRadius = 85;
            this.rpmGauge1.ScaleLinesMinorNumOf = 9;
            this.rpmGauge1.ScaleLinesMinorOuterRadius = 90;
            this.rpmGauge1.ScaleLinesMinorWidth = 1;
            this.rpmGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.rpmGauge1.ScaleNumbersFormat = null;
            this.rpmGauge1.ScaleNumbersRadius = 100;
            this.rpmGauge1.ScaleNumbersRotation = 90;
            this.rpmGauge1.ScaleNumbersStartScaleLine = 0;
            this.rpmGauge1.ScaleNumbersStepScaleLines = 1;
            this.rpmGauge1.Size = new System.Drawing.Size(220, 195);
            this.rpmGauge1.TabIndex = 15;
            this.rpmGauge1.TabStop = false;
            this.rpmGauge1.Text = "aGauge1";
            this.rpmGauge1.Value = 0F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1070, 703);
            this.Controls.Add(this.OnOffButton4);
            this.Controls.Add(this.OnOffButton3);
            this.Controls.Add(this.OnOffButton2);
            this.Controls.Add(this.OnOffButton1);
            this.Controls.Add(this.toggleValueButton);
            this.Controls.Add(this.logDataButton);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.loggerNameTextBox);
            this.Controls.Add(this.loggerNameLabel);
            this.Controls.Add(this.StartLoggerButton);
            this.Controls.Add(this.speed_label);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.gauge2_label);
            this.Controls.Add(this.gauge1_label);
            this.Controls.Add(this.secs_heading_label);
            this.Controls.Add(this.secsLabel);
            this.Controls.Add(this.addGauge8);
            this.Controls.Add(this.addGauge7);
            this.Controls.Add(this.addGauge6);
            this.Controls.Add(this.addGauge5);
            this.Controls.Add(this.addGauge4);
            this.Controls.Add(this.addGauge3);
            this.Controls.Add(this.addGauge2);
            this.Controls.Add(this.addGauge1);
            this.Controls.Add(this.Simulate_button);
            this.Controls.Add(this.analogGauge8);
            this.Controls.Add(this.analogGauge7);
            this.Controls.Add(this.analogGauge6);
            this.Controls.Add(this.analogGauge5);
            this.Controls.Add(this.analogGauge4);
            this.Controls.Add(this.analogGauge3);
            this.Controls.Add(this.analogGauge2);
            this.Controls.Add(this.analogGauge1);
            this.Controls.Add(this.Sensor_button);
            this.Controls.Add(this.LogComp_button);
            this.Controls.Add(this.ComPort_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.StopMonitor_button);
            this.Controls.Add(this.StartMonitor_button);
            this.Controls.Add(this.rpmGauge4);
            this.Controls.Add(this.rpmGauge3);
            this.Controls.Add(this.rpmGauge2);
            this.Controls.Add(this.rpmGauge1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(79, 89);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer updateScreenTimer;
		private AGauge rpmGauge1;
		private AGauge rpmGauge2;
		private AGauge rpmGauge3;
		private AGauge rpmGauge4;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Button StartMonitor_button;
		private System.Windows.Forms.Button StopMonitor_button;
		private System.Windows.Forms.Button Exit_button;
		private System.Windows.Forms.Button ComPort_button;
		private System.Windows.Forms.Button LogComp_button;
		private System.Windows.Forms.Button Sensor_button;
		private AGauge analogGauge1;
		private AGauge analogGauge2;
		private AGauge analogGauge3;
		private AGauge analogGauge4;
		private AGauge analogGauge5;
		private AGauge analogGauge6;
		private AGauge analogGauge7;
		private AGauge analogGauge8;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button Simulate_button;
		private AGauge addGauge1;
		private AGauge addGauge2;
		private AGauge addGauge3;
		private AGauge addGauge4;
		private AGauge addGauge5;
		private AGauge addGauge6;
		private AGauge addGauge7;
		private AGauge addGauge8;
		private System.Windows.Forms.Timer readComTimer;
		private System.Windows.Forms.Label secsLabel;
		private System.Windows.Forms.Label secs_heading_label;
		private System.Windows.Forms.Label gauge1_label;
		private System.Windows.Forms.Label gauge2_label;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label speed_label;
		private System.Windows.Forms.Button StartLoggerButton;
		private System.Windows.Forms.Label loggerNameLabel;
		private System.Windows.Forms.TextBox loggerNameTextBox;
		private System.Windows.Forms.Timer readLoggerTimer;
		private System.Windows.Forms.Timer initLoggerTimer;
		private System.Windows.Forms.TextBox logTextBox;
		private System.Windows.Forms.Button logDataButton;
		private System.Windows.Forms.Button toggleValueButton;
        private System.Windows.Forms.Button OnOffButton1;
        private System.Windows.Forms.Button OnOffButton2;
        private System.Windows.Forms.Button OnOffButton3;
        private System.Windows.Forms.Button OnOffButton4;
    }
}

