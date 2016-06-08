using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CompMonitor10
{
    class  raceFileClass : TextFile
    {
        public  int[] RPM = new int[4];
        public  int[] Analog = new int[16];
        public  bool[] onOff = new bool[3];
        public int ms = 0, ms2 = 0;

        public raceFileClass()
        {

        }

        public int ParseLine()
        {
            int memberCount = 0;
            char delimiterChar = ' ';
            string[] numStr = line.Split(delimiterChar);
            memberCount = numStr.Length;
            int[] nums = new int[memberCount];
            for (int i = 0; i < memberCount; i++)
            {
                if (i == 5)      // on off -signals
                    nums[i] = System.Convert.ToInt32(numStr[i], 16);
                else if (i == 0 || i > 5 )
                    nums[i] = System.Convert.ToInt32(numStr[i]);
            }
            if (memberCount > 8)
            {
                ms2 = ms2 + ms;             // previous time value, milli seconds!!
                ms = 10 * nums[0] - ms2;    // time delta (current - previous)
                RPM[0] = nums[6];
                RPM[1] = nums[7];
                onOff[0] = ((nums[5] & 1) > 0);
                onOff[1] = ((nums[5] & 2) > 0);
                onOff[2] = ((nums[5] & 4) > 0);
            }
            if (memberCount > 16)
            {
                RPM[2] = nums[16];
                RPM[3] = nums[17];
                for (int i = 0, j = 8; i < 8; i++, j++) // first 8 analog signals
                    Analog[i] = nums[j];
            }
            if (memberCount > 25)
            {
                for (int i = 8, j = 18; i < 16; i++, j++)
                    Analog[i] = nums[j];
            }
            return memberCount;
        }

        public int calculateAnalogValue(int analogNumber, int digitalValue, int meterValue, float multiplier)
        {   // this calculates one measured analog value pointed by index i.e. analogNumber

            float flValue = (float)(Analog[analogNumber] - digitalValue) * multiplier + (float)meterValue;
            return System.Convert.ToInt32(flValue);
        }

        public float calcFloatAnalogValue(int analogNumber, int digitalValue, int meterValue, float multiplier)
        {
            float flValue = (float)(Analog[analogNumber] - digitalValue) * multiplier + (float)meterValue;
            return flValue;
        }

    }
}
