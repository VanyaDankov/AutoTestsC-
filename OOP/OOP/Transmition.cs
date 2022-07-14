using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    
    public class Transmition
    {
        private string manufacturer;
        private int numberOfgears;
        private string type;
        public string Type { get => type; set => type = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public int NumberOfgears { get => numberOfgears; set => numberOfgears = value; }

        

        public Transmition(string type, string manufacturer, int numberOfgears)
        {
            try
            {
                this.Type = type;
                this.Manufacturer = manufacturer;
                this.NumberOfgears = numberOfgears;
            }
            catch (Exception e)
            {
                Console.WriteLine("Transmition " + e.Message);
            }
            
        }

        

        public override string ToString()
        {
            return " type:" + Type + " manufacturer:" + Manufacturer + " number of gears:" + NumberOfgears;
        }
    }
}
