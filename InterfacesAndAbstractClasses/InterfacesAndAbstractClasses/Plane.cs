using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractClasses
{
    class Plane : IFlyable
    {
        private Point point;
        double speed = 200;         //km/h
        double changeSpeed = 10;        //km/h
        double frequencyChange = 10;        //km

        public Plane(Point point)
        {
            this.point = point;
        }

        public void FlyTo(Point point)          // Makes movement based on time and end point.(km/h)
        {
            double time = IFlyable.time;
            Point vectorPoint = point - this.point;
            while (time + frequencyChange / speed > 0 && point.GetDistance(point, this.point) > frequencyChange) 
            {
                this.point += vectorPoint * (frequencyChange / vectorPoint.GetSumm());
                time -= 10 / speed;
                speed += changeSpeed;
            }
            if (point.GetDistance(point, this.point) > frequencyChange && time > 0) 
            {
                this.point += vectorPoint * (speed * time / vectorPoint.GetSumm());
            }
            if (point.GetDistance(point, this.point) < frequencyChange && time + frequencyChange / speed > 0) 
            {
                this.point = point;
            }

        }

        public double GetFlyTime(Point point)       //get time in hours
        {
            double distance = point.GetDistance(this.point, point);
            double time = 0, calculationSpeed = speed;
            
            while (distance > 10)
            {

                time += 10 / calculationSpeed;
                distance -= 10;
                calculationSpeed += 10;
            }

            time += distance;

            return time;
        }

    }
}
