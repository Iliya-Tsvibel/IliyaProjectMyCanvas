using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Point
    {
        int x;
        int y;

        internal Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        internal int GetX()
        {
            return this.x;
        }
        internal int GetY()
        {
            return this.y;
        }
        internal void SetX(int x)
        {
            if ((x >= 0) && (x <= MyCanvas.MaxWidth))
                this.x = x;
            else
                Console.WriteLine($" Not convencional value of X, should be from 0 to {MyCanvas.MaxWidth}");
        }
        internal void SetY(int y)
        {
            if ((y >= 0) && (y <= MyCanvas.MaxHeight))
                this.y = y;
            else
                Console.WriteLine($"Not convencional value of Y, should be from 0 to {MyCanvas.MaxHeight}");
        }

        public override string ToString()
        {
            return $"The value of X is: {this.x}, The value of Y is: {this.y}";
        }
    }
}
