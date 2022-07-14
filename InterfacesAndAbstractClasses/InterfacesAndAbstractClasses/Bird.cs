using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractClasses
{
    class Bird : IFlyable
    {
        Point point;
        double speed;

        public Bird(Point point, double speed)
        {
            this.point = point;
            if (speed <= 20)   this.speed = speed; 
            else this.speed = 20;
            
        }

        public void FlyTo(Point point)
        {
            Point vectorPoint = point - this.point;
            this.point += vectorPoint * (speed * IFlyable.time / vectorPoint.GetSumm());
        }

        public double GetFlyTime(Point point) => 
            point.GetDistance(this.point, point) / speed;
        
    }
}
