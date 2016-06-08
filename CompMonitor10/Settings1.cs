using System;
using Microsoft.Win32;

namespace CompMonitor10
{


    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.



    internal  partial class Settings1
    {

        public string regKeyPath = "Software\\MolinProducts\\RaceAppl\\Ajoloki Win32 Versio";

        public cOnOff OnOffs = new cOnOff();
        cRpmSensor rpms = new cRpmSensor();
        public  cAnalog analog1 = new cAnalog();

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
            private string[] OnOffName;// = { "O 1","O 2","O 3" };
            private int on_off_states = 0;
            private bool[] OnOffState;

            public cOnOff() {
                this.OnOffName = new string[3];
                this.OnOffState = new bool[3];
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

        public double   speedPerShaftRPM = 4.0F;

        public Settings1()
        {
        }
        
        public void Init()
        {

            RegistryKey rKey = Registry.CurrentUser;
            string regKey = regKeyPath;
            string tempStr;

            regKey = regKeyPath + "\\Program";
            RegistryKey reKey = rKey.OpenSubKey(regKey);
            port = (int)reKey.GetValue("ComPort", 5);
            port_speed = (int)reKey.GetValue("ComPortSpeed", 1);
            reKey.Close();

            regKey = regKeyPath + "\\Currents";
            reKey = rKey.OpenSubKey(regKey);
//            tempStr = (string)reKey.GetValue("GearRatio", 5.0);
//            gear = System.Convert.ToSingle(tempStr);
            gear = System.Convert.ToSingle(reKey.GetValue("GearRatio", 5.0)); 
//            tempStr = (string)reKey.GetValue("TireDiam", 0.8);
            wheel_d = System.Convert.ToSingle(reKey.GetValue("TireDiam", 0.8));
            reKey.Close();

            regKey = regKeyPath + "\\OnOffs";
            reKey = rKey.OpenSubKey(regKey);
            tempStr = (string)reKey.GetValue("1");
            OnOffs.setName(0, tempStr);
            OnOffs.setName(1, (string)reKey.GetValue("2"));
            OnOffs.setName(2, (string)reKey.GetValue("3"));
            OnOffs.setStates((int)reKey.GetValue("State"));
            reKey.Close();

            regKey = regKeyPath + "\\RaceComputer";
            reKey = rKey.OpenSubKey(regKey);
            engine_ctr = (int)reKey.GetValue("EngineCounter");
            shaft_ctr = (int)reKey.GetValue("ShaftCounter");

            rpms.setName(0, "Engine");
            rpms.setName(1, "Drift Shaft");
            rpms.setName(2, (string)reKey.GetValue("2"));
            rpms.setName(3, (string)reKey.GetValue("3"));
            rpms.setPulses(0, (int)reKey.GetValue("EnginePulses"));
            rpms.setPulses(1, (int)reKey.GetValue("ShaftPulses"));
            rpms.setPulses(2, (int)reKey.GetValue("pulses2"));
            rpms.setPulses(3, (int)reKey.GetValue("pulses3"));

            analog_sensor_count = (int)reKey.GetValue("AnalogCount");
            first_analog_index = (int)reKey.GetValue("1stAnalogInput");
            first_temp_sensor_index = (int)reKey.GetValue("1stTempSensorInput");
            temp_sensor_count = (int)reKey.GetValue("TempSensorCount");
            temp_1 = (int)reKey.GetValue("Temperature1");
            temp_2 = (int)reKey.GetValue("Temperature2");
            analog_value_1 = (int)reKey.GetValue("DigitalValue1");
            analog_value_2 = (int)reKey.GetValue("DigitalValue2");

            trip_ctr = (int)reKey.GetValue("TripCounter");
            tempStr = (string)reKey.GetValue("TripPer100Pulses", 40.0 );
            trip_per_100_pulses = System.Convert.ToSingle(tempStr);

            reKey.Close();

            speedPerShaftRPM = 1 * 60 / gear * wheel_d * 3.14159 /1000.0;
                // km/h = RPM * 60 min / peräv. * matka / renkaan r / 1000(m/km)

            for (int i = first_temp_sensor_index; i < (analog_sensor_count + temp_sensor_count); i++)
            {
                int i1 = i + 1;
                regKey = regKeyPath + "\\Analog" + i1.ToString();
                reKey = rKey.OpenSubKey(regKey);
                tempStr = (string)reKey.GetValue("Name", "ana");
                analog1.setName(i, tempStr);
                tempStr = (string)reKey.GetValue("Unit", "unit");
                analog1.setMeasUnit(i, tempStr);
                analog1.setVal1(i, (int)reKey.GetValue("DigitalValue1", 0));
                analog1.setVal2(i, (int)reKey.GetValue("DigitalValue2", 5));
                tempStr = (string)reKey.GetValue("1", 0.0);
                analog1.setVolt1(i, System.Convert.ToSingle(tempStr));
                tempStr = (string)reKey.GetValue("2", 10.0);
                analog1.setVolt2(i, System.Convert.ToSingle(tempStr));
                analog1.setMinVal(i, (int)reKey.GetValue("MinTemp", 0));
                analog1.setMaxVal(i, (int)reKey.GetValue("MaxTemp", 50));
                analog1.setMultip(i, (analog1.getVolt2(i) - analog1.getVolt1(i)) / (analog1.getVal2(i) - analog1.getVal1(i)));
                reKey.Close();
            }
        }
        public Single CalcSpeed( int Pulses, int rpm ){
            // r/min * min/h * km /1000 m * m /100 pulses * pulses/r --> km/h
            Single speed = 0.0F;

            return speed;
       
        }
    }
}
