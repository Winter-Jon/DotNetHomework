using System;

namespace problem1
{

    abstract class Polygon
    {
        protected double[] edge;
        protected int edgeNum { get; }

        public Polygon(int edgeNum, double[] edge)
        {
            this.edgeNum = edgeNum;
            this.edge = new double[edgeNum];
            for (int i = 0; i < edgeNum; i++)
            {
                this.edge[i] = edge[i];
            }
        }

        public abstract double Area { get; }
        public abstract bool IsLegal();
    }

    class Triangle : Polygon
    {
        public Triangle(double[] edge) : base(3, edge) { }

        public override double Area
        {
            get
            {
                double p = (edge[0] + edge[1] + edge[2]) / 2;
                double s = Math.Pow(p * (p - edge[0]) * (p - edge[1]) * (p - edge[2]), 0.5);
                return s;
            }
        }
        public override bool IsLegal()
        {
            foreach (double e in edge)
                if (e <= 0)
                    return false;
            if (edge[0] + edge[1] <= edge[2] || edge[0] + edge[2] <= edge[1] || edge[1] + edge[2] <= edge[0])
                return false;
            return true;
        }
    }

    class Rectangle : Polygon
    {
        public Rectangle(double[] edge) : base(4, edge) { }
        public Rectangle(double length, double width) : base(4, new double[4] { length, width, length, width }) { }

        public override double Area
        {
            get => edge[0] * edge[1];
        }

        public override bool IsLegal()
        {
            foreach (double e in edge)
                if (e <= 0)
                    return false;

            if (edge[0] != edge[2] || edge[1] != edge[3])
                return false;

            return true;
        }
    }

    class Square : Rectangle
    {
        public Square(double[] edge) : base(edge) { }
        public Square(double length) : base(length, length) { }

        public override bool IsLegal()
        {
            foreach (double e in edge)
                if (e <= 0)
                    return false;

            if (edge[0] != edge[2] || edge[1] != edge[3] || edge[0] != edge[1])
                return false;

            return true;
        }

        public override double Area
        {
            get => edge[0] * edge[1];
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Polygon triangle = new Triangle(new double[] {3,4,5});
            Polygon rectangel = new Rectangle(6,7);
            Polygon squre = new Square(4);

            Console.WriteLine(triangle.IsLegal());
            Console.WriteLine(rectangel.IsLegal());
            Console.WriteLine(squre.IsLegal());

            Console.WriteLine(triangle.Area);
            Console.WriteLine(rectangel.Area);
            Console.WriteLine(squre.Area);

        }
    }
}
