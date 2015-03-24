using System;
using System.Collections.Generic;
using System.Text;

namespace Coordinates3D
{
    class PointPaths
    {
        private List<Point3D> pointList = new List<Point3D>();

        public List<Point3D> PointList
        {
            get { return pointList; }
        }
        public void AddPoints(Point3D point)
        {
            pointList.Add(point);
        }
        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < pointList.Count; i++)
            {
                result.Append(pointList[i].ToString());
            }
            return result.ToString();
        }
    }
}
