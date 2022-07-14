using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace OOP
{
    class Machine
    {
        private Engine engine;
        private Chassis chassis;
        private Transmition transmition;

        public Engine Engine { get => engine; set => engine = value; }
        public Chassis Chassis { get => chassis; set => chassis = value; }
        public Transmition Transmition { get => transmition; set => transmition = value; }



        public Machine(Engine engine, Chassis chassis, Transmition transmition)
        {
            try
            {
                this.Engine = engine;
                this.Chassis = chassis;
                this.Transmition = transmition;
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e.Message);
            }
            
        }
        public virtual void WriteXml()
        {
            try
            {
                var xDoc = XDocument.Load("C:/Users/danko/source/repos/OOP/OOP/doc.xml");
                XElement? root = xDoc.Element("machine");
                if (root != null)
                {
                    root.Add(new XElement("machin",
                        new XElement("EngineSerialNumber", Engine.SerialNumber),
                        new XElement("EngineVolume", Engine.Volume),
                        new XElement("EnginePower", Engine.Power),
                        new XElement("EngineType", Engine.Type),
                        new XElement("NumberOfWeels", Chassis.NumberOfWheels),
                        new XElement("ChassisNumber", Chassis.Number),
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
        public void WriteXmlEngine()
        {
            try
            {
                var xDoc = XDocument.Load("C:/Users/danko/source/repos/OOP/OOP/doc.xml");
                XElement? root = xDoc.Element("machine");
                if (root != null)
                {
                    root.Add(new XElement("machin",
                        new XElement("EngineSerialNumber", Engine.SerialNumber),
                        new XElement("EngineVolume", Engine.Volume),
                        new XElement("EnginePower", Engine.Power)));
                        

                    xDoc.Save("C:/Users/danko/source/repos/OOP/OOP/doc.xml");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void getAutoByParameter(string parametr, string value)
        {
            try
            {
                bool check = false;
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("C:/Users/danko/source/repos/OOP/OOP/doc.xml");
                XmlElement? xRoot = xDoc.DocumentElement;
                if (xRoot != null)
                {
                    foreach (XmlElement xnode in xRoot)
                    {

                        foreach (XmlNode childnode in xnode.ChildNodes)
                        {
                            if (childnode.Name == parametr && childnode.InnerText == value)
                            {
                                check = true;
                            }

                        }
                        foreach (XmlNode childnode in xnode.ChildNodes)
                        {
                            if (check == false) { throw new Exception("GetAutoByParameterException"); }
                            if (childnode.Name == "EngineSerialNumber")
                            {
                                Console.WriteLine($"EngineSerialNumber: {childnode.InnerText}");
                            }
                            if (childnode.Name == "EnginePower")
                            {
                                Console.WriteLine($"EnginePower: {childnode.InnerText}");
                            }
                            if (childnode.Name == "EngineVolume")
                            {
                                Console.WriteLine($"EngineVolume: {childnode.InnerText}");
                            }
                            if (childnode.Name == "EngineType")
                            {
                                Console.WriteLine($"EngineType: {childnode.InnerText}");
                            }
                            if (childnode.Name == "NumberOfWeels")
                            {
                                Console.WriteLine($"NumberOfWeels: {childnode.InnerText}");
                            }
                            if (childnode.Name == "ChassisNumber")
                            {
                                Console.WriteLine($"ChassisNumber: {childnode.InnerText}");
                            }
                            if (childnode.Name == "BearingCapacity")
                            {
                                Console.WriteLine($"BearingCapacity: {childnode.InnerText}");
                            }
                            if (childnode.Name == "TransmitionType")
                            {
                                Console.WriteLine($"TransmitionType: {childnode.InnerText}");
                            }
                            if (childnode.Name == "TransmitionManufacturer")
                            {
                                Console.WriteLine($"TransmitionManufacturer: {childnode.InnerText}");
                            }
                            if (childnode.Name == "NumberOfGears")
                            {
                                Console.WriteLine($"NumberOfGears: {childnode.InnerText}");
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public bool volumeMore(double volume) => Engine.Volume > volume;

        public override string ToString()
        {
            return Engine.ToString() + Chassis.ToString() + Transmition.ToString();

        }
    }
}
