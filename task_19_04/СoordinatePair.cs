using System;

namespace task_19_04
{
    delegate double GetDistance(PointCreator fPoint, PointCreator sPoint);

    class СoordinatePair
    {
        PointCreator firstPoint;
        PointCreator secondPoint;

        public СoordinatePair(int pointSize)
        {
            firstPoint = new PointCreator();
            secondPoint = new PointCreator();
            Random rnd = new Random();
            for (int i=0; i < pointSize; i++)
            {
                firstPoint.Point.Add(rnd.Next(-10, 10));
                secondPoint.Point.Add(rnd.Next(-10, 10));                              
            }
        }

        public double DistanceCounter(GetDistance del)
        {
            double resultDistance = del.Invoke(firstPoint, secondPoint);
            return resultDistance;
        }

        public static double GetDistanceByDecart(PointCreator fPoint, PointCreator sPoint)
        {
            double result = 0;
            for(int i = 0; i < fPoint.Point.Count; i++)
            {
                result += Math.Pow((fPoint.Point[i] - sPoint.Point[i]), 2);
            }
            return Math.Sqrt(result);
        }

        public static double GetDistanceByOtherMethod(PointCreator fPoint, PointCreator sPoint)
        {
            double result = 0;
            for (int i = 0; i < fPoint.Point.Count; i++)
            {
                result += fPoint.Point[i] * sPoint.Point[i];
            }
            return Math.Abs(result);
        }
    }
}