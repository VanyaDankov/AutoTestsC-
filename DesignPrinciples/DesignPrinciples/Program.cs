using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPrinciples
{
    class Program
    {

        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            DataBase dataBase = DataBase.getDataBase();
            string command;
            Console.WriteLine("available commands:count types, count all, average price, average price type, add car, exit");
            command = Console.ReadLine();
            while (command != "exit")
            {
                switch (command)
                {
                    case "count types":
                        CountTypesCommand countTypesCommand = new CountTypesCommand(dataBase.Cars);
                        invoker.SetCommand(countTypesCommand);
                        invoker.Execute();
                        break;

                    case "count all":
                        CountAllCommand countAllCommand = new CountAllCommand(dataBase.Cars);
                        invoker.SetCommand(countAllCommand);
                        invoker.Execute();
                        break;

                    case "average price":
                        AveragePriceCommand averagePriceCommand = new AveragePriceCommand(dataBase.Cars);
                        invoker.SetCommand(averagePriceCommand);
                        invoker.Execute();
                        break;

                    case "average price type":
                        AveragePriceTypeCommand averagePriceTypeCommand = new AveragePriceTypeCommand(dataBase.Cars);
                        invoker.SetCommand(averagePriceTypeCommand);
                        invoker.Execute();
                        break;

                    case "add car":
                        dataBase.addCar();
                        break;
                }
                command = Console.ReadLine();
            }
        }    
    }
}
