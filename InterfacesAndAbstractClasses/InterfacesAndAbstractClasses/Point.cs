using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractClasses
{
    public struct Point
    {
        public double x, y, z;

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }


        public double GetDistance(Point startPoint, Point finalPoint)
        {
            Point point = finalPoint - startPoint;
            return Math.Sqrt(point.x * point.x + point.y * point.y + point.z * point.z);
        } 

        public double GetSumm() => x + y + z;

        public static Point operator +(Point point1, Point point2)
            => new Point(point1.x + point2.x, point1.y + point2.y, point1.z + point2.z);

        public static Point operator -(Point point1, Point point2)
            => new Point(point1.x - point2.x, point1.y - point2.y, point1.z - point2.z);

        public static Point operator *(Point point, double number)
           => new Point(point.x *number, point.y * number, point.z * number);

    }
}
