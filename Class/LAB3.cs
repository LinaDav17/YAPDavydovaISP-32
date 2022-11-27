using System;
class Program
{
    class PointPlane
    {
        double x, y;

        public PointPlane(double x, double y) { X = x; Y = y; }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Distance(PointPlane point)
        {
            return Math.Sqrt(Math.Pow((this.X - point.X), 2) + Math.Pow((this.Y - point.Y), 2));
        }
    }
    class ShortestWayPlane
    {
        PointPlane point1, point2, point3;
        double s;
        public ShortestWayPlane(PointPlane point, PointPlane size, PointPlane fly)
        {
            point1 = new PointPlane(size.X + point.Y, -point.X);

            point2 = new PointPlane(size.X + point.X, point.Y);

            point3 = new PointPlane(size.X + size.Y - point.Y, size.Y + point.X);
            ShortestWay(fly);
        }
        void ShortestWay(PointPlane fly)
        {
            s = point1.Distance(fly) < point2.Distance(fly) ? point1.Distance(fly) : point2.Distance(fly);
            if (s > point3.Distance(fly)) s = point3.Distance(fly);
        }
        public double S { get => s; }
    }
    static void Main(string[] args)
    {
        double A = 10, B = 10;// размеры комнаты
        Console.WriteLine("add spider");
        double xS = double.Parse(Console.ReadLine());
        double yS = double.Parse(Console.ReadLine());
        double zS = double.Parse(Console.ReadLine()); 
        Console.WriteLine("add eat spider");
        double xF = double.Parse(Console.ReadLine());
        double yF = double.Parse(Console.ReadLine());

        double S = -1;

        if (zS == 0)
            S = new PointPlane(xS, yS).Distance(new PointPlane(xF, yF));
        else
        {
            if (Turn(ref xS, ref yS, ref xF, ref yF, ref A, ref B) == -1)
                Console.WriteLine("Ошибочка...(((\n Паук сидит не на стене!");
            else
            {
                ShortestWayPlane shortest = new ShortestWayPlane(new PointPlane(zS, yS), new PointPlane(A, B), new PointPlane(xF, yF));
                S = shortest.S;
            }
        }
        if (S != -1)
            Console.WriteLine("Наименьшая длинна пути " + Math.Round(S, 5));
        Console.ReadKey();
    }
    static int Turn(ref double xS, ref double yS, ref double xF, ref double yF, ref double A, ref double B)
    {
        if (xS == A) return 0;
        double temp = xF;
        if (yS == 0)
        {
            yS = xS;
            xS = B;
            xF = B - yF;
            yF = temp;
            B = A;
            A = xS;
            return 0;
        }
        if (yS == B)
        {
            yS = A - xS;
            xS = B;
            xF = yF;
            yF = A - temp;
            B = A;
            A = xS;
            return 0;
        }
        if (xS == 0)
        {
            yS = B - yS;
            xS = A;
            xF = A - xF;
            yF = B - yF;
            return 0;
        }
        return -1;
    }
}
