using System;
using System.Globalization;

namespace LoggerMonitor
{
    public class limits
    {
        public string name;
        public double min;
        public double max;
        public double multiplier;
        public double zeroValue;

        public limits()
        {
            min = 0;
            max = 100;
            multiplier = 1.0;
            zeroValue = 0.0;
            name = "";
        }
    }

    class raceFileClass : TextFile
    {
        public int[] RPM;
        public int[] Analog;
        public double[] AnalogDouble;
        public double[] AnalogVoltage;
        public double[] Acceleration;
        public bool[] onOff;
        public int AnalogRotator;
        public int ms = 0, ms2 = 0;

        public limits[] RPMLimit;
        public limits[] AnalogLimit;
        public string[] OnOffName;

        public raceFileClass()
        {
            RPM = new int[4];
            Analog = new Int32[16];
            AnalogDouble = new double[16];
            AnalogVoltage = new double[16];
            Acceleration = new double[4];
            onOff = new bool[4];
            RPMLimit = new limits[4];
            for (int i = 0; i < 4; i++)
                RPMLimit[i] = new limits();
            foreach(var rl in RPMLimit)
            {
                rl.name = "RPM x";
                rl.min = 0;
                rl.max = 10000;
            }
            AnalogLimit = new limits[16];
            for (int i = 0; i < 16; i++)
                AnalogLimit[i] = new limits();
            foreach (var al in AnalogLimit)
            {
                al.name = "Analog x";
                al.min = 0;
                al.max = 1000;
            }
            OnOffName = new string[4];
        }

        public int ParseLine()
        {
            int memberCount = 0;
            char delimiterChar = ' ';
            string[] numStr = line.Split(delimiterChar);
            memberCount = numStr.Length;
            if (memberCount < 8)
                return 0;
            Int16 num1;
            var success = Int16.TryParse(numStr[1], NumberStyles.HexNumber, CultureInfo.InvariantCulture, out num1);
            if (!success)
                return 0;
            int[] nums = new int[memberCount];
            for (int i = 0; i < memberCount; i++)
            {
                if (i == 5)      // on off -signals
                    nums[i] = System.Convert.ToInt32(numStr[i], 16);
                else if (i == 0 || (i > 5 && i < 27))
                    nums[i] = System.Convert.ToInt32(numStr[i]);
                else if (i >= 27 && i < 31)
                    Acceleration[i-27] = System.Convert.ToDouble(numStr[i]);
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
                onOff[3] = ((nums[5] & 8) > 0);
            }
            if (memberCount > 26)
                AnalogRotator = nums[26];
            else
                AnalogRotator = 9;

            if (memberCount > 16)
            {
                RPM[2] = nums[16];
                RPM[3] = nums[17];
                for (int i = 0, j = 8; i < 8; i++, j++) // first 8 analog signals
                    Analog[i] = nums[j] << AnalogRotator;
            }
            if (memberCount > 25)
            {
                for (int i = 8, j = 18; i < 16; i++, j++)
                    Analog[i] = nums[j] << AnalogRotator;
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

        public void WriteLoggerLine()
        {
            // disk storage not implemented yet
        }

        public int ParseLoggerLine()
        {
            int memberCount = 0;
            char delimiterChar = ';';
            string[] item = line.Split(delimiterChar);
            memberCount = item.Length;      // should be 1 + 4 + 4 + 16 = 25

            for (int i = 0; i < 4; i++)
            {
                try
                {
                    RPM[i] = System.Convert.ToInt32(item[i + 1]);
                }
                catch
                {
                    RPM[i] = 0;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    onOff[i] = System.Convert.ToInt32(item[i + 5]) > 0;
                }
                catch
                {
                    onOff[i] = false;
                }
            }
            for (int i = 0; i < 16; i++)
            {
                try
                {
                    AnalogDouble[i] = System.Convert.ToDouble(item[i + 9], CultureInfo.InvariantCulture);
                }
                catch
                {
                    AnalogDouble[i] = 0;
                }
            }
            return memberCount;
        }

        public int ParseLoggerVoltages()
        {
            int memberCount = 0;
            char delimiterChar = ';';
            string[] item = line.Split(delimiterChar);
            memberCount = item.Length;      // should be 1 + 4 + 4 + 16 = 25

            for (int i = 0; i < 4; i++)
            {
                try
                {
                    RPM[i] = System.Convert.ToInt32(item[i + 1]);
                }
                catch
                {
                    RPM[i] = 0;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    onOff[i] = System.Convert.ToInt32(item[i + 5]) > 0;
                }
                catch
                {
                    onOff[i] = false;
                }
            }
            for (int i = 0; i < 16; i++)
            {
                try
                {
                    AnalogVoltage[i] = System.Convert.ToDouble(item[i + 9], CultureInfo.InvariantCulture);
                }
                catch
                {
                    AnalogVoltage[i] = 0;
                }
            }
            return memberCount;
        }
    }
}
