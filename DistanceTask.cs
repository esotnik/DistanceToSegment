using System;

namespace DistanceTask
{
    public static class DistanceTask
    {
        // Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
        public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
        {
            double a = x - ax;
            double b = y - ay;
            double c = bx - ax;
            double d = by - ay;
            double dot = a * c + b * d;
            var len_sq = c * c + d * d;
            double param = -1;
            if (len_sq != 0) //in case of 0 length line
                param = dot / len_sq;

            var xx = 0.0;
            var yy = 0.0;

            if (param < 0)
            {
                xx = ax;
                yy = ay;
            }
            else if (param > 1)
            {
                xx = bx;
                yy = by;
            }
            else
            {
                xx = ax + param * c;
                yy = ay + param * d;
            }

            var dx = x - xx;
            var dy = y - yy;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}