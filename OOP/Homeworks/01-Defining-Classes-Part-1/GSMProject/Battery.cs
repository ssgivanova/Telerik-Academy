namespace GSMProject
{
    using System;

    //battery characteristics (model, hours idle and hours talk) and 

    public class Battery
    {
        private int hoursIdle;
        private double hoursTalk;

        public Battery(BatteryType batteryType)
        {
            this.BatteryType = batteryType;
            //this.HoursIdle = 0;
            //this.HoursTalk = 0;
        }

        public Battery(BatteryType batteryType, string model) : this(batteryType)
        {
            this.Model = model;
        }

        public Battery(BatteryType batteryType, string model, int hoursIdle, int hoursTalk)
            : this(batteryType, model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }


        public string Model { get; set; }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (this.hoursIdle >= 0)
                {
                    this.hoursIdle = value;
                }
            }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (this.hoursTalk >= 0)
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryType BatteryType {get; private set;}

        public override string ToString()
        {
            string info = String.Format("Battery : {0}", this.BatteryType);
            return info;
        }
    }
}
