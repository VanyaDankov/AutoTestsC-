using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    class CountTypesCommand:ICommand
    {
        private List<Car> cars;
        public CountTypesCommand(List<Car> cars)
        {
            this.cars = new List<Car>(cars);
        }
               

        public void Execute()
        {
            cars.Sort();
            int count = 0;
            if (cars != null)
            {
                count = 1;
            }
            for (int i= 0; i < cars.Count-1; i++)
            {
                if (cars[i].model != cars[i + 1].model)
                {
                    count++;
                }
            }
            Console.WriteLine("count marks:" + count);

        }
    }
}
