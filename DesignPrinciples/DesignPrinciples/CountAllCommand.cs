using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    class CountAllCommand : ICommand
    {
        private List<Car> cars;
        public CountAllCommand(List<Car> cars)
        {
            this.cars = new List<Car>(cars);
        }
        public void Execute()
        {
            int count = 0;
            foreach(Car car in cars)
            {
                count += car.count;
            }
            Console.WriteLine("count all cars:" + count);
        }
    }
}
