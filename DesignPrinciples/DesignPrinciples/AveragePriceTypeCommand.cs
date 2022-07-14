using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    class AveragePriceTypeCommand : ICommand
    {
        private List<Car> cars;
        public AveragePriceTypeCommand(List<Car> cars)
        {
            this.cars = new List<Car>(cars);
        }
        public void Execute()
        {
            double price = 0;
            int count = 0;
            string mark;
            Console.WriteLine("enter the mark ");
            mark = Console.ReadLine();
            foreach (Car car in cars)
            {
                if (car.mark == mark)
                {
                    price += car.price;
                    count++;
                }
            }
            if (count > 0)
            {
                price /= cars.Count;
            }
            Console.WriteLine("average price:" + price);
        }
    }
}
