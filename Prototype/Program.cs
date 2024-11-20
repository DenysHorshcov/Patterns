using PrototypeFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IFigure figure = new Rectangle(10, 20);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            figure = new Circle(15);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            IFigure figure2 = new Triangle((10, 20), (2, -4), (5, 7));
            IFigure clonedFigure2 = figure2.Clone();
            figure2.GetInfo();
            clonedFigure2.GetInfo();

            Console.Read();
        }
    }
    interface IFigure
 {
 IFigure Clone();
    void GetInfo();
}
class Rectangle : IFigure
{
    int width;
    int height;
    public Rectangle(int w, int h)
    {
        width = w;
        height = h;
    }
    public IFigure Clone()
    {
        return new Rectangle(this.width, this.height);
    }
    public void GetInfo()
    {
        Console.WriteLine("Прямокутник довжиною {0} і шириною{1}", height, width);
    }
}

    class Triangle : IFigure
    {
        (int, int) A;
        (int, int) B;
        (int, int) C;
        public Triangle((int, int) a, (int, int) b, (int, int) c)
        {
            A = a;
            B = b;
            C = c;
        }
        public IFigure Clone()
        {
            return new Triangle(this.A, this.B, this.C);
        }
        public void GetInfo()
        {
            Console.WriteLine("Трикутник з вершинами {0}, {1}, {2}", A, B, C);
        }
    }

    class Circle : IFigure
{
    int radius;
    public Circle(int r)
    {
        radius = r;
    }
    public IFigure Clone()
    {
        return new Circle(this.radius);
    }
    public void GetInfo()
    {
        Console.WriteLine("Круг радіусом {0}", radius);
    }
}
}