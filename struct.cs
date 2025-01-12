using System.Security.Cryptography.X509Certificates;

namespace Points
{
    public struct Point2D( int x, int y)
    {
        public double Magnitude => Math.Sqrt(x * x + y * y);
    }

    public record class Point3D(int x, int y, int z)
    {
        public double Magnitude => Math.Sqrt(x * x + y * y + z * z);
    }
}


namespace CircularDependency{
    public struct A{
        public B B { get; set; }
    }

    public class B{
        public A A { get; set; }
    }
}