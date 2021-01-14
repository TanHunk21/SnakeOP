using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOP
{
    class FoodGenerator
    {
        int mapWidt;
        int mapHeight;
        char symb;

        Random rnd = new Random();

        public FoodGenerator(int _mapWidt, int _mapHeight, char _symb)
        {
            mapWidt = _mapWidt;
            mapHeight = _mapHeight;
            symb = _symb;
        }

        public Point GenerateFood()
        {
            int x = rnd.Next(2, mapWidt - 2);
            int y = rnd.Next(2, mapHeight - 2);
            return new Point(x, y, symb);
        }

    }
}
