using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class MyButton
    {
        protected Point topLeft;
        protected Point bottomRight;

        private int width;
        private int height;

        internal MyButton(Point topLeft, Point bottomRigth)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRigth;

        }
        internal int GetWidth()
        {
            return this.width;
        }
        internal int GetHeihth()
        {
            return this.height;
        }
        internal bool SetTopLeft(Point editpoint)
        {
            if ((editpoint.GetX() < this.bottomRight.GetX()) && (editpoint.GetY() > this.bottomRight.GetY()))
            {
                this.topLeft = editpoint;
                this.height = 5;
                this.width = 5;
                return true;
            }
            else
            {
                Console.WriteLine("The point should be on the top left side of the button");
                return false;
            }
        }
        internal bool SetBotomRight(Point editpoint)
        {
            if ((editpoint.GetX() > this.topLeft.GetX()) && (editpoint.GetY() < this.topLeft.GetY()))
            {
                this.bottomRight = editpoint;
                this.height = 5;
                this.width = 5;
                return true;

            }
            else
            {
                Console.WriteLine("The point should be on the botom Right of button");
                return false;
            }
        }
        internal Point GetTopLeft()
        {
            return topLeft;
        }
        internal Point GetBottomRigth()
        {
            return bottomRight;
        }

        public override string ToString()
        {
            return $"Width: {this.width}, Height: {this.height}, Right botoom: {bottomRight} Top {this.topLeft}";
        }
    }
}
