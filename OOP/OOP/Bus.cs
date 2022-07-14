using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OOP
{
    class Bus : Machine
    {
        public Bus(Engine engine, Chassis chassis, Transmition transmition) : base(engine, chassis, transmition)
        {
        }
        public override void WriteXml()
        {
            try
            {
                var xDoc = XDocument.Load("C:/Users/danko/source/repos/OOP/OOP/doc.xml");
                XElement? root = xDoc.Element("machine");
                if (root != null)
                {
                    root.Add(new XElement("Bus",
                        new XElement("EngineSerialNumber", Engine.SerialNumber),
                        new XElement("EngineVolume", Engine.Volume),
                        new XElement("EnginePower", Engine.Power),
                        new XElement("EngineType", Engine.Type),
                        new XElement("NumberOfWeels", Chassis.NumberOfWheels),
                        new XElement("Chassis.number", Chassis.Number),
                        new XElement("BearingCapacity", Chassis.BearingCapacity),
                        new XElement("TransmitionType", Transmition.Type),
                        new XElement("TransmitionManufacturer", Transmition.Manufacturer),
                        new XElement("NumberOfGears", Transmition.NumberOfgears)));

                    xDoc.Save("C:/Users/danko/source/repos/OOP/OOP/doc.xml");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
