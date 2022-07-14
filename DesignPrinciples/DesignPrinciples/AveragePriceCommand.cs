using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    class AveragePriceCommand : ICommand
    {
        private List<Car> cars;
        public AveragePriceCommand(List<Car> cars)
        {
            this.cars = new List<Car>(cars);
        }
        public void Execute()
        {
            double price = 0;
            foreach(Car car in cars)
            {
                price += car.price;
            }
            if (cars.Count > 0)
            {
                price /= cars.Count;
            }
            Console.WriteLine("average price:" + price);
        }
    }
}
