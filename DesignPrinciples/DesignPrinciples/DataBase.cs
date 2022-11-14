using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    class DataBase
    {
        private static DataBase dataBase;
        private DataBase() {  }
        private List<Car> cars = new List<Car>();

        public List<Car> Cars { get => cars;}

        public static DataBase getDataBase()
        {
            if (dataBase == null)
            {
                dataBase = new DataBase();
            }
            return dataBase;
        }
        public void addCar()
        {
            Car car = new Car();
            Console.WriteLine("mark");
            car.mark = Console.ReadLine();
            Console.WriteLine("model");
            car.model = Console.ReadLine();
            Console.WriteLine("count");
            car.count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("price");
            car.price = Convert.ToDouble(Console.ReadLine());
            Cars.Add(car);
        }
    }
}
