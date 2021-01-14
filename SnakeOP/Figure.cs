using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOP
{
    class Figure
    {
       protected List<Point> PointList;
        public void Draw()
        {
            foreach (Point point in PointList)
            {
                point.Draw();

            }
        }

        public bool IsHit(Figure figure)
        {
            foreach(var point in PointList)
            {
                if (figure.IsHit(point))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsHit(Point point)
        {
            foreach(var p in PointList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
