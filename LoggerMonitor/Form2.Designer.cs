namespace LoggerMonitor
{
    partial class Form2
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.OK_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComPort_listBox = new System.Windows.Forms.ListBox();
            this.CarLabel = new System.Windows.Forms.Label();
            this.carTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(154, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "9600";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port Speed";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(255, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "38400";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(113, 226);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 3;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(214, 226);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 4;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "COM Port number";
            // 
            // ComPort_listBox
            // 
            this.ComPort_listBox.DisplayMember = "mComNumber";
            this.ComPort_listBox.FormattingEnabled = true;
            this.ComPort_listBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20",
            "COM21",
            "COM22",
            "COM23",
            "COM24",
            "COM25",
            "COM26",
            "COM27",
            "COM28",
            "COM29",
            "COM30",
            "COM31",
            "COM32"});
            this.ComPort_listBox.Location = new System.Drawing.Point(154, 102);
            this.ComPort_listBox.Name = "ComPort_listBox";
            this.ComPort_listBox.Size = new System.Drawing.Size(100, 108);
            this.ComPort_listBox.TabIndex = 6;
            this.ComPort_listBox.ValueMember = "mComNumber";
            this.ComPort_listBox.Click += new System.EventHandler(this.ComPort_listBox_Click);
            // 
            // CarLabel
            // 
            this.CarLabel.AutoSize = true;
            this.CarLabel.Location = new System.Drawing.Point(67, 19);
            this.CarLabel.Name = "CarLabel";
            this.CarLabel.Size = new System.Drawing.Size(54, 13);
            this.CarLabel.TabIndex = 7;
            this.CarLabel.Text = "Car Name";
            this.CarLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // carTextBox
            // 
            this.carTextBox.Location = new System.Drawing.Point(154, 15);
            this.carTextBox.MaxLength = 10;
            this.carTextBox.Name = "carTextBox";
            this.carTextBox.Size = new System.Drawing.Size(100, 20);
            this.carTextBox.TabIndex = 1;
            this.carTextBox.ModifiedChanged += new System.EventHandler(this.carTextBox_ModifiedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 284);
            this.Controls.Add(this.carTextBox);
            this.Controls.Add(this.CarLabel);
            this.Controls.Add(this.ComPort_listBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ComPort_listBox;
        private System.Windows.Forms.Label CarLabel;
        private System.Windows.Forms.TextBox carTextBox;
    }
}