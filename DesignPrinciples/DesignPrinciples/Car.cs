using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    struct Car: IComparable<Car>
    {
        public string mark, model;
        public int count;
        public double price;

        public int CompareTo(Car other)
        {
            return this.mark.CompareTo(other.mark);
        }
    }
}
