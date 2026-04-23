using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdirEf10th
{
    public class Rectangle
    {
        private Point bottomLeft;
        private Point topRight;

        public static void RectangleUT()
        {
            //Rectangle rect1 = new Rectangle(new Point(1, 2), new Point(3, 5));
            //Rectangle rect2 = new Rectangle(new Point(4, 4), new Point(7, 10));
            //Console.WriteLine(rect1);
            //Console.WriteLine(rect2);
            //Console.WriteLine(rect2.GetArea());
            //Console.WriteLine(rect1.GetPerimeter());
            //rect1.Move(2, 3);
            //Console.WriteLine(rect1.GetArea());
            //Console.WriteLine(rect1);
            //Console.WriteLine(rect1.PointIsIn(new Point(2, 4)));
            //Console.WriteLine(rect2.PointIsIn(new Point(2, 4)));
            //Console.WriteLine(rect2.PointIsIn(new Point()));
            //Console.WriteLine(rect2.PointIsIn(new Point(4, 10)));
            //Console.WriteLine(rect1.Distance(rect2));
        }

        public Rectangle(Point bottomLeft, Point topRight)
        {
            this.bottomLeft = bottomLeft;
            this.topRight = topRight;
        }

        public Rectangle(Point bottomLeft, double width, double height)
        {
            this.bottomLeft = bottomLeft;
            this.topRight.SetX(bottomLeft.GetX() + width);
            this.topRight.SetY(bottomLeft.GetY() + height);
        }

        public Rectangle() : this(new Point(), new Point(1, 1))
        {
            
        }

        public Rectangle(Rectangle rect)
        {
            this.bottomLeft = rect.bottomLeft;
            this.topRight = rect.topRight;
        }

        public Point GetBottomLeft()
        {
            return this.bottomLeft;
        }

        public Point GetTopRight()
        {
            return this.topRight;
        }

        public void SetBottomLeft(Point bottomLeft)
        {
            this.bottomLeft.SetX(bottomLeft.GetX());
            this.bottomLeft.SetY(bottomLeft.GetY());
        }

        public void SetTopRight(Point topRight)
        {
            this.topRight.SetX(topRight.GetX());
            this.topRight.SetY(topRight.GetY());
        }

        public double GetArea()
        {
            double width = this.GetTopRight().GetX() - this.GetBottomLeft().GetX();
            double height = this.GetTopRight().GetY() - this.GetBottomLeft().GetY();
            double area = width * height;
            return area;
        }

        public double GetPerimeter()
        {
            double width = this.GetTopRight().GetX() - this.GetBottomLeft().GetX();
            double height = this.GetTopRight().GetY() - this.GetBottomLeft().GetY();
            double perimeter = 2 * width + 2 * height;
            return perimeter;
        }

        public void Move(double deltaX, double deltaY)
        {
            this.SetBottomLeft(new Point(this.GetBottomLeft().GetX() + deltaX, this.GetBottomLeft().GetY() + deltaY));
            this.SetTopRight(new Point(this.GetTopRight().GetX() + deltaX, this.GetTopRight().GetY() + deltaY));
        }

        public override string ToString()
        {
            string str = "";
            str += "Rectangle:\n";
            str += $"bottom-left point = ( {this.GetBottomLeft().ToString()} )\n";
            str += $"top-right point = ( {this.GetTopRight().ToString()} )";
            return str;
        }

        public bool PointIsIn(Point point)
        {
            bool isIn = false;
            if (point.GetX() >= this.GetBottomLeft().GetX() && point.GetX() <= this.GetTopRight().GetX() && point.GetY() >= this.GetBottomLeft().GetY() && point.GetY() <= this.GetTopRight().GetY())
            {
                isIn = true;
            }
            return isIn;
        }

        public double Distance(Rectangle rect)
        {
            double dist = 0;
            Point mid1 = this.GetBottomLeft().Middle(this.GetTopRight());
            Point mid2 = rect.GetBottomLeft().Middle(rect.GetTopRight());
            dist = mid1.Distance(mid2);
            return dist;
        }
    }
}
