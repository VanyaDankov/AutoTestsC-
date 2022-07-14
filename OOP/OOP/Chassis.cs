using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Chassis
    {
        private int number;
        private double bearingCapacity;
        private int numberOfWheels;
        public int NumberOfWheels { get => numberOfWheels; set => numberOfWheels = value; }
        public int Number { get => number; set => number = value; }
        public double BearingCapacity { get => bearingCapacity; set => bearingCapacity = value; }

        public Chassis(int numberOfWheels, int number, double bearingCapacity)
        {
            try
            {
                this.NumberOfWheels = numberOfWheels;
                this.Number = number;
                this.BearingCapacity = bearingCapacity;
            }
            catch (Exception e)
            {
                Console.WriteLine("Chassis " + e.Message);
            }
            
        }

        

        public override string ToString()
        {
            return " number of wheels:"+ NumberOfWheels+" number:"+Number+ " bearing capacity:"+BearingCapacity;
        }
    }
}
