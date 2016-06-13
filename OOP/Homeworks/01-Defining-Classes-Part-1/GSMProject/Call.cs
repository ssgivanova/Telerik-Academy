namespace GSMProject
{
    using System;

    //Create a class Call to hold a call performed through a GSM.
    //It should contain date, time, dialled phone number and duration (in seconds).

    public class Call
    {
        private string dialledNumber;
        private int duration;

        public Call(string dialledNumber,int duration,DateTime dateTimeCall)
        {
            this.Duration = duration;
            this.DialledNumber = dialledNumber;
            this.Date = dateTimeCall.ToShortDateString();
            this.Time = dateTimeCall.ToShortTimeString();
        }

        public string Date { get; private set; }

        public string Time { get; private set; }

        public string DialledNumber
        {
            get { return this.dialledNumber; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid phone number");
                }
                else
                {
                    this.dialledNumber = value;
                }
            }
        }

        public int Duration
        {
            get { return this.duration; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid duration");
                }
                else
                {
                    this.duration = value;
                }
            }
        }

        public override string ToString()
        {
            return String.Format("dialledNumber : {0}- {1} {2} - {3}s", this.DialledNumber, this.Date, this.Time,
                                   this.Duration);
        }
    }
}
