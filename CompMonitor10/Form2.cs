using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompMonitor10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            OK_button.DialogResult = DialogResult.OK;
            Cancel_button.DialogResult = DialogResult.Cancel;

//            string ComStr = Settings1.Equals();
            ComPort_listBox.SetSelected(0, true);
        }

        private int speed = 1;
        private int comIndex = 0;
        public string comPort;

        public void ComPort_InitPortSpeed( int portSpeedIndex )
        {
            if (portSpeedIndex == 2)
                radioButton2.Select();
            else if (portSpeedIndex == 1)
                radioButton1.Select();
            else
                return;

            speed = portSpeedIndex;
        }

        public int ComPort_ReadPortSpeed()
        {
            return speed;
        }

        public void ComPort_InitPortNbr(int portNbr )
        {
            comIndex = portNbr;
            ComPort_listBox.SetSelected(portNbr, true );
        }

        public int ComPort_ReadPortNbr()
        {
            return comIndex;
        }

        private void ComPort_listBox_Click(object sender, EventArgs e)
        {
            // ComPort_listBox.SetSelected(1, true);
            object port = ComPort_listBox.SelectedIndex;
            comIndex = (int)port;
            port = ComPort_listBox.SelectedItem;
            comPort = (string)port;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            speed = 1;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            speed = 2;
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
