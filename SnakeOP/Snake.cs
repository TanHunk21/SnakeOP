using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeOP
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            PointList = new List<Point>();
            for(int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                PointList.Add(p);
            }
            
        }

        public void Move()
        {
            Point tail = PointList.First();
            PointList.Remove(tail);
            tail.Clear();

            Point head = GetNextPoint();
            PointList.Add(head);
            head.Draw();
        }

        public  Point GetNextPoint()
        {
            Point head = PointList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKeys(ConsoleKey key)
        {
            if(key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            } else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            } else if(key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            } else if(key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symb = head.symb;
                PointList.Add(food);
                return true;
            } else
            {
                return false;
            }
        }

        

        
        public bool IsHitTail()
        {
            
            Point head = PointList.Last();
            for(int i = 0; i < PointList.Count - 2; i++)
            {
                if (head.IsHit(PointList[i]))
                {
                    return true;
                }
            }

            
            return false;
        }
    }
}
