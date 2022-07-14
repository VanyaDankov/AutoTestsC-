using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    
    public class Engine
    {
        private int serialNumber;
        private double power, volume;
        private string type;

        public int SerialNumber { get => serialNumber; set => serialNumber = value; }
        public double Volume { get => Volume1; set => Volume1 = value; }
        public string Type { get => type; set => type = value; }
        public double Volume1 { get => volume; set => volume = value; }
        public double Power { get => power; set => power = value; }

        public Engine()
        {
        }

        public Engine(int serialNumber, double volume, double power, string type)
        {
            try
            {
                this.SerialNumber = serialNumber;
                this.Volume = volume;
                this.Power = power;
                this.Type = type;
            }
            catch(Exception e)
            {
                Console.WriteLine("Engine " + e.Message);
            }
        }

        public override string ToString()
        {
            return " serial number:" + SerialNumber + " volume:" + Volume + " power:" + Power + " type:" + Type;
        }
    }
}
