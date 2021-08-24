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
			this.OnOff1_label = new System.Windows.Forms.Label();
			this.OnOff2_label = new System.Windows.Forms.Label();
			this.OnOff3_label = new System.Windows.Forms.Label();
			this.OnOff4_label = new System.Windows.Forms.Label();
			this.OnOff1_progressBar = new System.Windows.Forms.ProgressBar();
			this.OnOff2_progressBar = new System.Windows.Forms.ProgressBar();
			this.OnOff3_progressBar = new System.Windows.Forms.ProgressBar();
			this.OnOff4_progressBar = new System.Windows.Forms.ProgressBar();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.readComTimer = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
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
			this.addGauge8 = new LoggerMonitor.AGauge();
			this.addGauge7 = new LoggerMonitor.AGauge();
			this.addGauge6 = new LoggerMonitor.AGauge();
			this.addGauge5 = new LoggerMonitor.AGauge();
			this.addGauge4 = new LoggerMonitor.AGauge();
			this.addGauge3 = new LoggerMonitor.AGauge();
			this.addGauge2 = new LoggerMonitor.AGauge();
			this.addGauge1 = new LoggerMonitor.AGauge();
			this.aGauge12 = new LoggerMonitor.AGauge();
			this.aGauge11 = new LoggerMonitor.AGauge();
			this.aGauge10 = new LoggerMonitor.AGauge();
			this.aGauge9 = new LoggerMonitor.AGauge();
			this.aGauge8 = new LoggerMonitor.AGauge();
			this.aGauge7 = new LoggerMonitor.AGauge();
			this.aGauge6 = new LoggerMonitor.AGauge();
			this.aGauge5 = new LoggerMonitor.AGauge();
			this.aGauge4 = new LoggerMonitor.AGauge();
			this.aGauge3 = new LoggerMonitor.AGauge();
			this.aGauge2 = new LoggerMonitor.AGauge();
			this.aGauge1 = new LoggerMonitor.AGauge();
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
			this.StartMonitor_button.Location = new System.Drawing.Point(986, 554);
			this.StartMonitor_button.Name = "StartMonitor_button";
			this.StartMonitor_button.Size = new System.Drawing.Size(80, 41);
			this.StartMonitor_button.TabIndex = 2;
			this.StartMonitor_button.Text = "Start COM Monitor";
			this.StartMonitor_button.UseVisualStyleBackColor = true;
			this.StartMonitor_button.Click += new System.EventHandler(this.StartMonitor_button_Click);
			// 
			// StopMonitor_button
			// 
			this.StopMonitor_button.Location = new System.Drawing.Point(986, 113);
			this.StopMonitor_button.Name = "StopMonitor_button";
			this.StopMonitor_button.Size = new System.Drawing.Size(80, 40);
			this.StopMonitor_button.TabIndex = 3;
			this.StopMonitor_button.Text = "Stop Monitor";
			this.StopMonitor_button.UseVisualStyleBackColor = true;
			this.StopMonitor_button.Click += new System.EventHandler(this.StopMonitor_button_Click);
			// 
			// Exit_button
			// 
			this.Exit_button.Location = new System.Drawing.Point(986, 662);
			this.Exit_button.Name = "Exit_button";
			this.Exit_button.Size = new System.Drawing.Size(80, 40);
			this.Exit_button.TabIndex = 9;
			this.Exit_button.Text = "Exit";
			this.Exit_button.UseVisualStyleBackColor = true;
			this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
			// 
			// ComPort_button
			// 
			this.ComPort_button.Location = new System.Drawing.Point(986, 501);
			this.ComPort_button.Name = "ComPort_button";
			this.ComPort_button.Size = new System.Drawing.Size(80, 40);
			this.ComPort_button.TabIndex = 8;
			this.ComPort_button.Text = "COM Port Settings...";
			this.ComPort_button.UseVisualStyleBackColor = true;
			this.ComPort_button.Click += new System.EventHandler(this.ComPort_button_Click);
			// 
			// LogComp_button
			// 
			this.LogComp_button.Location = new System.Drawing.Point(986, 397);
			this.LogComp_button.Name = "LogComp_button";
			this.LogComp_button.Size = new System.Drawing.Size(80, 40);
			this.LogComp_button.TabIndex = 6;
			this.LogComp_button.Text = "Race Logger Settings...";
			this.LogComp_button.UseVisualStyleBackColor = true;
			this.LogComp_button.Click += new System.EventHandler(this.LogComp_button_Click);
			// 
			// Sensor_button
			// 
			this.Sensor_button.Location = new System.Drawing.Point(986, 449);
			this.Sensor_button.Name = "Sensor_button";
			this.Sensor_button.Size = new System.Drawing.Size(80, 40);
			this.Sensor_button.TabIndex = 7;
			this.Sensor_button.Text = "Sensor Settings...";
			this.Sensor_button.UseVisualStyleBackColor = true;
			this.Sensor_button.Click += new System.EventHandler(this.Sensor_button_Click);
			// 
			// Simulate_button
			// 
			this.Simulate_button.Location = new System.Drawing.Point(986, 283);
			this.Simulate_button.Name = "Simulate_button";
			this.Simulate_button.Size = new System.Drawing.Size(80, 40);
			this.Simulate_button.TabIndex = 4;
			this.Simulate_button.Text = "Simulate from File...";
			this.Simulate_button.UseVisualStyleBackColor = true;
			this.Simulate_button.Click += new System.EventHandler(this.Simulate_button_Click);
			// 
			// StartLoggerButton
			// 
			this.StartLoggerButton.Location = new System.Drawing.Point(986, 58);
			this.StartLoggerButton.Name = "StartLoggerButton";
			this.StartLoggerButton.Size = new System.Drawing.Size(80, 40);
			this.StartLoggerButton.TabIndex = 1;
			this.StartLoggerButton.Text = "Start Logger Monitor";
			this.StartLoggerButton.UseVisualStyleBackColor = true;
			this.StartLoggerButton.Click += new System.EventHandler(this.StartLoggerButtonClick);
			// 
			// logDataButton
			// 
			this.logDataButton.Location = new System.Drawing.Point(986, 609);
			this.logDataButton.Name = "logDataButton";
			this.logDataButton.Size = new System.Drawing.Size(80, 41);
			this.logDataButton.TabIndex = 45;
			this.logDataButton.Text = "Toggle Data Transfer Log";
			this.logDataButton.UseVisualStyleBackColor = true;
			this.logDataButton.Click += new System.EventHandler(this.logDataButton_Click);
			// 
			// OnOff1_label
			// 
			this.OnOff1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OnOff1_label.Location = new System.Drawing.Point(265, 231);
			this.OnOff1_label.Name = "OnOff1_label";
			this.OnOff1_label.Size = new System.Drawing.Size(100, 20);
			this.OnOff1_label.TabIndex = 11;
			this.OnOff1_label.Text = "OnOff1";
			this.OnOff1_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// OnOff2_label
			// 
			this.OnOff2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OnOff2_label.Location = new System.Drawing.Point(465, 231);
			this.OnOff2_label.Name = "OnOff2_label";
			this.OnOff2_label.Size = new System.Drawing.Size(100, 20);
			this.OnOff2_label.TabIndex = 13;
			this.OnOff2_label.Text = "OnOff2";
			this.OnOff2_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// OnOff3_label
			// 
			this.OnOff3_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OnOff3_label.Location = new System.Drawing.Point(685, 231);
			this.OnOff3_label.Name = "OnOff3_label";
			this.OnOff3_label.Size = new System.Drawing.Size(100, 20);
			this.OnOff3_label.TabIndex = 15;
			this.OnOff3_label.Text = "OnOff3";
			this.OnOff3_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// OnOff4_label
			// 
			this.OnOff4_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OnOff4_label.Location = new System.Drawing.Point(905, 231);
			this.OnOff4_label.Name = "OnOff4_label";
			this.OnOff4_label.Size = new System.Drawing.Size(100, 20);
			this.OnOff4_label.TabIndex = 43;
			this.OnOff4_label.Text = "OnOff4";
			this.OnOff4_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// OnOff1_progressBar
			// 
			this.OnOff1_progressBar.BackColor = System.Drawing.SystemColors.Control;
			this.OnOff1_progressBar.ForeColor = System.Drawing.Color.Red;
			this.OnOff1_progressBar.Location = new System.Drawing.Point(370, 218);
			this.OnOff1_progressBar.Margin = new System.Windows.Forms.Padding(20);
			this.OnOff1_progressBar.MarqueeAnimationSpeed = 5;
			this.OnOff1_progressBar.Name = "OnOff1_progressBar";
			this.OnOff1_progressBar.Size = new System.Drawing.Size(40, 40);
			this.OnOff1_progressBar.Step = 1;
			this.OnOff1_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.OnOff1_progressBar.TabIndex = 12;
			this.OnOff1_progressBar.Value = 100;
			// 
			// OnOff2_progressBar
			// 
			this.OnOff2_progressBar.BackColor = System.Drawing.SystemColors.Control;
			this.OnOff2_progressBar.ForeColor = System.Drawing.Color.Red;
			this.OnOff2_progressBar.Location = new System.Drawing.Point(570, 218);
			this.OnOff2_progressBar.MarqueeAnimationSpeed = 3;
			this.OnOff2_progressBar.Name = "OnOff2_progressBar";
			this.OnOff2_progressBar.Size = new System.Drawing.Size(40, 40);
			this.OnOff2_progressBar.Step = 50;
			this.OnOff2_progressBar.TabIndex = 14;
			this.OnOff2_progressBar.Value = 100;
			// 
			// OnOff3_progressBar
			// 
			this.OnOff3_progressBar.BackColor = System.Drawing.SystemColors.Control;
			this.OnOff3_progressBar.ForeColor = System.Drawing.Color.Red;
			this.OnOff3_progressBar.Location = new System.Drawing.Point(790, 218);
			this.OnOff3_progressBar.MarqueeAnimationSpeed = 10;
			this.OnOff3_progressBar.Name = "OnOff3_progressBar";
			this.OnOff3_progressBar.Size = new System.Drawing.Size(40, 40);
			this.OnOff3_progressBar.Step = 5;
			this.OnOff3_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.OnOff3_progressBar.TabIndex = 16;
			this.OnOff3_progressBar.Value = 100;
			// 
			// OnOff4_progressBar
			// 
			this.OnOff4_progressBar.BackColor = System.Drawing.SystemColors.Control;
			this.OnOff4_progressBar.ForeColor = System.Drawing.Color.Red;
			this.OnOff4_progressBar.Location = new System.Drawing.Point(1010, 218);
			this.OnOff4_progressBar.MarqueeAnimationSpeed = 10;
			this.OnOff4_progressBar.Name = "OnOff4_progressBar";
			this.OnOff4_progressBar.Size = new System.Drawing.Size(40, 40);
			this.OnOff4_progressBar.Step = 5;
			this.OnOff4_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.OnOff4_progressBar.TabIndex = 44;
			this.OnOff4_progressBar.Value = 100;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// readComTimer
			// 
			this.readComTimer.Tick += new System.EventHandler(this.readComTimer_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(550, 800);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(400, 13);
			this.label1.TabIndex = 33;
			this.label1.Text = "Run Monitor, Version 3.1. Copyright  © S.Molin, 2020. Special thanks for A.J.Bauer!";
			// 
			// secsLabel
			// 
			this.secsLabel.AutoSize = true;
			this.secsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.secsLabel.Location = new System.Drawing.Point(150, 228);
			this.secsLabel.Name = "secsLabel";
			this.secsLabel.Size = new System.Drawing.Size(45, 24);
			this.secsLabel.TabIndex = 34;
			this.secsLabel.Text = "0.00";
			// 
			// secs_heading_label
			// 
			this.secs_heading_label.AutoSize = true;
			this.secs_heading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.secs_heading_label.Location = new System.Drawing.Point(50, 228);
			this.secs_heading_label.Name = "secs_heading_label";
			this.secs_heading_label.Size = new System.Drawing.Size(90, 24);
			this.secs_heading_label.TabIndex = 35;
			this.secs_heading_label.Text = "Seconds:";
			// 
			// gauge1_label
			// 
			this.gauge1_label.AutoSize = true;
			this.gauge1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gauge1_label.Location = new System.Drawing.Point(100, 178);
			this.gauge1_label.Name = "gauge1_label";
			this.gauge1_label.Size = new System.Drawing.Size(44, 17);
			this.gauge1_label.TabIndex = 36;
			this.gauge1_label.Text = "0000";
			// 
			// gauge2_label
			// 
			this.gauge2_label.AutoSize = true;
			this.gauge2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gauge2_label.Location = new System.Drawing.Point(355, 178);
			this.gauge2_label.Name = "gauge2_label";
			this.gauge2_label.Size = new System.Drawing.Size(35, 17);
			this.gauge2_label.TabIndex = 37;
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
			this.numericUpDown1.Location = new System.Drawing.Point(1000, 356);
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
			this.speed_label.Location = new System.Drawing.Point(970, 336);
			this.speed_label.Name = "speed_label";
			this.speed_label.Size = new System.Drawing.Size(92, 13);
			this.speed_label.TabIndex = 39;
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
			this.loggerNameTextBox.Location = new System.Drawing.Point(986, 25);
			this.loggerNameTextBox.Name = "loggerNameTextBox";
			this.loggerNameTextBox.Size = new System.Drawing.Size(80, 20);
			this.loggerNameTextBox.TabIndex = 0;
			this.loggerNameTextBox.TextChanged += new System.EventHandler(this.loggerNameTextBox_TextChanged);
			this.loggerNameTextBox.Leave += new System.EventHandler(this.loggerNameTextBox_Leave);
			// 
			// readLoggerTimer
			// 
			this.readLoggerTimer.Interval = 300;
			this.readLoggerTimer.Tick += new System.EventHandler(this.readLoggerTimer_Tick);
			// 
			// initLoggerTimer
			// 
			this.initLoggerTimer.Interval = 300;
			this.initLoggerTimer.Tick += new System.EventHandler(this.initLoggerTimer_Tick);
			// 
			// logTextBox
			// 
			this.logTextBox.Location = new System.Drawing.Point(20, 673);
			this.logTextBox.Multiline = true;
			this.logTextBox.Name = "logTextBox";
			this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.logTextBox.Size = new System.Drawing.Size(935, 40);
			this.logTextBox.TabIndex = 42;
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
			this.addGauge8.Location = new System.Drawing.Point(879, 531);
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
			this.addGauge8.Size = new System.Drawing.Size(95, 140);
			this.addGauge8.TabIndex = 32;
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
			this.addGauge7.Location = new System.Drawing.Point(756, 531);
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
			this.addGauge7.Size = new System.Drawing.Size(95, 140);
			this.addGauge7.TabIndex = 31;
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
			this.addGauge6.Location = new System.Drawing.Point(633, 531);
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
			this.addGauge6.Size = new System.Drawing.Size(95, 140);
			this.addGauge6.TabIndex = 30;
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
			this.addGauge5.Location = new System.Drawing.Point(510, 531);
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
			this.addGauge5.Size = new System.Drawing.Size(95, 140);
			this.addGauge5.TabIndex = 29;
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
			this.addGauge4.Location = new System.Drawing.Point(382, 531);
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
			this.addGauge4.TabIndex = 28;
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
			this.addGauge3.Location = new System.Drawing.Point(264, 531);
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
			this.addGauge3.TabIndex = 27;
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
			this.addGauge2.Location = new System.Drawing.Point(141, 531);
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
			this.addGauge2.Size = new System.Drawing.Size(95, 140);
			this.addGauge2.TabIndex = 26;
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
			this.addGauge1.Location = new System.Drawing.Point(18, 531);
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
			this.addGauge1.Size = new System.Drawing.Size(95, 140);
			this.addGauge1.TabIndex = 25;
			this.addGauge1.Text = "aGauge13";
			this.addGauge1.Value = 0F;
			// 
			// aGauge12
			// 
			this.aGauge12.BaseArcColor = System.Drawing.Color.Gray;
			this.aGauge12.BaseArcRadius = 105;
			this.aGauge12.BaseArcStart = 180;
			this.aGauge12.BaseArcSweep = 120;
			this.aGauge12.BaseArcWidth = 2;
			this.aGauge12.Cap_Idx = ((byte)(1));
			this.aGauge12.CapColors = new System.Drawing.Color[] {
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black};
			this.aGauge12.CapPosition = new System.Drawing.Point(20, 110);
			this.aGauge12.CapsPosition = new System.Drawing.Point[] {
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(20, 110),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10)};
			this.aGauge12.CapsText = new string[] {
		"",
		"Exh. Temp 8",
		"",
		"",
		""};
			this.aGauge12.CapText = "Exh. Temp 8";
			this.aGauge12.Center = new System.Drawing.Point(110, 110);
			this.aGauge12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aGauge12.Location = new System.Drawing.Point(780, 268);
			this.aGauge12.MaxValue = 1000F;
			this.aGauge12.MinValue = 0F;
			this.aGauge12.Name = "aGauge12";
			this.aGauge12.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
			this.aGauge12.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.aGauge12.NeedleRadius = 95;
			this.aGauge12.NeedleType = 0;
			this.aGauge12.NeedleWidth = 2;
			this.aGauge12.Range_Idx = ((byte)(2));
			this.aGauge12.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.aGauge12.RangeEnabled = true;
			this.aGauge12.RangeEndValue = 1000F;
			this.aGauge12.RangeInnerRadius = 75;
			this.aGauge12.RangeOuterRadius = 85;
			this.aGauge12.RangesColor = new System.Drawing.Color[] {
		System.Drawing.Color.PaleTurquoise,
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
		System.Drawing.Color.Red,
		System.Drawing.SystemColors.Control};
			this.aGauge12.RangesEnabled = new bool[] {
		true,
		true,
		true,
		false,
		false};
			this.aGauge12.RangesEndValue = new float[] {
		250F,
		800F,
		1000F,
		1000F,
		0F};
			this.aGauge12.RangesInnerRadius = new int[] {
		75,
		75,
		75,
		70,
		70};
			this.aGauge12.RangesOuterRadius = new int[] {
		85,
		85,
		85,
		80,
		80};
			this.aGauge12.RangesStartValue = new float[] {
		0F,
		251F,
		800F,
		800F,
		0F};
			this.aGauge12.RangeStartValue = 800F;
			this.aGauge12.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.aGauge12.ScaleLinesInterInnerRadius = 75;
			this.aGauge12.ScaleLinesInterOuterRadius = 82;
			this.aGauge12.ScaleLinesInterWidth = 1;
			this.aGauge12.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.aGauge12.ScaleLinesMajorInnerRadius = 75;
			this.aGauge12.ScaleLinesMajorOuterRadius = 85;
			this.aGauge12.ScaleLinesMajorStepValue = 200F;
			this.aGauge12.ScaleLinesMajorWidth = 2;
			this.aGauge12.ScaleLinesMinorColor = System.Drawing.Color.Black;
			this.aGauge12.ScaleLinesMinorInnerRadius = 75;
			this.aGauge12.ScaleLinesMinorNumOf = 7;
			this.aGauge12.ScaleLinesMinorOuterRadius = 80;
			this.aGauge12.ScaleLinesMinorWidth = 1;
			this.aGauge12.ScaleNumbersColor = System.Drawing.Color.Black;
			this.aGauge12.ScaleNumbersFormat = null;
			this.aGauge12.ScaleNumbersRadius = 95;
			this.aGauge12.ScaleNumbersRotation = 90;
			this.aGauge12.ScaleNumbersStartScaleLine = 0;
			this.aGauge12.ScaleNumbersStepScaleLines = 1;
			this.aGauge12.Size = new System.Drawing.Size(175, 130);
			this.aGauge12.TabIndex = 20;
			this.aGauge12.Text = "aGauge12";
			this.aGauge12.Value = 0F;
			// 
			// aGauge11
			// 
			this.aGauge11.BaseArcColor = System.Drawing.Color.Gray;
			this.aGauge11.BaseArcRadius = 105;
			this.aGauge11.BaseArcStart = 180;
			this.aGauge11.BaseArcSweep = 120;
			this.aGauge11.BaseArcWidth = 2;
			this.aGauge11.Cap_Idx = ((byte)(1));
			this.aGauge11.CapColors = new System.Drawing.Color[] {
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black};
			this.aGauge11.CapPosition = new System.Drawing.Point(20, 110);
			this.aGauge11.CapsPosition = new System.Drawing.Point[] {
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(20, 110),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10)};
			this.aGauge11.CapsText = new string[] {
		"",
		"Exh. Temp 7",
		"",
		"",
		""};
			this.aGauge11.CapText = "Exh. Temp 7";
			this.aGauge11.Center = new System.Drawing.Point(110, 110);
			this.aGauge11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aGauge11.Location = new System.Drawing.Point(680, 399);
			this.aGauge11.MaxValue = 1000F;
			this.aGauge11.MinValue = 0F;
			this.aGauge11.Name = "aGauge11";
			this.aGauge11.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
			this.aGauge11.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.aGauge11.NeedleRadius = 95;
			this.aGauge11.NeedleType = 0;
			this.aGauge11.NeedleWidth = 2;
			this.aGauge11.Range_Idx = ((byte)(2));
			this.aGauge11.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.aGauge11.RangeEnabled = true;
			this.aGauge11.RangeEndValue = 1000F;
			this.aGauge11.RangeInnerRadius = 75;
			this.aGauge11.RangeOuterRadius = 85;
			this.aGauge11.RangesColor = new System.Drawing.Color[] {
		System.Drawing.Color.PaleTurquoise,
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
		System.Drawing.Color.Red,
		System.Drawing.SystemColors.Control};
			this.aGauge11.RangesEnabled = new bool[] {
		true,
		true,
		true,
		false,
		false};
			this.aGauge11.RangesEndValue = new float[] {
		250F,
		800F,
		1000F,
		1000F,
		0F};
			this.aGauge11.RangesInnerRadius = new int[] {
		75,
		75,
		75,
		70,
		70};
			this.aGauge11.RangesOuterRadius = new int[] {
		85,
		85,
		85,
		80,
		80};
			this.aGauge11.RangesStartValue = new float[] {
		0F,
		251F,
		800F,
		800F,
		0F};
			this.aGauge11.RangeStartValue = 800F;
			this.aGauge11.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.aGauge11.ScaleLinesInterInnerRadius = 75;
			this.aGauge11.ScaleLinesInterOuterRadius = 82;
			this.aGauge11.ScaleLinesInterWidth = 1;
			this.aGauge11.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.aGauge11.ScaleLinesMajorInnerRadius = 75;
			this.aGauge11.ScaleLinesMajorOuterRadius = 85;
			this.aGauge11.ScaleLinesMajorStepValue = 200F;
			this.aGauge11.ScaleLinesMajorWidth = 2;
			this.aGauge11.ScaleLinesMinorColor = System.Drawing.Color.Black;
			this.aGauge11.ScaleLinesMinorInnerRadius = 75;
			this.aGauge11.ScaleLinesMinorNumOf = 7;
			this.aGauge11.ScaleLinesMinorOuterRadius = 80;
			this.aGauge11.ScaleLinesMinorWidth = 1;
			this.aGauge11.ScaleNumbersColor = System.Drawing.Color.Black;
			this.aGauge11.ScaleNumbersFormat = null;
			this.aGauge11.ScaleNumbersRadius = 95;
			this.aGauge11.ScaleNumbersRotation = 90;
			this.aGauge11.ScaleNumbersStartScaleLine = 0;
			this.aGauge11.ScaleNumbersStepScaleLines = 1;
			this.aGauge11.Size = new System.Drawing.Size(175, 130);
			this.aGauge11.TabIndex = 24;
			this.aGauge11.Text = "aGauge11";
			this.aGauge11.Value = 0F;
			// 
			// aGauge10
			// 
			this.aGauge10.BaseArcColor = System.Drawing.Color.Gray;
			this.aGauge10.BaseArcRadius = 105;
			this.aGauge10.BaseArcStart = 180;
			this.aGauge10.BaseArcSweep = 120;
			this.aGauge10.BaseArcWidth = 2;
			this.aGauge10.Cap_Idx = ((byte)(1));
			this.aGauge10.CapColors = new System.Drawing.Color[] {
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black};
			this.aGauge10.CapPosition = new System.Drawing.Point(20, 110);
			this.aGauge10.CapsPosition = new System.Drawing.Point[] {
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(20, 110),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10)};
			this.aGauge10.CapsText = new string[] {
		"",
		"Exh. Temp 6",
		"",
		"",
		""};
			this.aGauge10.CapText = "Exh. Temp 6";
			this.aGauge10.Center = new System.Drawing.Point(110, 110);
			this.aGauge10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aGauge10.Location = new System.Drawing.Point(560, 268);
			this.aGauge10.MaxValue = 1000F;
			this.aGauge10.MinValue = 0F;
			this.aGauge10.Name = "aGauge10";
			this.aGauge10.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
			this.aGauge10.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.aGauge10.NeedleRadius = 95;
			this.aGauge10.NeedleType = 0;
			this.aGauge10.NeedleWidth = 2;
			this.aGauge10.Range_Idx = ((byte)(2));
			this.aGauge10.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.aGauge10.RangeEnabled = true;
			this.aGauge10.RangeEndValue = 1000F;
			this.aGauge10.RangeInnerRadius = 75;
			this.aGauge10.RangeOuterRadius = 85;
			this.aGauge10.RangesColor = new System.Drawing.Color[] {
		System.Drawing.Color.PaleTurquoise,
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
		System.Drawing.Color.Red,
		System.Drawing.SystemColors.Control};
			this.aGauge10.RangesEnabled = new bool[] {
		true,
		true,
		true,
		false,
		false};
			this.aGauge10.RangesEndValue = new float[] {
		250F,
		800F,
		1000F,
		1000F,
		0F};
			this.aGauge10.RangesInnerRadius = new int[] {
		75,
		75,
		75,
		70,
		70};
			this.aGauge10.RangesOuterRadius = new int[] {
		85,
		85,
		85,
		80,
		80};
			this.aGauge10.RangesStartValue = new float[] {
		0F,
		251F,
		800F,
		800F,
		0F};
			this.aGauge10.RangeStartValue = 800F;
			this.aGauge10.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.aGauge10.ScaleLinesInterInnerRadius = 75;
			this.aGauge10.ScaleLinesInterOuterRadius = 82;
			this.aGauge10.ScaleLinesInterWidth = 1;
			this.aGauge10.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.aGauge10.ScaleLinesMajorInnerRadius = 75;
			this.aGauge10.ScaleLinesMajorOuterRadius = 85;
			this.aGauge10.ScaleLinesMajorStepValue = 200F;
			this.aGauge10.ScaleLinesMajorWidth = 2;
			this.aGauge10.ScaleLinesMinorColor = System.Drawing.Color.Black;
			this.aGauge10.ScaleLinesMinorInnerRadius = 75;
			this.aGauge10.ScaleLinesMinorNumOf = 7;
			this.aGauge10.ScaleLinesMinorOuterRadius = 80;
			this.aGauge10.ScaleLinesMinorWidth = 1;
			this.aGauge10.ScaleNumbersColor = System.Drawing.Color.Black;
			this.aGauge10.ScaleNumbersFormat = null;
			this.aGauge10.ScaleNumbersRadius = 95;
			this.aGauge10.ScaleNumbersRotation = 90;
			this.aGauge10.ScaleNumbersStartScaleLine = 0;
			this.aGauge10.ScaleNumbersStepScaleLines = 1;
			this.aGauge10.Size = new System.Drawing.Size(175, 130);
			this.aGauge10.TabIndex = 19;
			this.aGauge10.Text = "aGauge10";
			this.aGauge10.Value = 0F;
			// 
			// aGauge9
			// 
			this.aGauge9.BaseArcColor = System.Drawing.Color.Gray;
			this.aGauge9.BaseArcRadius = 105;
			this.aGauge9.BaseArcStart = 180;
			this.aGauge9.BaseArcSweep = 120;
			this.aGauge9.BaseArcWidth = 2;
			this.aGauge9.Cap_Idx = ((byte)(1));
			this.aGauge9.CapColors = new System.Drawing.Color[] {
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black};
			this.aGauge9.CapPosition = new System.Drawing.Point(20, 110);
			this.aGauge9.CapsPosition = new System.Drawing.Point[] {
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(20, 110),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10)};
			this.aGauge9.CapsText = new string[] {
		"",
		"Exh. Temp 5",
		"",
		"",
		""};
			this.aGauge9.CapText = "Exh. Temp 5";
			this.aGauge9.Center = new System.Drawing.Point(110, 110);
			this.aGauge9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aGauge9.Location = new System.Drawing.Point(460, 399);
			this.aGauge9.MaxValue = 1000F;
			this.aGauge9.MinValue = 0F;
			this.aGauge9.Name = "aGauge9";
			this.aGauge9.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
			this.aGauge9.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.aGauge9.NeedleRadius = 95;
			this.aGauge9.NeedleType = 0;
			this.aGauge9.NeedleWidth = 2;
			this.aGauge9.Range_Idx = ((byte)(2));
			this.aGauge9.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.aGauge9.RangeEnabled = true;
			this.aGauge9.RangeEndValue = 1000F;
			this.aGauge9.RangeInnerRadius = 75;
			this.aGauge9.RangeOuterRadius = 85;
			this.aGauge9.RangesColor = new System.Drawing.Color[] {
		System.Drawing.Color.PaleTurquoise,
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
		System.Drawing.Color.Red,
		System.Drawing.SystemColors.Control};
			this.aGauge9.RangesEnabled = new bool[] {
		true,
		true,
		true,
		false,
		false};
			this.aGauge9.RangesEndValue = new float[] {
		250F,
		800F,
		1000F,
		1000F,
		0F};
			this.aGauge9.RangesInnerRadius = new int[] {
		75,
		75,
		75,
		70,
		70};
			this.aGauge9.RangesOuterRadius = new int[] {
		85,
		85,
		85,
		80,
		80};
			this.aGauge9.RangesStartValue = new float[] {
		0F,
		251F,
		800F,
		800F,
		0F};
			this.aGauge9.RangeStartValue = 800F;
			this.aGauge9.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.aGauge9.ScaleLinesInterInnerRadius = 75;
			this.aGauge9.ScaleLinesInterOuterRadius = 82;
			this.aGauge9.ScaleLinesInterWidth = 1;
			this.aGauge9.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.aGauge9.ScaleLinesMajorInnerRadius = 75;
			this.aGauge9.ScaleLinesMajorOuterRadius = 85;
			this.aGauge9.ScaleLinesMajorStepValue = 200F;
			this.aGauge9.ScaleLinesMajorWidth = 2;
			this.aGauge9.ScaleLinesMinorColor = System.Drawing.Color.Black;
			this.aGauge9.ScaleLinesMinorInnerRadius = 75;
			this.aGauge9.ScaleLinesMinorNumOf = 7;
			this.aGauge9.ScaleLinesMinorOuterRadius = 80;
			this.aGauge9.ScaleLinesMinorWidth = 1;
			this.aGauge9.ScaleNumbersColor = System.Drawing.Color.Black;
			this.aGauge9.ScaleNumbersFormat = null;
			this.aGauge9.ScaleNumbersRadius = 95;
			this.aGauge9.ScaleNumbersRotation = 90;
			this.aGauge9.ScaleNumbersStartScaleLine = 0;
			this.aGauge9.ScaleNumbersStepScaleLines = 1;
			this.aGauge9.Size = new System.Drawing.Size(175, 130);
			this.aGauge9.TabIndex = 23;
			this.aGauge9.Text = "aGauge9";
			this.aGauge9.Value = 0F;
			// 
			// aGauge8
			// 
			this.aGauge8.BaseArcColor = System.Drawing.Color.Gray;
			this.aGauge8.BaseArcRadius = 105;
			this.aGauge8.BaseArcStart = 180;
			this.aGauge8.BaseArcSweep = 120;
			this.aGauge8.BaseArcWidth = 2;
			this.aGauge8.Cap_Idx = ((byte)(1));
			this.aGauge8.CapColors = new System.Drawing.Color[] {
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black};
			this.aGauge8.CapPosition = new System.Drawing.Point(20, 110);
			this.aGauge8.CapsPosition = new System.Drawing.Point[] {
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(20, 110),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10)};
			this.aGauge8.CapsText = new string[] {
		"",
		"Exh. Temp 4",
		"",
		"",
		""};
			this.aGauge8.CapText = "Exh. Temp 4";
			this.aGauge8.Center = new System.Drawing.Point(110, 110);
			this.aGauge8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aGauge8.Location = new System.Drawing.Point(340, 268);
			this.aGauge8.MaxValue = 1000F;
			this.aGauge8.MinValue = 0F;
			this.aGauge8.Name = "aGauge8";
			this.aGauge8.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
			this.aGauge8.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.aGauge8.NeedleRadius = 95;
			this.aGauge8.NeedleType = 0;
			this.aGauge8.NeedleWidth = 2;
			this.aGauge8.Range_Idx = ((byte)(2));
			this.aGauge8.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.aGauge8.RangeEnabled = true;
			this.aGauge8.RangeEndValue = 1000F;
			this.aGauge8.RangeInnerRadius = 75;
			this.aGauge8.RangeOuterRadius = 85;
			this.aGauge8.RangesColor = new System.Drawing.Color[] {
		System.Drawing.Color.PaleTurquoise,
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
		System.Drawing.Color.Red,
		System.Drawing.SystemColors.Control};
			this.aGauge8.RangesEnabled = new bool[] {
		true,
		true,
		true,
		false,
		false};
			this.aGauge8.RangesEndValue = new float[] {
		250F,
		800F,
		1000F,
		1000F,
		0F};
			this.aGauge8.RangesInnerRadius = new int[] {
		75,
		75,
		75,
		70,
		70};
			this.aGauge8.RangesOuterRadius = new int[] {
		85,
		85,
		85,
		80,
		80};
			this.aGauge8.RangesStartValue = new float[] {
		0F,
		251F,
		800F,
		800F,
		0F};
			this.aGauge8.RangeStartValue = 800F;
			this.aGauge8.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.aGauge8.ScaleLinesInterInnerRadius = 75;
			this.aGauge8.ScaleLinesInterOuterRadius = 82;
			this.aGauge8.ScaleLinesInterWidth = 1;
			this.aGauge8.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.aGauge8.ScaleLinesMajorInnerRadius = 75;
			this.aGauge8.ScaleLinesMajorOuterRadius = 85;
			this.aGauge8.ScaleLinesMajorStepValue = 200F;
			this.aGauge8.ScaleLinesMajorWidth = 2;
			this.aGauge8.ScaleLinesMinorColor = System.Drawing.Color.Black;
			this.aGauge8.ScaleLinesMinorInnerRadius = 75;
			this.aGauge8.ScaleLinesMinorNumOf = 7;
			this.aGauge8.ScaleLinesMinorOuterRadius = 80;
			this.aGauge8.ScaleLinesMinorWidth = 1;
			this.aGauge8.ScaleNumbersColor = System.Drawing.Color.Black;
			this.aGauge8.ScaleNumbersFormat = null;
			this.aGauge8.ScaleNumbersRadius = 95;
			this.aGauge8.ScaleNumbersRotation = 90;
			this.aGauge8.ScaleNumbersStartScaleLine = 0;
			this.aGauge8.ScaleNumbersStepScaleLines = 1;
			this.aGauge8.Size = new System.Drawing.Size(175, 130);
			this.aGauge8.TabIndex = 18;
			this.aGauge8.Text = "aGauge8";
			this.aGauge8.Value = 0F;
			// 
			// aGauge7
			// 
			this.aGauge7.BaseArcColor = System.Drawing.Color.Gray;
			this.aGauge7.BaseArcRadius = 105;
			this.aGauge7.BaseArcStart = 180;
			this.aGauge7.BaseArcSweep = 120;
			this.aGauge7.BaseArcWidth = 2;
			this.aGauge7.Cap_Idx = ((byte)(1));
			this.aGauge7.CapColors = new System.Drawing.Color[] {
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black};
			this.aGauge7.CapPosition = new System.Drawing.Point(20, 110);
			this.aGauge7.CapsPosition = new System.Drawing.Point[] {
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(20, 110),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10)};
			this.aGauge7.CapsText = new string[] {
		"",
		"Exh. Temp 3",
		"",
		"",
		""};
			this.aGauge7.CapText = "Exh. Temp 3";
			this.aGauge7.Center = new System.Drawing.Point(110, 110);
			this.aGauge7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aGauge7.Location = new System.Drawing.Point(240, 399);
			this.aGauge7.MaxValue = 1000F;
			this.aGauge7.MinValue = 0F;
			this.aGauge7.Name = "aGauge7";
			this.aGauge7.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
			this.aGauge7.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.aGauge7.NeedleRadius = 95;
			this.aGauge7.NeedleType = 0;
			this.aGauge7.NeedleWidth = 2;
			this.aGauge7.Range_Idx = ((byte)(2));
			this.aGauge7.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.aGauge7.RangeEnabled = true;
			this.aGauge7.RangeEndValue = 1000F;
			this.aGauge7.RangeInnerRadius = 75;
			this.aGauge7.RangeOuterRadius = 85;
			this.aGauge7.RangesColor = new System.Drawing.Color[] {
		System.Drawing.Color.PaleTurquoise,
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
		System.Drawing.Color.Red,
		System.Drawing.SystemColors.Control};
			this.aGauge7.RangesEnabled = new bool[] {
		true,
		true,
		true,
		false,
		false};
			this.aGauge7.RangesEndValue = new float[] {
		250F,
		800F,
		1000F,
		1000F,
		0F};
			this.aGauge7.RangesInnerRadius = new int[] {
		75,
		75,
		75,
		70,
		70};
			this.aGauge7.RangesOuterRadius = new int[] {
		85,
		85,
		85,
		80,
		80};
			this.aGauge7.RangesStartValue = new float[] {
		0F,
		251F,
		800F,
		800F,
		0F};
			this.aGauge7.RangeStartValue = 800F;
			this.aGauge7.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.aGauge7.ScaleLinesInterInnerRadius = 75;
			this.aGauge7.ScaleLinesInterOuterRadius = 82;
			this.aGauge7.ScaleLinesInterWidth = 1;
			this.aGauge7.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.aGauge7.ScaleLinesMajorInnerRadius = 75;
			this.aGauge7.ScaleLinesMajorOuterRadius = 85;
			this.aGauge7.ScaleLinesMajorStepValue = 200F;
			this.aGauge7.ScaleLinesMajorWidth = 2;
			this.aGauge7.ScaleLinesMinorColor = System.Drawing.Color.Black;
			this.aGauge7.ScaleLinesMinorInnerRadius = 75;
			this.aGauge7.ScaleLinesMinorNumOf = 7;
			this.aGauge7.ScaleLinesMinorOuterRadius = 80;
			this.aGauge7.ScaleLinesMinorWidth = 1;
			this.aGauge7.ScaleNumbersColor = System.Drawing.Color.Black;
			this.aGauge7.ScaleNumbersFormat = null;
			this.aGauge7.ScaleNumbersRadius = 95;
			this.aGauge7.ScaleNumbersRotation = 90;
			this.aGauge7.ScaleNumbersStartScaleLine = 0;
			this.aGauge7.ScaleNumbersStepScaleLines = 1;
			this.aGauge7.Size = new System.Drawing.Size(175, 130);
			this.aGauge7.TabIndex = 22;
			this.aGauge7.Text = "aGauge7";
			this.aGauge7.Value = 0F;
			// 
			// aGauge6
			// 
			this.aGauge6.BaseArcColor = System.Drawing.Color.Gray;
			this.aGauge6.BaseArcRadius = 105;
			this.aGauge6.BaseArcStart = 180;
			this.aGauge6.BaseArcSweep = 120;
			this.aGauge6.BaseArcWidth = 2;
			this.aGauge6.Cap_Idx = ((byte)(1));
			this.aGauge6.CapColors = new System.Drawing.Color[] {
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black};
			this.aGauge6.CapPosition = new System.Drawing.Point(20, 110);
			this.aGauge6.CapsPosition = new System.Drawing.Point[] {
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(20, 110),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10)};
			this.aGauge6.CapsText = new string[] {
		"",
		"Exh. Temp 2",
		"",
		"",
		""};
			this.aGauge6.CapText = "Exh. Temp 2";
			this.aGauge6.Center = new System.Drawing.Point(110, 110);
			this.aGauge6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aGauge6.Location = new System.Drawing.Point(120, 268);
			this.aGauge6.MaxValue = 1000F;
			this.aGauge6.MinValue = 0F;
			this.aGauge6.Name = "aGauge6";
			this.aGauge6.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
			this.aGauge6.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.aGauge6.NeedleRadius = 95;
			this.aGauge6.NeedleType = 0;
			this.aGauge6.NeedleWidth = 2;
			this.aGauge6.Range_Idx = ((byte)(2));
			this.aGauge6.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.aGauge6.RangeEnabled = true;
			this.aGauge6.RangeEndValue = 1000F;
			this.aGauge6.RangeInnerRadius = 75;
			this.aGauge6.RangeOuterRadius = 85;
			this.aGauge6.RangesColor = new System.Drawing.Color[] {
		System.Drawing.Color.PaleTurquoise,
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
		System.Drawing.Color.Red,
		System.Drawing.SystemColors.Control};
			this.aGauge6.RangesEnabled = new bool[] {
		true,
		true,
		true,
		false,
		false};
			this.aGauge6.RangesEndValue = new float[] {
		250F,
		800F,
		1000F,
		1000F,
		0F};
			this.aGauge6.RangesInnerRadius = new int[] {
		75,
		75,
		75,
		70,
		70};
			this.aGauge6.RangesOuterRadius = new int[] {
		85,
		85,
		85,
		80,
		80};
			this.aGauge6.RangesStartValue = new float[] {
		0F,
		251F,
		800F,
		800F,
		0F};
			this.aGauge6.RangeStartValue = 800F;
			this.aGauge6.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.aGauge6.ScaleLinesInterInnerRadius = 75;
			this.aGauge6.ScaleLinesInterOuterRadius = 82;
			this.aGauge6.ScaleLinesInterWidth = 1;
			this.aGauge6.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.aGauge6.ScaleLinesMajorInnerRadius = 75;
			this.aGauge6.ScaleLinesMajorOuterRadius = 85;
			this.aGauge6.ScaleLinesMajorStepValue = 200F;
			this.aGauge6.ScaleLinesMajorWidth = 2;
			this.aGauge6.ScaleLinesMinorColor = System.Drawing.Color.Black;
			this.aGauge6.ScaleLinesMinorInnerRadius = 75;
			this.aGauge6.ScaleLinesMinorNumOf = 7;
			this.aGauge6.ScaleLinesMinorOuterRadius = 80;
			this.aGauge6.ScaleLinesMinorWidth = 1;
			this.aGauge6.ScaleNumbersColor = System.Drawing.Color.Black;
			this.aGauge6.ScaleNumbersFormat = null;
			this.aGauge6.ScaleNumbersRadius = 95;
			this.aGauge6.ScaleNumbersRotation = 90;
			this.aGauge6.ScaleNumbersStartScaleLine = 0;
			this.aGauge6.ScaleNumbersStepScaleLines = 1;
			this.aGauge6.Size = new System.Drawing.Size(175, 130);
			this.aGauge6.TabIndex = 17;
			this.aGauge6.Text = "aGauge6";
			this.aGauge6.Value = 0F;
			// 
			// aGauge5
			// 
			this.aGauge5.BaseArcColor = System.Drawing.Color.Gray;
			this.aGauge5.BaseArcRadius = 105;
			this.aGauge5.BaseArcStart = 180;
			this.aGauge5.BaseArcSweep = 120;
			this.aGauge5.BaseArcWidth = 2;
			this.aGauge5.Cap_Idx = ((byte)(1));
			this.aGauge5.CapColors = new System.Drawing.Color[] {
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black};
			this.aGauge5.CapPosition = new System.Drawing.Point(20, 110);
			this.aGauge5.CapsPosition = new System.Drawing.Point[] {
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(20, 110),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10)};
			this.aGauge5.CapsText = new string[] {
		"",
		"Exh. Temp 1",
		"",
		"",
		""};
			this.aGauge5.CapText = "Exh. Temp 1";
			this.aGauge5.Center = new System.Drawing.Point(110, 110);
			this.aGauge5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aGauge5.Location = new System.Drawing.Point(20, 399);
			this.aGauge5.MaxValue = 1000F;
			this.aGauge5.MinValue = 0F;
			this.aGauge5.Name = "aGauge5";
			this.aGauge5.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
			this.aGauge5.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.aGauge5.NeedleRadius = 95;
			this.aGauge5.NeedleType = 0;
			this.aGauge5.NeedleWidth = 2;
			this.aGauge5.Range_Idx = ((byte)(2));
			this.aGauge5.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.aGauge5.RangeEnabled = true;
			this.aGauge5.RangeEndValue = 1000F;
			this.aGauge5.RangeInnerRadius = 75;
			this.aGauge5.RangeOuterRadius = 85;
			this.aGauge5.RangesColor = new System.Drawing.Color[] {
		System.Drawing.Color.PaleTurquoise,
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
		System.Drawing.Color.Red,
		System.Drawing.SystemColors.Control};
			this.aGauge5.RangesEnabled = new bool[] {
		true,
		true,
		true,
		false,
		false};
			this.aGauge5.RangesEndValue = new float[] {
		250F,
		800F,
		1000F,
		1000F,
		0F};
			this.aGauge5.RangesInnerRadius = new int[] {
		75,
		75,
		75,
		70,
		70};
			this.aGauge5.RangesOuterRadius = new int[] {
		85,
		85,
		85,
		80,
		80};
			this.aGauge5.RangesStartValue = new float[] {
		0F,
		251F,
		800F,
		800F,
		0F};
			this.aGauge5.RangeStartValue = 800F;
			this.aGauge5.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.aGauge5.ScaleLinesInterInnerRadius = 75;
			this.aGauge5.ScaleLinesInterOuterRadius = 82;
			this.aGauge5.ScaleLinesInterWidth = 1;
			this.aGauge5.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.aGauge5.ScaleLinesMajorInnerRadius = 75;
			this.aGauge5.ScaleLinesMajorOuterRadius = 85;
			this.aGauge5.ScaleLinesMajorStepValue = 200F;
			this.aGauge5.ScaleLinesMajorWidth = 2;
			this.aGauge5.ScaleLinesMinorColor = System.Drawing.Color.Black;
			this.aGauge5.ScaleLinesMinorInnerRadius = 75;
			this.aGauge5.ScaleLinesMinorNumOf = 7;
			this.aGauge5.ScaleLinesMinorOuterRadius = 80;
			this.aGauge5.ScaleLinesMinorWidth = 1;
			this.aGauge5.ScaleNumbersColor = System.Drawing.Color.Black;
			this.aGauge5.ScaleNumbersFormat = null;
			this.aGauge5.ScaleNumbersRadius = 95;
			this.aGauge5.ScaleNumbersRotation = 90;
			this.aGauge5.ScaleNumbersStartScaleLine = 0;
			this.aGauge5.ScaleNumbersStepScaleLines = 1;
			this.aGauge5.Size = new System.Drawing.Size(175, 130);
			this.aGauge5.TabIndex = 21;
			this.aGauge5.Text = "aGauge5";
			this.aGauge5.Value = 0F;
			// 
			// aGauge4
			// 
			this.aGauge4.BaseArcColor = System.Drawing.Color.Gray;
			this.aGauge4.BaseArcRadius = 109;
			this.aGauge4.BaseArcStart = 135;
			this.aGauge4.BaseArcSweep = 270;
			this.aGauge4.BaseArcWidth = 2;
			this.aGauge4.Cap_Idx = ((byte)(1));
			this.aGauge4.CapColors = new System.Drawing.Color[] {
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black};
			this.aGauge4.CapPosition = new System.Drawing.Point(90, 150);
			this.aGauge4.CapsPosition = new System.Drawing.Point[] {
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(90, 150),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10)};
			this.aGauge4.CapsText = new string[] {
		"",
		"RPM 4",
		"",
		"",
		""};
			this.aGauge4.CapText = "RPM 4";
			this.aGauge4.Center = new System.Drawing.Point(110, 110);
			this.aGauge4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aGauge4.Location = new System.Drawing.Point(760, 8);
			this.aGauge4.MaxValue = 10000F;
			this.aGauge4.MinValue = 0F;
			this.aGauge4.Name = "aGauge4";
			this.aGauge4.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Yellow;
			this.aGauge4.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.aGauge4.NeedleRadius = 95;
			this.aGauge4.NeedleType = 0;
			this.aGauge4.NeedleWidth = 2;
			this.aGauge4.Range_Idx = ((byte)(1));
			this.aGauge4.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.aGauge4.RangeEnabled = true;
			this.aGauge4.RangeEndValue = 10000F;
			this.aGauge4.RangeInnerRadius = 75;
			this.aGauge4.RangeOuterRadius = 85;
			this.aGauge4.RangesColor = new System.Drawing.Color[] {
		System.Drawing.Color.LightGreen,
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
		System.Drawing.SystemColors.Control,
		System.Drawing.SystemColors.Control,
		System.Drawing.SystemColors.Control};
			this.aGauge4.RangesEnabled = new bool[] {
		true,
		true,
		false,
		false,
		false};
			this.aGauge4.RangesEndValue = new float[] {
		8000F,
		10000F,
		0F,
		0F,
		0F};
			this.aGauge4.RangesInnerRadius = new int[] {
		75,
		75,
		75,
		70,
		70};
			this.aGauge4.RangesOuterRadius = new int[] {
		85,
		85,
		85,
		80,
		80};
			this.aGauge4.RangesStartValue = new float[] {
		0F,
		8000F,
		0F,
		0F,
		0F};
			this.aGauge4.RangeStartValue = 8000F;
			this.aGauge4.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.aGauge4.ScaleLinesInterInnerRadius = 80;
			this.aGauge4.ScaleLinesInterOuterRadius = 90;
			this.aGauge4.ScaleLinesInterWidth = 1;
			this.aGauge4.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.aGauge4.ScaleLinesMajorInnerRadius = 70;
			this.aGauge4.ScaleLinesMajorOuterRadius = 90;
			this.aGauge4.ScaleLinesMajorStepValue = 2000F;
			this.aGauge4.ScaleLinesMajorWidth = 2;
			this.aGauge4.ScaleLinesMinorColor = System.Drawing.Color.Black;
			this.aGauge4.ScaleLinesMinorInnerRadius = 85;
			this.aGauge4.ScaleLinesMinorNumOf = 9;
			this.aGauge4.ScaleLinesMinorOuterRadius = 90;
			this.aGauge4.ScaleLinesMinorWidth = 1;
			this.aGauge4.ScaleNumbersColor = System.Drawing.Color.Black;
			this.aGauge4.ScaleNumbersFormat = null;
			this.aGauge4.ScaleNumbersRadius = 100;
			this.aGauge4.ScaleNumbersRotation = 90;
			this.aGauge4.ScaleNumbersStartScaleLine = 0;
			this.aGauge4.ScaleNumbersStepScaleLines = 1;
			this.aGauge4.Size = new System.Drawing.Size(220, 200);
			this.aGauge4.TabIndex = 10;
			this.aGauge4.Text = "aGauge4";
			this.aGauge4.Value = 0F;
			// 
			// aGauge3
			// 
			this.aGauge3.BaseArcColor = System.Drawing.Color.Gray;
			this.aGauge3.BaseArcRadius = 109;
			this.aGauge3.BaseArcStart = 135;
			this.aGauge3.BaseArcSweep = 270;
			this.aGauge3.BaseArcWidth = 2;
			this.aGauge3.Cap_Idx = ((byte)(1));
			this.aGauge3.CapColors = new System.Drawing.Color[] {
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black};
			this.aGauge3.CapPosition = new System.Drawing.Point(90, 150);
			this.aGauge3.CapsPosition = new System.Drawing.Point[] {
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(90, 150),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10)};
			this.aGauge3.CapsText = new string[] {
		"",
		"RPM 3",
		"",
		"",
		""};
			this.aGauge3.CapText = "RPM 3";
			this.aGauge3.Center = new System.Drawing.Point(110, 110);
			this.aGauge3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aGauge3.Location = new System.Drawing.Point(510, 8);
			this.aGauge3.MaxValue = 10000F;
			this.aGauge3.MinValue = 0F;
			this.aGauge3.Name = "aGauge3";
			this.aGauge3.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Yellow;
			this.aGauge3.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.aGauge3.NeedleRadius = 95;
			this.aGauge3.NeedleType = 0;
			this.aGauge3.NeedleWidth = 2;
			this.aGauge3.Range_Idx = ((byte)(1));
			this.aGauge3.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.aGauge3.RangeEnabled = true;
			this.aGauge3.RangeEndValue = 10000F;
			this.aGauge3.RangeInnerRadius = 75;
			this.aGauge3.RangeOuterRadius = 85;
			this.aGauge3.RangesColor = new System.Drawing.Color[] {
		System.Drawing.Color.LightGreen,
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
		System.Drawing.SystemColors.Control,
		System.Drawing.SystemColors.Control,
		System.Drawing.SystemColors.Control};
			this.aGauge3.RangesEnabled = new bool[] {
		true,
		true,
		false,
		false,
		false};
			this.aGauge3.RangesEndValue = new float[] {
		8000F,
		10000F,
		0F,
		0F,
		0F};
			this.aGauge3.RangesInnerRadius = new int[] {
		75,
		75,
		75,
		70,
		70};
			this.aGauge3.RangesOuterRadius = new int[] {
		85,
		85,
		85,
		80,
		80};
			this.aGauge3.RangesStartValue = new float[] {
		0F,
		8000F,
		0F,
		0F,
		0F};
			this.aGauge3.RangeStartValue = 8000F;
			this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.aGauge3.ScaleLinesInterInnerRadius = 80;
			this.aGauge3.ScaleLinesInterOuterRadius = 90;
			this.aGauge3.ScaleLinesInterWidth = 1;
			this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.aGauge3.ScaleLinesMajorInnerRadius = 70;
			this.aGauge3.ScaleLinesMajorOuterRadius = 90;
			this.aGauge3.ScaleLinesMajorStepValue = 2000F;
			this.aGauge3.ScaleLinesMajorWidth = 2;
			this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.Black;
			this.aGauge3.ScaleLinesMinorInnerRadius = 85;
			this.aGauge3.ScaleLinesMinorNumOf = 9;
			this.aGauge3.ScaleLinesMinorOuterRadius = 90;
			this.aGauge3.ScaleLinesMinorWidth = 1;
			this.aGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
			this.aGauge3.ScaleNumbersFormat = null;
			this.aGauge3.ScaleNumbersRadius = 100;
			this.aGauge3.ScaleNumbersRotation = 90;
			this.aGauge3.ScaleNumbersStartScaleLine = 0;
			this.aGauge3.ScaleNumbersStepScaleLines = 1;
			this.aGauge3.Size = new System.Drawing.Size(220, 200);
			this.aGauge3.TabIndex = 9;
			this.aGauge3.Text = "aGauge3";
			this.aGauge3.Value = 0F;
			// 
			// aGauge2
			// 
			this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
			this.aGauge2.BaseArcRadius = 109;
			this.aGauge2.BaseArcStart = 135;
			this.aGauge2.BaseArcSweep = 270;
			this.aGauge2.BaseArcWidth = 2;
			this.aGauge2.Cap_Idx = ((byte)(1));
			this.aGauge2.CapColors = new System.Drawing.Color[] {
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black};
			this.aGauge2.CapPosition = new System.Drawing.Point(75, 150);
			this.aGauge2.CapsPosition = new System.Drawing.Point[] {
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(75, 150),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10)};
			this.aGauge2.CapsText = new string[] {
		"",
		"Shaft RPM",
		"",
		"",
		""};
			this.aGauge2.CapText = "Shaft RPM";
			this.aGauge2.Center = new System.Drawing.Point(110, 110);
			this.aGauge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aGauge2.Location = new System.Drawing.Point(260, 8);
			this.aGauge2.MaxValue = 10000F;
			this.aGauge2.MinValue = 0F;
			this.aGauge2.Name = "aGauge2";
			this.aGauge2.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
			this.aGauge2.NeedleColor2 = System.Drawing.Color.Maroon;
			this.aGauge2.NeedleRadius = 95;
			this.aGauge2.NeedleType = 0;
			this.aGauge2.NeedleWidth = 3;
			this.aGauge2.Range_Idx = ((byte)(2));
			this.aGauge2.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.aGauge2.RangeEnabled = true;
			this.aGauge2.RangeEndValue = 10000F;
			this.aGauge2.RangeInnerRadius = 75;
			this.aGauge2.RangeOuterRadius = 85;
			this.aGauge2.RangesColor = new System.Drawing.Color[] {
		System.Drawing.Color.PaleTurquoise,
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
		System.Drawing.SystemColors.Control,
		System.Drawing.SystemColors.Control};
			this.aGauge2.RangesEnabled = new bool[] {
		true,
		true,
		true,
		false,
		false};
			this.aGauge2.RangesEndValue = new float[] {
		6000F,
		7999F,
		10000F,
		0F,
		0F};
			this.aGauge2.RangesInnerRadius = new int[] {
		75,
		75,
		75,
		70,
		70};
			this.aGauge2.RangesOuterRadius = new int[] {
		85,
		85,
		85,
		80,
		80};
			this.aGauge2.RangesStartValue = new float[] {
		0F,
		6001F,
		8000F,
		0F,
		0F};
			this.aGauge2.RangeStartValue = 8000F;
			this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.aGauge2.ScaleLinesInterInnerRadius = 80;
			this.aGauge2.ScaleLinesInterOuterRadius = 90;
			this.aGauge2.ScaleLinesInterWidth = 1;
			this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.aGauge2.ScaleLinesMajorInnerRadius = 70;
			this.aGauge2.ScaleLinesMajorOuterRadius = 90;
			this.aGauge2.ScaleLinesMajorStepValue = 1000F;
			this.aGauge2.ScaleLinesMajorWidth = 2;
			this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Black;
			this.aGauge2.ScaleLinesMinorInnerRadius = 85;
			this.aGauge2.ScaleLinesMinorNumOf = 9;
			this.aGauge2.ScaleLinesMinorOuterRadius = 90;
			this.aGauge2.ScaleLinesMinorWidth = 1;
			this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
			this.aGauge2.ScaleNumbersFormat = null;
			this.aGauge2.ScaleNumbersRadius = 100;
			this.aGauge2.ScaleNumbersRotation = 90;
			this.aGauge2.ScaleNumbersStartScaleLine = 0;
			this.aGauge2.ScaleNumbersStepScaleLines = 1;
			this.aGauge2.Size = new System.Drawing.Size(220, 200);
			this.aGauge2.TabIndex = 8;
			this.aGauge2.Text = "aGauge2";
			this.aGauge2.Value = 0F;
			// 
			// aGauge1
			// 
			this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
			this.aGauge1.BaseArcRadius = 109;
			this.aGauge1.BaseArcStart = 135;
			this.aGauge1.BaseArcSweep = 270;
			this.aGauge1.BaseArcWidth = 2;
			this.aGauge1.Cap_Idx = ((byte)(1));
			this.aGauge1.CapColors = new System.Drawing.Color[] {
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black,
		System.Drawing.Color.Black};
			this.aGauge1.CapPosition = new System.Drawing.Point(78, 150);
			this.aGauge1.CapsPosition = new System.Drawing.Point[] {
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(78, 150),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10),
		new System.Drawing.Point(10, 10)};
			this.aGauge1.CapsText = new string[] {
		"",
		"Engine RPM",
		"",
		"",
		""};
			this.aGauge1.CapText = "Engine RPM";
			this.aGauge1.Center = new System.Drawing.Point(110, 110);
			this.aGauge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aGauge1.Location = new System.Drawing.Point(10, 8);
			this.aGauge1.MaxValue = 10000F;
			this.aGauge1.MinValue = 0F;
			this.aGauge1.Name = "aGauge1";
			this.aGauge1.NeedleColor1 = LoggerMonitor.AGauge.NeedleColorEnum.Red;
			this.aGauge1.NeedleColor2 = System.Drawing.Color.Maroon;
			this.aGauge1.NeedleRadius = 95;
			this.aGauge1.NeedleType = 0;
			this.aGauge1.NeedleWidth = 3;
			this.aGauge1.Range_Idx = ((byte)(2));
			this.aGauge1.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.aGauge1.RangeEnabled = true;
			this.aGauge1.RangeEndValue = 10000F;
			this.aGauge1.RangeInnerRadius = 75;
			this.aGauge1.RangeOuterRadius = 85;
			this.aGauge1.RangesColor = new System.Drawing.Color[] {
		System.Drawing.Color.PaleTurquoise,
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
		System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
		System.Drawing.SystemColors.Control,
		System.Drawing.SystemColors.Control};
			this.aGauge1.RangesEnabled = new bool[] {
		true,
		true,
		true,
		false,
		false};
			this.aGauge1.RangesEndValue = new float[] {
		6000F,
		7999F,
		10000F,
		0F,
		0F};
			this.aGauge1.RangesInnerRadius = new int[] {
		75,
		75,
		75,
		70,
		70};
			this.aGauge1.RangesOuterRadius = new int[] {
		85,
		85,
		85,
		80,
		80};
			this.aGauge1.RangesStartValue = new float[] {
		0F,
		6001F,
		8000F,
		0F,
		0F};
			this.aGauge1.RangeStartValue = 8000F;
			this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.aGauge1.ScaleLinesInterInnerRadius = 80;
			this.aGauge1.ScaleLinesInterOuterRadius = 90;
			this.aGauge1.ScaleLinesInterWidth = 1;
			this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.aGauge1.ScaleLinesMajorInnerRadius = 70;
			this.aGauge1.ScaleLinesMajorOuterRadius = 90;
			this.aGauge1.ScaleLinesMajorStepValue = 1000F;
			this.aGauge1.ScaleLinesMajorWidth = 2;
			this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Black;
			this.aGauge1.ScaleLinesMinorInnerRadius = 85;
			this.aGauge1.ScaleLinesMinorNumOf = 9;
			this.aGauge1.ScaleLinesMinorOuterRadius = 90;
			this.aGauge1.ScaleLinesMinorWidth = 1;
			this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
			this.aGauge1.ScaleNumbersFormat = null;
			this.aGauge1.ScaleNumbersRadius = 100;
			this.aGauge1.ScaleNumbersRotation = 90;
			this.aGauge1.ScaleNumbersStartScaleLine = 0;
			this.aGauge1.ScaleNumbersStepScaleLines = 1;
			this.aGauge1.Size = new System.Drawing.Size(220, 200);
			this.aGauge1.TabIndex = 7;
			this.aGauge1.Text = "aGauge1";
			this.aGauge1.Value = 0F;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1074, 714);
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
			this.Controls.Add(this.label1);
			this.Controls.Add(this.addGauge8);
			this.Controls.Add(this.addGauge7);
			this.Controls.Add(this.addGauge6);
			this.Controls.Add(this.addGauge5);
			this.Controls.Add(this.addGauge4);
			this.Controls.Add(this.addGauge3);
			this.Controls.Add(this.addGauge2);
			this.Controls.Add(this.addGauge1);
			this.Controls.Add(this.Simulate_button);
			this.Controls.Add(this.aGauge12);
			this.Controls.Add(this.aGauge11);
			this.Controls.Add(this.aGauge10);
			this.Controls.Add(this.aGauge9);
			this.Controls.Add(this.aGauge8);
			this.Controls.Add(this.aGauge7);
			this.Controls.Add(this.aGauge6);
			this.Controls.Add(this.aGauge5);
			this.Controls.Add(this.OnOff4_label);
			this.Controls.Add(this.OnOff4_progressBar);
			this.Controls.Add(this.OnOff3_label);
			this.Controls.Add(this.OnOff3_progressBar);
			this.Controls.Add(this.OnOff2_label);
			this.Controls.Add(this.OnOff2_progressBar);
			this.Controls.Add(this.OnOff1_label);
			this.Controls.Add(this.OnOff1_progressBar);
			this.Controls.Add(this.Sensor_button);
			this.Controls.Add(this.LogComp_button);
			this.Controls.Add(this.ComPort_button);
			this.Controls.Add(this.Exit_button);
			this.Controls.Add(this.StopMonitor_button);
			this.Controls.Add(this.StartMonitor_button);
			this.Controls.Add(this.aGauge4);
			this.Controls.Add(this.aGauge3);
			this.Controls.Add(this.aGauge2);
			this.Controls.Add(this.aGauge1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Logger Monitor v3.1.0";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer updateScreenTimer;
		private AGauge aGauge1;
		private AGauge aGauge2;
		private AGauge aGauge3;
		private AGauge aGauge4;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Button StartMonitor_button;
		private System.Windows.Forms.Button StopMonitor_button;
		private System.Windows.Forms.Button Exit_button;
		private System.Windows.Forms.Button ComPort_button;
		private System.Windows.Forms.Button LogComp_button;
		private System.Windows.Forms.Button Sensor_button;
		private System.Windows.Forms.Label OnOff1_label;
		private System.Windows.Forms.ProgressBar OnOff1_progressBar;
		private System.Windows.Forms.Label OnOff2_label;
		private System.Windows.Forms.ProgressBar OnOff2_progressBar;
		private System.Windows.Forms.Label OnOff3_label;
		private System.Windows.Forms.ProgressBar OnOff3_progressBar;
		private System.Windows.Forms.Label OnOff4_label;
		private System.Windows.Forms.ProgressBar OnOff4_progressBar;
		private AGauge aGauge5;
		private AGauge aGauge6;
		private AGauge aGauge7;
		private AGauge aGauge8;
		private AGauge aGauge9;
		private AGauge aGauge10;
		private AGauge aGauge11;
		private AGauge aGauge12;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button Simulate_button;
		private AGauge addGauge1;
		private AGauge addGauge2;
		private AGauge addGauge4;
		private AGauge addGauge6;
		private AGauge addGauge5;
		private AGauge addGauge8;
		private AGauge addGauge7;
		private AGauge addGauge3;
		private System.Windows.Forms.Timer readComTimer;
		private System.Windows.Forms.Label label1;
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

	}
}

