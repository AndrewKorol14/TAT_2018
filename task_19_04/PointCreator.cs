using System.Collections.Generic;

namespace task_19_04
{
    class PointCreator
    {
        List<double> point;

        public PointCreator()
        {
            point = new List<double>();
        }

        public List<double> Point
        {
            get { return point; }
        }
    }
}