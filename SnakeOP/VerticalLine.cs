﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOP
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char symb)
        {
            PointList = new List<Point>();
            for(int i = yUp; i <= yDown; i ++)
            {
                Point p = new Point(x, i, symb);
                PointList.Add(p);

            }    
        }
    }
}