using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine carEngine = new Engine(12345, 5.5, 500, "petrol");
            Chassis carChassis = new Chassis(4, 1234123, 1544);
            Transmition carTransmition = new Transmition("springs", "BMW", 8);
            Car car = new Car(carEngine, carChassis, carTransmition);
            Engine busEngine = new Engine(12341215, 7, 300, "disel");
            Chassis busChassis = new Chassis(8, 123423123, 1512344);
            Transmition busTransmition = new Transmition("auto", "MAZ", 24);
            Bus bus = new Bus(busEngine, busChassis, busTransmition);
            Engine scooterEngine = new Engine(12341215, 0.5, 50, "petrol");
            Chassis scooterChassis = new Chassis(2, 1234323123, 154);
            Transmition scooterTransmition = new Transmition("springs", "Toyota", 7);
            Scooter scooter = new Scooter(scooterEngine, scooterChassis, scooterTransmition);



            var cars = new List<Machine>();
            cars.Add(car);
            cars.Add(bus);
            cars.Add(scooter);
            var selectedCars = from c in cars
                               where c.volumeMore(1.5) == true
                               select c;

            foreach(var a in selectedCars)
            {
               a.WriteXml();
            }
            var orderedCars = from c in cars
                                 orderby c.Transmition.Type
                                 select c;
            foreach (var a in orderedCars)
            {
                a.WriteXml();
            }
            foreach(var c in cars)
            {
                if(c is Bus ||c is Truck)
                {
                    c.WriteXmlEngine();
                }
            }
        }
    }
}
