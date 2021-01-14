using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOP
{
    class HorizontalLine : Figure
    {
        

        public HorizontalLine(int xLeft, int xRight, int y, char symb)
        {
            PointList = new List<Point>();

            for(int i = xLeft; i <= xRight; i++ )
            {
                Point p = new Point(i, y, symb);
                PointList.Add(p);
            }

            //  ############

        }
    }
}
