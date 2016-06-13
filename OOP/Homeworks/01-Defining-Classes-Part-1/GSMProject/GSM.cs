namespace GSMProject
{
    using System;
    using System.Collections.Generic;

    //Define a class that holds information about a mobile phone device: 
    //model, manufacturer, price, owner, 
    //battery characteristics (model, hours idle and hours talk) and 
    //display characteristics (size and number of colors).

    //Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S

    public class GSM
    {
        //Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        private static readonly GSM iPhone4S = new GSM("IPhone4S", "Apple", 500, new Battery(BatteryType.LiPo, "Non-removable 1432 mAh", 200, 14),
                                               new Display(640, 960, 3.5));
        private string model;
        private string manufacturer;
        private decimal? price;

        // list of the performed calls.
        private List<Call> callHistory;

        public GSM(string model,string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal price) : this(model,manufacturer)
        {
           this.Price = price;
        }

        public GSM(string model, string manufacturer, Battery battery)
            : this(model, manufacturer)
        {
            this.Battery = battery;
        }

        public GSM(string model, string manufacturer, Battery battery, Display display)
            : this(model, manufacturer, battery)
        {
            this.Display = display;
        }

        public GSM(string model, string manufacturer, decimal price, Battery battery, Display display)
            : this(model, manufacturer, battery,display)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model,manufacturer,price,battery,display)
        {
            this.Owner = owner;
        }

        //properties
        public string Model 
        { get {return this.model;}
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid model");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid manufacturer");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public string Owner { get; set; }

        public decimal? Price {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can't be negative");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }
        
        //call history methods
        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CalculateTotalCallPrice(decimal pricePerMin)
        {
            int totalCallDuration = 0;

            foreach (var call in callHistory)
            {
                totalCallDuration += call.Duration;
            }
            decimal totalPrice = (totalCallDuration/60.0m) * pricePerMin;
            return totalPrice;
        }

        public void PrintCallHistoryInfo()
        {
            if (this.callHistory.Count > 0)
            {
                Console.WriteLine("Call history :");
                foreach (var call in this.callHistory)
                {
                    Console.WriteLine(" - " + call);
                }
            }
            else
            {
                Console.WriteLine("No call history");
            }
        }

        public override string ToString()
        {
            return String.Format("GSM : {0} {1} - {2}lv\n{3}\n{4}\n", 
                this.Model, this.Manufacturer,this.Price,this.Battery,this.Display);
        }

    }
}
