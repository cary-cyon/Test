namespace Shape
{
    //абстрактный класс фигуры 
    public abstract class Shape
    {
       public abstract double getSqure();
    }
    //класс фигуры окружность
    public class Circle : Shape
    {
        private double radius;
        public Circle(double R)
        {
            radius = R;
        }
        public override double getSqure()
        {
            return 3.1417 * Math.Pow(radius, 2);
        }
    }
    //класс фигуры треугольник 
    public class Triangle: Shape
    {
        double a;
        double b;
        double c;
        double p;

        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
            p = (a + b + c) / 2;
        }

        public override double getSqure()
        {
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
    //класс Для вывода на экран (просто продемонстрировать ссвободу замены фигуры)
    public class Solver
    {
        static public void getSqure(Shape shape)
        {
            Console.WriteLine(shape.getSqure());
        }
    }
}