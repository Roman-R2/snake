using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {

        int mapWidrh;
        int mapHeight;
        char symbol;

        Random random = new Random();

        public FoodCreator(int _mapWidrh, int _mapHeight, char _symbol) {
            mapWidrh = _mapWidrh;
            mapHeight = _mapHeight;
            symbol = _symbol;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidrh - 2);
            int y = random.Next(2, mapHeight - 2);

            return new Point(x, y, symbol);
        }
    }
}
