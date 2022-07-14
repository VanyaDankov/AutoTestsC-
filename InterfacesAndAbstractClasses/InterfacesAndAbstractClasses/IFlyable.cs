using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractClasses
{
    interface IFlyable
    {
        static double time = 0;
        public void FlyTo(Point point);
        public double GetFlyTime(Point point);
    }
}
