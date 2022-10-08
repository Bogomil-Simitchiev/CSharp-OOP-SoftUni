using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Shapes
{  


    public interface IDrawable
    {
        public void Draw();

    }
    class Circle : IDrawable
    {
        public Circle(int radius)
        {
            this.radius = radius;
        }
        private int radius;

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }


        public void Draw()
        {
            double rIn = this.radius - 0.4;
            double rOut = this.radius + 0.4;
            for (int i = this.radius; i >= -this.radius; --i)
            {
                for (double j = -this.radius; j < rOut; j+=0.5)
                {
                    double value = j * j + i * i;
                    if (value>=rIn*rIn&&value<=rOut*rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    public class Rectangle : IDrawable
    {
        public Rectangle(int width,int height)
        {
            this.width = width;
            this.height = height;
        }
        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public void Draw()
        {
            DrawLine(this.width, '*', '*');
            for (int i = 1; i < this.height-1; ++i)
            {
                DrawLine(this.width, '*', ' ');
                
            }
            DrawLine(this.width, '*', '*');
        }
        private void DrawLine(int width,char end,char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width-1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(r);

            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            IDrawable rectangle = new Rectangle(w,h);

            rectangle.Draw();

            circle.Draw();
        }
    }
}