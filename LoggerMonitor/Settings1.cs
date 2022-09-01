
using System;
using System.IO;
using System.Runtime.InteropServices;

unsafe public struct analogSensor     /* analogiasignaalien asetukset, size 54 */
{
    public string name;
    public string meas_unit;
    public Int32 values1; 
    public Int32 values2;
    public float volts1;
    public float volts2;
    public Int32 maxVal;
    public Int32 minVal;
    public Int32 kaValue;
}

//[StructLayout(LayoutKind.Explicit)]
unsafe public class rpmData_t          // size 15
{
    public Int32 pulses1;
    public sbyte[] name;
    public rpmData_t()
    {
        this.pulses1 = new Int32();
        this.name = new sbyte[11];
    }
}

[StructLayout(LayoutKind.Explicit)]
public struct onOffName_t       // size 21
{                               // from offset 1052 onwards
    [FieldOffset(0)]    public string name;
}


namespace LoggerMonitor
{

    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.

    internal unsafe partial class Settings1
    {
        const int NAME_LEN = 15;
        public string regKeyPath = "Software\\MolinProducts\\RaceAppl\\Ajoloki Win32 Versio";
        const string dataPath = "C:\\ProgramData\\MolinProducts\\";

        public cOnOff OnOffs = new cOnOff();
        cRpmSensor rpms = new cRpmSensor();
        public  cAnalog analog1 = new cAnalog();
        public string vehicleName;

        public class cAnalog
        {
            private string[] name;
            private string[] measUnit;
            private int[] value1;
            private int[] value2;
            private float[] volts1;
            private float[] volts2;
            private int[] maxValue;
            private int[] minValue;
            private float[] multip;

            public cAnalog()
            {
                this.name = new string[16];
                this.measUnit = new string[16];
                this.value1 = new int[16];
                this.value2 = new int[16];
                this.volts1 = new float[16];
                this.volts2 = new float[16];
                this.minValue = new int[16];
                this.maxValue = new int[16];
                this.multip = new float[16];
            }
            public void setName(int record, string Name)
            {
                this.name[record] = String.Copy(Name);
            }
            public string getName(int record)
            {
                return this.name[record];
            }
            public void setMeasUnit(int record, string Unit)
            {
                this.measUnit[record] = String.Copy(Unit);
            }
            public string getMeasUnit(int record)
            {
                return this.measUnit[record];
            }
            public void setVal1(int record, int v1)
            {
                this.value1[record] = v1;
            }
            public int getVal1(int record)
            {
                return this.value1[record];
            }
            public void setVal2(int record, int v2)
            {
                this.value2[record] = v2;
            }
            public int getVal2(int record)
            {
                return this.value2[record];
            }
            public void setVolt1(int record, float v1)
            {
                this.volts1[record] = v1;
            }
            public float getVolt1(int record)
            {
                return this.volts1[record];
            }
            public void setVolt2(int record, float v2)
            {
                this.volts2[record] = v2;
            }
            public float getVolt2(int record)
            {
                return this.volts2[record];
            }
            public void setMinVal(int record, int v1)
            {
                this.minValue[record] = v1;
            }
            public int getMinVal(int record)
            {
                return this.minValue[record];
            }
            public void setMaxVal(int record, int v1)
            {
                this.maxValue[record] = v1;
            }
            public int getMaxVal(int record)
            {
                return this.maxValue[record];
            }
            public void setMultip(int record, float v1)
            {
                this.multip[record] = v1;
            }
            public float getMultip(int record)
            {
                return this.multip[record];
            }
        }

        public class cRpmSensor
        {
            private int[] pulses;
            private string[] RPM_name;

            public cRpmSensor()
            {
                this.pulses = new int[4];
                this.RPM_name = new string[4];
            }
            public void setPulses(int record, int Pulses)
            {
                this.pulses[record] = Pulses;
            }
            public int getPulses(int record)
            {
                return this.pulses[record];
            }
            public void setName(int record, string Name)
            {
                this.RPM_name[record] = String.Copy(Name);
            }
            public string getName(int record)
            {
                return this.RPM_name[record];
            }
        }

        public class cOnOff
        {
            private string[] OnOffName;
            private int on_off_states = 0;
            private bool[] OnOffState;

            public cOnOff() {
                this.OnOffName = new string[4];
                this.OnOffState = new bool[4];
            }
            public void setName(int record, string Name) {
                this.OnOffName[record] = String.Copy(Name);
            }
            public string getName(int record) {
                return this.OnOffName[record];
            }
            public void setStates(int states) {
                this.on_off_states = states;
                this.OnOffState[0] = (this.on_off_states == 0x1);
                this.OnOffState[1] = ((this.on_off_states >> 1) == 0x1);
                this.OnOffState[2] = ((this.on_off_states >> 2) == 0x1);
                this.OnOffState[3] = ((this.on_off_states >> 3) == 0x1);
            }

