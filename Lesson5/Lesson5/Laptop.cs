using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Laptop
    {
        //FIELDS
        public string model; //Mandatory
        public string manufacturer;
        public string processor;
        public int ram;
        public string graphicsCard;
        public int hdd;
        public string screen;
        public Battery battery;
        public double price; //Mandatory

        //CONSTRUCTORS
        public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, int hdd, string screen, Battery battery, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.processor = processor;
            this.ram = ram;
            this.graphicsCard = graphicsCard;
            this.hdd = hdd;
            this.screen = screen;
            this.battery = battery;
            this.price = price;
        }

        public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, int hdd, string screen, string batteryType, double batteryLife, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.processor = processor;
            this.ram = ram;
            this.graphicsCard = graphicsCard;
            this.hdd = hdd;
            this.screen = screen;
            this.battery = new Battery(batteryType, batteryLife);
            this.price = price;
        }

        public Laptop(string model, double price)
        {
            this.model = model;
            this.price = price;
        }

        //PROPERTIES
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The model entered is empty!");
                }
                model = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
        }

        public string Processor
        {
            get { return processor; }
        }

        public string GraphicsCard
        {
            get { return graphicsCard; }
        }

        public int Hdd
        {
            get { return hdd; }
            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Hdd cannot be negative or null");
                }
                hdd = value;
            }
        }

        public int Ram
        {
            get
            {
                return Ram;
            }
            set
            {
                if (ram <= 0)
                {
                    throw new ArgumentOutOfRangeException("The RAM cannot be negative or null");
                }
                ram = value;
            }
        }

        public string Screen
        {
            get
            {
                return screen;
            }
        }

        public Battery Battery
        {
            get { return battery; }
            set
            {
                battery = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative or null");
                }
                if (price > 10000)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be more than 10000");
                }
                price = value;
            }
        }

        //TO STRING
        public override string ToString()
        {
            return $"Laptop information of {model} :\n\n"

                + $"- Manufacturer  : {manufacturer}\n"
                + $"- Processor     : {processor}\n"
                + $"- Graphics Card : {graphicsCard}\n"
                + $"- Hdd           : {hdd} GB SSD\n"
                + $"- Ram           : {ram} GB\n"
                + $"- Screen        : {screen}\n"
                + $"- Battery       :\n{Battery}"
                + $"- Price         : {price} lv.";
        }
    }
}
