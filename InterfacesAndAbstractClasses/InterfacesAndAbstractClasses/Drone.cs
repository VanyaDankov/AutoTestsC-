using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractClasses
{
    class Drone : IFlyable
    {
        Point point;
        double speed;

        public void FlyTo(Point point)
        {
            Point speedPoint = point - this.point;
            this.point += speedPoint * (speed *
                (IFlyable.time - Math.Floor(IFlyable.time / 10)) / speedPoint.GetSumm());
        }

        public double GetFlyTime(Point point)
        {
            return point.GetDistance(this.point, point) / speed
                + Math.Floor(point.GetDistance(this.point, point) / speed) / 10;
        }
    }
}