            public bool getState(int sign) {
//                bool state = false;
//                state = ((this.on_off_states >> sign) == 0x1);
//                return state;
                return this.OnOffState[sign];
            }
        }

        public int      port = 5;
        public int      port_speed = 2; // 1 -> 9600, 2 -> 38400

        public float	wheel_d = 0.8F;
        public float	gear = 5.0F;

        public int      engine_ctr = 1;
        public int      shaft_ctr = 2;

        public int      max_rpm = 10000;
        public int      rpm_shift = 1000;

        public int      temp_1 = 22;
        public int      analog_value_1 = 12;
        public int      temp_2 = 300;
        public int      analog_value_2 = 71;
        public int      max_temp = 1000;
        public int      temp_shift = 100;
        public int      temp_sensor_count = 8;
        public int      first_temp_sensor_index = 0;

        public int      analog_sensor_count = 8;
        public int      first_analog_index = 8;

        public int      trip_ctr = 1;
        public float    trip_per_100_pulses = 41.0F;

        public double   speedPerShaftRPM = 0.027F;

        public Settings1()
        {
        }

        unsafe public void Init()
        {

            //RegistryKey rKey = Registry.CurrentUser;
            //string regKey = regKeyPath;

            string car = "";
            int len = ReadProgFile(ref car);
            if (len > 0)
                vehicleName = car;

            long position = ReadSetsFile(car);

            ReadSetsFile1(position);
            position += 120;

            ReadSetsFile2(position);
            position += 68;

            ReadSetsFile3(position);
            position += 864;
            
            ReadSetsFile4(position);
        }

        public Single CalcSpeed( int Pulses, int rpm ){
            // r/min * min/h * km /1000 m * m /100 pulses * pulses/r --> km/h
            Single speed = 0.0F;
            return speed;
        }

        public int ReadProgFile(ref String carName)
        {
            carName = "initial";
            string fileName = dataPath + "Program.set";

            if (File.Exists(fileName))
            {
                StreamReader sFile = File.OpenText(fileName);
                char[] name = new char[20];
                int len = sFile.ReadBlock(name, 0, NAME_LEN);
                if (len > 0)
                    carName = new string(name);
            }

            char[] sep = new char[1];
            sep[0] = '\0';
            string[] temp = carName.Split(sep);
            carName = temp[0];
            return carName.Length;
        }

        public long ReadSetsFile(String carName)
        {
            byte[] retBytes = new byte[1118];
            long pos = 0;
            {
                string fileName = dataPath + "RaceComp.set";
                if (File.Exists(fileName))
                {
                    FileStream cFile = File.OpenRead(fileName);
                    int readCount = 0;
                    int start = 0;
                    string retCarName = "";
                    while ((readCount = cFile.Read(retBytes, start, retBytes.Length)) == retBytes.Length)
                    {
                        char[] chars = new char[20];
                        int i = 0;
                        for (; i < chars.Length; i++)
                        {
                            chars[i] = System.Convert.ToChar(retBytes[i]);
                            if (chars[i] == 0)
                                break;
                        }
                        retCarName = new string(chars);
                        string[] temp = retCarName.Split('\0');
                        retCarName = temp[0];
                        if (carName.Equals(retCarName))
                            break;

                        pos += 1118;
                    }
                    cFile.Close();
                }
            }
            return pos;
        }

        public void ReadSetsFile1(long pos)
        {
            string fileName = dataPath + "RaceComp.set";
            if (File.Exists(fileName))
            {
                FileStream cFile = File.OpenRead(fileName);
                BinaryReader br = new BinaryReader(cFile);
                long start = pos, next;
                next = br.BaseStream.Seek(start, SeekOrigin.Begin);

                br.BaseStream.Seek(start+16, SeekOrigin.Begin);
                engine_ctr = br.ReadInt32();
                shaft_ctr = br.ReadInt32();
                br.BaseStream.Seek(start+40, SeekOrigin.Begin);
                max_rpm = br.ReadInt32();
                rpm_shift = br.ReadInt32();
                int notUsed = br.ReadInt32();   // max_rpm_relation
                port = br.ReadInt32();
                port_speed = br.ReadInt32();
                notUsed = br.ReadInt32();       // port_comm_method 
                br.BaseStream.Seek(start+68, SeekOrigin.Begin);
  
                temp_1 = br.ReadInt32();
                analog_value_1 = br.ReadInt32();
                temp_2 = br.ReadInt32();
                analog_value_2 = br.ReadInt32();

                max_temp = br.ReadInt32();
                temp_shift = br.ReadInt32();
                temp_sensor_count = br.ReadInt32();
                first_temp_sensor_index = br.ReadInt32();
                analog_sensor_count = br.ReadInt32();
                first_analog_index = br.ReadInt32();

                cFile.Close();
            }
        }

