using System;
using System.Collections.Generic;

namespace LoggerMonitor
{
    partial class AnalogSettingsForm
    {
        const int sensorCount = 32;
        const int calibPoints = 5;

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

        List<System.Windows.Forms.TreeNode> sensorNodes = new List<System.Windows.Forms.TreeNode>(sensorCount);
        List<System.Windows.Forms.TreeNode> nameNodes = new List<System.Windows.Forms.TreeNode>(sensorCount);
        List<System.Windows.Forms.TreeNode> valueNodes = new List<System.Windows.Forms.TreeNode>(sensorCount * calibPoints);
        List<System.Windows.Forms.TreeNode> voltageNodes = new List<System.Windows.Forms.TreeNode>(sensorCount * calibPoints);

        public event EventHandler<ModifyEventArgs> ModifyItem = delegate { };

        private void CreateNodes()
        {
            // Create nodes for 32 sensors with 5 calibration points

            for (int i = 0; i < sensorCount; i++)
            {
                var cb1Index = i * calibPoints;
                for (int cb = 0; cb < calibPoints; cb++)
                {
                    var cbIndex = cb1Index + cb;
                    voltageNodes.Add(new System.Windows.Forms.TreeNode($"Voltage {cb+1}"));
                    valueNodes.Add(new System.Windows.Forms.TreeNode($"Value {cb+1}",
                        new System.Windows.Forms.TreeNode[] {voltageNodes[cbIndex]}));
                }
                nameNodes.Add(new System.Windows.Forms.TreeNode($"Name {i+1}"));
                sensorNodes.Add(new System.Windows.Forms.TreeNode($"Sensor {i+1}",
                    new System.Windows.Forms.TreeNode[] {
                        nameNodes[i],
                        valueNodes[cb1Index],
                        valueNodes[cb1Index+1],
                        valueNodes[cb1Index+2],
                        valueNodes[cb1Index+3],
                        valueNodes[cb1Index+4],
                    }));
            }
        }

        #region Windows Form Designer generated code

        #endregion

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Modify_button = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.ReadFromLogger_button = new System.Windows.Forms.Button();
            this.WriteToLogger_button = new System.Windows.Forms.Button();

            var buttonSize = new System.Drawing.Size(70, 40);
            // 
            // Modify_button
            // 
            this.Modify_button.Name = "Modify_button";
            this.Modify_button.Size = buttonSize;
            this.Modify_button.TabIndex = 1;
            this.Modify_button.Text = "Modify Selected";
            this.Modify_button.UseVisualStyleBackColor = true;
            this.Modify_button.Click += new System.EventHandler(this.Modify_button_Click);
            this.Modify_button.Visible = true;
            // 
            // OK_button
            // 
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = buttonSize;
            this.OK_button.TabIndex = 2;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            this.OK_button.Visible = true;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = buttonSize;
            this.Cancel_button.TabIndex = 3;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // ReadFromLogger_button
            // 
            this.ReadFromLogger_button.Name = "ReadFromLogger_button";
            this.ReadFromLogger_button.Size = buttonSize;
            this.ReadFromLogger_button.TabIndex = 4;
            this.ReadFromLogger_button.Text = "Read From Logger";
            this.ReadFromLogger_button.UseVisualStyleBackColor = true;
            this.ReadFromLogger_button.Click += new System.EventHandler(this.ReadFromLogger_button_Click);
            // 
            // WriteToLogger_button
            // 
            this.WriteToLogger_button.Name = "WriteToLogger_button";
            this.WriteToLogger_button.Size = buttonSize;
            this.WriteToLogger_button.TabIndex = 5;
            this.WriteToLogger_button.Text = "Write To Logger";
            this.WriteToLogger_button.UseVisualStyleBackColor = true;
            this.WriteToLogger_button.Click += new System.EventHandler(this.WriteToLogger_button_Click);

            CreateNodes();

            this.sensorsTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();

            // 
            // sensorsTreeView
            // 
            System.Windows.Forms.TreeNode sensorsTopNode = new System.Windows.Forms.TreeNode("Sensors", 
                new System.Windows.Forms.TreeNode[] {
                    sensorNodes[0],
                    sensorNodes[1],
                    sensorNodes[2],
                    sensorNodes[3],
                    sensorNodes[4],
                    sensorNodes[5],
                    sensorNodes[6],
                    sensorNodes[7],
                    sensorNodes[8],
                    sensorNodes[9],
                    sensorNodes[10],
                    sensorNodes[11],
                    sensorNodes[12],
                    sensorNodes[13],
                    sensorNodes[14],
                    sensorNodes[15],
                    sensorNodes[16],
                    sensorNodes[17],
                    sensorNodes[18],
                    sensorNodes[19],
                    sensorNodes[20],
                    sensorNodes[21],
                    sensorNodes[22],
                    sensorNodes[23],
                    sensorNodes[24],
                    sensorNodes[25],
                    sensorNodes[26],
                    sensorNodes[27],
                    sensorNodes[28],
                    sensorNodes[29],
                    sensorNodes[30],
                    sensorNodes[31]
                });
            var x = 240;
            var y = 80;
            var addY = buttonSize.Height + 10;
            this.ReadFromLogger_button.Location = new System.Drawing.Point(x, y);
            y += addY;
            this.WriteToLogger_button.Location = new System.Drawing.Point(x, y);
            y += addY;
            this.OK_button.Location = new System.Drawing.Point(x, y);
            y += addY;
            this.Modify_button.Location = new System.Drawing.Point(x, y);
            y += addY;
            this.Cancel_button.Location = new System.Drawing.Point(x, y);
            y += addY;

            this.sensorsTreeView.Location = new System.Drawing.Point(30, 30);
            this.sensorsTreeView.LineColor = System.Drawing.Color.Empty;
            this.sensorsTreeView.Name = "sensorsTreeView";
            this.sensorsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {sensorsTopNode});
            this.sensorsTreeView.Size = new System.Drawing.Size(200, y);
            y += addY;

            sensorsTopNode.Expand();
            this.sensorsTreeView.TabIndex = 0;
            // 
            // AnalogSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, y);
            this.Controls.Add(this.sensorsTreeView);
            this.Controls.Add(this.ReadFromLogger_button);
            this.Controls.Add(this.WriteToLogger_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Modify_button);
            this.Controls.Add(this.OK_button);
            this.Name = "AnalogSettingsForm";
            this.Text = "Analog Sensor Settings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button Modify_button;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button ReadFromLogger_button;
        private System.Windows.Forms.Button WriteToLogger_button;
        private System.Windows.Forms.TreeView sensorsTreeView;
    }
}