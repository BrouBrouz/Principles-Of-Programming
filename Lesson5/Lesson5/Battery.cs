using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Battery
    {
        public string batteryType;
        public double batteryLife;

        public Battery()
        {
            batteryType = "";
            batteryLife = -1;
        }
        
        public Battery(string batteryType, double batteryLife)
        {
            this.batteryType = batteryType;
            this.batteryLife = batteryLife;
        }

        public string BatteryType
        {
            get
            {
                return batteryType;
            }
        }

        public double BatteryLife
        {
            get
            {
                return batteryLife;
            }
            set
            {
                if (batteryLife <= 0)
                {
                    throw new IndexOutOfRangeException("The battery life cannot be null or negative");
                }
            }
        }

        public override string ToString()
        {
            return $"    > Battery Type = {batteryType}\n    > Battery Life = {batteryLife} hours\n";
        }
    }
}