        public void ReadSetsFile2(long pos)
        {
            string fileName = dataPath + "RaceComp.set";
            if (File.Exists(fileName))
            {
                FileStream cFile = File.OpenRead(fileName);
                BinaryReader br = new BinaryReader(cFile);

                long start = pos, next;
                sbyte ch;
                string sName = "";
                char[] sep = new char[1];
                sep[0] = '\0';
                Int32 pulses = 1;
                next = br.BaseStream.Seek(start, SeekOrigin.Begin);

                for (int i = 0; i < 4; i++)
                {
                    pulses = br.ReadInt32();
                    rpms.setPulses(i, pulses);
                    sName = "";
                    for (int j = 0; j < 10; j++)
                    {
                        ch = br.ReadSByte();
                        sName += (char)ch;
                        if (ch == 0)
                            break;
                    }
                    sName += 0;
                    string[] temp = sName.Split(sep);
                    sName = temp[0];

                    rpms.setName(i, sName);
                    
                    start += 15;
                    br.BaseStream.Seek(start, SeekOrigin.Begin);
                }
                trip_ctr = br.ReadInt32();
                trip_per_100_pulses = br.ReadSingle();
                cFile.Close();

                speedPerShaftRPM = speedPerShaftRPM * 4 / rpms.getPulses(shaft_ctr);
            }
        }

        public void ReadSetsFile3(long pos)
        {
            string fileName = dataPath + "RaceComp.set";

            if (File.Exists(fileName))
            {
                FileStream cFile = File.OpenRead(fileName);
                BinaryReader br = new BinaryReader(cFile);

                long start = pos, next;
                char ch;
                char sep = new char();
                sep = '\0';
                string analog;
                string[] temp = new string[10];

                for (int i = 0; i < (analog_sensor_count + temp_sensor_count); i++)
                {
                    next = br.BaseStream.Seek(start, SeekOrigin.Begin);
                    analog = "";
                    for (int j = 0; j < 15; j++)
                    {
                        ch = (char)br.ReadByte();
                        analog += ch;
                        if (ch == 0)
                            break;
                    }
                    analog += '\0';
                    temp = analog.Split(sep);
                    analog = temp[0];
                    analog1.setName(i, analog);

                    start += 15;
                    br.BaseStream.Seek(start, SeekOrigin.Begin);
                    analog = "";
                    for (int j = 0; j < 11; j++)
                    {
                        ch = br.ReadChar();
                        analog += ch;
                        if (ch == 0)
                            break;
                    }
                    analog += '\0';
                    temp = analog.Split(sep);
                    analog = temp[0];
                    analog1.setMeasUnit(i, analog);

                    start += 11;
                    br.BaseStream.Seek(start, SeekOrigin.Begin);

                    Int32 i1 = br.ReadInt32();
                    analog1.setVal1(i, i1);
                    i1 = br.ReadInt32();
                    analog1.setVal2(i, i1);

                    Single s1 = br.ReadSingle();
                    analog1.setVolt1(i, s1);
                    s1 = br.ReadSingle();
                    analog1.setVolt2(i, s1);

                    i1 = br.ReadInt32();
                    analog1.setMaxVal(i, i1);
                    i1 = br.ReadInt32();
                    analog1.setMinVal(i, i1);
                    i1 = br.ReadInt32();    // kaValue 

                    start += 28;
                    analog1.setMultip(i, (analog1.getVolt2(i) - analog1.getVolt1(i)) / (analog1.getVal2(i) - analog1.getVal1(i)));
                }
                cFile.Close();
            }
        }

        public void ReadSetsFile4(long pos)
        {
            string fileName = dataPath + "RaceComp.set";
            if (File.Exists(fileName))
            {
                FileStream cFile = File.OpenRead(fileName);
                BinaryReader br = new BinaryReader(cFile);

                long start = pos, next;
                char[] chars = new char[21];
                char sep = new char();
                sep = '\0';
                string[] tempS = new string[10];
                string temp;
                byte[] states = new byte[4];

                next = br.BaseStream.Seek(start, SeekOrigin.Begin);
                chars = br.ReadChars(21);
                temp = new string(chars);
                tempS = temp.Split(sep);
                OnOffs.setName(0, tempS[0]);
                start += 21;

                next = br.BaseStream.Seek(start, SeekOrigin.Begin);
                chars = br.ReadChars(21);
                temp = new string(chars);
                tempS = temp.Split(sep);
                OnOffs.setName(1, tempS[0]);
                start += 21;

                next = br.BaseStream.Seek(start, SeekOrigin.Begin);
                chars = br.ReadChars(21);
                temp = new string(chars);
                tempS = temp.Split(sep);
                OnOffs.setName(2, tempS[0]);
                start += 21;

                next = br.BaseStream.Seek(start, SeekOrigin.Begin);
                states[0] = br.ReadByte();
                states[1] = br.ReadByte();
                states[2] = br.ReadByte();

                int sta = states[0] & states[1] << 1 & states[2] << 2;
                OnOffs.setStates(sta);

                cFile.Close();
            }
        }
    }
}
